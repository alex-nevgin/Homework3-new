using System;

namespace primeNumberDefiner
{
    /// <summary>
    /// Программа, определяющая простоту числа.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; // Стартовое значение
            double m = 0; 
            bool flag = false; // Логическая переменная, значение которой изменяется, если число не является простым   
            Console.Write("Введите число: ");    
            num = int.Parse(Console.ReadLine());  
            m = Math.Sqrt(num);    
            for(int i = 2; i <= m; i++)    
            {    
                if(num % i == 0)    
                {    
                    Console.Write("Число не простое.");    
                    flag = true;    
                    break;    
                }    
            }    
            if (flag == false)    
                Console.Write("Число простое.");   
        }
    }
}