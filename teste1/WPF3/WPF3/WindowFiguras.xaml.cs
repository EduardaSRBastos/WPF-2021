using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF3
{
    /// <summary>
    /// Interaction logic for WindowFiguras.xaml
    /// </summary>
    public partial class WindowFiguras : Window
    {
        public WindowFiguras()
        {
            InitializeComponent();
        }

        public string figuraEscolhida
        {
            get;

            private set;
        }
        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            figuraEscolhida = cbFigura.Text;
            this.DialogResult = true;
        }
    }
}
