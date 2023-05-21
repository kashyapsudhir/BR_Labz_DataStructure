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
        public DsNode head;
        public DsNode last;
        public void AddFirst(int data)
        {
            DsNode newNode = new DsNode(data);
            if (this.head == null)
            {
                this.head = newNode;
                return;
            }
            else
            {
                //...Node with data 56 is First Created Next Append 30 to 56 Finally Append 70 to 30 LinkedList Sequence: 56->30->70

                DsNode currentNode = this.head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
                //........................................

                //newNode.next = this.head;
                //this.head = newNode;
            }
        }

        public void Delete(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.data == key)
            {
                head = head.next;
                if (head == null)
                {
                    last = null;
                }
                return;
            }

            DsNode currentNode = head;
            while (currentNode.next != null)
            {
                if (currentNode.next.data == key)
                {
                    currentNode.next = currentNode.next.next;
                    if (currentNode.next == null)
                    {
                        last = currentNode;
                    }
                    return;
                }
                currentNode = currentNode.next;
            }

            Console.WriteLine($"value {key} not availale.");
        }

        public int SizeOfList()
        {
            int count = 0;
            DsNode currentNode = head;
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.next;
            }
            return count;
        }










        public void Print()
        {
            DsNode currentNode = this.head;
            
            while (currentNode != null)
            {
                Console.Write(currentNode.data + "-->");
                currentNode = currentNode.next;
            }
            
        }
            
               

        
    }
}
