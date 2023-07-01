using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Materials.xaml
    /// </summary>
    public partial class Materials : UserControl
    {
        Models.Materials material;
        public Materials(Models.Materials material)
        {
            InitializeComponent();
            this.material = material;
            BitmapImage bi = new BitmapImage();
            MemoryStream ms = new MemoryStream(material.Logo);
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.EndInit();
            Img.Source = bi;
            SomeText.Text = material.SomeText;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(SomeText.Text);
            MessageBox.Show("Текст материала скопирован в буфер обмена!");
        }

        private void Img_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            MemoryStream ms = new MemoryStream(material.Logo);
            bi.BeginInit();
            bi.StreamSource = ms;
            bi.EndInit();
            Clipboard.SetImage(bi);
            MessageBox.Show("Изображение материала скопировано в буфер обмена!");
        }
    }
}
