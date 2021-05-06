﻿using System;

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

            list.AddInReverseOrder(66);
            list.AddInReverseOrder(77);
            list.Display(); 
            Console.WriteLine("-----------------------");

            list.InsertAtParticularPosition(2, 30);
            list.Display();
            Console.WriteLine("-----------------------");

            list.DeleteFirst();
            list.Display();
            Console.WriteLine("-----------------------");

            list.DeleteLast();
            list.Display();
        }
    }
}
