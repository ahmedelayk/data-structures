using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Queue<T>
    {
        private List<T> data;
        private int head;
        private int size;
        public Queue()
        {
            size = 0;
            head = 0;
            data = new List<T>();
        }
        public void Enqueue(T element)
        {
            data.Add(element);
            size++;
        }
        public T Dequeue()
        {
            T returnedValue = data[head];
            data.Remove(data[head]);
            size--;
            return returnedValue;
        }
        public void PrintQueue()
        {
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
        public bool isEmpty()
        {
            return size == 0;
        }
    }
}
