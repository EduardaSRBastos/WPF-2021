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

namespace wpfCalculadora
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

        private void mais_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = (Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text)).ToString();

        }

        private void menos_Copy_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = (Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text)).ToString();
        }

        private void vezes_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = (Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text)).ToString();
        }

        private void dividir_Click(object sender, RoutedEventArgs e)
        {
            if(num2.Text=="0")
            {
                MessageBox.Show("Não é possível dividir por 0.", "Erro Matemático", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                resultado.Text = (Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text)).ToString();
            }
        }
    }
}
