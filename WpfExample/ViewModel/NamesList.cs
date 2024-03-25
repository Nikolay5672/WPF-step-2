using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExample.Commands;

namespace WpfExample.ViewModel
{
    public class NamesList : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public AddCommand AddCommand { get; set; } = new AddCommand();
        public RemoveCommand RemoveCommand { get; set; } = new RemoveCommand();

        string _firstName = "";
        string _lastName = "";
        string _selectedName;
        public ObservableCollection<string> Names { get; private set; }

        public NamesList()
        {
            Names = new ObservableCollection<string>();
        }
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
            RemoveCommand.RaiseExecuteChanged();
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }
        public string SelectedName
        {
            get { return _selectedName; }
            set
            {
                if (_selectedName != value)
                {
                    _selectedName = value;
                    OnPropertyChanged("SelectedName");
                }
            }
        }
    
    }
}
