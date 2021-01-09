using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rps_game
{
    
    class Program
    {
        public static ConsoleColor mycolor=Console.ForegroundColor;
        static void Main(string[] args)
        {
            #region game workflow
            //single round match
            //Console.WriteLine("******************welcome to AI powered rps game*****");        
            //choice userchoice=getuserinput("enter your choice(1.rock,2.paper,3.scissor):");
            //choice AIchoice=getAIinput();
            //displaychoices(userchoice,AIchoice);
            //winningstate currentwinner=getwinner
            //multiple rounds-5;
            int AIwincount=0;
            int userwincount=0;
            int drawcount=0;
            for (int i = 0; i < 5; i++)
            {
                if (userwincount >= 3 || AIwincount >= 3)
                {
                    printwinner(AIwincount, userwincount, drawcount);
                    break;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*******welcome AI************");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*******this is round:" + (i + 1) + "************");
                Console.WriteLine("******current standing in game**********");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("user win count:" + userwincount + "AI win count:" + AIwincount + "draw count:" + drawcount);
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = mycolor;
                choice userchoice = getuserinput("enter rps");
                choice AIchoice = getAIinput();
                displaychoices(userchoice, AIchoice);
                winningstate currentwinner = getwinner(userchoice, AIchoice);
                if (currentwinner == winningstate.AIwins)
                {
                    AIwincount++;
                }
                else if (currentwinner == winningstate.userwins)
                {
                    userwincount++;
                }
                else if (currentwinner == winningstate.draw)
                {
                    drawcount++;
                }
                string winningmessage = getwinningmessage(userchoice, AIchoice);
                displayresult(currentwinner, winningmessage);
            }
            printwinner(AIwincount, userwincount, drawcount);
       

            }
            #endregion
            #region print winner
            public static void printwinner(int AIwincount,int userwincount,int drawcount)
            {
                Console.Clear();
                int rounds=AIwincount+userwincount+drawcount;
                if(AIwincount==userwincount)
                {
                  Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine("***result after"+rounds+"rounds.******");
                    Console.WriteLine("user wins count:"+userwincount+"AI win count:"+AIwincount+"Draw Count:"+drawcount);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor=ConsoleColor.Blue;
                    Console.WriteLine("************NOBODY WINS.IT IS A DRAW AFTER 5 ROUNDS.***********");
                }
                else if(AIwincount>userwincount)
                {
                     Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine("***result after"+rounds+"rounds.******");
                    Console.WriteLine("user wins count:"+userwincount+"AI win count:"+AIwincount+"draw count:"+drawcount);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor=ConsoleColor.Blue;
                    Console.WriteLine("************AI WINS.Better next time.***********");
                }
                  else if(userwincount>AIwincount)
                {
                     Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine("***result after"+rounds+"rounds.******");
                    Console.WriteLine("user wins count:"+userwincount+"AI win count:"+AIwincount+"draw count:"+drawcount);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor=ConsoleColor.Blue;
                    Console.WriteLine("************USER  WINS.Congratulations.***********");
                }
                Console.ForegroundColor=mycolor;
            }
            #endregion
            #region display choices
            public static void displaychoices( choice userchoice,choice AIchoice)
            {
                Console.WriteLine(string.Format("*********user choice:{0}***AIchoice:{1}*******",userchoice,AIchoice));
            }
            #endregion
            #region display game result
        public static void displayresult(winningstate currentwinner,string winningmessage)
        {
            if(currentwinner==winningstate.draw)
            {
                Console.WriteLine("******"+winningmessage+"********");
                Console.WriteLine("************nobody wins.it is draw.***********");
            }
            else if(currentwinner==winningstate.AIwins)
            {
                 Console.WriteLine("******"+winningmessage+"********");
                Console.WriteLine("************AI wins.better luck next time.***********");
            }
            else if(currentwinner==winningstate.userwins)
            {
                 Console.WriteLine("******"+winningmessage+"********");
                Console.WriteLine("************user wins.congratulations.***********");
            }
        }

            #endregion
            #region get AI choice
            public static choice getAIinput()
            {
                Random random=new Random(DateTime.Now.Millisecond);
                choice AIchoice=(choice)random.Next(1,4);
                return AIchoice;
            }
            #endregion
            #region determine the winner
        public static winningstate getwinner(choice userchoice,choice AIchoice)
        {
            winningstate currentwinner=winningstate.draw;
            if(userchoice==AIchoice)
            {
                return currentwinner;
            }
            else if(userchoice==choice.paper )
            {
                if(AIchoice==choice.Scissors)
                {
                    currentwinner=winningstate.AIwins;
                }
                else
                {
                    currentwinner=winningstate.userwins;
                }
            }
            else if(userchoice==choice.Rock)
            {
                if(AIchoice==choice.paper)
                {
                    currentwinner=winningstate.AIwins;
                }
                 else
                {
                    currentwinner=winningstate.userwins;
                }
            }
             else if(userchoice==choice.Scissors)
            {
                if(AIchoice==choice.Rock)
                {
                    currentwinner=winningstate.AIwins;
                }
                 else
                {
                    currentwinner=winningstate.userwins;
                }
            }

            return currentwinner;
        }
            #endregion
            #region get winner message
        public static string getwinningmessage(choice userchoice,choice AIchoice)
        {
            string winningmessage="same choice.what a coincidence.";
            if(userchoice==AIchoice)
            {
                return winningmessage;
            }
            else if(userchoice==choice.paper)
            {
                if(AIchoice==choice.Scissors)
                {
                    winningmessage=string.Format("{1} cuts {0}.so{1} wins.",AIchoice,userchoice);

                }
                else
                {
                    winningmessage=string.Format("{0} covers {1}.so {0} wins.",userchoice,AIchoice);
            }
            }
             else if(userchoice==choice.Rock)
            {
                if(AIchoice==choice.paper)
                {
                    winningmessage=string.Format("{1} cover {0}.so{1} wins.",AIchoice,userchoice);

                }
                else
                {
                    winningmessage=string.Format("{0} braks {1}.so {0} wins.",userchoice,AIchoice);
            }
            }
             else if(userchoice==choice.Rock)
            {
                if(AIchoice==choice.Scissors)
                {
                    winningmessage=string.Format("{0} breaks {1}.so{0} wins.",AIchoice,userchoice);

                }
                else
                {
                    winningmessage=string.Format("{0} cuts {1}.so {0} wins.",userchoice,AIchoice);
            }
            }
            return winningmessage;
        }

            #endregion
            #region getting rps input user choice
            public static choice getuserinput(string message)
            {
                Console.WriteLine("******getting user input for RPS game*******");
                Console.WriteLine(message);
                int tempvalue;
                if(!int.TryParse(Console.ReadLine(),out tempvalue))
                {
                    return getuserinput(message);
                }
                else if(tempvalue>3||tempvalue<1)
                {
                    return getuserinput(message);
                }
                return (choice)tempvalue;
            }
            #endregion

        }
        #region winning state and choice enumerations
    public enum winningstate
    {
        draw=0,
        AIwins=1,
        userwins=2
    }
    public enum choice
    {
        Rock=1,
        paper=2,
        Scissors=3
    }
        #endregion
    }
        
    
