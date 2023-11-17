using Laboratorio09.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new TapDemo());
            };
            Item2.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new PanDemo());
            };
            Item3.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new SwipeDemo());
            };
            Item4.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new PinchDemo());
            };
        }
    }
}
