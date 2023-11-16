using System;

class Program
{
    static void Main()
    {
        
        string[] cards = { "Трефы", "Червы", "Бубны", "Пики" };
        int cardNumber = 2; 

        DisplayCard(cards, cardNumber);
    }

    static void DisplayCard(string[] cards, int cardNumber)
    {
        
        if (cardNumber >= 0 && cardNumber < cards.Length)
        {
            Console.WriteLine($"Игровая карта под номером {cardNumber + 1}: {cards[cardNumber]}");
        }
        else
        {
            Console.WriteLine("Карта с указанным номером отсутствует.");
        }
    }
}