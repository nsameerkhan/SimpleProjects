using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validname1
{
    class Program
    {
        static void Main(string[] args)
        {
            string validname = "";
            Console.WriteLine(checkname(validname));
        }
        public static bool startword(string a)
        {
            bool answer =false;
            if(a=="int"||a=="double"||a=="float"||a=="string"||a=="char"||a=="bool"||a=="void")
            {
                answer = false;
            }
            else if (char.IsLetter(a[0]) || a[0] == '_')
            {
                answer = true;
            }
           
            return answer;
        }
        public static bool endword(string a)
        {
          
            bool answer = false;
            if (a == "int" || a == "double" || a == "float" || a == "string" || a == "char" || a == "bool" || a == "void")
            {
                answer = false;
            }
            else if (char.IsLetter(a[a.Length-1])||char.IsDigit(a[a.Length-1]))
            {
                answer = true;
            }
            return answer;
        }
        public static bool inbetweenwords(string a)
        {
            bool answer =false;
            for (int i = 1; i < a.Length - 2; i++)
            {
                if (a == "int" || a == "double" || a == "float" || a == "string" || a == "char" || a == "bool" || a == "void")
                {
                    answer = false;
                }

                else if (char.IsLetter(a[i]) || char.IsDigit(a[i]) || a[i] == '_')
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                    break;
                }
            }
            return answer;

        }
        public static bool checkname(string a)
        {
            bool answer = false;
            if (a.Length == 1)
            {
                if (startword(a))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            else if (a.Length == 2)
            {
                if (startword(a) && endword(a))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            else if (startword(a) && endword(a) && inbetweenwords(a))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

    }
}
