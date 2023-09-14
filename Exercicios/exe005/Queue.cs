using System;

namespace QueueClass
{
    public class Queue
    {
        static int MAX = 1000;
        int front = 0;
        int rear = -1;
        int[] queue = new int[MAX];

        public bool IsEmpty()
        {
            return (rear < front);
        }

        public bool Enqueue(int data)
        {
            if (rear >= MAX - 1)
            {
                Console.WriteLine("Queue Overflow");
                return false;
            }

            rear += 1;
            queue[rear] = data;
            return true;
        }

        public int Dequeue()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return 0;
            }

            int valor = queue[front];
            front += 1;
            return valor;
        }

        public void Peek()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            Console.WriteLine($"O primeiro elemento da fila é: {queue[front]}");
        }

        public void PrintQueue()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            Console.WriteLine("Itens da fila:");
            for (int i = front; i <= rear; i++)
            {
                string texto = $"Queue[{queue[i]}]";
                Console.WriteLine(texto);
            }

        }
    }
}