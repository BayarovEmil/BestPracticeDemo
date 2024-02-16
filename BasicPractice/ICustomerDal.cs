using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("MySql silindi");
        }

        public void Update()
        {
            Console.WriteLine("MySql guncellendi");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle guncellendi");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
