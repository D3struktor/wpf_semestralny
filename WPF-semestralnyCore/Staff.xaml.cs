using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace wpf_semestralny
{
    /// <summary>
    /// Logika interakcji dla klasy Staff.xaml
    /// </summary>
    public partial class Staff : Window
    {
        public Staff()
        {
            InitializeComponent();

            ViewData();
        }

        private List<EmployerInfo> Employer_Info = new List<EmployerInfo>();

        private void ViewData()
        {
            using var db = new UsersDB();
            Employer_Info = db.Employers.Select(a => new EmployerInfo(a)).ToList();

            Pracownicy.ItemsSource = Employer_Info;
        }

        private void DeleteUser(object o, EventArgs e)
        {
            var id = (int)((Button)o).CommandParameter;

            var employer = Employer_Info.FirstOrDefault(a => a.Employer_id == id);
            Employer_Info.Remove(employer);

            using var db = new UsersDB();
            db.Employers.Remove(employer.Employer);

            db.SaveChanges();

            Pracownicy.ItemsSource = null;
            Pracownicy.ItemsSource = Employer_Info;
        }

        class EmployerInfo
        {
          public  Employers Employer { get; }

            public int Employer_id
            {
                get => Employer.Employer_id;
            }
            public string Employer_name
            {
                get => Employer.Employer_name;
                set
                {
                    using var db = new UsersDB();
                    db.Employers.Attach(Employer);
                    if (!Regex.IsMatch(value, "^[A-Z][a-m]*"))
                        return;
                    Employer.Employer_name = value;
                    db.SaveChanges();
                }
            }
            public string Employer_last_name
            {
                get => Employer.Employer_last_name;
                set
                {
                    using var db = new UsersDB();
                    db.Employers.Attach(Employer);
                    if (!Regex.IsMatch(value, "^[A-Z][a-m]*"))
                        return;
                    Employer.Employer_last_name = value;
                    db.SaveChanges();
                }

            }
            public System.DateTime Employment_date
            {
                get => Employer.Employment_date;
                set
                {
                    using var db = new UsersDB();
                    db.Employers.Attach(Employer);

                    Employer.Employment_date = value;
                    db.SaveChanges();
                }
            }
            public string Password
            {
                get => Employer.Password;
                set
                {
                    using var db = new UsersDB();
                    db.Employers.Attach(Employer);
                    if (value.Length < 3)
                        return;
                    Employer.Password = value;
                    db.SaveChanges();
                }
            }
            public string Username
            {
                get => Employer.Username;
                set
                {
                    using var db = new UsersDB();
                    db.Employers.Attach(Employer);
                    if (value.Length < 3)
                        return;
                    Employer.Username = value;
                    db.SaveChanges();
                }
            }


            public EmployerInfo()
            {
                using var db = new UsersDB();

                Employer = new Employers()
                {
                    Employer_name = "Jan",
                    Employer_last_name = "Nowak",
                    Employment_date = DateTime.Now,
                    Username = "User",
                    Password = "Password"
                };

                db.Employers.Add(Employer);
                db.SaveChanges();
            }

            public EmployerInfo(Employers employer)
            {
                Employer = employer;
            }
        }
    }
}
