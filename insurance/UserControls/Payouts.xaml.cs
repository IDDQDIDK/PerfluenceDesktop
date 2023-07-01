using insurance.Models;
using insurance.Pages.Senior;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Payouts.xaml
    /// </summary>
    public partial class Payouts : UserControl
    {
        Posts post;
        Models.Payouts payout;
        Pages.Senior.Payouts payouts;
        public Payouts(Models.Payouts payout, Pages.Senior.Payouts payouts)
        {
            InitializeComponent();
            Posts post = App.context.Posts.ToList().Find(p => p.Id == payout.Post);
            Bloggers blogger = App.context.Bloggers.ToList().Find(b => b.Id == post.Blogger);
            Projects projects = App.context.Projects.ToList().Find(p => p.Id == post.Project);
            Project.Text = projects.Title;
            Blog.Text = blogger.Blog;
            Requistits.Text = blogger.Requisits;
            Link.Text = post.Link;
            When.Text = post.WhenDate.ToString().Split(' ')[0];
            
            if (post.WhenDate.AddDays(7) >= DateTime.Now)
                this.Days.Text = post.WhenDate.AddDays(7).ToString().Split(' ')[0];
            else
                this.Days.Text = "Просрочено!";
            this.post = post;
            this.payouts = payouts;
            this.payout = payout;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            payout.WhenDate = DateTime.Now;
            App.context.Payouts.Update(payout);
            App.context.SaveChanges();
            payouts.LoadData();
        }

        private void Link_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", $"\"{post.Link}\"");
        }

        private void BG_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
