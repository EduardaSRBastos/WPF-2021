using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exercicio5
{
    /// <summary>
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        public Uri source
        {
            set
            {
                WebBrowser browser = new WebBrowser();
                browser.Source = value;
            }
            get
            {
                WebBrowser browser = new WebBrowser();
                return browser.Source;
            }

           
        }
        public Browser()
        {
            InitializeComponent();
        }
    }
}
