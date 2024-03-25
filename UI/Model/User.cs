using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Model
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void onPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; onPropertyChanged("Id"); }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; onPropertyChanged("FirstName");}
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; onPropertyChanged("LastName");}
        }

        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; onPropertyChanged("Role");}
        }


    }
}
