﻿using System.Collections.Generic;
using Xamarin.Forms;
using System.Xml;

namespace Trade
{
    public class Str1 
    {

      public  List<Xamarin.Forms.View> Lcontent = new List<Xamarin.Forms.View>();

        

        public Str1()
        {

            //Label Label1 = new Label
            //{
            //    Text = "Цель этого упражнения: понять свои особенности мышления, развить навыки обобщения, разобобщения и перехода по аналогиям./n Для начала, расскажу, что же такое это есть – «лингвистические пирамиды». Начнем с того, что оглянемся по сторонам.Первое, на что упал мой взгляд – кружка.Сама по себе кружка является просто кружкой, ничем больше. Однако кружку можно определить в более высокий класс – посуда.Таким образом, мы перешли на 1 класс наверх (обобщили кружку до посуды). С другой стороны, кружка бывает для кофе, чая, полулитровая, алюминиевая, фарфоровая (Разобобщили кружку на различные подвиды кружек)./n Это базовая модель лингвистических пирамид – все есть подвидом чего-то и состоит из чего-то.Кроме этого, в пределах одного класса есть аналогичные предметы..",
            //    FontSize = GlobalValue.MyFontSizeLabel,
            //    TextColor = Color.Green
            //};
            //Lcontent.Add(Label1);
            ////----------------------------------------------------------------------------


            //Image image1 = new Image
            //{
            //    Aspect = Aspect.AspectFill,
            //    Source = "moneta640.jpg"
            //};
            //Lcontent.Add(image1);
            ////---------------------------------------------------------------------------


            //Label label2 = new Label
            //{
            //    Text = "Его пример другим наука;\n" +
            // "Но, боже мой, какая скука\n" +
            // "С больным сидеть и день и ночь,\n" +
            // "Не отходя ни шагу прочь!\n",
            //    FontSize = GlobalValue.MyFontSizeLabel,
            //    TextColor = Color.BlueViolet,
            //    HorizontalTextAlignment = TextAlignment.Center
            //};
            //Lcontent.Add(label2);
            ////-----------------------------------------------------------------------------


            //Label label3 = new Label
            //{
            //    Text = "Его пример другим наука;\n" +
            // "Но, боже мой, какая скука\n" +
            // "С больным сидеть и день и ночь,\n" +
            // "Не отходя ни шагу прочь!\n",
            //    FontSize = GlobalValue.MyFontSizeLabel,
            //    TextColor = Color.BlueViolet,
            //    HorizontalTextAlignment = TextAlignment.Center
            //};
            //Lcontent.Add(label3);
            ////------------------------------------------------------------------------------------


            //Image image2 = new Image
            //{
            //    Aspect = Aspect.AspectFill,
            //    Source = "moneta640.jpg"
            //};
            //Lcontent.Add(image2);

            //Label Label4 = new Label
            //{
            //    Text = "Цель этого упражнения: понять свои особенности мышления, развить навыки обобщения, разобобщения и перехода по аналогиям./n Для начала, расскажу, что же такое это есть – «лингвистические пирамиды». Начнем с того, что оглянемся по сторонам.Первое, на что упал мой взгляд – кружка.Сама по себе кружка является просто кружкой, ничем больше. Однако кружку можно определить в более высокий класс – посуда.Таким образом, мы перешли на 1 класс наверх (обобщили кружку до посуды). С другой стороны, кружка бывает для кофе, чая, полулитровая, алюминиевая, фарфоровая (Разобобщили кружку на различные подвиды кружек)./n Это базовая модель лингвистических пирамид – все есть подвидом чего-то и состоит из чего-то.Кроме этого, в пределах одного класса есть аналогичные предметы..",
            //    FontSize = GlobalValue.MyFontSizeLabel,
            //    TextColor = Color.Green
            //};
            //Lcontent.Add(Label4);


            XmlDocument PageXML = new XmlDocument();
            PageXML.Load("C:/Users/2013g/source/repos/Trade/Trade/Pages/XMLFile1.xml");
            XmlElement xml = PageXML.DocumentElement;
            foreach (XmlNode item in xml)
            {
                if (item.Attributes.Count>0)
                {
                    XmlNode attr = item.Attributes.GetNamedItem("name");
                    if (attr!=null)
                    {

                    }
                }
            }


        }
    }
}
