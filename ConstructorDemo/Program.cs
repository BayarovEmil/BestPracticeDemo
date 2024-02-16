using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Engin","Demirog","Ankara");
            Customer customer2 = new Customer { Id=2,FirstName="EMil",LastName="Bayarov",City="Baki"};

        }
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Yapici blok calisdi!");
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
