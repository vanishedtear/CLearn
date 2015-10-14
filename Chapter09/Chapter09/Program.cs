using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public abstract class test
    {
        public int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
    public class MyBaseClass
    {
        public  MyBaseClass()
        {
        }

        public MyBaseClass(int i)
        {
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass()
        { }

        public MyDerivedClass(int i)
        { }

        public  MyDerivedClass(int i, int j)
        { }


    }



}
