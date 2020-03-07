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
        int PageContent = 0;
        public Page_template(int page)
        {
            
            NavigationPage.SetHasNavigationBar(this, false);
            PageContent = page;
            InitializeComponent();

            Str str1 = new Str(page);
            
            foreach (var lab in str1.Lcontent)
            {
                ContPage.Children.Add(lab);
            }
            
           

        }

        private void IncreaseFont_Clicked(object sender, EventArgs e)
        {
            int ddd = ContPage.Children.Count;
            
            foreach (View item in ContPage.Children)
            {
              Type type =  item.GetType();
                if (type == typeof(Label))
                {
                   
                }
            }


            IncreaseFont.Text = "uuuuuu";
            Titl.FontSize = 40;





        }
        private void ReduceFont_Clicked(object sender, EventArgs e)
        {
            //if (GlobalValue.MyFontSizeLabel >5)
            //{
            //    GlobalValue.MyFontSizeLabel--;
            //    GlobalValue.MyFontSizeTitle--;
            //}

            //Str str1 = new Str(PageContent);
            //foreach (var lab in str1.Lcontent)
            //{
            //    ContPage.Children.Add(lab);
            //}


        }



    }
}