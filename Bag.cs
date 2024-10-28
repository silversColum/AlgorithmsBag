﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsBag
{
    public class Bag<T>
    {
        //public int size;
        //public void Add(Node<T> item)
        //{

        //}
        private LinkedList<T> list = new LinkedList<T>();

        public void Add(T element)
        {
            list.Add(element);
        }

        public int Size()
        {
            return list.Count;
        }

        public Iterator<T> GetIterator() 
        {
            return new Iterator<T>(list);
        }
    }
}