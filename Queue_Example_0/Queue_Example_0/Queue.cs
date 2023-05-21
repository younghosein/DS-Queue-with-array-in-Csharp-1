using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Example_0
{
    class Queue
    {
        public int[] q;
        public int front;
        public int rear;
        public int max;

        public Queue(int size)
        {
            q = new int[size];
            max = size;
            rear = -1;
            front = 0;
        }
        public void print()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue Is Empty !");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(q[i] + " . ");
                }
            }
        }
        public void enqueue(int data)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Is Full !");
                return;
            }
            q[++rear] = data;
        }
        public int dequeue()
        {
            if (rear == front - 1)
            {
                Console.WriteLine("Queue Is Empty !");
                return -1;
            }
            Console.WriteLine($"{q[front]} Is Delete From Queue...");
            return q[++front];
        }
         public int avg()
        {
            int sum = 0;
            int c = 0;
            int avg;
            if (front == rear + 1)
            {
                Console.WriteLine("Queue Is Empty !");
                return -1;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    sum += q[i];
                    c++;
                }
                Console.Write($"Sum Is : {sum}\n");
                Console.Write($"Count Is : {c}\n");
                avg = sum / c;
                return avg;
            }
        }
    }
}
