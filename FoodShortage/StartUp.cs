using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            //Peter 25 8904041303 04 / 04 / 1989
            //Stan 27 WildMonkeys

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ").ToArray();

                if (line.Length==4)
                {
                    string name = line[0];
                    int age = int.Parse(line[1]);
                    string id = line[2];
                    string birthdate = line[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    buyers.Add(citizen);
                }

                else if (line.Length==3)
                {
                    string name = line[0];
                    int age = int.Parse(line[1]);
                    string group = line[2];

                    Rebel rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                    
                }

            }


            while (true)
            {
                string names = Console.ReadLine();

                if (names=="End")
                {
                    break;
                }

                if (buyers.Select(b=>b.Name).Contains(names))
                {
                    buyers.FirstOrDefault(b=>b.Name==names).BuyFood();
                }

            }


            Console.WriteLine(buyers.Sum(b => b.Food));

        }
    }
}
