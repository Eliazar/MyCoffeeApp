using System.Windows.Input;
using Xamarin.Forms;

namespace MyAwesomeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject
    {
        int count = 0;
        string countDisplay = "Click Me!";

        public ICommand IncreaseCount { get; }

        public string CountDisplay
        {
            get { return countDisplay; }

            set
            {
                if (value == countDisplay) return;

                countDisplay = value;
                OnPropertyChanged();
            }
        }

        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }

        public void OnIncrease()
        {
            CountDisplay = $"You clicked {++count} time(s)";
        }
    }
}
