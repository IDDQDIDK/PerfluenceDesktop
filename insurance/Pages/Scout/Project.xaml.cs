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
    /// Логика взаимодействия для Project.xaml
    /// </summary>
    public partial class Project : Page
    {
        public DispatcherTimer FadeIn = new DispatcherTimer();
        public DispatcherTimer FadeOut = new DispatcherTimer();
        List<RadioButton> cbs = new List<RadioButton>();
        List<TextBlock> kindtbs = new List<TextBlock>();
        List<RadioButton> rbs = new List<RadioButton>();
        public Project()
        {
            InitializeComponent();
            Grid1.Opacity = 0;
            
            FadeIn.Tick += new EventHandler(FadeIn_Tick);
            FadeOut.Tick += new EventHandler(FadeOut_Tick);
            FadeIn.Interval = new TimeSpan(0, 0, 0, 0, 1);
            FadeOut.Interval = new TimeSpan(0, 0, 0, 0, 1);
            LoadData();
            List<Models.Advertisers> advertisers = App.context.Advertisers.ToList();
            foreach (var item in advertisers)
            {
                ComboBoxItem cba = new ComboBoxItem();
                TextBlock tb = new TextBlock();
                tb.Text = item.Title;
                cba.Content = tb;
                Filtration.Items.Add(cba);
            }
            List<Models.Kinds> kinds = App.context.Kinds.ToList();
            foreach (var item in kinds)
            {
                RadioButton rb = new RadioButton();
                TextBlock tb = new TextBlock();
                tb.Text = item.Title;
                rb.Content = tb;
                Kinds.Children.Add(rb);
                rb.Checked += Cb_Checked;
                rbs.Add(rb);
                kindtbs.Add(tb);
            }
            List<Models.Tags> tags= App.context.Tags.ToList();
            foreach (var item in tags)
            {
                RadioButton cb = new RadioButton();
                TextBlock tb = new TextBlock();
                tb.Text = item.Title;
                cb.Checked += Cb_Checked;
                cb.Content = tb;
                cbs.Add(cb);
                
            }
        }
        public void LoadData()
        {
            Projects.Children.Clear();
            List<Models.Projectkinds> ps = App.context.Projectkinds.ToList();
            if (AllKinds.IsChecked != true)
                for (int i = 0; i < kindtbs.Count; i++)
                {
                    if (rbs[i].IsChecked == true)
                        ps = ps.Where(p => p.KindNavigation.Title == kindtbs[i].Text).ToList();
                }
            else
                ps = App.context.Projectkinds.ToList();

            if (Search.Text.Length != 0)
                ps = ps.Where(p => p.ProjectNavigation.Title.Contains(Search.Text)).ToList();

            foreach (var item in ps)
            {
                Projects.Children.Add(new UserControls.Project(item));
            }
        }
        private void Cb_Checked(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
        private void Filtration_DropDownClosed(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
        }
        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (Grid1.Opacity < 1)
                Grid1.Opacity += 0.01;
            else
                FadeIn.Stop();
        }
        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if (Grid1.Opacity > 0)
                Grid1.Opacity -= 0.01;
            else
            {
                FadeOut.Stop();
                Classes.Navigation.auth.Main.Content = null;
            }
        }

    }
}
