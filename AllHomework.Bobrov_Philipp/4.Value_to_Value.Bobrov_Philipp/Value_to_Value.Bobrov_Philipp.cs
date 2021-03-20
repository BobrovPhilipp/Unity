using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_to_Value.Bobrov_Philipp
    // Написать программу обмена значениями двух переменных:
    //а) с использованием третьей переменной;
    //б) * без использования третьей переменной.

{
    class Program
    {

        static void Main(string[] args)
        {
            //ОБМЕН ЗНАЧЕНИЙ (С третьей переменной и с выводом на экран)
            #region
            Console.WriteLine("ОБМЕН ЗНАЧЕНИЙ (С третьей переменной): ");
            int m = 150;
            int n = 60;
            mnText(m, n);

            int r = m;
            m = n;     
            n = r;     

            mnText(m, n);
            #endregion

            //ОБМЕН ЗНАЧЕНИЙ (БЕЗ третьей переменной и с выводом на экран)
            #region
            Console.WriteLine("ОБМЕН ЗНАЧЕНИЙ (БЕЗ третьей переменной): ");
            int g = 111;
            int h = 222;
            hgText(g, h);

            g += h; 
            h = g - h; 
            g -= h; 

            hgText(g, h);
            #endregion
        }
        //МЕТОДЫ И ФУНКЦИИ(опциональные).
        #region
        private static void mnText(int m, int n) //Вспомогательная функция для вывода значений "m" и "n" в консоль.
        {
            string m2Text = Convert.ToString(m);
            string n2Text = Convert.ToString(n);
            Console.WriteLine("m = " + m2Text + " " + "n = " + n2Text);
        }
        private static void hgText(int g, int h) //Вспомогательная функция для вывода значений "g" и "h" в консоль.
        {
            Convert.ToString(g);
            Convert.ToString(h);
            Console.WriteLine("g = " + g + " " + "h = " + h);
        }
        #endregion
    }
}
