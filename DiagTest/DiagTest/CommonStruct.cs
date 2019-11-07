using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagTest
{
    public class CommonStruct
    {
        public CommonStruct()
        {
            Assignment();
        }
        public KeyValuePair<Image, string>[] Randomnie = new KeyValuePair<Image, string>[6];
        void Assignment()
        {
            /*Random rnd0 = new Random();
            Randomnie[0] = Dictionary.diag.ElementAt(rnd0.Next(Dictionary.diag.Count));
            await Task.Delay(500);
            Random rnd1 = new Random();
            Randomnie[1] = Dictionary.diag.ElementAt(rnd1.Next(Dictionary.diag.Count));
            await Task.Delay(500);
            Random rnd2 = new Random();
            Randomnie[2] = Dictionary.diag.ElementAt(rnd2.Next(Dictionary.diag.Count));
            await Task.Delay(500);
            Random rnd3 = new Random();
            Randomnie[3] = Dictionary.diag.ElementAt(rnd3.Next(Dictionary.diag.Count));
            await Task.Delay(500);
            Random rnd4 = new Random();
            Randomnie[4] = Dictionary.diag.ElementAt(rnd4.Next(Dictionary.diag.Count));
            var test = Randomnie.Distinct();
            */
            Stack<int> rnd = new RandomNotRepeat(0, 20).list;
            for (int i = 0; i <= 5; i++)
            {
                Randomnie[i] = Dictionary.diag.ElementAt(rnd.ToArray()[i]);
            }
        }
    }
}
