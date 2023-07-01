using insurance.Models;
using insurance.Pages.Scout;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace insurance.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer1 = new DispatcherTimer();
        DispatcherTimer LogoutTimer = new DispatcherTimer();
        DispatcherTimer LogoutTimer1 = new DispatcherTimer();
        public Authorization()
        {
            InitializeComponent();
            Classes.Navigation.main = Main;
            Classes.Navigation.auth = this;
            timer.Tick += new EventHandler(timer_Tick);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer1.Interval = new TimeSpan(0, 0, 0, 0, 1);
            LogoutTimer.Tick += new EventHandler(LogoutTimer_Tick);
            LogoutTimer1.Tick += new EventHandler(LogoutTimer1_Tick);
            LogoutTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            LogoutTimer1.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }
        bool IsAdmin = false;

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text.Length != 0 && Passcode.Text.Length != 0)
            {
                Scouts user = App.context.Scouts.ToList().Find(u => u.Login == Login.Text && u.Passcode == Passcode.Text);
                if (user != null)
                {
                    timer.Start();
                    IsAdmin = false;
                    Classes.CurrentUser.user = user;
                }
                else if (Login.Text == "админ" && Passcode.Text == "админ")
                {
                    timer.Start();
                    IsAdmin = true;
                    MessageBox.Show("Добро пожаловать, Сеньор!");
                }
                else
                    MessageBox.Show("Вы ввели неверные данные!");
            }
            else
                MessageBox.Show("Вы должны заполнить все поля!");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Green.Angle < 0)
            {
                Green.Angle += 1;
                Lime.Angle -= 1;
                Pale.Angle -= 1;
                MostPale.Angle += 1;
            }
            else
            {
                timer.Stop();
                timer1.Start();
            }
        }
        Project project;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GreenBack.Height < 800)
            {
                GreenBack.Height += 10;
                Auth.Opacity -= 0.05;
            }
            else
            {
                Auth.Visibility = Visibility.Hidden;
                Logout.Visibility = Visibility.Visible;
                timer1.Stop();
                if (IsAdmin)
                {
                    Main.Navigate(new Pages.Senior.MainMenu()); 
                }
                else
                {
                    project = new Project();
                    Main.Navigate(project);
                    project.FadeIn.Start();
                }
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!IsAdmin)
                {
                    project.FadeOut.Start();
                }
                else
                    Main.Content = null;
                LogoutTimer.Start();
                
            }
            catch { }
        }
        private void LogoutTimer_Tick(object sender, EventArgs e)
        {
            if (Green.Angle > -36)
            {
                Green.Angle -= 1;
                Lime.Angle += 1;
                Pale.Angle += 1;
                MostPale.Angle -= 1;
            }
            else
            {
                LogoutTimer.Stop();
                LogoutTimer1.Start();
                Auth.Visibility = Visibility.Visible;
            }
        }
        private void LogoutTimer1_Tick(object sender, EventArgs e)
        {
            if (GreenBack.Height > 300)
            {
                GreenBack.Height -= 10;
                Auth.Opacity += 0.05;
            }
            else
            {
                Logout.Visibility = Visibility.Hidden;
                LogoutTimer1.Stop();
            }
        }

    }
}
