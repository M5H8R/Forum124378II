namespace Forum124378II
{
    public class ViewModelFactory
    {
        private readonly ViewModelBase customerViewModel;
        private readonly ViewModelBase dealerViewModel;

        public ViewModelFactory()
        {
            customerViewModel = new CustomerViewModel();
            dealerViewModel = new DealerViewModel();
        }

        public ViewModelBase Get(ViewModelTypes type)
        {
            switch (type)
            {
                case ViewModelTypes.Customers:
                    return customerViewModel;
                case ViewModelTypes.Dealers:
                    return dealerViewModel;
                default:
                    return null;
            }
        }
    }
}
