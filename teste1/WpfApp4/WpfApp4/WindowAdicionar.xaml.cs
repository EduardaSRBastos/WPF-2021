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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for WindowAdicionar.xaml
    /// </summary>
    public partial class WindowAdicionar : Window
    {
        public Figura FiguraAdicionada { get; private set; }
        public WindowAdicionar()
        {
            InitializeComponent();

            FiguraAdicionada = new Figura();
        }

        private void btAdicionar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

            FiguraAdicionada.Largura = tbLargura.Text;
            FiguraAdicionada.Altura = tbAltura.Text;

            if (rbQuadrado.IsChecked == true)
                //fig.Nome = "Quadrado";
                FiguraAdicionada.Nome = "Quadrado";
            else if (rbRetangulo.IsChecked == true)
                //fig.Nome = "Retangulo";
                FiguraAdicionada.Nome = "Retangulo";
            else
                //fig.Nome = "Circulo";
                FiguraAdicionada.Nome = "Circulo";
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
