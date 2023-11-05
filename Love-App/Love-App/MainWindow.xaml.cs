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
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySqlConnector;
using System.Runtime.CompilerServices;
using System.Runtime;

namespace Love_App
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sign_Up sign_Up = new Sign_Up();

        // ###################################### //
        // DATABASE FUNCTIONALITY (DO NOT CHANGE) //
        // ###################################### //
        // DATABASE LOGIN AS ADMIN //
        static string dbuser = "datingappadmin";
        static string dbpw = "123456789!?";
        static string dbobject = "datingapp";
        // ####################### //
        static List<string> UserData = new List<string>();
        static List<string> MatchData = new List<string>();
        static Random rnd = new Random();
        public static class database
        { 
            /// <summary>
        /// Inserting the credentials to the database to create an account
        /// </summary>
        /// <param name="kd_u">Object konten | kd_username</param>
        /// <param name="kd_p">Object konten | kd_password</param>
        /// <param name="kd_e">Object konten | kd_email</param>
        /// <param name="kd_q">Object konten | kd_question</param>
        /// <param name="kd_u_len">Object konten | kd_username character length</param>
        /// <param name="kd_p_len">Object konten | kd_password character length</param>
        /// <param name="kd_e_has">Object konten | kd_email bool to check if it has a @</param>
            public static void AccountCreation(string kd_u, string kd_p, string kd_e, string kd_q, int kd_u_len, int kd_p_len, bool kd_e_has)
            {
                bool kd_e_exists = false;
                try
                {
                    // MYSQL LOGIN //
                    var con = new MySqlConnection("server=localhost;userid=" + dbuser + ";password = " + dbpw + "; database = " + dbobject);
                    // MYSQL SESSION //
                    con.Open();
                    // READING ALL EMAILS TO COMPARE IF IT ALREADY EXISTS //
                    var command = new MySqlCommand("select * from konten where (kd_email = '" + kd_e + "')", con);
                    // STARTING THE READER //
                    var reader = command.ExecuteReader();
                    // E-MAIL WAS FOUND //
                    if (reader.Read())
                    {
                        kd_e_exists = true;
                    }
                    // E-MAIL WAS NOT FOUND //
                    else
                    {
                        kd_e_exists = false;
                    }
                    // CLOSING THE READER & THE MYSQL SESSION //
                    reader.Close();
                    con.Close();
                }
                // ERROR EXCEPTION //
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Registrierungsfehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                // REQUIREMENTS CHECK //
                if (kd_u != "" && kd_u_len >= 3 && kd_p != "" && kd_p_len >= 8 && kd_e != "" && kd_e_has == true && kd_q != "" && kd_e_exists == false)
                {
                    try
                    {
                        // MYSQL LOGIN //
                        var con = new MySqlConnection("server=localhost;userid=" + dbuser + ";password = " + dbpw + "; database = " + dbobject);
                        // WRITING DATA INTO THE DATABASE TABLE KONTEN //
                        string query = $"Insert into konten(kd_username, kd_password, kd_email, kd_question)" + $" values('{kd_u}', '{kd_p}', '{kd_e}', '{kd_q}')";
                        var command = new MySqlCommand(query, con);
                        // OPEN MYSQL SESSION & EXECUTE COMMAND //
                        con.Open();
                        command.ExecuteNonQuery();
                        // CLOSING THE MYSQL SESSION //
                        con.Close();
                        // SUCCESS LOGIN OUTPUT //
                        MessageBox.Show("Du wurdest erfolgreich registriert.\nBitte melden Sie sich nun an.", "Registrierung erfolgreich", MessageBoxButton.OK, MessageBoxImage.None);
                    }
                    // ERROR EXCEPTION //
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Registrierungsfehler", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    // E-MAIL ALREADY EXISTS OUTPUT //
                    if (kd_e_exists == true)
                    {
                        MessageBox.Show("Ein Konto mit dieser E-Mail Adresse existiert bereits.", "Fehlerausgabe", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        // USERNAME NOT 3 CHARACTERS LONG OUTPUT //
                        if (kd_u_len < 3)
                        {
                            MessageBox.Show("Dein Benutzername muss mindestens 3 Zeichen lang sein.", "Fehlerausgabe", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        // PASSWORD NOT 8 CHARACTERS LONG OUTPUT //
                        if (kd_p_len < 8)
                        {
                            MessageBox.Show("Dein Passwort muss mindestens 8 Zeichen lang sein.", "Fehlerausgabe", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        // EMAIL DOES NOT CONTAIN @ OUTPUT //
                        if (kd_e_has == false)
                        {
                            MessageBox.Show("Deine E-Mail Adresse ist ungültig.", "Fehlerausgabe", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        // SECURITY QUESTION IS EMPTY OUTPUT //
                        if (kd_q == "")
                        {
                            MessageBox.Show("Die Sicherheitsfrage musst ausgefüllt werden.", "Fehlerausgabe", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                }
            }

            /// <summary>
            /// Reading the login credentials and writing the personal data
            /// [0] = pd_id | [1] = Vorname | [2] = Nachname | [3] = Geschlecht | [4] = Geburtsdatum | [5] = Ortschaft | [6] = Postleitzahl 
            /// [7] = Straße | [8] = Hausnummer | [9] = Lieblingstier | [10] = Lieblingsfilm | [11] = Raucher Bool | [12] = Alkohol Bool
            /// </summary>
            /// <param name="kd_u_e">Object konten | kd_username or kd_email</param>
            /// <param name="kd_p">Object konten | kd_password</param>
            public static void LoginFeature(string kd_u_e, string kd_p)
        {
            try
            {
                // ######################### //
                // READING LOGIN CREDENTIALS //
                // ######################### //
                // MYSQL LOGIN //
                var con = new MySqlConnection("server=localhost;userid=" + dbuser + ";password = " + dbpw + "; database = " + dbobject);
                // MYSQL SESSION //
                con.Open();
                // READING DATA FROM THE DATABASE TABLE KONTEN //
                var command = new MySqlCommand("select * from konten where (kd_username = '" + kd_u_e + "' OR kd_email = '" + kd_u_e + "') AND kd_password = '" + kd_p + "'", con);
                // STARTING THE READER //
                var reader = command.ExecuteReader();
                // USERNAME OR EMAIL AND PASSWORD ARE THE SAME //
                if (reader.Read())
                {
                    // CLEARS THE LIST, ADDS THE USER ID TO THE LIST AND PULLS ALL PROFILE SETTINGS //
                    UserData.Clear();
                    UserData.Add(reader["kd_id"] + "");
                    // LOGIN SUCCESSFUL OUTPUT //
                    MessageBox.Show("Du wurdest erfolgreich angemeldet.", "Login erfolgreich", MessageBoxButton.OK, MessageBoxImage.None);
                    // CLOSING THE READER //
                    reader.Close();
                    // #################### //
                    // WRITING PROFILE DATA //
                    // #################### //
                    // READING ALL DATA FROM USER FROM THE TABLE PERSONENDATEN //
                    command = new MySqlCommand("select * from personendaten where pd_id = '" + UserData[0] + "'", con);
                    // STARTING THE READER //
                    reader = command.ExecuteReader();
                    // READING THE DATA FROM THE DATABASE //
                    while (reader.Read())
                    {
                        // WRITING THE PROFILE DATA TO THE BACKEND //
                        UserData.Add(reader["pd_vorname"] + "");
                        UserData.Add(reader["pd_nachname"] + "");
                        UserData.Add(reader["pd_geschlecht"] + "");
                        UserData.Add(reader["pd_geburtsdatum"] + "");
                        UserData.Add(reader["pd_ortschaft"] + "");
                        UserData.Add(reader["pd_postleitzahl"] + "");
                        UserData.Add(reader["pd_straße"] + "");
                        UserData.Add(reader["pd_hausnummer"] + "");
                        UserData.Add(reader["pd_lieblingstier"] + "");
                        UserData.Add(reader["pd_lieblingsfilm"] + "");
                        UserData.Add(reader["pd_raucher"] + "");
                        UserData.Add(reader["pd_alkohol"] + "");
                    }
                }
                // LOGIN NOT SUCCESSFUL OUTPUT //
                else
                {
                    MessageBox.Show("Deine Anmeldedaten stimmen nicht überein oder existrieren nicht.", "Loginfehler", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                // CLOSING THE READER & THE MYSQL SESSION //
                reader.Close();
                con.Close();
            }
            // ERROR EXCEPTION //
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Personendaten Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

            /// <summary>
            /// Updating the user profile data
            /// </summary>
            /// <param name="pd_v">Object personendaten | pd_vorname</param>
            /// <param name="pd_n">Object personendaten | pd_nachname</param>
            /// <param name="pd_g">Object personendaten | pd_geschlecht</param>
            /// <param name="pd_geb">Object personendaten | pd_geburtsdatum</param>
            /// <param name="pd_ort">Object personendaten | pd_ortschaft</param>
            /// <param name="pd_plz">Object personendaten | pd_postleitzahl</param>
            /// <param name="pd_s">Object personendaten | pd_straße</param>
            /// <param name="pd_hn">Object personendaten | pd_hausnummer</param>
            /// <param name="pd_liebt">Object personendaten | pd_lieblingstier</param>
            /// <param name="pd_liebf">Object personendaten | pd_lieblingsfilm</param>
            /// <param name="pd_r">Object personendaten | pd_raucher</param>
            /// <param name="pd_alk">Object personendaten | pd_alkohol</param>
            public static void SetProfileSettings(string pd_v, string pd_n, string pd_g, string pd_geb, string pd_ort, string pd_plz, string pd_s, string pd_hn, string pd_liebt, string pd_liebf, string pd_r, string pd_alk)
        {
            try
            {
                // MYSQL LOGIN //
                var con = new MySqlConnection("server=localhost;userid=" + dbuser + ";password = " + dbpw + "; database = " + dbobject);
                // WRITING DATA INTO THE DATABASE IN TABLE PERSONENDATEN //
                string query = $"update personendaten set pd_vorname = '" + pd_v + "', pd_nachname = '" + pd_n + "', pd_geschlecht = '" + pd_geb + "', pd_geburtsdatum = '" + pd_geb + "', pd_ortschaft = '" + pd_ort + "', pd_postleitzahl = '" + pd_plz + "', pd_straße = '" + pd_s + "', pd_hausnummer = '" + pd_hn + "', pd_lieblingstier = '" + pd_liebt + "', pd_lieblingsfilm = '" + pd_liebf + "', pd_raucher = '" + pd_r + "', pd_alkohol = '" + pd_alk + "' where pd_id = '" + UserData[0] + "'";
                var command = new MySqlCommand(query, con);
                // OPEN MYSQL SESSION & EXECUTE COMMAND //
                con.Open();
                command.ExecuteNonQuery();
                // CLOSING THE MYSQL SESSION //
                con.Close();
                // SUCCESS PROFILE UPDATE OUTPUT //
                MessageBox.Show("Dein Profil wurde erfolgreich aktualisiert.", "Profilbearbeitung erfolgreich", MessageBoxButton.OK, MessageBoxImage.None);
            }
            // ERROR EXCEPTION //
            catch (Exception ex)
            {
                // PROFILE UPDATE WAS NOT SUCCESSFUL OUTPUT //
                MessageBox.Show(ex.Message, "Profilfehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

            /// <summary>
            /// Reading and writing data from the database to find random matches
            /// [0] = pd_id | [1] = Vorname | [2] = Nachname | [3] = Geschlecht | [4] = Geburtsdatum | [5] = Ortschaft | [6] = Postleitzahl 
            /// [7] = Straße | [8] = Hausnummer | [9] = Lieblingstier | [10] = Lieblingsfilm | [11] = Raucher Bool | [12] = Alkohol Bool | [13] = Avatar
            /// </summary>
            /// <param name="matchdata">Listbox element used to output the matchdata</param>
            public static void MatchFunction(ListBox matchdata)
        {
            try
            {
                // ################## //
                // READING MATCH DATA //
                // ################## //
                // MYSQL LOGIN //
                var con = new MySqlConnection("server=localhost;userid=" + dbuser + ";password = " + dbpw + "; database = " + dbobject);
                // MYSQL SESSION //
                con.Open();
                // EXECUTING COMMAND TO READ THE TOTAL COUNT OF ENTRIES FROM THE TABLE PERSONENDATEN //
                var command = new MySqlCommand("select count(pd_id) from personendaten", con);
                // STARTING THE READER //
                var reader = command.ExecuteReader();
                // READING THE DATA FROM THE DATABASE //
                while (reader.Read())
                {
                    // RESETTING THE LIST FOR MULTIPLE REQUESTS //
                    MatchData.Clear();
                    // GENERATING RANDOM MATCH ID FROM ALL ENTRIES //
                    MatchData.Add(reader["count(pd_id)"] + "");
                    MatchData[0] = Convert.ToString(rnd.Next(1, Convert.ToInt32(reader["count(pd_id)"]) + 1));
                }
                // CLOSING THE READER AND THE MYSQL SESSION //
                reader.Close();
                con.Close();
                // ################## //
                // WRITING MATCH DATA //
                // ################## //
                // MYSQL SESSION //
                con.Open();
                // EXECUTING COMMAND TO READ THE DATA FROM THE MATCHED PERSON FROM THE TABLE PERSONENDATEN //
                command = new MySqlCommand("select * from personendaten where pd_id = '" + MatchData[0] + "'", con);
                // STARTING THE READER //
                reader = command.ExecuteReader();
                // READING THE PROFILE DATA FROM THE MATCH //
                while (reader.Read())
                {
                    MatchData.Add("Vorname: " + reader["pd_vorname"] + "");
                    MatchData.Add("Nachname: " + reader["pd_nachname"] + "");
                    MatchData.Add("Geschlecht: " + reader["pd_geschlecht"] + "");
                    MatchData.Add("Geburtsdatum: " + reader["pd_geburtsdatum"] + "");
                    MatchData.Add("Ortschaft: " + reader["pd_ortschaft"] + "");
                    MatchData.Add("Postleitzahl: " + reader["pd_postleitzahl"] + "");
                    MatchData.Add("Straße: " + reader["pd_straße"] + "");
                    MatchData.Add("Hausnummer: " + reader["pd_hausnummer"] + "");
                    MatchData.Add("Lieblingstier: " + reader["pd_lieblingstier"] + "");
                    MatchData.Add("Lieblingsfilm: " + reader["pd_lieblingsfilm"] + "");
                    MatchData.Add("Ist Raucher: " + reader["pd_raucher"] + "");
                    MatchData.Add("Trinkt Alkohol: " + reader["pd_alkohol"] + "");
                    matchdata.Items.Clear();
                    for (int i = 0; i < MatchData.Count - 1; i++)
                    {
                        matchdata.Items.Add(MatchData[i + 1]);
                    }
                }
                // CLOSING THE READER & THE MYSQL SESSION //
                reader.Close();
                con.Close();
            }
            // ERROR EXCEPTION //
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Matching Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        }
        // ###################################### //
        // DATABASE FUNCTIONALITY (DO NOT CHANGE) //
        // ###################################### //
        public MainWindow()
        {
            InitializeComponent();
            Main.Navigate(new Sign_Up());
        }

        public static void NavigateTo(Page page, string toPage)
        {
            NavigationService nav = NavigationService.GetNavigationService(page);
            nav.Navigate(new Uri($"{toPage}.xaml", UriKind.RelativeOrAbsolute));
        }

    private void Window_SizeChanged(object sender, SizeChangedEventArgs e)      // Keep Aspect Ratio together
        {
            double aspectRatio = 800.0 / 450.0; // Change these values to your initial aspect ratio.

            // Calculate the new width and height while maintaining the aspect ratio.
            double newWidth = e.NewSize.Width;
            double newHeight = newWidth / aspectRatio;

            // Set the new size for the window.
            this.Width = newWidth;
            this.Height = newHeight;
        }
            bool OpenState = true;
        private void Button_Click(object sender, RoutedEventArgs e)             // Dropdown click event
        {
            
            if (OpenState ==false)                                              //By a false state Collapse
            {
                DropDown.Visibility = Visibility.Collapsed;
            }
            if (OpenState == true)                                         //By a true state make Visible
            {
                DropDown.Visibility = Visibility.Visible;
            }
            OpenState = !OpenState;                                             // Flip State
        }
        private void ClickReg(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Sign_Up());

        }
        public void LoginClick(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Home());
        }

        private void ClickLogIn(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Login());
        }
    }
}
