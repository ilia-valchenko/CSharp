using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
    {
        private Node<T>[] elems;
        //private Navigator nav;
        private int nearestFreeSpace;
        private int indexOfTail {get; set;}
        private int count { get; set; }

        public LinkedList() {
            elems = new Node<T>[10];
            indexOfTail = 0;
            count = 0;

            for (int i = 0; i < elems.Length; i++)
                elems[i] = null;

            nearestFreeSpace = 0;
        }

        public void AddToHead(T value)
        {
            if (elems[0] == null)
            {
                elems[0] = new Node<T>(value, 0, 0);
                nearestFreeSpace = 1;
            } else
            {
                if(nearestFreeSpace != 0)
                {
                    elems[nearestFreeSpace] = new Node<T>(elems[0].value, elems[0].next, 0); 
                    elems[0] = new Node<T>(value, nearestFreeSpace, indexOfTail);
                    elems[nearestFreeSpace].prev = 0;
                    // update nearestFreeSpace
                    for(int i = 0; i < elems.Length; i++)
                    {
                        if (elems[i] == null)
                            nearestFreeSpace = i;
                    }
                }
            }

        }

        public void AddToTail(T value)
        {
            if (elems[0] == null)
            {
                elems[0] = new Node<T>(value, 0, 0);
                nearestFreeSpace = 1;
            }
            else
            {
                if (nearestFreeSpace != 0)
                {
                    elems[nearestFreeSpace] = new Node<T>(value, 0, indexOfTail);
                    // old tail
                    elems[indexOfTail].next = nearestFreeSpace;
                    // new index of tail
                    indexOfTail = nearestFreeSpace;
                    
                    // update nearestFreeSpace
                    for (int i = 0; i < elems.Length; i++)
                    {
                        if (elems[i] == null)
                            nearestFreeSpace = i;
                    }
                }
            }
        }

        public Node<T>[] GetList()
        {
            return elems;
        }
    }

    class Node<T>
    {
        public T value { get; set; }
        // contains index number
        public int next { get; set; }
        public int prev { get; set; }

        public Node() { } // default

        public Node(T value, int next, int prev)
        {
            this.value = value;
            this.next = next;
            this.prev = prev;
        }
    }

    struct Navigator
    {
        public int next { get; set; }
        public int prev { get; set; }
    }
}
