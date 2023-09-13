using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyAwesomeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase 
    {
        int count = 0;
        string countDisplay = "Click Me!";

        public ICommand IncreaseCount { get; }
        public ICommand CallServerCommand { get; }

        public ObservableRangeCollection<string> Coffee;

        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }

        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer);
            Coffee = new ObservableRangeCollection<string>();
        }

        public async Task CallServer()
        {
            var items = new List<string> { "Yes plz", "Tonx", "Blue Bottle" };
            Coffee.AddRange(items);
        }

        public void OnIncrease()
        {
            CountDisplay = $"You clicked {++count} time(s)";
        }
    }
}
