using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace baitap1
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

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnMhc(object sender, EventArgs e)
        {
            Navigation.PushAsync(new manhinhchao());
        }

        private void BtnMhtt(object sender, EventArgs e)
        {
            Navigation.PushAsync(new manhinhtinhtong());
        }

        private void BtnMaytinh(object sender, EventArgs e)
        {
            Navigation.PushAsync(new calculator());
        }

        private void BtnLogin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new login());
        }
    }
}
