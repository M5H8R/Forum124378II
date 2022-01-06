using System;

namespace Forum124378II
{
    public class Navigator
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return currentViewModel;
            }
            set
            {
                currentViewModel = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}
