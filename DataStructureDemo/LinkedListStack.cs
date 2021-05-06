using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class LinkedListStack
    {
        internal Node top;
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                this.top = node;

            }
            else
            {
                Node temp = top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} insert into linked list", value);
        }

        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;

            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }

        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
