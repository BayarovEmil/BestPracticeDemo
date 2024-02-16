using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferansTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ValueTypes();
            ReferenceTypes();
            ClassRefereceType();
            
            Console.ReadLine();
        }

        public static void ClassRefereceType()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Emil";

            person2 = person1;
            person2.FirstName = "Engin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            Employeer employeer = new Employeer();

            customer.FirstName = "Salih";
            customer.CreditNumber = 123456;
            // customer = employeer;
            Person person3 = customer;//Person Customer-in referansi tutur
            Console.WriteLine(person3.FirstName);//person customer-in proplarini islede bilmir
            Console.WriteLine(((Customer)person3).CreditNumber);//Cating person artiq sadece customer-dir
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employeer);
            personManager.Add(person1);
        }

        public static void ReferenceTypes()
        {
            // Referans tipler --> Class,array,interface...
            // stack -> heap sag teref stack-de olusur amma sol teref ucun heap-de yer ayrilir
            int[] num1 = new int[] { 1, 2, 3 };//101-nomerli referans
            int[] num2 = new int[] { 10, 20, 30 };//102-nomreli referans

            num1 = num2;//num1=102 artiq 102-ci referansa baxir
            num2[0] = 100;//102-deki ilk elementi deyisdik
            //101-nomreli referans-i tutan olmadigi ucun Garbage Collector terefinden silinir
            Console.WriteLine("Arrayin 1-ci elementi: " + num1[0]);
            //102-nomresli referansin ilk elementi cap edecek!
        }

        public static void ValueTypes()
        {
            //value types-->int,double,bool,decimal
            //bunlar deyer tiplerdir sadece stack oldugu ucun referansi yox deyerini saxliyirlar
            int num1 = 10;
            int num2 = 20;

            num1 = num2;
            num2 = 100;

            Console.WriteLine("Say 1: " + num1);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public int CreditNumber { get; set; }
    }

    class Employeer : Person
    {
        public int EmployeerNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("Eklendi: "+person.FirstName);//her 3-ude bir Person oldugundan //CRUD
        }
    }
}
