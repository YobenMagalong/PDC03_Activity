using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity1());
        }

        private async void CodeInteractions(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }

        private async void DataBindings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }

        private async void DataBindingMode(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity4());
        }
    }
}
