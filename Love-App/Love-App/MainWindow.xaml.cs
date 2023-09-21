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

namespace Love_App
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double aspectRatio = 800.0 / 450.0; // Change these values to your initial aspect ratio.

            // Calculate the new width and height while maintaining the aspect ratio.
            double newWidth = e.NewSize.Width;
            double newHeight = newWidth / aspectRatio;

            // Set the new size for the window.
            this.Width = newWidth;
            this.Height = newHeight;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int OpenState = 1;

            if (OpenState ==0)
            {
                DropDown.Visibility = Visibility.Collapsed;
            }
            else if (OpenState == 1)
            {
                DropDown.Visibility = Visibility.Visible;
            }

            OpenState = (OpenState + 1) % 2;
        }
    }
}
