﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TestBindings
{
    public class Data : INotifyPropertyChanged
    {
        string _name;
        public string Name { get { return _name; }
            set { _name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Data data { get; set; }

        public MainWindow()
        {
            this.data = new Data { Name = "John Snow" };
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.data.Name = "John Snow";
        }
    }
}
