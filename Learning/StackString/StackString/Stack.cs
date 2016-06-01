using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackString
{
    class Stack
    {
        private string[] array;
        private int indexOfLastElement;
        public bool isEmpty { get { return indexOfLastElement < 0; } }

        public Stack()
        {
            array = new string[10];
            indexOfLastElement = -1;
        }

        public void Pop()
        {
            if (!isEmpty)
            {
                array[indexOfLastElement] = default(string);
                indexOfLastElement--;
            }
        }

        public void Push(string value)
        {
            if (indexOfLastElement == array.Length - 1)
            {
                string[] bufferArr = new string[array.Length];

                for (int i = 0; i < array.Length - 1; i++)
                    bufferArr[i] = array[i];

                array = new string[2 * array.Length];

                for (int i = 0; i < bufferArr.Length - 1; i++)
                    array[i] = bufferArr[i];
            }

            indexOfLastElement++;
            array[indexOfLastElement] = value;
        }

        public string Peek()
        {
            try
            {
                return array[indexOfLastElement];
            }
            catch (Exception exc)
            {
                throw new IndexOutOfRangeException("Error! Stack is empty!", exc);
            }
        }

        public string[] GetArrayOfStackElements()
        {
            string[] arrayOfStackElements = new string[indexOfLastElement + 1];

            for (int i = 0; i <= indexOfLastElement; i++)
                arrayOfStackElements[i] = array[i];

            return arrayOfStackElements;
        }
    }
}

