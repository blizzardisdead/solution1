using System;


namespace Library
{
    public class ComplexFunctions
    {
        /// <summary>
        /// данный метод выводит числа от 1 до введеного параметра N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string UseNumber(uint n)
        {
            string number = "";
            var i = 1;
            while(i<n)
            {
                number += ((i++) + ",");
            }
            number += n;
            return number;
        }
     

         public void UseSquare(uint n)
         { 

            if (n % 2 != 0)
            {
                var centre = n / 2;

                for (var i = 0; i < n; i++)
                {

                    for (var j = 0; j < n; j++)
                    {

                        if (i == centre && j == centre)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write('\n');

                }  

            }
            else
            {
                Console.WriteLine("Для построения квадрата необходимо ввести нечётное число");

            }
           
        }

    }

}
