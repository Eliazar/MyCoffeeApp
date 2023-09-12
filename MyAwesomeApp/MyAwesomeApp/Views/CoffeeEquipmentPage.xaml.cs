using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAwesomeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {

        int count = 0;

        public CoffeeEquipmentPage()
        {
            InitializeComponent();

            LabelCount.Text = "Hello from code behind";
        }

        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            LabelCount.Text = $"You clicked {++count} times";
        }
    }
}