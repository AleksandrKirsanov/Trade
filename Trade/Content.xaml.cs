using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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







        }

        private async void Page1_Clicked(object sender, EventArgs e)// Переход на первую страницу
        {
            GlobalValue.Page = 1;
            await Navigation.PushAsync(new Page_template(GlobalValue.Page)); ;
        }
    }
}