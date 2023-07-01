using insurance.Models;
using insurance.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Payouts.xaml
    /// </summary>
    public partial class Payouts : Page
    {
        public Payouts()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            PayoutsPanel.Children.Clear();
            List<Posts> pays = App.context.Posts.ToList();
            if (Search.Text.Length != 0)
            {
                pays = pays.Where(p => p.ProjectNavigation.Title.Contains(Search.Text)).ToList();
            }
            List<Models.Payouts> payouts = App.context.Payouts.ToList().Where(p => p.WhenDate == new DateTime(0001,01,01)).ToList();
            foreach (Models.Payouts pay in payouts)
            {
                PayoutsPanel.Children.Add(new UserControls.Payouts(pay, this));
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintReport print = new PrintReport(Convert.ToDateTime(Begin.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(End.Text).ToString("yyyy-MM-dd"));
            print.Show();
        }

        private void End_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Print.IsEnabled = true;
        }

        private void Begin_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            End.DisplayDateStart = Convert.ToDateTime(Begin.Text);
            End.IsEnabled = true;
        }
    }
}
