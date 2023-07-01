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

namespace insurance.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Scouts.xaml
    /// </summary>
    public partial class Scouts : UserControl
    {
        Models.Scouts scout;
        
        public Scouts(Models.Scouts scout)
        {
            InitializeComponent();
            this.scout = scout;
            FirstName.Text = scout.FirstName;
            SecondName.Text = scout.SecondName;
            Patronymic.Text = scout.Patronymic;
            BD.Text = scout.BirthDate.ToString("dd.MM.yyyy");
            Login.Text = scout.Login;
            Passcode.Text = scout.Passcode;
            if (scout.Status == "Уволен")
                BG.Background = RedBG.Background;
        }

        private void BG_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
