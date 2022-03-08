using System;
using Library;

namespace NumberSquare
{
    class ProgramConsole
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите положительный параметр N");
            try
            {
                uint n = uint.Parse(Console.ReadLine());
                ComplexFunctions function = new ComplexFunctions();
                Console.WriteLine(function.UseNumber(n));
                function.UseSquare(n);

            }
            catch
            {
                Console.WriteLine("Пожалуйста, введите положительный параметр!");
            }
            // Принимает от пользователя параметр N и использует библиотеку классов.
            
        }
    }

}
