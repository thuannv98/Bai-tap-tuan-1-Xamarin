using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baitap1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void bt_login(object sender, EventArgs e)
        {
            DisplayAlert("Chào mừng!", "Chào bạn "+txtusername.Text, "Thoát");
        }
    }
}