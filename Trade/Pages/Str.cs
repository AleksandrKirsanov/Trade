using System.Collections.Generic;
using Xamarin.Forms;




namespace Trade
{
    public class Str
    {



       public string NamePage { set; get; }

        public List<View> Lcontent = new List<View>();



        public Str(int pageNumber)
        {
           

            switch (pageNumber) // выбор метода который построит содержимое страницы
            {
                case 1: // построение содержимого страницы 1
                    str1();
                    break;
                case 2: // построение содержимого страницы 2
                    str1();
                    break;
                case 3: // построение содержимого страницы 3
                    str1(); 
                    break;
                default:
                    str1();
                    break;
            } 




        }

        void str0()// Номер страницы не определён
        {
            NamePage = "Нулевая страница";

            Label label = new Label
            {
                Text = "Номер страницы не определён",
                FontSize = GlobalValue.MyFontSizeTitle,
                TextColor = Color.Red,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Label Label1 = label;
            Lcontent.Add(Label1);
        }

      
        void str1() //Страница 1   
        {
            NamePage = "Первая страница"; // Название страницы, которое выводится вверху 

            Label Label1 = new Label
            {

                Text = "Цель этого упражнения: понять свои особенности мышления, развить навыки обобщения, разобобщения и перехода по аналогиям.\n\n"+" Для начала, расскажу, что же такое это есть – «лингвистические пирамиды». Начнем с того, что оглянемся по сторонам.Первое, на что упал мой взгляд – кружка.Сама по себе кружка является просто кружкой, ничем больше. Однако кружку можно определить в более высокий класс – посуда.Таким образом, мы перешли на 1 класс наверх (обобщили кружку до посуды). С другой стороны, кружка бывает для кофе, чая, полулитровая, алюминиевая, фарфоровая (Разобобщили кружку на различные подвиды кружек).\n"+" Это базовая модель лингвистических пирамид – все есть подвидом чего-то и состоит из чего-то.Кроме этого, в пределах одного класса есть аналогичные предметы..",
                 FontSize = GlobalValue.MyFontSizeLabel,
                TextColor = Color.Green,
                Padding = 10
                
                
            };
            Lcontent.Add(Label1);
            //----------------------------------------------------------------------------
            Grid myGrid = new Grid();
          
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            myGrid.Padding = 5;
            myGrid.Margin = 3;
            myGrid.BackgroundColor = Color.Aqua;
            
           

            Label label4 = new Label
            {
                Text = "Его пример другим наука;\n" +
             "Но, боже мой, какая скука\n" +
             "С больным сидеть и день и ночь,\n" +
             "Не отходя ни шагу прочь!\n",
                FontSize = GlobalValue.MyFontSizeLabel,
                TextColor = Color.Red,
                HorizontalTextAlignment = TextAlignment.Center
            };


            Label label5= new Label
            {
                Text = "Его пример другим наука;\n" +
             "Но, боже мой, какая скука\n" +
             "С больным сидеть и день и ночь,\n" +
             "Не отходя ни шагу прочь!\n",
                FontSize = GlobalValue.MyFontSizeLabel,
                TextColor = Color.Magenta,
                HorizontalTextAlignment = TextAlignment.Center
                
            };

            Grid.SetColumn(label4, 0);
            Grid.SetColumn(label5, 1);
            myGrid.ColumnDefinitions.Add(colDef1);
            myGrid.ColumnDefinitions.Add(colDef2);
            myGrid.Children.Add(label4);
            myGrid.Children.Add(label5);

            Lcontent.Add(myGrid);




            Image image1 = new Image
            {
                Aspect = Aspect.AspectFill,
                Source = "moneta640.jpg"
            };
            Lcontent.Add(image1);
            //---------------------------------------------------------------------------


            Label label2 = new Label
            {
                Text = "Его пример другим наука;\n" +
             "Но, боже мой, какая скука\n" +
             "С больным сидеть и день и ночь,\n" +
             "Не отходя ни шагу прочь!\n",
               FontSize = GlobalValue.MyFontSizeLabel,
                TextColor = Color.Magenta,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Lcontent.Add(label2);
            //-----------------------------------------------------------------------------


            Label label3 = new Label
            {
                Text = "Его пример другим наука;\n" +
             "Но, боже мой, какая скука\n" +
             "С больным сидеть и день и ночь,\n" +
             "Не отходя ни шагу прочь!\n",
                FontSize = GlobalValue.MyFontSizeLabel,
                TextColor = Color.BlueViolet,
                HorizontalTextAlignment = TextAlignment.Center,
            

            };
            Lcontent.Add(label3);
            //------------------------------------------------------------------------------------


            Image image2 = new Image
            {
                Aspect = Aspect.AspectFill,
                Source = "moneta640.jpg"
            };
            Lcontent.Add(image2);

            Label Label4 = new Label
            {
                Text = "Цель этого упражнения: понять свои особенности мышления, развить навыки обобщения, разобобщения и перехода по аналогиям.\n Для начала, расскажу, что же такое это есть – «лингвистические пирамиды». Начнем с того, что оглянемся по сторонам.Первое, на что упал мой взгляд – кружка.Сама по себе кружка является просто кружкой, ничем больше. Однако кружку можно определить в более высокий класс – посуда.Таким образом, мы перешли на 1 класс наверх (обобщили кружку до посуды). С другой стороны, кружка бывает для кофе, чая, полулитровая, алюминиевая, фарфоровая (Разобобщили кружку на различные подвиды кружек).\n Это базовая модель лингвистических пирамид – все есть подвидом чего-то и состоит из чего-то.Кроме этого, в пределах одного класса есть аналогичные предметы..",
               FontSize = GlobalValue.MyFontSizeLabel,
                TextColor = Color.Green,
                Padding = 20,
                FontAttributes = FontAttributes.Italic
            };
            Lcontent.Add(Label4);

        } 


    }
}

