using System;

namespace Library
{
    public class ComplexFunctions
    {
        public void UseNumber(uint ParameterN)
        {

            for (var digit = 1; digit < ParameterN; digit++)
            {
                Console.Write(digit + ", ");
            }
            Console.Write(ParameterN + ".");
            Console.WriteLine();
        }
        // Данная функция возвращает число.

         public void UseSquare(uint ParameterN)
         { 

            if (ParameterN % 2 != 0)
            {
                var centre = ParameterN / 2;

                for (var digit = 0; digit < ParameterN; digit++)
                {

                    for (var figure = 0; figure < ParameterN; figure++)
                    {

                        if (figure == centre && digit == centre)
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
            // Выводит квадрат из звёздочек с пуcтым центром со стороной равной N.
        }

    }

}
