﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Test2;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ObservableCollection<string> strs = new ObservableCollection<string>() { "kk", "vb", "dadadad" };
    public MainWindow()
    {
        InitializeComponent();
        itemsLb.ItemsSource = strs;
    }

    private void addBtn_Click(object sender, RoutedEventArgs e)
    {
        strs.Add("bbbbbbbbbbbbbbbbb");
    }
}
