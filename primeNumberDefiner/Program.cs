using System;

namespace primeNumberDefiner
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, i;
            double m = 0; 
            bool flag = false;    
            Console.Write("Введите число: ");    
            num = int.Parse(Console.ReadLine());  
            m = Math.Sqrt(num);    
            for(i = 2; i <= m; i++)    
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