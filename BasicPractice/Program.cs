using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            //InterfacesDemo();
           // PolyMorphismDemo();
            Console.ReadLine();
        }

        private static void PolyMorphismDemo()
        {
            ICustomerDal[] customerDal = new ICustomerDal[]
                        {
                new MySqlCustomerDal(),
                new OracleCustomerDal()
                        };
            foreach (var customer in customerDal)
            {
                customer.Add();
            }
        }

        private static void InterfacesDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Student student = new Student() { Id = 1, Name = "Emil", Department = "IT" };
            Worker worker = new Worker() { Id = 2, Name = "Elmar", Adress = "Baki" };
            Customer customer = new Customer() { Id = 3, Name = "Elxan", Department = "Buissness" };

            PersonManager personManager = new PersonManager();
            personManager.Add(student);
            personManager.Add(worker);
            personManager.Add(customer);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    class Worker:IPerson
    {
        public int Id { get; set; }
        public string firstName;
        public string Name { get { return "Mr. "+firstName; }
            set { firstName = value; } }//Encapsulation dersi ornek
        public string Adress {  get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Eklendi: " + person.Name);
        }
    }
}
