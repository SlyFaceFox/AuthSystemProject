using System;
using System.Collections.Generic;
namespace Title
{
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(5);
            
            people.Add(new Person() { Name = "Вася", Id = 1 });
            people.Add(new Person() { Name = "Петя", Id = 2 });
            people.Add(new Person() { Name = "Ваня", Id = 3 });
            people.Add(new Person() { Name = "Гоша", Id = 4 });
            people.Add(new Person() { Name = "Таня", Id = 5 });
            
           
           
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }
            
          
        }
    }
}

