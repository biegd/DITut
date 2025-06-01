using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    private readonly Action _execute;
    public event EventHandler CanExecuteChanged;
    public RelayCommand(Action Execute) => _execute = Execute;
    public bool CanExecute(object parameter) => true;
    public void Execute(object parameter) => _execute();
}
