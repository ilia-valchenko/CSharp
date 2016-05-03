using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackRealization
{
    class Stack<T>
    {
        T[] arr = new T[5];
        int index = -1;
        public int SizeOfArray
        {
            get
            {
                return arr.Length;
            }
        }

        public void Pop()
        {
            if(index != -1)
            {
                arr[index] = default(T);
                index--;
            } else
            {
                throw new Exception("Stack is empty!");
            }
        }

        public T Peek()
        {
            if(index != -1)
            {
                return arr[index];
            } else
            {
                throw new Exception("Stack is empty!");
            }
        }

        public void Push(T val)
        {
            if(index + 1 > arr.Length - 1)
            {
                T[] arrBuff = arr.ToArray();
                arr = new T[2*arrBuff.Length];

                for (int i = 0; i < arrBuff.Length - 1; i++)
                    arr[i] = arrBuff[i];

                index++;
                arr[index] = val;
            } else
            {
                index++;
                try
                {
                    arr[index] = val;
                } catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}