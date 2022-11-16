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
                newnode.next = START;
                if (START != null)
                    START.prev = newnode;
                newnode.prev = null;
                START = newnode;
                return;
            }
            Node previous, current;
            for (current = previous = START; current != null && rollNO >= current.rollNumber; previous = current, current = current.next)
            {
                if (rollNO == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }
            /*On the execution of the above for loop, prev and 
             * current will point to those nodes between which the new node is to be inserted.*/
            newnode.next = current;
            newnode.prev = previous;

            /*If the node is to be inserted at the end of the list.*/
            if (current == null)
            {
                newnode.next = null;
                previous.next = newnode;
                return;
            }
            current.prev = newnode;
            previous.next = newnode;
        }
        
        /*Checks wheteher the specified node is present*/
        public bool Search(int rollNo, ref Node previous, ref Node current)
        {
            for ( previous = current = START; current != null && rollNo != current.rollNumber; previous = current,current = current.next)
            { }
            /*The above for loop traverses the list. If the specified node
             * is found then the function returns true, otherwise false.*/
            return (current != null);
        }
    }
}