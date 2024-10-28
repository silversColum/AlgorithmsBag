using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBag
{
    public class LinkedList<T>
    {
        //private Node<T> head;
        //private Node<T> tail;
        //private int size;

        //public LinkedList() 
        //{ 
        //    size = 0;
        //}
        //public void Add(T item)
        //{
        //    Node<T> node = new Node<T>(item);

        //    if (size ==  0) head = tail = node;
        //    else if (size == 1) head.next = tail = node;
        //    else tail = tail.next = node;
        //}

        private Node<T>? head;
        private int count;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public int Count => count;

        public Node<T>? Head => head;
    }
}
