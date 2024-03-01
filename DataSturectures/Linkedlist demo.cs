using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSturectures
{

    public class LinkedList
    {
        private Node head;
        private Node tail;//This will have latest node
        public int Count;


        // constructer
        public LinkedList()
        {
            head = new Node();
            tail = head;
        }
        // operations
        // to add a element at last
        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            tail.Next = newNode;
            tail = newNode;
            Count++;
        }
        // to add a element in alist at first
        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;//new node will have reference of head's next reference
            head.Next = newNode;//and now head will refer to new node
            Count++;
        }
        // to remove  a element in a list
        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }
        // to print the all elements in list
        public void PrintAllNodes()
        {

            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
    }
}
