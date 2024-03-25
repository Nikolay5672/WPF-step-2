using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Command;
using UI.Model;

namespace UI.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private UserService userService;
        public UserViewModel()
        {
            userService = new UserService();
            LoadData();
            CurrentUser = new User();
            saveCommand = new RelayCommand(Save);
            searchCommand = new RelayCommand(Search);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);
        }

        private ObservableCollection<User> usersList;

        public ObservableCollection<User> UsersList
        {
            get { return usersList; }
            set { usersList = value; OnPropertyChanged("UsersList"); }
        }

        private void LoadData()
        {
            UsersList =new ObservableCollection<User>(userService.GetAll());
        }

        private User currentUser;

        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; OnPropertyChanged("CurrentUser");}
        }

        private string message;

        public string Message
        {
            get { return message;}
            set { message = value; OnPropertyChanged("Message"); }
        }

        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }

        public void Save()
        {
            try
            {
                var IsSaved = userService.Add(CurrentUser);
                LoadData();
                if (IsSaved)
                {
                    Message = "User saved!";
                    ClearTextBoxes();
                }
                else
                {
                    Message = "Save operation failed!";
                }
                    
            }
            catch (Exception e)
            {
                Message=e.Message;
            }
        }


        private RelayCommand searchCommand;

        public RelayCommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Search()
        {
            try
            {
                var User = userService.GetUser(CurrentUser.Id);
                if (User != null)
                {
                    CurrentUser.FirstName = User.FirstName;
                    CurrentUser.LastName = User.LastName;
                    CurrentUser.Role = User.Role;
                    CurrentUser.Id = User.Id;
                    Message = currentUser.FirstName + " " + currentUser.LastName + " " + currentUser.Role;
                    ClearTextBoxes();

                    ///////////////////
                }
                else
                {
                    Message = "User not found!";
                }
            }
            catch (Exception e)
            {
                
                throw;
            }

        }

        private RelayCommand updateCommand;

        public RelayCommand UpdateCommand
        {
            get { return updateCommand; }
        }

        public void Update()
        {
            try
            {
                var IsUpdated = userService.Update(CurrentUser);
                if (IsUpdated)
                {
                    Message = "User updated!";
                    LoadData();
                    ClearTextBoxes();
                }
                else
                {
                    Message = "Update operation failed!";
                }
            }
            catch (Exception e)
            {
                Message = e.Message;
                
            }
        }

        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void Delete()
        {
            try
            {
                var IsDeleted = userService.Delete(CurrentUser.Id);
                if (IsDeleted)
                {
                    Message = "User deleted!";
                    LoadData();
                    ClearTextBoxes();
                }
                else
                {
                    Message = "Delete operation failed!";
                }
            }
            catch (Exception e)
            {
                Message = e.Message;
                throw;
            }
        }

        private void ClearTextBoxes()
        {
            CurrentUser = new User(); // Create a new instance of User to clear the text boxes
        }


    }
}
