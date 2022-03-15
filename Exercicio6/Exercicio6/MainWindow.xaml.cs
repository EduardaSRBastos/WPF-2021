using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Exercicio6
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        { //savefileDialog (apenas .csv)
            //using (var sr = new StreamWriter("Dados.csv"))
            //{
            //    string linha = txtNum.Text + ";" + txtNome.Text + ";" + Data.SelectedDate.Value.ToShortDateString();
            //    sr.WriteLine(linha);
            //}

            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Ficheiros CSV (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == true)
            {
                using (var sr = new StreamWriter("Dados.csv"))
                {
                    string linha = txtNum.Text + ";" + txtNome.Text + ";" + Data.SelectedDate.Value.ToShortDateString();
                    sr.WriteLine(linha);
                }
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        { //openfiledialog
            //if(File.Exists("Dados.csv"))
            //{
            //    using (var sr = new StreamReader("Dados.csv"))
            //    {
            //        string linha = sr.ReadLine();
            //        if (linha != null)
            //        {
            //            string[] partes = linha.Split(';');
            //            txtNum.Text = partes[0];
            //            txtNome.Text = partes[1];
            //            Data.SelectedDate = DateTime.Parse(partes[2]);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("O ficheiro não existe", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Procurar Ficheiros CSV",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "Ficheiros CSV (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == true)
            {
                using (var sr = new StreamReader("Dados.csv"))
                {
                    string linha = sr.ReadLine();
                    if (linha != null)
                    {
                        string[] partes = linha.Split(';');
                        txtNum.Text = partes[0];
                        txtNome.Text = partes[1];
                        Data.SelectedDate = DateTime.Parse(partes[2]);
                    }
                }
            }

        }
    }
}
