using insurance.Models;
using insurance.UserControls;
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
    /// Логика взаимодействия для Scouts.xaml
    /// </summary>
    public partial class Scouts : Page
    {
        public Scouts()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            ScoutPanel.Children.Clear();
            List<Models.Scouts> scouts = App.context.Scouts.ToList();
            BD.DisplayDateEnd = DateTime.Now.AddYears(-18);
            if (Search.Text.Length != 0)
                scouts = scouts.Where(s => s.FirstName.Contains(Search.Text) || s.SecondName.Contains(Search.Text) || s.Patronymic.Contains(Search.Text)).ToList();

            foreach (var item in scouts)
            {
                ScoutPanel.Children.Add(new UserControls.Scouts(item));
            }
        }
        Models.Scouts scout;
        public void UpdateScout(Models.Scouts scout)
        {
            Add.Visibility = Visibility.Hidden;
            FirstName.Text = scout.FirstName;
            SecondName.Text = scout.SecondName;
            Patronymic.Text = scout.Patronymic;
            BD.Text = scout.BirthDate.ToString();
            Login.Text = scout.Login;
            Password.Text = scout.Passcode;
            this.scout = scout;
        }
        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            scout.FirstName = FirstName.Text;
            scout.FirstName = FirstName.Text;
            scout.SecondName = SecondName.Text;
            scout.Patronymic = Patronymic.Text;
            scout.BirthDate = Convert.ToDateTime(BD.Text);
            scout.Login = Login.Text;
            scout.Passcode = Password.Text;
            App.context.SaveChanges();

            FirstName.Text = "";
            SecondName.Text = "";
            Patronymic.Text = "";
            BD.Text = "";
            Login.Text = "";
            Password.Text = "";
            Add.Visibility = Visibility.Visible;

            LoadData();
        }

        private void Decline_Click(object sender, RoutedEventArgs e)
        {
            FirstName.Text = "";
            SecondName.Text = "";
            Patronymic.Text = "";
            BD.Text = "";
            Login.Text = "";
            Password.Text = "";
            Add.Visibility = Visibility.Visible;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (FirstName.Text.Length != 0 && SecondName.Text.Length != 0 && Patronymic.Text.Length != 0 && BD.Text.Length != 0 && Login.Text.Length != 0 && Password.Text.Length != 0)
            {
                Models.Scouts scout = new Models.Scouts()
                {
                    FirstName = FirstName.Text,
                    SecondName = SecondName.Text,
                    Patronymic = Patronymic.Text,
                    BirthDate = Convert.ToDateTime(BD.Text), 
                    Login = Login.Text,
                    Passcode = Password.Text
                };
                App.context.Scouts.Add(scout);
                App.context.SaveChanges();
            }
            else
                MessageBox.Show("Вы должны заполнить все поля!");
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
        }

    }
}
