using System;

namespace oddEvenDefiner
{
    /// <summary>
    /// Программа, определяющая четность или нечетность введенного пользователем числа
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num; // вводимое число
            
            Console.WriteLine("Введите число: ");
            num = int.Parse(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine("Введенное число - четное");
            }
            else
            {
                Console.WriteLine("Введенное число - нечетное");
            }
        }
    }
}