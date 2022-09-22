using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna_xamarinforms
{
    public partial class MainPage : ContentPage
    {
        //Button button;
        //Grid grid = new Grid();
        public MainPage()
        {
            InitializeComponent();
            //le epickie tworzenie przycisku, ale w CSHARP YOOO
            /*button = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Kliknij mie"
            };
            button.Clicked += Button_Clicked;
            //dodanie do tablicy Children jest jak dodanie obiektu na layout aplikacji
            grid.Children.Add(button);
            Content = grid;*/
        }

        /*private void Button_Clicked(object sender, EventArgs e)
        {
            //okienko alertu: najpierw duża wiadomość, mała wiadomość, treść przycisku
            DisplayAlert("Udało się", "Wreszcie...", "OK");
        }*/

        /*private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //obiekt nie musi mieć nazwy, wystarczy że opisze się go tutaj słowem "sender"
            //double value = ((Slider)sender).Value;
            double value = e.NewValue;
            rotatingLabel.Rotation = value;
            sliderValue.Text = value.ToString();
        }*/
    }
}
