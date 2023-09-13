using MyAwesomeApp.ViewModels;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAwesomeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {

        public CoffeeEquipmentPage()
        {
            InitializeComponent();

            //BindingContext = new CoffeeEquipmentViewModel();
        }
    }
}