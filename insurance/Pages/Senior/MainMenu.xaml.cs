using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace insurance.Pages.Senior
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            Classes.Navigation.Senior = Main;
            Main.Navigate(new Scouts());
        }

        private void Scouts_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Navigate(new Scouts());
        }

        private void Payouts_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Navigate(new Payouts());
        }

        private void Requests_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Navigate(new Requests());
        }
    }
}
