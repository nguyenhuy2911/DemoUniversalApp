using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoApp.Common
{
   public class DelegateCommand : ICommand
    {
        private SimpleEventHandler handler;
        private bool isEnable = true;
        public event EventHandler CanExecuteChanged;

        public delegate void SimpleEventHandler();
        public DelegateCommand(SimpleEventHandler handler)
        {
            this.handler = handler;
        }
        public bool IsEnabled
        {
            get
            {
                return isEnable;
            }
        }
        private void OnCanExcuteChanged()
        {
            if (this.CanExecuteChanged != null)
            {
                this.CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        public bool CanExecute(object parameter)
        {
          return  this.IsEnabled;
        }

        public void Execute(object parameter)
        {
            this.handler();
        }
    }
}
