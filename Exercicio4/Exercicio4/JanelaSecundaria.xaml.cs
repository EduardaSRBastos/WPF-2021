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

namespace Exercicio4
{
    /// <summary>
    /// Interaction logic for JanelaSecundaria.xaml
    /// </summary>
    public partial class JanelaSecundaria : Window
    {
        public string texto
        {
            set
            {
                txtBoxTexto.Text = value;
            }
            get
            {
                return txtBoxTexto.Text;
            }
        }
        public JanelaSecundaria()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
