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

namespace Love_App
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Sign_Up sign_Up = new Sign_Up();


        public MainWindow()
        {
            InitializeComponent();

        }
        public static void NavigateTo(Page page, string toPage)
        {
            NavigationService nav = NavigationService.GetNavigationService(page);
            nav.Navigate(new Uri($"{toPage}.xaml", UriKind.RelativeOrAbsolute));
        }
    

    /*private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        var personDetails = new Person()
        {
            Name = "John",
            Birthdate = DateTime.Parse("2001-02-03")
        };

        var nameBindingObject = new Binding("Name");
        nameBindingObject.Source = personDetails;
    }*/



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

        private void ClickLogOut(object sender, RoutedEventArgs e)
        {
            sign_Up.temp = Main;


            Main.Navigate(new Sign_Up());
    
        }
        public void LoginClick(object sender, RoutedEventArgs e)
        {
            try 
            { 
            Main.Navigate(new Uri("MainWindow.xaml", UriKind.Relative));
            }

            catch(Exception ex)
            {
                Console.WriteLine("Exeption during navigation: " + ex.Message);
            }
        }
    }
}
