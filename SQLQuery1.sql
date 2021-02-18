use master
go
	Drop Database if exists MH
go
	Create Database MH
Go
	Use MH
go
	Create Table Items(
		Item_ID int identity primary key,
		Item_name nchar(25) not null,
	)

	Create Table Clients(
		Client_id int identity primary key,
		Client_name nchar(25) not null,
		Client_last_name nchar(25) not null,
		Client_registration_date date default(sysdatetime()) not null,
		check (Client_registration_date <= sysdatetime())
	)

	Create Table Employer_types_of_work(
		Employer_type_of_work_id int identity primary key,
		Employer_type_of_work nchar(50)
	)

	Create Table Employers(
		Employer_id int identity primary key,
		Employer_name nchar(25) not null,
		Employer_last_name nchar(25),
		Employment_date date not null,
	)

	Create Table Performance(
		Performance_id int identity primary key,
		Performance_name nchar(25) not null,
		Performace_visit_cost smallmoney not null,

		check (Performace_visit_cost > 0)
	)

	Create Table Performance_staff(
		Performance_staff_id int identity primary key,
		Performance_id int not null,
		Employer_id int not null,
		Employer_type_of_work_id int not null,

		Constraint FK_Performance_staff__Performance Foreign key(Performance_id)
			references Performance(Performance_id),
		Constraint FK_Performance_staff__Employers Foreign key(Employer_id)
			references Employers(Employer_id),
		Constraint FK_Performance_staff__Employer_types_of_work Foreign key(Employer_type_of_work_id)
			references Employer_types_of_work(Employer_type_of_work_id),
	)

	Create Table Performance_items(
		Performance_id int not null,
		Item_ID int not null,

		Constraint PK_Performance_items Primary key(Performance_id, Item_ID),
		Constraint FK_Performance_items__Performance Foreign key(Performance_id)
			references Performance(Performance_id),
		Constraint FK_Performance_items__Items Foreign key(Item_ID)
			references Items(Item_ID)
	)

	Create Table Performance_viewers(
		Performance_id int not null,
		Client_ID int not null,

		Constraint PK_Performance_viewers Primary key(Performance_id, Client_ID),
		Constraint FK_Performance_viewers__Performance Foreign key(Performance_id)
			references Performance(Performance_id),
		Constraint FK_Performance_viewers__Clients Foreign key(Client_ID)
			references Clients(Client_id),
	)
go
	Create view Most_useful_items as
		SELECT i.Item_name, COUNT(p.Item_ID) 'used' 
			FROM Performance_items p
			JOIN Items i on p.Item_ID=i.Item_ID
			GROUP BY i.Item_ID, i.Item_name
go
	Create view Best_customers as
		select pv.Client_id, c.Client_name, c.Client_last_name, sum(p.Performace_visit_cost)'revenues', count(pv.Client_id)'number of entries' 
			from Performance_viewers pv
			join Performance p on p.Performance_id=pv.Performance_id
			join Clients c on c.Client_id=pv.Client_ID
			GROUP BY pv.Client_ID, c.Client_name, c.Client_last_name
			order by pv.Client_ID
go
	Create view Best_employer as
		SELECT ps.Employer_id, e.Employer_name, e.Employer_last_name, COUNT(ps.Employer_id) 'number of entries' 
			from Performance_staff ps
			join Employers e on ps.Employer_id = e.Employer_id
			group by ps.Employer_id, e.Employer_name, e.Employer_last_name
go

	insert into Items(Item_name) values 
		('Dymiarka'),
		('Kostium 1'),
		('Kostium 2'),
		('Gitara'),
		('Bębny'),
		('Fortepian')

	insert into Clients(Client_name, Client_last_name) values
		('imie 1', 'nazwisko 1'),
		('imie 2', 'nazwisko 2'),
		('imie 3', 'nazwisko 3'),
		('imie 4', 'nazwisko 4'),	
		('imie 5', 'nazwisko 5'),
		('imie 6', 'nazwisko 6')

	insert into Employer_types_of_work(Employer_type_of_work) values
		('Gitarzysta'),
		('Śpiewak'),
		('Bramkarz'),
		('Obsługa baru')

	insert into Employers(Employer_name, Employer_last_name, Employment_date) values
		('Imie 1', 'nazwisko 1', '2000-01-01'),
		('Imie 2', 'nazwisko 2', '2000-01-01'),
		('Imie 3', 'nazwisko 3', '2000-01-01'),
		('Imie 4', 'nazwisko 4', '2000-01-01'),
		('Imie 5', 'nazwisko 5', '2000-01-01')

	insert into Performance(Performance_name, Performace_visit_cost) values
		('Występ 1', 20),
		('Występ 2', 30),
		('Występ 3', 50)

	insert into Performance_staff(Employer_id, Employer_type_of_work_id, Performance_id) values
		(1,4,1),
		(1,2,1),
		(2,3,1),
		(3,1,1),
		(1,1,2),
		(2,2,3)

	insert into Performance_items(Item_ID, Performance_id) values
		(1,1),
		(2,1),
		(3,1),
		(4,2),
		(2,3),
		(2,2)

	insert into Performance_viewers(Client_ID, Performance_id) values 
		(1, 1),
		(2, 1),
		(3, 1),
		(4, 1),
		(5, 1),
		(6, 2),
		(1, 2),
		(2, 2),
		(3, 2),
		(4, 3)
