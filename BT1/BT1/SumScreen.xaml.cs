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
    public partial class SumScreen : ContentPage
    {
        public SumScreen()
        {
            InitializeComponent();
        }
        private void CalSum(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            txtTong.Text = (a + b).ToString();
        }

        private void ReturnHomepage(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}