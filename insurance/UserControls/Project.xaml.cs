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

namespace insurance.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Project.xaml
    /// </summary>
    public partial class Project : UserControl
    {
        Models.Projects project;
        public Project(Models.Projectkinds project)
        {
            InitializeComponent();
            Models.Projects pr = App.context.Projects.ToList().Find(p => p.Id == project.Project);
            this.project = pr;
            Models.Kinds kind = App.context.Kinds.ToList().Find(k => k.Id == project.Kind);
            Type.Text = kind.Title;
            BitmapImage bi = new BitmapImage();
            Models.Advertisers advertiser = App.context.Advertisers.ToList().Find(a => a.Id == project.Project);
            try
            {
                MemoryStream ms = new MemoryStream(advertiser.Logo);
                bi.BeginInit();
                bi.StreamSource = ms;
                bi.EndInit();
                Img.Source = bi;
            }
            catch { }
            Title.Text = " " + pr.Title;
            Specification.Text = " " + pr.Specification;
            List<Models.Projecttags> pt = App.context.Projecttags.ToList().Where(p => p.Project == pr.Id).ToList();
            Tags.Text += " ";
            foreach (var item in pt)
            {
                Models.Tags tag = App.context.Tags.ToList().Find(t => t.Id == item.Tag);
                Tags.Text += tag.Title + ", ";
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Classes.Navigation.main.Navigate(new Pages.Scout.AboutProject(project));
        }
    }
}
