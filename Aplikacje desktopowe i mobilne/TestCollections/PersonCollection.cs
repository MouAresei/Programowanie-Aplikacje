using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
    class PersonCollection
    {
        public void Test()
        {
            List<Person> listOfPeople = new List<Person>();
            listOfPeople.Add(new Person()
            {
                Name = "Marek",
                Surname = "Kowalski",
                Age = 23,
                Height = 179
            });

            listOfPeople.Add(new Person()
            {
                Name = "Mirek",
                Surname = "Adam",
                Age = 96,
                Height = 161
            });

            listOfPeople.Add(new Person()
            {
                Name = "Agnieszka",
                Surname = "Nowak",
                Age = 77,
                Height = 149
            });

            listOfPeople.Add(new Person()
            {
                Name = "Adam",
                Surname = "Małysz",
                Age = 15,
                Height = 149
            });

            //List<>


            Console.WriteLine("Wszystkie dane w kolekcji: ");
            foreach (Person person in listOfPeople)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            bool isAnyHere = listOfPeople.Any();
            Console.WriteLine("czy ktos jest na liscie: " + isAnyHere);

            bool isAnyHereUnder18 = listOfPeople.Any(p => p.Age < 18);
            Console.WriteLine("czy na liscie jest osoba niepelnoletnia: " + isAnyHereUnder18);

               
        }

    }
}
