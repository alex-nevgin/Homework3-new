using System;

namespace blackjackCounter
{
    class Program
    {
        /// <summary>
        /// Программа расчета суммы карт руки при игре в блэкджек.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число карт: ");
            int handCards = int.Parse(Console.ReadLine()); // количество карт
            int handValue = 0; // Сумма руки
            
            // Расчет суммы руки
            for (int i = 1; i <= handCards; i++)
            {
                Console.Write($"Введите номинал {i}-й карты: ");
                string cardValue = Console.ReadLine();
                int Value;
                switch (cardValue)
                {
                    case "2":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "3":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "4":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "5":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "6":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "7":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "8":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "9":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "10":
                        Value = Convert.ToInt32(cardValue);
                        handValue = Value + handValue;
                        break;
                    case "J":
                        Value = 10;
                        handValue = Value + handValue;
                        break;
                    case "Q":
                        Value = 10;
                        handValue = Value + handValue;
                        break;
                    case "K":
                        Value = 10;
                        handValue = Value + handValue;
                        break;
                    case "T":
                        Value = 10;
                        handValue = Value + handValue;
                        break;
                    default:
                        Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T"); // вывод ошибки
                        break;
                }
            }
            Console.WriteLine($"Сумма карт руки: " + handValue); // Вывод
            Console.ReadKey();
        }
    }
}