using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        private T[] array;
        private bool isEmpty { get; set; }
        private int indexOfLastElement;

        public Stack()
        {
            array = new T[10];
            isEmpty = true;
            indexOfLastElement = -1;
        }

        public int Pop()
        {
            if(isEmpty)
                return -1; 
            else
            {
                if(indexOfLastElement == 0)
                    isEmpty = true;

                indexOfLastElement--;
                return 1;
            }
        }

        public void Push(T value)
        {
            isEmpty = false;

            if(indexOfLastElement == array.Length - 1)
            {
                // create buffer array
                T[] bufferArr = new T[array.Length];

                for(int i = 0; i < array.Length - 1; i++)
                    bufferArr[i] = array[i];

                // increase the size of the old array
                array = new T[2 * array.Length];

                for (int i = 0; i < bufferArr.Length - 1; i++)
                    array[i] = bufferArr[i];
            }

            indexOfLastElement++;
            array[indexOfLastElement] = value;
        }

        public T Peek()
        {
            return array[indexOfLastElement];
        }

        public T[] GetArrayOfStackElements()
        {
            T[] arrayOfStackElements = new T[indexOfLastElement + 1];

            for (int i = 0; i <= indexOfLastElement ; i++)
                arrayOfStackElements[i] = array[i];

            return arrayOfStackElements;
        }
    }
}
