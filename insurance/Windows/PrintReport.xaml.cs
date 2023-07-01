using insurance.Models;
using insurance.UserControls;
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

namespace insurance.Windows
{
    /// <summary>
    /// Логика взаимодействия для PrintReport.xaml
    /// </summary>
    public partial class PrintReport : Window
    {
        public PrintReport(string Begin, string End)
        {
            InitializeComponent();
            Classes.CurrentUser.Total = 0;
            List<Projectkinds> pks = App.context.Projectkinds.ToList();
            When.Text += DateTime.Now.ToString("dd.MM.yyyy").Split(' ')[0];
            EndStart.Text = "Отчёт от " + Begin.Split(' ')[0] + " по " + End.Split(' ')[0];
            foreach (var item in pks)
            {
                Report.Children.Add(new ReportProject(item));
            }
            Total.Text += " " + Classes.CurrentUser.Total + " р.";
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                pd.PrintVisual(Grid1, "Печать");
            }
        }
    }
}
