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
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Page
    {
        //public Frame temp;
        public Sign_Up()
        {
            InitializeComponent();
            
        }
        public void LoginClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateTo(this, "Home");

        }


        private void ClickReg(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateTo(this, "Login");
        }
    }
}
