/*Программа ищет в числах до n числа, который кратны 3 или 5
 * Затем находит сумму этих чисел
 * 
 */

using System;
using System.Collections.Generic;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;//Объявляем сумму
            var n = 1000;
            for (int i =0;i<n;++i)
            {
                //Проходим по всем числам до n...
                if(i%3==0 || i % 5 == 0)
                {
                    //Проверяем условие кратности
                    sum += i;//Суммируем 
                
                }
            }
            Console.WriteLine(sum);//Вывод
            Console.ReadKey();
        }
    }
}
