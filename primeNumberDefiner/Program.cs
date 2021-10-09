using System;

namespace primeNumberDefiner
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, i, m = 0; 
            bool flag = false;    
            Console.Write("Введите число: ");    
            num = int.Parse(Console.ReadLine());  
            m = num / 2;    
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