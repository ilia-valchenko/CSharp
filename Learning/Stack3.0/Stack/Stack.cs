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
        private int indexOfLastElement;
        public bool isEmpty { get { return indexOfLastElement < 0; } }
        

        public Stack()
        {
            array = new T[10];
            indexOfLastElement = -1;
        }

        public void Pop()
        {
            if(!isEmpty)
            {
                array[indexOfLastElement] = default(T);
                indexOfLastElement--;
            }
        }

        public void Push(T value)
        {
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
            try
            {
                return array[indexOfLastElement];
            } 
            catch(Exception ex)
            {
                throw new ApplicationException("Error! Stack is empty!", ex);
            }
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
