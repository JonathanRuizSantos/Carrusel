using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFnavegacionCarruselx1
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btgato(object sender, EventArgs e)
        {
            await DisplayAlert("Aml\n Gato\n Carrusel", "ASIME\n ICE", "OK");
        }

        private async void btgallo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAml());
        }

        private async void btganso(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageArMaLe());
        }

        private async void btalas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAlas());
        }
    }
}
