using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum124378II
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Navigator navigator;
        private ViewModelFactory viewModelFactory;
        private ViewModelTypes selectedViewType;
        private string errorMessage;

        public ViewModelBase CurrentViewModel
        {
            get { return navigator.CurrentViewModel; }
        }

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

        public IEnumerable<ViewModelTypes> ViewTypes
        {
            get
            {
                return Enum.GetValues(typeof(ViewModelTypes)).Cast<ViewModelTypes>();
            }
        }

        public ViewModelTypes SelectedViewType
        {
            get { return selectedViewType; }
            set
            {
                if (selectedViewType != value)
                {
                    selectedViewType = value;
                    OnPropertyChanged();
                    UpdateView();
                }
            }
        }

        public MainWindowViewModel()
        {
            navigator = new Navigator();
            viewModelFactory = new ViewModelFactory();

            navigator.StateChanged += ViewModelChanged;
            SelectedViewType = ViewModelTypes.Customers;
            navigator.CurrentViewModel = viewModelFactory.Get(SelectedViewType);
        }

        private void UpdateView()
        {
            navigator.CurrentViewModel = viewModelFactory.Get(SelectedViewType);
        }

        private void ViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
            if (CurrentViewModel is IMessage viewModelWithMessage)
            {
                ErrorMessage = viewModelWithMessage.Message;
            }
        }
    }
}
