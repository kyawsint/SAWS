using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    interface IA
    {
        void AA();
        void BB();
        void CC();
    }

    interface IB
    {
        void BB();
    }

    interface IC
    {
        void CC();
    }

    class ABC : IB
    {
        public void BB()
        {
            Console.WriteLine("IB");
        }

        public void CC()
        {
            Console.WriteLine("IC");
        }
    }

    class Class1
    {
        public static void Main(string[] args)
        {
            ABC a = new ABC();
            a.CC();
            Console.Read();
        }
    }
}
