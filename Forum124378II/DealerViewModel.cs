using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum124378II
{
    public class DealerViewModel : ViewModelBase
    {
        public ObservableCollection<Dealer> Dealers { get; set; }

        public string Message { get; set; }

        public DealerViewModel()
        {
            Dealers = new ObservableCollection<Dealer>();
            for (int i = 1; i < 11; i++)
            {
                Dealers.Add(new Dealer() { Name = $"Dealer { i }" });
            }

            Message = "Error messages in DealerViewModel!";
        }
    }
}
