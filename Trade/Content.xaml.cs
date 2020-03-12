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
    public partial class Content : ContentPage // страница оглавления книги
    {
        public Content()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            //Style buttonStyle = new Style(typeof(Button))
            //{
            //    Setters =
            //{
            //    new Setter
            //    {
            //        Property = Button.TextColorProperty,
            //        Value = Color.FromRgb(0, 77, 64)
            //    },
            //    new Setter
            //    {
            //        Property = Button.BackgroundColorProperty,
            //        Value = Color.Red
            //    },
            //    new Setter
            //    {
            //        Property = Button.FontSizeProperty,
            //        Value = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            //    }

                
            //}
                
            //};


            //Page2.Style = buttonStyle;


        }

        private async void Page2_Clicked(object sender, EventArgs e)
        {
            GlobalValue.Page = 1;
            await Navigation.PushAsync(new Page_template(GlobalValue.Page)); ;
        }
    }
}