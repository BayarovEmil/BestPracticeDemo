using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Adana");
            Console.Write(cities.Count+"\n");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Baki");
            Console.Write(sehirler2.Count);

            Console.ReadLine();
        }
    }
    class MyList<T>
    {
        T[] _arr;
        T[] _tempArr;
        public MyList()
        {
            _arr = new T[0];
        }
        public void Add(T item)
        {
            _tempArr = _arr;
            _arr = new T[_arr.Length + 1];
            for (int i = 0; i < _tempArr.Length; i++)
            {
                _arr[i] = _tempArr[i];
            }
            _arr[_arr.Length-1 ] = item;
        }
        public int Count
        {
            get { return _arr.Length; }
        }
    }
}
