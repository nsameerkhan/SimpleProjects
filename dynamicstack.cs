using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicstack
{
    public class DStack
    {
        int[] Data;
        public DStack()
        {
            Capacity=2;
            Data=new int[Capacity];

        }
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        private int _count;
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        private bool _isempty;
        public bool IsEmpty
        {
            get
            {
                if (Count == 0)
                {
                    return _isempty=true;
                }
                else
                {
                    return _isempty=false;
                }
            }
        }
        public void resize()
        {
            int[] newarray = new int[Capacity*2];
            Array.Copy(Data, newarray, Data.Length);
            Data = newarray;
            Capacity = Capacity * 2;
        }
        public void push(int value)
        {
            if (Count < Capacity)
            {
                Data[Count++] = value;
            }
            else
            {
                resize();
                push(value);
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
                throw new InvalidOperationException("DStack is empty");
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
                throw new InvalidOperationException("DStack is empty");
            }
        }
        public void print()
        {
            if (!IsEmpty)
            {

                for (int i = Count - 1; i >= 0; i--)
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
