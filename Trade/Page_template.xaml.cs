using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trade  // Шаблон для создания страницы с текстом. 
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_template : ContentPage
    {
        public Page_template()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            PictureHeight.Height = 300;
        }

       

       
        

    }
}