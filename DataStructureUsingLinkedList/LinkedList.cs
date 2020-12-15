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

        /// <summary>
        /// Inserts at particular poistion ie 2.
        /// </summary>
        /// <param name="poistion">The poistion.</param>
        /// <param name="data">The data.</param>
        /// <returns>data at second poistion</returns>
        public Node InsertAtParticularPoistion(int poistion,int data)
        {
            if (poistion < 1)
                Console.WriteLine("Invalid Poistion");
            if (poistion == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while(poistion-- != 0)
                {
                    if (poistion == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (poistion != 1)
                    Console.WriteLine("poistion out of range");
            }
            return head;
        }

        /// <summary>
        /// Removes the first node from list.
        /// </summary>
        /// <returns>deleted node</returns>
        public Node removeFirstNode()
        {
            if (this.head == null)
                return null;
            Node temp = head;
            head = head.next;
            return temp;
        }

        /// <summary>
        /// Removes the last node from list.
        /// </summary>
        /// <returns>deleted node</returns>
        public Node removeLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Node lastElement = newNode.next;
            newNode.next = null;
            return lastElement;
        }
    }
}
