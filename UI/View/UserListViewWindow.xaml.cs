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
using UI.ViewModel;

namespace UI.View
{
    /// <summary>
    /// Interaction logic for UserListViewWindow.xaml
    /// </summary>
    public partial class UserListViewWindow : Window
    {
        /*public UserListViewWindow()
        {
            InitializeComponent();
            DataContext = new UserViewModel(); // Set DataContext to the ViewModel containing user data
            // Alternatively, you can pass the user data to the window constructor and bind to it directly
        }*/

        public UserListViewWindow(UserViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel; // Set DataContext to the same instance of UserViewModel
        }

    }
}
