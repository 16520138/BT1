using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

  


        private void HelloScreen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HelloScreen());
        }

        private void SumScreen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SumScreen());
        }

        private void StackLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }

        private void AbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayout());
        }

        private void GridLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}
