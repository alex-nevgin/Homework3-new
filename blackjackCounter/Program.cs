using System;

namespace blackjackCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число карт: ");
            int handCards = int.Parse(Console.ReadLine());

            int handValue = 0;

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
                        Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T");
                        break;
                }
            }
            
            Console.WriteLine($"Сумма карт руки: " + handValue);
            Console.ReadKey();
        }
    }
}