using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operation
    {
        public void RetrieveTopTwoRecords(List<Person> list)
        {
            var result = list.Where(x => x.Age < 60).Take(2);
            Display(result.ToList());
        }
        public void RetrieveRecordsInBetweenAge(List<Person> list)
        {
            var result = list.Where(x => x.Age > 13 && x.Age<18);
            Display(result.ToList());
        }
        public void RetrieveAverageAge(List<Person> list)
        {
            var result = list.Average(x => x.Age);
            Console.WriteLine(result);
        }
        public void RetrievePersonDetailsByName(List<Person> list)
        {
            Console.WriteLine("Enter Name to Search");
            string name = Console.ReadLine();
            var result = list.Where(x => x.Name==name);
            Display(result.ToList());
        }

        public void Display(List<Person> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.SSN + "\n" + data.Name + "\n" + data.Address + "\n" + data.Age);
            }
        }
    }
}
