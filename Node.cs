using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBag
{
    public class Node<T>
    {
        //public Node<T> next;
        //public T value;
        //public Node(T value)
        //{
        //    this.value = value;
        //}
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}