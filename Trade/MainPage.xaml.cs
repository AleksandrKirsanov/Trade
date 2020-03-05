using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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





        }

        private async void Oglavlenie_Clicked(object sender, EventArgs e)
        {
                  await Navigation.PushAsync(new Content());
        }
    }
}
