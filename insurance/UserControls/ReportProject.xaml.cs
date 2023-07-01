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

namespace insurance.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ReportProject.xaml
    /// </summary>
    public partial class ReportProject : UserControl
    {
        public ReportProject(Projectkinds pk)
        {
            InitializeComponent();
            Projects project = App.context.Projects.ToList().Find(p => p.Id == pk.Project);
            Kinds kind = App.context.Kinds.ToList().Find(k => k.Id == pk.Kind);
            Projectkinds pks = App.context.Projectkinds.ToList().Find(p => p.Kind == kind.Id && p.Project == project.Id);
            Advertisers adv = App.context.Advertisers.ToList().Find(a => a.Id == project.Company);
            List<Posts> posts = App.context.Posts.ToList().Where(p => p.Project == pk.Project).ToList();

            BitmapImage bi = new BitmapImage();
            MemoryStream ms = new MemoryStream(adv.Logo);
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.EndInit();
            Img.Source = bi;
            Title.Text += " " + project.Title;
            Company.Text += " " + adv.Title;
            Quantity.Text += " " + posts.Count;
            When.Text += " " + project.DateStart;
            Kind.Text = kind.Title;
            Cost.Text = pks.Cost.ToString() + " р.";
            Fee.Text = " - " + pks.Cost * 0.2 + " р.";
            Classes.CurrentUser.Total += pks.Cost - pks.Cost * 0.2;
        }
    }
}
