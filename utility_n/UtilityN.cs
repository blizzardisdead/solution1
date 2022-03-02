using System;
using ClassLib;


namespace Utility
{
    class UtilityN
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите положительный параметр N");
            
            try
            {
                uint n = uint.Parse(Console.ReadLine());
                refund apply = new refund();
                apply.Number(n);

            }
            catch
            {
                Console.WriteLine("Пожалуйста, введите верный параметр!");
            }
 
            
            
        }
    }
}
