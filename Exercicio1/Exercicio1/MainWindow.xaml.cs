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

namespace Exercicio1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool informacaoOk = true;
            int inicioHora = 0, duracao = 0, inicioMinuto = 0;

           if(String.IsNullOrEmpty(txtBDesignacao.Text))
            {
                informacaoOk = false;
                txtBDesignacao.Background = Brushes.Pink;
            }
           else
            {
                txtBDesignacao.Background = Brushes.White;
            }

           if(dataEvento.SelectedDate.HasValue && dataEvento.SelectedDate.Value.Date >= DateTime.Now.Date)
            {
                dataEvento.Background = Brushes.White;
            }
            else
            {
                informacaoOk = false;
                dataEvento.Background = Brushes.Pink;               
            }

           if(String.IsNullOrEmpty(txtBHora.Text) && Int32.TryParse(txtBHora.Text, out inicioHora))
            {
                txtBHora.Background = Brushes.White;
            }
            else
            {
                informacaoOk = false;
                txtBHora.Background = Brushes.Pink;
            }

            if (String.IsNullOrEmpty(txtBMinuto.Text) && Int32.TryParse(txtBMinuto.Text, out inicioMinuto))
            {
                txtBMinuto.Background = Brushes.White;
            }
            else
            {
                informacaoOk = false;
                txtBMinuto.Background = Brushes.Pink;
            }

            if (String.IsNullOrEmpty(txtBDuracao.Text) && Int32.TryParse(txtBDuracao.Text, out duracao))
            {
                txtBDuracao.Background = Brushes.White;
            }
            else
            {
                informacaoOk = false;
                txtBDuracao.Background = Brushes.Pink;
            }

            if (informacaoOk == false)
            {
                MessageBox.Show("Campos mal preenchidos.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string mensagem = "Foi inserido o seguinte evento: ";
                mensagem += "\n\"" + txtBDesignacao.Text + "\"";
                mensagem += "\na" + dataEvento.SelectedDate.Value.ToShortDateString();
                mensagem += "\ncom inicio a " + inicioHora + ":" + inicioMinuto;

                inicioHora += duracao / 60;
                inicioMinuto += duracao % 60;
                inicioHora += inicioMinuto / 60;
                inicioMinuto += inicioMinuto % 60;

                mensagem += "\ncom término às " + inicioHora + ":" + inicioMinuto;

                MessageBox.Show(mensagem, "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
