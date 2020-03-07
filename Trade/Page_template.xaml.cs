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
           
        }

       

       
        

    }
}