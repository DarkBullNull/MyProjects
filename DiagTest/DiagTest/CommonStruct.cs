using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DiagTest
{
    class CommonStruct
    {
        public CommonStruct()
        {
            Assignment();
        }
        static KeyValuePair<Image, string> Random0 { get; set; }
        static KeyValuePair<Image, string> Random1 { get; set; }
        static KeyValuePair<Image, string> Random2 { get; set; }
        static KeyValuePair<Image, string> Random3 { get; set; }
        static KeyValuePair<Image, string> Random4 { get; set; }
        static public void Assignment()
        {
            
            Random rnd0 = new Random();
            Random0 = Dictionary.diag.ElementAt(rnd0.Next(Dictionary.diag.Count));
            Random rnd1 = new Random();
            Random1 = Dictionary.diag.ElementAt(rnd1.Next(Dictionary.diag.Count));
            Random rnd2 = new Random();
            Random2 = Dictionary.diag.ElementAt(rnd2.Next(Dictionary.diag.Count));
            Random rnd3 = new Random();
            Random3 = Dictionary.diag.ElementAt(rnd3.Next(Dictionary.diag.Count));
            Random rnd4 = new Random();
            Random4 = Dictionary.diag.ElementAt(rnd4.Next(Dictionary.diag.Count));
        }

    }
}
