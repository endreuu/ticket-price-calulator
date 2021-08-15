using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            SumTickets calculator = new();

            string charName = Console.ReadLine();
            int numTickets = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < numTickets)
            {
                string fullName = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                calculator.CalculatePrice(fullName, charName, age, numTickets);
            }
        }
    }

    class SumTickets
    {
        double price = 0;
        int aux = 0;

        static int NameCompare(string fullName, string charName)
        {
            if (fullName.Contains(charName)) return 1;
            else return 0;
        }

        public void CalculatePrice(string fullName, string charName, int age, int numTickets)
        {

            if (NameCompare(fullName, charName) == 1) price += 20;
            else if (age < 18 || age > 65) price += 25;
            else if (NameCompare(fullName, charName) == 0) price += 50;

            aux += 1;
            if (aux == numTickets)
            {
                Console.WriteLine("$" + price);
            }
        }
    }
}
