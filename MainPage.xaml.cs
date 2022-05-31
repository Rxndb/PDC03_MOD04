using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Activity1Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity1());
        }
        private async void Activity2Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }
        private async void Activity3Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }
    }
}
