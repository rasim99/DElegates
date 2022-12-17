using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Rasim";
            person.SurName = "Mahmudov";
            person.Adress = "Baku";
            person.Salary = 7000;
            Person person1 = new Person();
            person1.Name = "Ronald";
            person1.SurName = "Adilov";
            person1.Adress = "Sumqayit";
            person1.Salary = 700;
            Person person2 = new Person();
            person2.Name = "Rafiq";
            person2.SurName = "Zeynalli";
            person2.Adress = "Naxcivan";
            person2.Salary = 2400;
            Person person3= new Person();
            person3.Name = "Ehmed";
            person3.SurName = "Zahidzade";
            person3.Adress = "Gence";
            person3.Salary = 977;
            PersonPredicate predi= new PersonPredicate();
            predi.persons.Add(person);
            predi.persons.Add(person1);
            predi.persons.Add(person2);
            predi.persons.Add(person3);
            predi.SalaryOfPerson(l => l < 1000);

        }

        

    }
}
