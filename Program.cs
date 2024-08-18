using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args) 
        {
            int num1 = 0;
            int num2 = 1;
            int a;
            Console.WriteLine(0);
            for (int i = 0; i < 10; i++)
            {
                a = num1;
                num1 = num1 + num2;
                num2 = a;
                
                Console.WriteLine(num1);
                
            }

        }

    }
}