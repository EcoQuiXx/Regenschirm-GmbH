using System;
using System.Collections.Generic;
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
using MySqlConnector;

namespace TryCatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inserting the sign up account credentials to the database (konten)
        /// </summary>
        /// <param name="kd_u">SignUp Username</param>
        /// <param name="kd_p">SignUp Password</param>
        /// <param name="kd_e">SignUp E-Mail</param>
        /// <param name="kd_q">SignUp SecurityQuestion</param>
        private void SignUp_Write(string kd_u, string kd_p, string kd_e, string kd_q)
        {
            try
            {
                // MYSQL LOGIN //
                var con = new MySqlConnection("server=localhost;userid=datingappadmin;password = 123456789!?; database = datingapp");
                // WRITING DATA INTO THE DB //
                string query = $"Insert into konten(kd_username, kd_password, kd_email, kd_question)" + $" values('{kd_u}', '{kd_p}', '{kd_e}', '{kd_q}')";
                var command = new MySqlCommand(query, con);
                // MYSQL SESSION //
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Die Registrierung war erfolreich.");
            }
            // ERROR EXCEPTION //
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Reading and checking the login credentials from the database (konten) 
        /// </summary>
        /// <param name="kd_u_e">LogIn Username OR E-Mail</param>
        /// <param name="kd_p">LogIn Password</param>
        private void LogIn_Read(string kd_u_e, string kd_p)
        {
            try
            {
                // MYSQL LOGIN //
                var con = new MySqlConnection("server=localhost;userid=datingappadmin;password = 123456789!?; database = datingapp");
                // MYSQL SESSION //
                con.Open();
                // READING DATA FROM THE DATABASE //
                var command = new MySqlCommand("select * from konten where (kd_username = '" + kd_u_e + "' OR kd_email = '" + kd_u_e + "') AND kd_password = '" + kd_p + "'", con);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Du wurdest erfolgreich angemeldet.");
                }
                else
                {
                    MessageBox.Show("Deine Anmeldedaten stimmen nicht überein oder existrieren nicht.");
                }
                reader.Close();
                con.Close();
            }
            // ERROR EXCEPTION //
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void signup_submit_Click(object sender, RoutedEventArgs e)
        {
            // CHECK TO MAKE SURE THAT THE BOXES ARE NOT EMPTY //
            if (username.Text != "" && password.Text != "" && email.Text != "" && question.Text != "")
            {
                // REDIRECTING THE DATA TO THE DATABASE FUNCTION //
                try
                {
                    SignUp_Write(username.Text, password.Text, email.Text, question.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // EMPTY BOXES EXCEPTION //
                MessageBox.Show("Ungültige Daten");
            }
        }

        private void login_submit_Click(object sender, RoutedEventArgs e)
        {
            LogIn_Read(login_username.Text, login_password.Text);
        }
    }
}
