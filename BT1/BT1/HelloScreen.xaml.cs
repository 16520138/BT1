using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloScreen : ContentPage
    {
        public HelloScreen()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Lời chào", "Chào bạn " + txtHoTen.Text, "Thoát");
        }
    }
}