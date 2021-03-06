using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack1
{
   public class stack
    {
       
       private int[] Data;
       public stack(int size)
       {
          Capacity=size;
          Data = new int[capacity];

       }
       private int _capacity;
       public int capacity
       {
           get {return _capacity;}
           set{_capacity=value;}
       }
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
       
        public bool IsEmpty
        {
            get 
            {
                if (Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void push(int value)
        {
           
                if (Count <=capacity)
                {
                    Data[Count++] = value;
                  
                }
                else
                {
                    throw new InvalidOperationException("if the stack is full");
                }
         }
            
        
        public int pop()
        {
            
            if (!IsEmpty)
            {
                
                return Data[--Count];
               
            }
            else
            {
                throw new InvalidOperationException("if the stack is empty");
            }
          
            
           
        }
        public int peek()
        {
            
            if (!IsEmpty)
            {
                return Data[Count - 1];
            }
            else
            {
                throw new InvalidOperationException("if the stack is empty");
            }
        }
        public void print()
        {
            if (!IsEmpty)
            {
                
                for (int i = Count - 1; i >=0; i--)
                {
                    Console.Write(Data[i] + "\t");
                }
            }
            else
            {
                throw new InvalidOperationException("if the stack is empty");
            }
        }
    }
}
