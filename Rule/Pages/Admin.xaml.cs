using Rule.Classes;
using Rule.Pages;
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

namespace Rule
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Vxod(object sender, RoutedEventArgs e)
        {
            if (login.Text == "root" && password.Text == "12345")
            {
                Manager.MainFrame.Navigate(new adminik());
            }
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Collapsed;
            password.Visibility = Visibility.Visible;
            password.Text = passwordBox.Password;
        }

        private void Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible;
            password.Visibility = Visibility.Collapsed;
        }
    }
}
