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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateTo(this, "Sign-Up");
        }

        private void ClickLogin(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateTo(this, "Home");
        }
    }
}
