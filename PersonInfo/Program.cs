using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using PersonInfo;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {

            List<IBirthable> birthable = new List<IBirthable>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();

                string type = parts[0];

                if (type == nameof(Citizen))
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdate = parts[4];

                   birthable.Add(new Citizen(name,age,id,birthdate)); 
                }

                else if (type == nameof(Pet))
                {
                    string name = parts[1];
                    string birthdate = parts[2];

                    birthable.Add(new Pet(name, birthdate));
                }

            }

            string filterYear = Console.ReadLine();

            List<IBirthable> filtered = birthable
                .Where(i => i.Birthdate.EndsWith(filterYear))
                .ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Birthdate);
            }

            //List<IIdentifiable> identifiables = new List<IIdentifiable>();

            //while (true)
            //{
            //    string line = Console.ReadLine();

            //    if (line=="End")
            //    {
            //        break;
            //    }

            //    string[] parts = line.Split();

            //    if (parts.Length==3)
            //    {
            //        string name = parts[0];
            //        int age = int.Parse(parts[1]);
            //        string id = parts[2];
            //        identifiables.Add(new Citizen(name, age,id));
            //    }

            //    else
            //    {
            //        string model = parts[0];
            //        string id = parts[1];

            //        identifiables.Add(new Robot(model,id));
            //    }
            //}

            //string filterID = Console.ReadLine();

            //List<IIdentifiable> filtered = identifiables
            //    .Where(i => i.Id.EndsWith(filterID))
            //    .ToList();

            //foreach (var identifiable in filtered)
            //{
            //    Console.WriteLine(identifiable.Id);
            //}

            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //string id = Console.ReadLine();
            //string birthdate = Console.ReadLine();

            //IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            //IBirthable birthable = new Citizen(name, age, id, birthdate);


            //Console.WriteLine(identifiable.Id);
            //Console.WriteLine(birthable.Birthdate);


            //string name = Console.ReadLine();

            //int age = int.Parse(Console.ReadLine());

            //IPerson person = new Citizen(name, age);

            //Console.WriteLine(person.Name);

            //Console.WriteLine(person.Age);

        }
    }
}
