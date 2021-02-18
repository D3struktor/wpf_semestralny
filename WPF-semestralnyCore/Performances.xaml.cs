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
    /// Logika interakcji dla klasy Performances.xaml
    /// </summary>
    public partial class Performances : Window
    {
        public Performances()
        {
            InitializeComponent();

            ViewData();
        }

        private List<PerformanceInfo> Employer_Info = new List<PerformanceInfo>();

        private void ViewData()
        {
            using var db = new UsersDB();
            Employer_Info = db.Performance.Select(a => new PerformanceInfo(a)).ToList();

            Wystepy.ItemsSource = Employer_Info;
        }

        private void DeleteUser(object o, EventArgs e)
        {
            var id = (int)((Button)o).CommandParameter;

            var performance = Employer_Info.FirstOrDefault(a => a.ID == id);
            Employer_Info.Remove(performance);

            using var db = new UsersDB();
            db.Performance.Remove(performance.Performance);

            db.SaveChanges();

            Wystepy.ItemsSource = null;
            Wystepy.ItemsSource = Employer_Info;
        }

        class PerformanceInfo
        {
            public Performance Performance { get; }

            public int ID
            {
                get => Performance.Performance_id;
            }
            public string Name
            {
                get => Performance.Performance_name;
                set
                {
                    using var db = new UsersDB();
                    db.Performance.Attach(Performance);
                    if (!Regex.IsMatch(value, "^[A-Z][a-m]*"))
                        return;
                    Performance.Performance_name = value;
                    db.SaveChanges();
                }
            }

            public decimal Cost
            {
                get => Performance.Performace_visit_cost;
                set
                {
                    using var db = new UsersDB();
                    db.Performance.Attach(Performance);

                    if (value < 0)
                        return;
                    Performance.Performace_visit_cost = value;
                    db.SaveChanges();
                }
            }
            public System.DateTime Date
            {
                get => Performance.Performance_Date;
                set
                {
                    using var db = new UsersDB();
                    db.Performance.Attach(Performance);

                    Performance.Performance_Date = value;
                    db.SaveChanges();
                }
            }


            public PerformanceInfo()
            {
                using var db = new UsersDB();

                Performance = new Performance()
                {
                    Performance_name = "Koncert",
                    Performace_visit_cost = 10,
                    Performance_Date = DateTime.Now + new TimeSpan(24, 0, 0)
                };

                db.Performance.Add(Performance);
                db.SaveChanges();
            }

            public PerformanceInfo(Performance performance)
            {
                Performance = performance;
            }
        }
    }
}
