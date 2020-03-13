using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Trade
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage // Обложка книги 
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            if (Preferences.ContainsKey("Str")) Nastrojki();// проверяет наличие сохранённого ключа 

            

           
            



        }

        private async void Nastrojki()// устанавливает глобальную переменную по сохранённому ключу и открыввает нужную страницу.
        {
            GlobalValue.Page = Preferences.Get("Str", 1);
            await Navigation.PushAsync(new Page_template(GlobalValue.Page));
        }

        private async void Oglavlenie_Clicked(object sender, EventArgs e)
        {
                  await Navigation.PushAsync(new Content());
        }
    }
}
