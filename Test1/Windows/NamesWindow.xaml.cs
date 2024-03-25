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
using System.Windows.Shapes;
using Test1.Data;

namespace Test1.Windows;
/// <summary>
/// Interaction logic for NamesWindow.xaml
/// </summary>
public partial class NamesWindow : Window
{
    public NamesWindow()
    {
        InitializeComponent();
        this.DataContext = new NamesList();
    }
}
