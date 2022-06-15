using System;

namespace _10_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double rent = 0;
            double discount = 0;

            double difference = 0;
            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter":
                    rent = 2600;
                    break;



            }
            if (fisherman <= 6)
            {

                discount = 0.10;

            }
            else if (fisherman <= 11)
               
            {
                discount = 0.15;
            }
            else
            {
                discount = 0.25;
            }
                   

            
            rent = rent - rent * discount;
            if (fisherman % 2==0 && season!="Autumn")
            {
                rent = rent - rent * 0.05;

            }
            difference = budget - rent;
            if (difference<0)
            {
                Console.WriteLine($"Not enough money! You need { Math.Abs(difference):f2} leva.");
            }
            else
            {
                Console.WriteLine($" Yes! You have { difference:f2} leva left.");
                
               
            }
        }
    }
}
