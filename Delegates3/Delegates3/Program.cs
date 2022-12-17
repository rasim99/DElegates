using System;

namespace Delegates3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employ = new Employee();
            employ.Name = "Orxan";
            employ.Surname = "Serxanov";
            employ.Age = 27;
            employ.Salary = 600;
            Employee employ1 = new Employee();
            employ1.Name = "Eldar";
            employ1.Surname = "Eldarli";
            employ1.Age = 28;
            employ1.Salary = 300;
            EmplList emplList = new EmplList();
          
            emplList.lists.Add(employ1);
            emplList.lists.Add(employ);

            emplList.SalaryOfEmps();

        }
       
    }
}
