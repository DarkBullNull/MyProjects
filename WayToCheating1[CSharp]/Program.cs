using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayToCheating1_CSharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            int typeint = 123456;
            unsafe
            {
                int* varInt = &typeint;
                Console.WriteLine($"varInt = {String.Format("Hex",(int)(varInt))}" );
                Console.ReadKey();
            }
        }
        
    }
    
}

