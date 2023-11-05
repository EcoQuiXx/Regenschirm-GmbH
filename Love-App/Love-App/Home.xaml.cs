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

namespace Love_App
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            MainWindow.database.MatchFunction(listb_matchdata);
        }

        private void btn_smash_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Herzlichen Glückwunsch\nIhr wurdet erfolgreich gematched", "Match erfolgreich", MessageBoxButton.OK);
        }

        private void btn_pass_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Match abgelehnt\nNeuer Match wurde gefunden", "Match nicht erfolgreich", MessageBoxButton.OK);
            MainWindow.database.MatchFunction(listb_matchdata);
        }
    }
}
