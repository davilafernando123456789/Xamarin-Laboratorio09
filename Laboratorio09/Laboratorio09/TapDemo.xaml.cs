using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio09.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TapDemo : ContentPage
    {

        int tapCount;
        readonly Label label;
        public TapDemo()
        {
            InitializeComponent();
            var image = new Image
            {
                Source = "jhon.jpg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            var tapGestureReconizer = new TapGestureRecognizer();
            tapGestureReconizer.NumberOfTapsRequired = 2;
            tapGestureReconizer.Tapped += OnTapGestureReconizerTapped;
            image.GestureRecognizers.Add(tapGestureReconizer);

            label = new Label
            {
                Text = "tap the photo Davila!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Content = new StackLayout
            {
                Padding = new Thickness(20, 100),

                Children =
                {
                    image,
                    label
                }
            };

            void OnTapGestureReconizerTapped(object sender, EventArgs args)
            {
                tapCount++;
                label.Text = String.Format("{0} tap{1} so far1!",
                    tapCount,
                    tapCount == 1 ? "" : "s");

                var imageSender = (Image)sender;

                if (tapCount % 2 == 0) 
                {
                    imageSender.Source = "taped.jpg";

                }
                else
                {
                    imageSender.Source = "jhon.jpg";
                }
            }
        }
    }
}