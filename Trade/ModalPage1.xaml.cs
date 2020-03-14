using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trade
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage1 : ContentPage
    {
        public ModalPage1()
        {
            InitializeComponent();
        }

        private async void Setter_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}