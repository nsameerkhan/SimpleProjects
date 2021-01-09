using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace studentdetails1
{
   class program
    {
        static void Main(string[] args)
       {
           #region Outside the class(Encapsulation)
           studentsdetails st = new studentsdetails();
            Console.WriteLine("enter no of  student:");
            int noofstudent=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= noofstudent; i++)
            {
                Console.WriteLine("enter student name:");
                st.studentname = Console.ReadLine();
                Console.WriteLine("enter no of subjects:");
                int subject = Convert.ToInt32(Console.ReadLine());
                //st.getinput(subject);
                SortedList<string, int> m = st.getinput(subject);
                st.printlist(m);
           #endregion
            }
            
            
            
      
        }
      

    }
     
    public class studentsdetails
    {
        #region Inside class
        string _studentname;
        string _subjectname;
        int _marks;
        SortedList<string, int> s1 = new SortedList<string, int>();
         public  void printlist(SortedList<string,int> s1)
        {
            int i =0;
            Console.WriteLine("S.NO\t |  SUBJECT\t |  SCORE/100 \t |  LETTERGRADE\t | \t STATUS\t");
            Console.WriteLine("|-------------|---------------|-------------|---------|---------------|");
            foreach (KeyValuePair<string, int> d in s1)
            {
                i = i + 1;
                
              Console.WriteLine(string.Format(" {0}\t\t |  {1}\t\t |  {2}\t\t | {3}\t\t | {4}\t\t",i,d.Key,d.Value,grade(d.Value),statusgrade(grade(d.Value))));
              
            }

            Console.WriteLine("highest score:" + highestscore());
            Console.WriteLine("lowest score:"+lowestscore());
            Console.WriteLine("total score:"+total());
        #endregion

        }
         # region Get input to the students details
         public SortedList<string,int> getinput(int noofsubject)
        {
           
            for (int i = 1; i <= noofsubject; i++)
            {
                Console.WriteLine("enter the subjectname");
                string subject = Console.ReadLine();
                Console.WriteLine("enter subject marks:");
                int mark = Convert.ToInt32(Console.ReadLine());
                s1.Add(subject, mark);
                
            }
            return s1;

        }
         #endregion
         #region calculate total marks
         public double total()
        {
            int total = 0;
            foreach (KeyValuePair<string, int> d in s1)
                {
                    Console.WriteLine(d.Key + ":" + d.Value);
                    total = total + d.Value;
                }
            return total;
        }
#endregion
         #region print highest marks
         public double highestscore()
        {
            double maxvalue = s1.Values.Max();
            return maxvalue;
        }
#endregion
         #region print lowest marks
         public double lowestscore()
        {
            double minvalue = s1.Values.Min();
            return minvalue;
        }
#endregion
         #region print grades
         public  string grade(int num)
        {
            string grade="";
            if (num >=90)
            {
                grade = "S";
            }
            else if (num >= 80)
            {
                grade = "A";
            }
            else if (num >= 70)
            {
                grade = "B";
            }
            else if (num >= 60)
            {
                grade = "C";
            }
            else if (num >= 50)
            {
                grade = "D";
            }
            else if (num < 50)
            {
                grade= "F";
            }
            return grade;
        }
#endregion
         #region status of the grades
         public string statusgrade(string var)
        {
            string variable = "";
            if (var =="S")
            {
                variable = "Distinction";
            }
            else if (var == "A" || var == "B")
            {
                variable = "First Class";
            }
            else if (var == "C" || var == "D")
            {
                variable = "Second Class";
            }
            else if (var == "F")
            {
                variable = "Fail";
            }
            return variable;
        }
#endregion
         #region Using properties(get,set)
         public string studentname
        {
            get
            {
                return _studentname;
            }
            set
            {
                _studentname = value;
            }
        }
        public string subjectname
        {
            get
            {
                return _subjectname;
            }
            set
            {
                _subjectname = value;
            }


        }
        public int mark
        {
            get
            {
                return _marks;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _marks = value;
                }
                else
                {
                    throw new ArgumentException("invalid marks:must between 0 to 100");
                }
                }

        }
#endregion
    }
        
    }