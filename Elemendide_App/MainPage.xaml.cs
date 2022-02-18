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
        Button Ent_btn, Picker_btn;
        public MainPage()
        {
            Ent_btn = new Button
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
            Picker_btn = new Button
            {
                Text = "Picker",
                BackgroundColor = Color.Aqua
            };
            StackLayout st = new StackLayout
            {
                Children = { Ent_btn, Timer_btn, Box_btn, Date_btn, SS_btn, Frame_btn, Image_btn, Picker_btn }
            };
            st.BackgroundColor = Color.Aqua;
            Content = st;
            Ent_btn.Clicked += Start_Pages;
            //Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
            Date_btn.Clicked += Date_btn_Clicked;
            SS_btn.Clicked += SS_btn_Clicked;
            Frame_btn.Clicked += Frame_btn_Clicked;
            Image_btn.Clicked += Image_btn_Clicked;
            Picker_btn.Clicked += Start_Pages;
            SwipeGestureRecognizer swipe = new SwipeGestureRecognizer();
            swipe.Swiped += Swipe_Swiped;
            swipe.Direction = SwipeDirection.Left;
            st.GestureRecognizers.Add(swipe);
        }

        private async void Swipe_Swiped(object sender, SwipedEventArgs e)
        {
            await Navigation.PushAsync(new TTT_Page());
        }

        private async void Start_Pages(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (sender==Ent_btn)
            {
                await Navigation.PushAsync(new Entry_Page());
            }
            else if (sender==Picker_btn)
            {
                await Navigation.PushAsync(new Picker_Page());
            }
        }

        private async void Picker_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Picker_Page());
        }

        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_Page());
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
