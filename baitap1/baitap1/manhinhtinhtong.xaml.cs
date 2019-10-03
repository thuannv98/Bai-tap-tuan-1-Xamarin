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
    public partial class manhinhtinhtong : ContentPage
    {
        public manhinhtinhtong()
        {
            InitializeComponent();
        }

        private void cmdtong_clicked(object sender, EventArgs e)
        {
            Double a, b, tong;
            a = Double.Parse(txtsoa.Text);
            b = Double.Parse(txtsob.Text);
            tong = a + b;
            txttong.Text = tong.ToString();
        }
    }
}