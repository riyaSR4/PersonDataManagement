using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person()
            {
                SSN = 1,
                Name = "a",
                Address = "a",
                Age = 10
            });
            persons.Add(new Person()
            {
                SSN = 2,
                Name = "b",
                Address = "b",
                Age = 15
            });
            persons.Add(new Person()
            {
                SSN = 3,
                Name = "c",
                Address = "c",
                Age = 20
            });
            persons.Add(new Person()
            {
                SSN = 4,
                Name = "d",
                Address = "d",
                Age = 25
            });
            persons.Add(new Person()
            {
                SSN = 5,
                Name = "e",
                Address = "e",
                Age = 30
            });
            Operation operation = new Operation();
            Console.WriteLine("Retrieve top 2 records for age less than 60");
            operation.RetrieveTopTwoRecords(persons);
            Console.WriteLine("Retrieve age between 13 to 18");
            operation.RetrieveRecordsInBetweenAge(persons);
        }
    }
}
