using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
    {
        // do private
        public Node<T>[] elems;
        private Navigator nav;
        private int nearestFreeSpace;
        private int indexOfTail {get; set;}
        // Head always have zero index

        public LinkedList() {
            elems = new Node<T>[10];
            indexOfTail = 0;

            for (int i = 0; i < elems.Length; i++)
                elems[i] = null;

            nearestFreeSpace = 0;

            nav = new Navigator();
            nav.prev = 9999;
            nav.next = 9999;
        }

        public void AddToHead(T value)
        {
            if (elems[0] == null)
            {
                elems[0] = new Node<T>(value, 9999, 9999);
                nearestFreeSpace = 1;
            } else
            {
                if(nearestFreeSpace != 9999)
                {
                    if(nearestFreeSpace == 1)
                        indexOfTail = nearestFreeSpace;

                    elems[nearestFreeSpace] = new Node<T>(elems[0].value, elems[0].next, 0); 
                    elems[0] = new Node<T>(value, nearestFreeSpace, 9999);

                    UpdateNearestFreeSpace();
                }
            }
        }

        public void AddToTail(T value)
        {
            if (elems[0] == null)
            {
                elems[0] = new Node<T>(value, 9999, 9999);
                nearestFreeSpace = 1;
            }
            else
            {
                if (nearestFreeSpace != 0)
                {
                    elems[nearestFreeSpace] = new Node<T>(value, 9999, indexOfTail);
                    // old tail
                    elems[indexOfTail].next = nearestFreeSpace;
                    // new index of tail
                    indexOfTail = nearestFreeSpace;

                    UpdateNearestFreeSpace();
                }
            }
        }

        // insert new node on current navigator position
        public void Add(T value)
        {
            if(nav.next != 9999)
            {
                if(nearestFreeSpace != 9999)
                {
                    elems[nearestFreeSpace] = new Node<T>(value, nav.next, nav.prev);
                    elems[nav.prev].next = nearestFreeSpace;
                    elems[nav.next].prev = nearestFreeSpace;

                    UpdateNearestFreeSpace();
                } 
            }
        }

        // delete node from current navigator position
        public void Delete()
        {
            if (nav.next != 9999)
            {
                elems[elems[nav.next].next].prev = nav.prev;
                elems[nav.prev].next = elems[nav.next].next;
                nav.next = elems[nav.next].next;
                elems[nav.next] = null;

                UpdateNearestFreeSpace();
            }
        }

        public Node<T> GetHead()
        {
            if (elems[0] == null)
                return null;
            else
                return elems[0];
        }

        public Node<T> GetTail()
        {
            if (elems[0] == null)
                return null;
            else
                return elems[indexOfTail];
        }

        public int Count()
        {
            int res = 0;

            foreach(Node<T> item in elems)
            {
                if (item != null)
                    res++;
            }

            return res;
        }

        public void Next()
        {
            if(elems[0] != null)
            {
                if (nav.next == 9999)
                {
                    nav.next = 0;
                }
                else
                {
                    nav.prev = nav.next;
                    nav.next = elems[nav.next].next;
                }
            }
        }

        public void Prev()
        {
            if (elems[0] != null)
            {
                if (nav.next == 9999)
                {
                    nav.next = 0;
                }
                else
                {
                    nav.next = nav.prev;
                    nav.prev = elems[nav.prev].prev;
                }
            }
        }

        public Node<T> GetCurrentNode()
        {
            return elems[nav.next];
        }

        public void UpdateNearestFreeSpace()
        {
            for (int i = 0; i < elems.Length; i++)
            {
                if (elems[i] == null)
                {
                    nearestFreeSpace = i;
                    break;
                }

                nearestFreeSpace = 9999; // means that free space not exist 
            }
        }
    }

    class Node<T>
    {
        public T value { get; set; }
        // contains index number
        public int next { get; set; }
        public int prev { get; set; }

        public Node() { } 

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
