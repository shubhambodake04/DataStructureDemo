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
            list.AddInReverseOrder(66);
            list.AddInReverseOrder(77);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
        }
    }
}
