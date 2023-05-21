using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linkedList \n delete the last element in the LinkedList of sequence 56->30->70");

            LinkedList list = new LinkedList();

            list.AddFirst(70);
            //list.Print();
            list.AddFirst(56);
            //list.Print();
            list.AddFirst(30);
            list.Print();
            Console.WriteLine("delete last");
            list.deletelast();
            
            list.Print();


            
        }
      
    }
}