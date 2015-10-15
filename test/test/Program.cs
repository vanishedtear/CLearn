using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int? result;
            //System.Nullable<int> nullableInt;
            int? nullableInt = null;
            Console.WriteLine("{0}",nullableInt);
            int? nullableint=2;
            result = nullableInt ?? nullableint; 

            
            Console.ReadKey();
        }
    }
}
