using System;

namespace DoublyLinkedList
{
    class Node
    {
        /*Node class representes the node of doubly linked list.
         * It consists of the information part and links to
         * its succeeding and preceeding nodes
         * in terms of next and previous node.*/
        public int rollNumber;
        public string name;
        public Node next;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }
    class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addnote()/*Adds a new node*/
        {
            int rollNO;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNO = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNO;
            newnode.name = nm;
            /*Checks if the list is empty*/
            if (START == null || rollNO <= START.rollNumber)
            {
                if ((START != null) && (rollNO == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }
        }
    }
}