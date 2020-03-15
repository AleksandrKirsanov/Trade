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
    public static class GlobalValue // Статический класс для хранения  глобальных переменных и методов
    {
        public static double MyFontSizeLabel = Device.GetNamedSize(NamedSize.Small, typeof(Label)); // устанавливает величину шрифта текста для Label


        public static double MyFontSizeTitle = Device.GetNamedSize(NamedSize.Title, typeof(Label)); // устанавливает величину шрифта титульного текста для Label

       


        public static int Page = 1;// Страница, которая отрисована или будет отрисована


       
    }

}
