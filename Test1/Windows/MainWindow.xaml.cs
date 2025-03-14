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
using Test1.Commands;

namespace Test1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public static ObservableCollection<string> Strs = new ObservableCollection<string>() { "1", "2" };
    private InfoCommand _infoCommand = new InfoCommand();
    public InfoCommand InformationCommand
    {
        get { return _infoCommand; }
        set { _infoCommand = value; }
    }
    public MainWindow()
    {
        InitializeComponent();
        Setup();
        this.DataContext = this;
    }

    private void Setup()
    {
        itemsLb.ItemsSource = Strs;
    }

}
