using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linked List

            /*LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("-----------------------");

            list.AddInReverseOrder(60);
            list.AddInReverseOrder(74);
            list.Display(); 
            Console.WriteLine("-----------------------");

            list.InsertAtParticularPosition(3, 40);
            list.Display();
            Console.WriteLine("-----------------------");

            list.SearchValue(60);
            list.Display();
            Console.WriteLine("-----------------------");

            list.DeleteFirst();
            list.Display();
            Console.WriteLine("-----------------------");

            list.DeleteLast();
            list.Display();
            Console.WriteLine("-----------------------");*/

            //Stack
            /*LinkedListStack list = new LinkedListStack();
            list.push(56);
            list.push(30);
            list.push(70);
            Console.WriteLine("------------------");
            list.Display();
            Console.WriteLine("------------------");
            list.IsEmpty();
            Console.WriteLine("------------------");
            list.Display();*/

            //Queue
            LinkedListQueue list = new LinkedListQueue();
            list.Enqueue(70);
            list.Enqueue(30);
            list.Enqueue(56);
            Console.WriteLine("------------------");
            list.Display();
            Console.WriteLine("------------------");
            list.Dequeue();
            list.Display();


        }
    }
}
