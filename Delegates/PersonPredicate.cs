using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    internal class PersonPredicate
    {
        public List<Person> persons = new List<Person>();
        public void SalaryOfPerson(Predicate<int> predicate)
        {
            foreach (var item in persons)
            {
                if (predicate(item.Salary))
                {
                    Console.WriteLine(item.SurName + " "+ item.Name +"  "+ item.Adress);
                }
            }
           
        }
    }
}
