using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES_BASICAS_COLA
{
    internal class Program
    {
        static int maxSize = 10;
        static int[] queueArray = new int[maxSize];
        static int front = 0;
        static int rear = -1;
        static int itemCount = 0;

        static void Enqueue(int item)
        {
            if (itemCount < maxSize)
            {
                if (rear == maxSize - 1)
                    rear = -1;

                queueArray[++rear] = item;
                itemCount++;
            }
            else
            {
                Console.WriteLine("Queue is full");
            }
        }

        static int Dequeue()
        {
            if (itemCount > 0)
            {
                int item = queueArray[front++];
                if (front == maxSize)
                    front = 0;

                itemCount--;
                return item;
            }
            else
            {
                Console.WriteLine("Queue is empty");
                return -1; // or throw an exception
            }
        }

        static void Main(string[] args)
        {
            Enqueue(10);
            Enqueue(20);
            Enqueue(30);

            Console.WriteLine("Dequeued: " + Dequeue()); // Output: 10
            Console.WriteLine("Dequeued: " + Dequeue()); // Output: 20
            Console.ReadLine();
        }
    }
}
