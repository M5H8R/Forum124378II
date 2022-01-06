using System.Collections.ObjectModel;

namespace Forum124378II
{
    public class CustomerViewModel : ViewModelBase, IMessage
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public string Message { get; set; }

        public CustomerViewModel()
        {
            Customers = new ObservableCollection<Customer>();
            for (int i = 1; i < 11; i++)
            {
                Customers.Add(new Customer() { Name = $"Customer { i }" });
            }

            Message = "Error messages in CustomerViewModel!";
        }
    }
}
