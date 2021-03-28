using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtosymbols1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "MMMMMMMMMMMMMMM";
            int ans =romanvalues1(a);
            Console.WriteLine(ans);
        }
       
        public static int romanvalues1(string a)
        {
            int sum = 0;
            int previous =0;
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            d1.Add('I',1);
            d1.Add('V', 5);
            d1.Add('X',10);
            d1.Add('L', 50);
            d1.Add('C', 100);
            d1.Add('D', 500);
            d1.Add('M', 1000);
            for (int i = a.Length-1; i >=0; i--)
            {
                int current =d1[a[i]];
                if (current>=previous)
                {
                    sum += d1[a[i]];
                }
                else
                {
                    sum -= d1[a[i]];
                }
                previous =current;
            }
            return sum;
            
        }
    }
}
