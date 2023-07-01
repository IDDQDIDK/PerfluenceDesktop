using insurance.Classes;
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
using System.Windows.Threading;

namespace insurance.Pages.Scout
{
    /// <summary>
    /// Логика взаимодействия для AddPost.xaml
    /// </summary>
    public partial class AddPost : Page
    {
        Frame f;
        Projects project;
        DispatcherTimer timer = new DispatcherTimer();
        public AddPost(Frame f, Projects project)
        {
            InitializeComponent();
            this.f = f;
            this.project = project;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);

            List<Bloggers> bloggers = App.context.Bloggers.ToList();
            foreach (var item in bloggers)
            {
                Blogger.Items.Add(item.Blog);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (f.Height > 0)
            {
                f.Height -= 25;
                f.Width -= 25;
            }
            else
            {
                timer.Stop();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Blogger.Text.Length != 0 && Link.Text.Length != 0)
            {
                Posts p = new Posts();
                p.Project = project.Id;
                p.WhenDate = DateTime.Now;
                p.Blogger = Blogger.SelectedIndex + 1;
                p.Link = Link.Text;
                App.context.Posts.Add(p);
                App.context.SaveChanges();

                Payouts pay = new Payouts();
                pay.Post = p.Id;
                App.context.Payouts.Add(pay);
                App.context.SaveChanges();

                Navigation.ap.LoadData();

                Bloggers blogger = App.context.Bloggers.ToList().Find(b => b.Blog == Blogger.Text);

                PrintAgreement print = new PrintAgreement(pay.Id.ToString(), blogger, project);
                print.Show();

                timer.Start();
            }
            else
                MessageBox.Show("Вы должны заполнить все поля!");
        }
    }
}
