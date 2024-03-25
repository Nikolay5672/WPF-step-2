using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test1.Data;

namespace Test1.Commands;
internal class RemoveCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public void RaiseCanExecuteChanged()
    {
        if (CanExecuteChanged != null)
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
    }

    public bool CanExecute(object? parameter)
    {
        if (parameter == null) return false;
        NamesList namesList = (NamesList)parameter;

        return namesList.Names.Count > 0;
    }

    public void Execute(object? parameter)
    {
        if (parameter == null) return;
        NamesList namesList = (NamesList)parameter;
        namesList.Names.Remove(namesList.SelectedName);
    }
}
