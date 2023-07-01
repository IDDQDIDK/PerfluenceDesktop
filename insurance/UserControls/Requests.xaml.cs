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

namespace insurance.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Requests.xaml
    /// </summary>
    public partial class Requests : UserControl
    {
        Models.Requests request;
        public Requests(Models.Requests request)
        {
            InitializeComponent();
            this.request = request;

            Bloggers bloggers = App.context.Bloggers.ToList().Find(b => b.Id == request.Blogger);
            List<Projecttags> projecttags = App.context.Projecttags.ToList().Where(pt => pt.Project == request.Project).ToList();
            Projects projects = App.context.Projects.ToList().Find(p => p.Id == request.Project);
            Advertisers advertisers = App.context.Advertisers.ToList().Find(a => a.Id == projects.Id);
            Blog.Text = bloggers.Blog;
            Project.Text = projects.Title;
            Email.Text = bloggers.Email;
            Company.Text = advertisers.Title;
            When.Text = request.WhenDate.ToString().Split(' ')[0];
            //foreach (var item in projecttags)
            //{
            //    Tags tag = App.context.Tags.ToList().Find(t => t.Id == item.Tag);
            //    Tags.Text += tag.Title + ", ";
            //}
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            request.Status = "Одобрено";

            App.context.SaveChanges();
        }

        private void Decline_Click(object sender, RoutedEventArgs e)
        {
            request.Status = "Отвергнуто";

            App.context.SaveChanges();
        }

        private void BG_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
