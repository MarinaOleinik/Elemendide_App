using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendide_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Picker_Page : ContentPage
    {
        Picker picker;
        WebView webView;
        StackLayout st;
        Frame frame;
        ImageButton home, back;
        string[] lehed = new string[4] { "https://tahvel.edu.ee", "https://moodle.edu.ee", "https://www.tthk.ee/", "https://www.google.com/" };
        public Picker_Page()
        {
            picker = new Picker
            {
                Title = "Webilehed"
            };
            picker.Items.Add("Tahvel");
            picker.Items.Add("Moodle");
            picker.Items.Add("TTHK");
            //picker.Items.Add("GOOGLE");
            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
            webView = new WebView {  };
            SwipeGestureRecognizer swipe = new SwipeGestureRecognizer();
            swipe.Swiped += Swipe_Swiped;
            swipe.Direction = SwipeDirection.Right;
            
            home = new ImageButton
            {
                Source = "button_home.png",
            };
            back = new ImageButton
            {
                Source = "back.jpg",
            };
            StackLayout buttons = new StackLayout 
            { 
                Children = { home,back},
                Orientation=StackOrientation.Horizontal
            };
            
            frame = new Frame
            {
                Content =buttons,
                BorderColor = Color.AliceBlue,
                CornerRadius = 20,
                HeightRequest = 40, WidthRequest=400,
                VerticalOptions=LayoutOptions.Start,
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                HasShadow=true
            };
            st = new StackLayout { Children = { picker , frame} };
            frame.GestureRecognizers.Add(swipe);//?
            Content = st;
        }
        private void Swipe_Swiped(object sender, SwipedEventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = lehed[3] };
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (webView!=null)
            {
                st.Children.Remove(webView);
            }
            webView = new WebView
            {
                Source = new UrlWebViewSource { Url = lehed[picker.SelectedIndex] },
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            st.Children.Add(webView);
        }

    }
}