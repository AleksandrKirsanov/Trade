using System.Collections.Generic;
using Xamarin.Forms;

namespace Trade
{
    public class Str1 
    {

      public  List<Xamarin.Forms.View> Lcontent = new List<Xamarin.Forms.View>();

        

        public Str1()
        {
           
            Label Label1 = new Label();

            Label1.Text = "Цель этого упражнения: понять свои особенности мышления, развить навыки обобщения, разобобщения и перехода по аналогиям./n Для начала, расскажу, что же такое это есть – «лингвистические пирамиды». Начнем с того, что оглянемся по сторонам.Первое, на что упал мой взгляд – кружка.Сама по себе кружка является просто кружкой, ничем больше. Однако кружку можно определить в более высокий класс – посуда.Таким образом, мы перешли на 1 класс наверх (обобщили кружку до посуды). С другой стороны, кружка бывает для кофе, чая, полулитровая, алюминиевая, фарфоровая (Разобобщили кружку на различные подвиды кружек)./n Это базовая модель лингвистических пирамид – все есть подвидом чего-то и состоит из чего-то.Кроме этого, в пределах одного класса есть аналогичные предметы..";
            Label1.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            Label1.TextColor = Color.Green;
            Lcontent.Add(Label1);
            //----------------------------------------------------------------------------


            Image image1 = new Image();
            image1.Aspect = Aspect.AspectFill;
            image1.Source = "moneta640.jpg";
            Lcontent.Add(image1);
            //---------------------------------------------------------------------------


            Label label2 = new Label();
            label2.Text = "Его пример другим наука;\n" +
             "Но, боже мой, какая скука\n" +
             "С больным сидеть и день и ночь,\n" +
             "Не отходя ни шагу прочь!\n";
            label2.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            label2.TextColor = Color.BlueViolet;
            label2.HorizontalTextAlignment = TextAlignment.Center;
            Lcontent.Add(label2);
            //-----------------------------------------------------------------------------


            Label label3 = new Label();
            label3.Text = "Его пример другим наука;\n" +
             "Но, боже мой, какая скука\n" +
             "С больным сидеть и день и ночь,\n" +
             "Не отходя ни шагу прочь!\n";
            label3.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            label3.TextColor = Color.BlueViolet;
            label3.HorizontalTextAlignment = TextAlignment.Center;
            Lcontent.Add(label3);
            //------------------------------------------------------------------------------------


            Image image2 = new Image();
            image2.Aspect = Aspect.AspectFill;
            image2.Source = "moneta640.jpg";
            Lcontent.Add(image2);

            Label Label4 = new Label();

            Label4.Text = "Цель этого упражнения: понять свои особенности мышления, развить навыки обобщения, разобобщения и перехода по аналогиям./n Для начала, расскажу, что же такое это есть – «лингвистические пирамиды». Начнем с того, что оглянемся по сторонам.Первое, на что упал мой взгляд – кружка.Сама по себе кружка является просто кружкой, ничем больше. Однако кружку можно определить в более высокий класс – посуда.Таким образом, мы перешли на 1 класс наверх (обобщили кружку до посуды). С другой стороны, кружка бывает для кофе, чая, полулитровая, алюминиевая, фарфоровая (Разобобщили кружку на различные подвиды кружек)./n Это базовая модель лингвистических пирамид – все есть подвидом чего-то и состоит из чего-то.Кроме этого, в пределах одного класса есть аналогичные предметы..";
            Label4.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            Label4.TextColor = Color.Green;
            Lcontent.Add(Label4);



        }
    }
}
