using insurance.Models;
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
    /// Логика взаимодействия для Requests.xaml
    /// </summary>
    public partial class Requests : Page
    {
        public Requests()
        {
            InitializeComponent();
            List<Models.Advertisers> advertisers = App.context.Advertisers.ToList();
            foreach (var item in advertisers)
            {
                Filtration.Items.Add(item.Title);
            }
            LoadData();
        }
        public void LoadData()
        {
            RequestsPanel.Children.Clear();
            List<Models.Requests> requests = App.context.Requests.ToList();
            //if (Filtration.SelectedIndex != 0)
            //    requests = requests.Where(r => r.ProjectNavigation.CompanyNavigation.Title == Filtration.Text).ToList();
            //else
            //    requests = App.context.Requests.ToList();
            if (Search.Text.Length != 0)
                requests = requests.Where(p => p.ProjectNavigation.Title.Contains(Search.Text)).ToList();
            
            foreach (var item in requests)
            {
                RequestsPanel.Children.Add(new UserControls.Requests(item));
            }
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
        }

        private void Filtration_DropDownClosed(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
