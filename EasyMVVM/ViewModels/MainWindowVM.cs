using EasyMVVM.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace EasyMVVM.ViewModels;

public class MainWindowVM : DependencyObject, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private Model Model { get; set; }
    private ObservableCollection<string> _boundProperty;

    public MainWindowVM()
    {
        Model = new Model();
        BoundProperty = Model.GetData();
    }
    private void RaisePropertyChanged(string property)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
    public ObservableCollection<string> BoundProperty
    {
        get { return _boundProperty; }
        set { _boundProperty = value; RaisePropertyChanged("BoundProperty"); }
    }
}
