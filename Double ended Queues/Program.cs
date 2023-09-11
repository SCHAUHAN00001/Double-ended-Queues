using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    public class Node
    {
        public int element;
        public Node next;
        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class DeQueLinked
    {
        private Node front;
        private Node rear;
        private int size;

        public DeQueLinked()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addlast(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
                front = newest;
            else
                rear.next = newest;
            rear = newest;
            size = size + 1;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                front = newest;
                rear = newest;
            }
            else
            {
                newest.next = front;
                front = newest;
            }
            size = size + 1;
        }

        public int removeFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int e = front.element;
            front = front.next;
            size = size - 1;
            if (isEmpty())
                rear = null;
            return e;
        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = front;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i = i + 1;
            }
            rear = p;
            p = p.next;
            int e = p.element;
            rear.next = null;
            size = size - 1;
            return e;
        }

        public int search(int key)
        {
            Node p = front;
            int index = 0;
            while (p != null)
            {
                if (p.element == key)
                    return index;
                p = p.next;
                index = index + 1;
            }
            return -1;
        }

        public void display()
        {
            Node p = front;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public int first()
        {
            if (isEmpty())
            {
                Console.WriteLine("DeQueue is Empty");
                return -1;
            }
            return front.element;
        }

        public int last()
        {
            if (isEmpty())
            {
                Console.WriteLine("DeQueue is Empty");
                return -1;
            }
            return rear.element;
        }

        static void Main(string[] args)
        {
            DeQueLinked d = new DeQueLinked();
            Console.WriteLine("Creating a Double ended queue: addlast()");
            d.addlast(1);
            d.addlast(2);
            d.addlast(3);
            d.addlast(4);
            d.addlast(5);
            d.addlast(6);
            d.display();
            Console.WriteLine("Size: " + d.length());
            Console.WriteLine();
            Console.WriteLine("Adding elemnet at first: addfirst()");
            d.addFirst(55);
            d.display();
            Console.WriteLine("Size: " + d.length());
            Console.WriteLine();
            Console.WriteLine("Removing last elemnet: removelast()");
            d.removeLast();
            d.display();
            Console.WriteLine("Size: " + d.length());
            Console.WriteLine();
            Console.WriteLine("Removing first element: removefirst()");
            d.removeFirst();
            d.display();
            Console.WriteLine("Size: " + d.length());
            Console.WriteLine();
            Console.WriteLine("Finding first element: first() --> "+ d.first());
            Console.WriteLine("Finding last element: last() -->" + d.last());
            Console.WriteLine("Searching element 3: index -->" +d.search(3) );
            Console.ReadLine();





        }
    }
}
