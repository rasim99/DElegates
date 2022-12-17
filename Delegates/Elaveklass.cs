using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Elaveklass 
    {
        public List<Person> listperson = new List<Person>();


        public void SLP(Predicate<int> slppers)
        {
            foreach (Person item in listperson)
            {
                if (slppers(item.Salary))
                {
                    //Console.WriteLine(listperson);
                    //Console.WriteLine( "2ci cw",Name, SurName, Salary);
                    Console.WriteLine(item.SurName + item.Name + item.Adress);
                }
            }
            Console.WriteLine("isledi");
        }
    }
}
