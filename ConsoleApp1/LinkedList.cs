using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
    public class LinkedList<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = null;
        }
        public void AddLast(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        public void AddFirst(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (head == null) head = newNode;
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        public bool FindElement(T element)
        {
            Node<T> current = head;
            while (current != null)
            {
                if ((EqualityComparer<T>.Default.Equals(current.data, element)))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
        public int FindElementIndex(T element)
        {
            Node<T> current = head;
            int index = 0;
            while (current != null)
            {
                if ((EqualityComparer<T>.Default.Equals(current.data, element)))
                {
                    return index;
                }
                current = current.next;
                index++;
            }
            return -1;
        }
        public void Reverse()
        {
            Node<T> prev, curr, next;
            prev = null;
            curr = head;
            next = curr.next;
            while(next != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }
        public void Print()
        {
            Node<T> current = head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
