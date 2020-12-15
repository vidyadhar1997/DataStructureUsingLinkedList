using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingLinkedList
{
    class LinkedList
    {
        internal Node head;

        /// <summary>
        /// Add methode to add the specific data into linked list
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("inserted into the linked list", node.data);
        }

        /// <summary>
        /// Add2 methode to add the specified data into linked list.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add2(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("inserted into the linked list", node.data);
        }

        /// <summary>
        /// Display methode for display the specific data.
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Console.WriteLine("Squence of linked list");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
