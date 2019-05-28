
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var ucha = b*0.9;
            var sum = ucha*8;
            var sum1 = c*(2*b);
            var vs = sum + sum1;
            var s = 0.0;
            if (a <= vs)
            {
                 s =vs - a;
                Console.WriteLine("Yes!{0} hours left.",Math.Floor(s));
            }
            else
            {
                s = a - vs;
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(s));
            }

        }
    }
}
