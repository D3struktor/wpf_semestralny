using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_semestralny
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        /*  DatabaseEntities login = new DatabaseEntities();
            private void btnLogin_Click(object sender, EventArgs e)
                 {
                    foreach (var username in Database)
                if(Employers.username == txtUsername && Employers.Password == txtPassword)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login or Password is incorrect");
                }
        
        */

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            using var db = new UsersDB();
            string userName = txtUsername.Text;
            string password = txtPassword.Password;

            var user = db.Employers.FirstOrDefault(a => a.Username == userName && a.Password == password);

            if(user is null)
            {
                MessageBox.Show("Nie poprawny login lub haslo");
            }
            else
            {
                new Dashboard().Show();
                this.Close();
            }

            //SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\Database; Initial Catalog=Database; Integrated Secutity=true;");
            //try
            //{
            //    if (sqlCon.State == ConnectionState.Closed)
            //        sqlCon.Open();
            //    String query = "SELECT COUNT(1) FROM Employers WHERE Username=@Username and Password=@Password";
            //    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            //    sqlCmd.CommandType = CommandType.Text;
            //    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            //    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
            //    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            //    if (count == 1)
            //    {
            //        MainWindow dashboard = new MainWindow();
            //        dashboard.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Login or Password is incorrect");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{

            //}
        }
    }
}
