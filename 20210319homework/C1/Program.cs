using System;
using System.Collections.Generic;

namespace C1
{
    class Program
    {
        static void Main(string[] args){
            GenericList<int> intlist = new GenericList<int>();
            for(int x = 0; x < 10; x++) {
                intlist.Add(x);
            }
            intlist.ForEach(node => Console.WriteLine(node.Data));

            int maxVal = -1;
            intlist.ForEach(node => {
                maxVal = Math.Max(maxVal, node.Data);
            });
            Console.WriteLine("maxVal: " + maxVal);

            int minVal = 11;
            intlist.ForEach(node => {
                minVal = Math.Min(minVal, node.Data);
            });
            Console.WriteLine("minVal: " + minVal);

            int ret = 0;
            intlist.ForEach(node => {
                ret += node.Data;
            });
            Console.WriteLine("sum: " + ret);
        }
    }

    public class Node<T> {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t) {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T> {
        private Node<T> head;
        private Node<T> tail;

        public GenericList() {
            tail = head = null;
        }

        public Node<T> Head {
            get => head;
        }
        public void Add(T t) {
            Node<T> n = new Node<T>(t);
            if(tail == null) {
                head = tail = n;
            }else {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<Node<T>> action) {
            for (Node<T> node = this.Head; node != null; node = node.Next) {
                action(node);
            }
        }
    }
}
