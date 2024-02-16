using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBestPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // CokluImplementasyon();
            Worker worker = new Worker { Id=1,Name="Engin"};
            Student student = new Student() { Id = 2, Name = "Derin" };
            Person person = new Person() { Id = 3, Name = "Salih" };

            Person[] persons = new Person[] { person,student,worker };
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }

        private static void CokluImplementasyon()
        {
            //Isciler islesin deyek
            IWorkable[] workable = new IWorkable[]
            {
                new Worker(),
                new Student(),
                new Robot()
            };
            foreach (var work in workable)
            {
                work.Work();
            }
            //Yemek fasilesi
            IEatable[] eatables = new IEatable[]
            {
                new Worker(), new Student()
            };
            foreach (var eat in eatables)
            {
                eat.Eat();
            }
            //Ayin axiri odenis vaxti
            IGetSalary[] salaries = new IGetSalary[]
            {
                new Student(),new Worker()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }
    //Inheritance dersi ornek
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Student :Person
    {
        public int SchooolarShip {  get; set; }
    }
    class Worker : Person
    {
        public int Salary { get; set; }
    }
}
