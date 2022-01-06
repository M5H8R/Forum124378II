using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum124378II
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase viewModelBase;

        public ViewModelBase CurrentViewModel
        {
            get { return viewModelBase; }
            set
            {
                if (viewModelBase != value)
                {
                    viewModelBase = value;
                    OnPropertyChanged();
                }
            }
        }

        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                if (errorMessage != value)
                {
                    errorMessage = value;
                    OnPropertyChanged();
                }
            }
        }


    }
}
