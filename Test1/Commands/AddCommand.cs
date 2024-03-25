using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test1.Data;

namespace Test1.Commands;
public class AddCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter == null) return;
        NamesList namesList = (NamesList)parameter;
        string newName = $"{namesList.FirstName}{namesList.LastName}";
        namesList.Names.Add(newName);

        namesList.FirstName = "";
        namesList.LastName = "";
    }
}
