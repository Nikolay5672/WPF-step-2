using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Commands;

namespace Test1.Data;
internal class NamesList : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    AddCommand _addCommand = new AddCommand();
    RemoveCommand _removeCommand = new RemoveCommand();

    public ObservableCollection<string> Names { get; set; } = new ObservableCollection<string>();
    private string _firstName = "";
    private string _lastName = "";
    private string _selectedName = "";

    public AddCommand AddCommand { get => this._addCommand; set => this._addCommand = value; }
    public RemoveCommand RemoveCommand { get => this._removeCommand; set => this._removeCommand = value; }

    public string FirstName { get => this._firstName; set { this._firstName = value; OnPropertyChanged("FirstName"); } }
    public string LastName { get => this._lastName; set { this._lastName = value; OnPropertyChanged("LastName"); } }
    public string SelectedName { get => this._selectedName; set { this._selectedName = value; OnPropertyChanged("SelectedName"); } }


    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        RemoveCommand.RaiseCanExecuteChanged();
    }
}
