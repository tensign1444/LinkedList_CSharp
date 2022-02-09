using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListLib
{
    /// <summary>
    /// Linked list library Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class _2022_Spring_TannerEnsign_MyListLibrary<T> : IEnumerable<T>
    {

        /// <summary>
        /// Internal class called Node
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal class Node<T>
        {
            public T data; //data of the node

            public Node<T> next; //the next node

            /// <summary>
            /// Constructor for node class
            /// </summary>
            public Node(T value)
            {
                data = value;
                next = null;
            }

            public Node()
            {
                data = default;
                next = null;
            }

        }


        private Node<T> head; //our head node(the front node)
        private Node<T> tail; //our tail node(the end node)

        /// <summary>
        /// Constructor for library
        /// </summary>
        public _2022_Spring_TannerEnsign_MyListLibrary()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        /// <summary>
        /// Add, this method adds an item of type T to our list.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            Node<T> temp = new Node<T>(item);
            if(Count > 0)
            {
                tail.next = temp;
                tail = tail.next;
                Count++;
            }
            else
            {
                Count++;
                head = temp;
                tail = temp;
            }
        }

        public int Count { get; set; } //getter and setter for our count


        /// <summary>
        /// IndexOf, this method finds the index of a specific item the user wants.
        /// Uses a while loop to walk through the tree.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            int idx = 0;
            Node<T> temp = head;
            while(temp != null)
            {
                if (temp.data.Equals(item))
                    return idx;
                temp = temp.next;
                idx++;
            }
            return -1;
        }


        /// <summary>
        /// Contains, this method checks to see if the item the user is looking for
        /// is in the list.
        /// </summary>
        /// <param name="item"> The item to check for </param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            if (IndexOf(item) >= 0)
                return true;
            else
                return false;
        }



        /// <summary>
        /// Insert, inserts a specific item at a specific index
        /// </summary>
        /// <param name="idx"> The index to be inserted at </param>
        /// <param name="item"> The item being inserted </param>
        public void Insert(int idx, T item)
        {
            Node<T> temp = new Node<T>(item);
            Node<T> curr = head;

            for(int i = 0; i < idx - 1; i++)
            {
                curr = curr.next;
            }
            temp.next = curr.next;
            curr.next = temp;
            Count++;
        }

        /// <summary>
        /// RemoveAt, removes the item at an specific index
        /// </summary>
        /// <param name="idx"> The index to remove </param>
        public void RemoveAt(int idx)
        {           
            Node<T> curr = head;

            for (int i = 0; i < idx - 1; i++)
            {
                curr = curr.next;
            }
            Node<T> temp = curr.next;
            curr.next = temp.next;
            Count--;
            
        }


        /// <summary>
        /// Clear, clears the whole linked list making it empty
        /// </summary>
        public void Clear()
        {
            Node<T> temp = new Node<T>();
            head = temp;
            tail = temp;
            Count = 0;
        }


        /// <summary>
        /// IEnumerable method that calls the GetEnumerator() method
        /// </summary>
        /// <returns> Our custom GetEnumerator method</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// IEnumerator method
        /// </summary>
        /// <returns>The data of our item</returns>
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                yield return temp.data;
                temp = temp.next;
            }
        }

    }
}
