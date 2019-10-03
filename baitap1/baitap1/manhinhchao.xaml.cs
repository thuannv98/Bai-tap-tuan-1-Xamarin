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
    public partial class manhinhchao : ContentPage
    {
        public manhinhchao()
        {
            InitializeComponent();
        }

        private void cmdhello_clicked(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            DisplayAlert("Chào", "Chào bạn:" + hoten, "Thoát");
        }
    }
}