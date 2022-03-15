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

namespace WPF2
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

        private void btnAcrescentar_Click(object sender, RoutedEventArgs e)
        {
            if(txtNome.Text == "" && txtApelido.Text == "")
            {
                MessageBox.Show("Não inseriu texto!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                txtNomeCompleto.Text = txtNome.Text + " " + txtApelido.Text;
                combo.Items.Add(txtNomeCompleto.Text);
                lst.Items.Add(txtNomeCompleto.Text);
                tree.Items.Add(txtNomeCompleto.Text);
            }          
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtNomeCompleto.Text = "";
            txtNome.Text = "";
            txtApelido.Text = "";
            combo.Items.Clear();
            lst.Items.Clear();
            tree.Items.Clear();
        }
    }
}
