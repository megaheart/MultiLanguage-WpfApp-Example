using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var c = new System.Globalization.CultureInfo("ja-JP");
            Thread.CurrentThread.CurrentUICulture = c;
            Thread.CurrentThread.CurrentCulture = c;
            InitializeComponent();
            //MessageBox.Show(Language.IetfLanguageTag);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Language.IetfLanguageTag != "en-us")
                Language = System.Windows.Markup.XmlLanguage.GetLanguage("en-us");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Language.IetfLanguageTag != "vi-vn")
                Language = System.Windows.Markup.XmlLanguage.GetLanguage("vi-VN");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Language.IetfLanguageTag != "ja-jp")
                Language = System.Windows.Markup.XmlLanguage.GetLanguage("ja-JP");
        }
    }
}
