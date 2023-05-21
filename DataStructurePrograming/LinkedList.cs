﻿using System;
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





        //public void InsertAfter(int key, int data)
        //{
        //    DsNode newNode = new DsNode(data);

        //    DsNode currentNode = head;
        //    while (currentNode != null)
        //    {
        //        if (currentNode.data == key)
        //        {
        //            newNode.next = currentNode.next;
        //            currentNode.next = newNode;
        //            break;
        //        }
        //        currentNode = currentNode.next;
        //    }
        //}

        public void deletelast()
        {
            if (this.head == null)
            {
                Console.WriteLine("the list is empty");

            }
            if (this.head.next == last)
            {
                this.head = null;
                last = null;
            }
            DsNode SecondLast = this.head;
            DsNode LastNode = head.next;
            while (LastNode.next != null)
            {
                LastNode = LastNode.next;
                SecondLast = SecondLast.next;

            }

            SecondLast.next = null;
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
