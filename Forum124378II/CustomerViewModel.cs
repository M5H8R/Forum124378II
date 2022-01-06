using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum124378II
{
    public class CustomerViewModel : ViewModelBase
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
