using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private int[] array;
        private bool isEmpty;
        private int lastElementIndex;

        public Stack(int stackSize)
        {
            array = new int[stackSize];
            isEmpty = true;
            lastElementIndex = 0;

            for (int i = 0; i < array.Length; i++)
                array[i] = 0;
        }

        public void Pop()
        {
            if(!isEmpty)
            {
                return;
            } else
            {
                if(lastElementIndex == 0)
                {
                    isEmpty = true;
                } else
                {
                    lastElementIndex--;
                }
            }
        }

        public void Push(int value)
        {
            if(lastElementIndex == array.Length - 1)
            {
                return;
            } else
            {
                lastElementIndex++;
                array[lastElementIndex] = value;
            }
        }

        public int Peek()
        {
            return array[lastElementIndex];
        }
    }
}
