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
        public void Display(List<Person> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.SSN + "\n" + data.Name + "\n" + data.Address + "\n" + data.Age);
            }
        }
    }
}
