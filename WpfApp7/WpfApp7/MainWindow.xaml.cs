﻿using System;
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

namespace WpfApp7
{
    public delegate void MethodWithAString(string text);
    public delegate void MethodWithoutArgs();
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private App app;
        public MainWindow()
        {
            InitializeComponent();
            app = App.Current as App;
            app.ModelLines.LineInserted += ModelLines_LineInserted;

        }
        private void ModelLines_LineInserted()
        {
            lbLines.Items.Add(app.ModelLines.Line);
        }
        private void btInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                app.ModelLines.Add(tbLine.Text);
            }
            catch (InvalidLineException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
