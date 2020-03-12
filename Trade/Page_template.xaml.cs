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
    public partial class Page_template : ContentPage  // Шаблон для создания страницы с текстом. 
    {
       
        public Page_template(int page)
        {
            
            NavigationPage.SetHasNavigationBar(this, false);
           
            InitializeComponent();

            Str str1 = new Str(page);
            
            foreach (var lab in str1.Lcontent)
            {
                ContPage.Children.Add(lab);
            }

            PageName.Text = str1.NamePage;

        }

        private async void forward_Clicked(object sender, EventArgs e)
        {
            if (GlobalValue.Page < 255) { GlobalValue.Page++; Preferences.Set("Str", GlobalValue.Page); }



            await Navigation.PushAsync(new Page_template(GlobalValue.Page));
        }

        private async void back_Clicked(object sender, EventArgs e)
        {
            if (GlobalValue.Page > 0) { GlobalValue.Page--; Preferences.Set("Str",GlobalValue.Page); }



                await Navigation.PushAsync(new Page_template(GlobalValue.Page));
        }

        private async void Context_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Content());
        }
    }
}