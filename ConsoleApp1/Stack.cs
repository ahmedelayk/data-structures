using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stack<T>
    {
        private T[] data;
        int top;
        public Stack(int size)
        {
            data = new T[size];
            top = -1;
        }
        public void push(T element)
        {
            data[++top] = element;
        }
        public T pop()
        {
            //if (isEmpty())
            //{
            //    //return -1;
            //}
            //else
            //{
                return data[top--];
            //}
        }
        public bool isEmpty()
        {
            return top == -1;
        }
    }
}
