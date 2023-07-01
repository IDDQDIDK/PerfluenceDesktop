using insurance.Classes;
using insurance.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AboutProject.xaml
    /// </summary>
    public partial class AboutProject : Page
    {
        Projects project;
        public AboutProject(Projects project)
        {
            InitializeComponent();
            this.project = project;
            Title.Text = project.Title;
            Specification.Text = project.Specification;
            List<Projecttags> pt = App.context.Projecttags.ToList().Where(p => p.Project == project.Id).ToList();
            foreach (Projecttags p in pt)
            {
                Tags.Text += p.TagNavigation.Title + ", ";
            }

            List<Materials> materials = App.context.Materials.ToList().Where(m => m.Project == project.Id).ToList();
            foreach (Materials material in materials)
            {
                Materials.Children.Add(new UserControls.Materials(material));
            }

            BitmapImage bi = new BitmapImage();
            Advertisers adv = App.context.Advertisers.ToList().Find(a => a.Id == project.Company);
            MemoryStream ms = new MemoryStream(adv.Logo);
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.EndInit();
            Img.Source = bi;

            LoadData();
            Navigation.ap = this;
            AddPostFrame.Navigate(new AddPost(AddPostFrame, project));

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }


        public void LoadData()
        {
            Posts.Children.Clear();
            List<Posts> posts = App.context.Posts.ToList().Where(p => p.Project == project.Id && p.Status != "Проверено").ToList();
            foreach (Posts post in posts)
            {
                Posts.Children.Add(new UserControls.Post(post, this));
            }
        }
        DispatcherTimer timer = new DispatcherTimer();
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (AddPostFrame.Height < 300)
            {
                AddPostFrame.Height += 25;
                AddPostFrame.Width += 25;
            }
            else
            {
                timer.Stop();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Classes.Navigation.main.GoBack();
        }
    }
}
