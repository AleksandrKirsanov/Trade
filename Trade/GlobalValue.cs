using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trade
{
    public static class GlobalValue // Статический класс для хранения  глобальных переменных
    {
      public  static double MyFontSizeLabel =  Device.GetNamedSize(NamedSize.Medium, typeof(Label)); // устанавливает величину шрифта текста для Label
    }
}
