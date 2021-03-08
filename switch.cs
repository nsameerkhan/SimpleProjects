using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchoops1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Switch s1 = new Switch();
            Console.WriteLine(s1.Switchon());
            Console.WriteLine(s1.Switchoff());
        }
        public enum Switchstate
        {
            on=0,
            off
        }
        public class Switch //class
        {
            Switchstate state;
            public Switch() //constructors
        {
            state = Switchstate.on;

        }
            public Switchstate Switchon() //methods
            {
                if (state == Switchstate.off)
                {
                    state = Switchstate.on;
                }
                return state;
            }
            public Switchstate Switchoff() //methods
            {
                if (state == Switchstate.on)
                {
                    state = Switchstate.off;
                }
                return state;
            }
        }
    }
   
}


