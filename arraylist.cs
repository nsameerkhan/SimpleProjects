using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist1
{

    public class Class1
    {
       
        private int[] _data;
        public Class1()
        {
            Capacity = 2;
            _data = new int[Capacity];
        }
        private int _capacity;

        private int Capacity
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
        public string print()
        {
            string x = "";
            x = x + '[';
            for (int i = 0; i < Count-1; i++)
            {
                x = x + _data[i] + ",";
            }
            x = x + _data[Count-1]+ ']';

            return x;
        }
        public void resize()
        {
            int[] newarray = new int[Capacity * 2];
            Array.Copy(_data, newarray, _data.Length);
            _data = newarray;
            Capacity = Capacity * 2;


        }


        public void Add(int value)
        {
            if (Count < Capacity)
            {
                _data[Count++] = value;
            }
            else
            {
                resize();
                Add(value);
            }
        }
        public void delete(int index1)
        {
            if (!IsEmpty)
            {

                if (index1 >= 0 && index1 <= Count)
                {
                    for (int i = index1; i <= Count; i++)
                    {
                        if (Count != i)
                        {
                            _data[i] = _data[i + 1];

                        }
                        else
                        {
                            _data[i] = 0;

                        }
                    }
                    Count--;
                }
            }


        }

        public int get(int index)
        {

            if (index < Count && index >= 0)
            {
                return _data[index];
            }

            else
            {
                throw new InvalidCastException("Index out of range");
            }
        }

        public int set(int index, int value)
        {
            if (index < Count && index > 0)
            {
                return _data[index] = value;
            }
            else
            {
                throw new InvalidCastException("Index out of range");
            }
        }
        public void insert(int index, int value)
        {
            if (index <= Count && index >= 0)
            {
                if (Count == Capacity)
                {
                    resize();
                }
                for (int i = Count; i > index; i--)
                {
                    _data[i] = _data[i - 1];


                }

                _data[index] = value;
                Count++;


            }
            else
            {
                throw new InvalidCastException("Index out of range");
            }
        }

        public bool contains(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_data[i] == value)
                {
                    return true;
                }

            }
            return false;

        }
        public int indexof(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_data[i] == value)
                {
                    return i;
                }

            }
            return -1;
        }
        public int max()
        {
            int maximum = 0;
            for (int i = 0; i < Count; i++)
            {
                if (maximum < _data[i])
                {
                    maximum = _data[i];
                }
            }
            return maximum;
        }
        public int min()
        {
            int minimum = int.MaxValue;
            for (int i = 0; i < Count; i++)
            {
                if (minimum > _data[i])
                {
                    minimum = _data[i];
                }
            }
            return minimum;
        }
        public int sum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum = sum + _data[i];

            }
            return sum;
        }
        public string reverse()
        {
            string x = " ";
            for (int i = Count - 1; i >= 0; i--)
            {
                x = x + _data[i] + "\t";
            }
            return x;
        }
        public void toarray()
        {
          
            for (int i = 0; i < Count; i++)
            {
                Console.Write(_data[i] + "\t");
            }
        }
        public void addall(IEnumerable<int> col)
        {

            int[] a = col.ToArray();
            for (int i = 0; i < a.Length; i++)
            {
                Add(a[i]);
            }

        }
       
        public string toarray(int startindex)
        {
            string x = "";
            for (int i = startindex; i < Count; i++)
            {
                x = x + _data[i]+"\t";
            }
            return x;
        }
        public string toarray(int startindex, int endindex)
        {
            string x = "";
            for (int i = startindex; i <=endindex; i++)
            {
                x = x + _data[i] + "\t";
            }
            return x;
        }
        public string distinct()
        {
            string x = "";
            int[] a=new int[Count];
            for (int i = 0; i < Count; i++)
            {
                if (!a.Contains(_data[i]))
                {
                    a[i]=_data[i];
                    x = x + a[i] + "\t";

                }
                else
                {
                    continue;
                }
            }
            return x;
           
        }
        public void sort()
        {
           
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count - 1; j++)
                {
                    if (_data[j] > _data[j + 1])
                    {
                        int temp = _data[j];
                        _data[j] = _data[j + 1];
                        _data[j + 1] = temp;
                    }

                }

            }
            foreach (var ans in _data)
            {
                Console.Write(ans+"\t");
            }
            
           
        }
    }
}


