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
using System.Windows.Shapes;

namespace insurance.Windows
{
    /// <summary>
    /// Логика взаимодействия для PrintAgreement.xaml
    /// </summary>
    public partial class PrintAgreement : Window
    {
        public PrintAgreement(string ID, Bloggers blogger, Projects project)
        {
            InitializeComponent();
            this.ID.Text += ID;
            Who.Text += " " + blogger.SecondName + " " + blogger.FirstName + " " + blogger.Patronymic;
            Blog.Text += " " + blogger.Blog;
            Project.Text += " " + project.Title;
            Advertisers adv = App.context.Advertisers.ToList().Find(a => a.Id == project.Company);
            Company.Text += " " + adv.Title + ".";
            BitmapImage bi = new BitmapImage();
            MemoryStream ms = new MemoryStream(adv.Logo);
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.EndInit();
            Logo.Source = bi;
            When.Text += " " + DateTime.Now;
            Scout.Text += " " + Classes.CurrentUser.user.FirstName + " " + Classes.CurrentUser.user.SecondName + " " + Classes.CurrentUser.user.Patronymic;
            Blogger.Text += "\n " + blogger.SecondName + " " + blogger.FirstName + " " + blogger.Patronymic + " / ____________";
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                pd.PrintVisual(Grid1, "Печать");
            }
        }
    }
}
