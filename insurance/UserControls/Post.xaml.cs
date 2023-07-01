using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для Post.xaml
    /// </summary>
    public partial class Post : UserControl
    {
        Models.Posts post;
        string link;
        Pages.Scout.AboutProject ap;
        public Post(Models.Posts post, Pages.Scout.AboutProject ap)
        {
            InitializeComponent();
            this.post = post;
            Models.Bloggers blogger = App.context.Bloggers.ToList().Find(b => b.Id == post.Blogger);
            Title.Text = blogger.Blog;
            Date.Text = post.WhenDate.ToString("dd.mm.yyyy").Split(' ')[0];
            Link.Text = post.Link;
            link = post.Link;
            this.ap = ap;
        }

        private void Link_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("explorer.exe", $"\"{link}\"");
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            post.Status = "Проверено";
            App.context.Update(post);
            App.context.SaveChanges();
            ap.LoadData();
        }
    }
}
