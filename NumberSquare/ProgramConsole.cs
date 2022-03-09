using System;
using Library;

namespace NumberSquare
{
    class ProgramConsole
    {/// <summary>
    /// Принимает от пользователя параметр N и использует библиотеку классов.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительный параметр N");
   
            try
            {
                uint n = uint.Parse(Console.ReadLine());
                ComplexFunctions function = new ComplexFunctions();
                Console.WriteLine(function.UseNumber(n));
                Console.WriteLine(function.UseSquare(n));


            }
            catch
            {
                Console.WriteLine("Введён не соответствующий параметр");
            }
            
        }
    }

}
