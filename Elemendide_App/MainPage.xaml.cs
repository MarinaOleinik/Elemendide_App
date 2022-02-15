using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Ent_btn = new Button
            {
                Text = "Entry",
                BackgroundColor = Color.Fuchsia
            };
            Button Timer_btn = new Button
            {
                Text = "Timer",
                BackgroundColor = Color.Fuchsia
            };
            Button Box_btn = new Button
            {
                Text = "BoxView",
                BackgroundColor = Color.Fuchsia
            };
            Button Date_btn = new Button
            {
                Text = "Date/Time",
                BackgroundColor = Color.Plum
            };
            Button SS_btn = new Button
            {
                Text = "Stepper/Slider",
                BackgroundColor = Color.Plum
            };
            Button Frame_btn = new Button
            {
                Text = "Frame/Grid",
                BackgroundColor = Color.Coral
            };
            Button Image_btn = new Button
            {
                Text = "Image",
                BackgroundColor = Color.Coral
            };
            StackLayout st = new StackLayout
            {
                Children = { Ent_btn, Timer_btn, Box_btn, Date_btn, SS_btn, Frame_btn, Image_btn }
            };
            st.BackgroundColor = Color.Aqua;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
            Date_btn.Clicked += Date_btn_Clicked;
            SS_btn.Clicked += SS_btn_Clicked;
            Frame_btn.Clicked += Frame_btn_Clicked;
            Image_btn.Clicked += Image_btn_Clicked;
        }

        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Picker_Page());
        }

        private async void Frame_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frame_Page());
        }

        private async void SS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_Page());
        }

        private async void Date_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DateTime_Page());
        }

        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_Page());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer_Page());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frame_Page());
        }
    }
}
