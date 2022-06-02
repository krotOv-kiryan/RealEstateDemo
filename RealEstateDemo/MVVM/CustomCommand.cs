using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RealEstateDemo.MVVM
{
    public class CustomCommand : ICommand //написано ручками
    {
        // события для команд
        public event EventHandler CanExecuteChanged;
        Action action;

        public CustomCommand(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
