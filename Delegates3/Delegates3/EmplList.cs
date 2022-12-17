using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates3
{
    internal class EmplList
    {
      public  List<Employee> lists = new List<Employee>();
        public void SalaryOfEmps()
        {
            int orta = 0;

            foreach (var empl in lists)
            {


                if (empl.Age > 20 && empl.Age < 40)
                {

                    orta = empl.Salary / lists.Count;

                }

            }
            Console.WriteLine(orta);
        }
    }
}
