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
            FontSizeLabel.FontSize = GlobalValue.MyFontSizeLabel;

        }

        private async void Setter_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void FontPlus_Clicked(object sender, EventArgs e)
        {
            if (GlobalValue.MyFontSizeLabel < 30)
            {
                GlobalValue.MyFontSizeLabel++;
                FontSizeLabel.FontSize = GlobalValue.MyFontSizeLabel;
            }
        }

        private void FontMinus_Clicked(object sender, EventArgs e)
        {
            if (GlobalValue.MyFontSizeLabel > 10)
            {
                GlobalValue.MyFontSizeLabel--;
                FontSizeLabel.FontSize = GlobalValue.MyFontSizeLabel;
            }
        }
    }
}