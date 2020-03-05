using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Classses
{
    class LabelContent // класс определяет содержание и атрибуты отдельного элемента label
    {
        string content { set; get; }// текст 
        string fontSize { set; get; }//величина шрифта
        string fontColor { set; get; }// цвет шрифта
        string fontAttributes { set; get; }// атрибут текста
        string horizontalTextAlignment { set; get; }// расположение текста  на странице
        string heightRequest { get; set; }// высота Label
        string bacgroundColor { set; get; }//цвет подложки
    }
}
