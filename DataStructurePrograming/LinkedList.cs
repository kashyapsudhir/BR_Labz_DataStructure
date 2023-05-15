using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DataStructurePrograming
{
    public class LinkedList
    {
        internal DsNode head;
        internal void AddFirst(int data)
        {
            DsNode newNode = new DsNode(data);
            if (this.head == null)
            {
                this.head = newNode;
            }

            else
            {
                DsNode temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = newNode;
            }

            Console.WriteLine("{0} Inserted into linked list", newNode.data);
        }

        internal void Print()
        {

            DsNode temp = head;

            if (temp == null)
            {

                Console.WriteLine("Linkedlist is empty");
                return;
            }

            while (temp != null)
            {

                Console.Write(temp.data + " ");

                temp = temp.next;
            }
        }

    }
}
