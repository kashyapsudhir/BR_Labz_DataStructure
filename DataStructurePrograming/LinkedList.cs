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
        public void AddFirst(int data)
        {
            DsNode newNode = new DsNode(data);
            if (this.head == null)
            {
                this.head = newNode;
                return; 
            }
            newNode.next = this.head;
            head = newNode;
           
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
