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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Adicionar_Click(object sender, RoutedEventArgs e)
        {
            WindowFiguras wfiguras = new WindowFiguras();
            if(wfiguras.ShowDialog() == true)
            {
                lstDescricao.Items.Add(wfiguras.figuraEscolhida);
                canvasRepresentacao.Children.Clear();
                switch(wfiguras.figuraEscolhida)
                {
                    case "Quadrado":
                        Rectangle r1 = new Rectangle();
                        r1.Width = 100;
                        r1.Height = 100;
                        r1.Stroke = Brushes.Red;
                        r1.StrokeThickness = 1;
                        canvasRepresentacao.Children.Add(r1);
                        break;
                    case "Retângulo":
                        Rectangle r2 = new Rectangle();
                        r2.Width = 200;
                        r2.Height = 100;
                        r2.Stroke = Brushes.Green;
                        r2.StrokeThickness = 1;
                        canvasRepresentacao.Children.Add(r2);
                        break;
                    case "Círculo":
                        Ellipse el = new Ellipse();
                        el.Width = 100;
                        el.Height = 100;
                        el.Stroke = Brushes.Blue;
                        el.StrokeThickness = 1;
                        canvasRepresentacao.Children.Add(el);
                        break;
                }
            }
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
