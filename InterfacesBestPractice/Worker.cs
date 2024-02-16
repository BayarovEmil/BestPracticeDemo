using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBestPractice
{
    interface IWorkable
    {
        void Work();
    }
    interface IEatable
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }
    class Worker : IWorkable, IEatable, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Isci yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Isci maasini aldi");
        }

        public void Work()
        {
            Console.WriteLine("Robot calisdi");
        }
    }
    class Student : IWorkable, IEatable, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Telebe yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Telebe odenisi aldi");
        }

        public void Work()
        {
            Console.WriteLine("Robot calisdi");
        }
    }
    class Robot :IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot calisdi");
        }
    }
}
