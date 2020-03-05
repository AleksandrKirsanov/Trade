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
        public Page_template()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            //PictureHeight.Height = 300;

            ////-------------------------------------------------
            //TopLabel.TextColor = Color.Red ;
            //TopLabel.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button));
            //TopLabel.Text = "Его пример другим наука;\n" +
            // "Но, боже мой, какая скука\n" +
            // "С больным сидеть и день и ночь,\n" +
            // "Не отходя ни шагу прочь!\n";



            ////-------------------------------------------------
            //BottonLabel.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            //BottonLabel.Text =  "Его пример другим наука;\n" +
            // "Но, боже мой, какая скука\n" +
            // "С больным сидеть и день и ночь,\n" +
            // "Не отходя ни шагу прочь!\n";

            Str1 str1 = new Str1();
            foreach (var lab in str1.Lcontent)
            {
                 ContPage.Children.Add(lab);
            }
           
        }

       

       
        

    }
}