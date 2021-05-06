using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
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
            Console.WriteLine("-----------------------");

            
        }
    }
}
