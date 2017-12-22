using DemoApp.Common;
using GalaSoft.MvvmLight;
using System.Windows.Input;

namespace DemoApp.ViewModels
{
    public class StartPageViewModel : ViewModelBase
    {
        private bool _isLoading = false;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                RaisePropertyChanged("IsLoading");
            }
        }

        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    RaisePropertyChanged("Title");
                }
            }
        }

        public StartPageViewModel()
        {
            Title = "Hello World";
        }

        public ICommand Changelabel
        {
            get
            {
                return new DelegateCommand(Change);
            }
        }

        public void Change()
        {

            Title = "Well come to Demo App";
     
        }

    }
}