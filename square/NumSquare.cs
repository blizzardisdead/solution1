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
                uint ParameterN = uint.Parse(Console.ReadLine());
                ComplexFunctions apply = new ComplexFunctions();
                apply.UseNumber(ParameterN);
                apply.UseSquare(ParameterN);

            }
            catch
            {
                Console.WriteLine("Пожалуйста, введите положительный параметр!");
            }
            // Принимает от пользователя параметр N и использует библиотеку классов.
            
        }
    }

}
