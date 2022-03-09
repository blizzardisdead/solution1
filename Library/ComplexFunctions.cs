using System;


namespace Library
{/// <summary>
/// Класс содержит два метода построения чисел и преобразование последовательности чисел.
/// </summary>
    public class ComplexFunctions
    {
        /// <summary>
        /// Данный метод выводит последовательность положительных чисел от 1 до параметра N.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string UseNumber(uint n)
        {
            string number = "";
            var i = 1;
            
            if (n == 0)
            {
                throw new Exception("Введенное значение должно быть больше 0");
            }

            while(i < n)
            {
                number += ((i++) + ", ");
            }
            number +=n;
            return number;
           
        }
     /// <summary>
     /// Данный метод рисует квадрат со стороной N и пустым значением внутри.
     /// </summary>
     /// <param name="n"></param>

         public string UseSquare(uint n)
         {
            string square = "";
            var mid = n / 2;

            if (n % 2 == 0)
            {
                throw new Exception("Введите нечётное число");
            }

            for (var i = 0; i <n ; i++)
            {
                for (var j = 0; j < n; j++)
                {

                    if (j == mid && i == mid)
                    {
                        square+=" ";
                    }
                    else
                    {
                        square+="*";
                    }

                }
                 square+='\n';
                
            }
            return square;
        }

    }

}
