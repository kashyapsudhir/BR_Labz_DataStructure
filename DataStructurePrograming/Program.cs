using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linked List Program");

            LinkedList list = new LinkedList();

            list.AddFirst(56);
            //list.Print();
            list.AddFirst(30);
            //list.Print();
            list.AddFirst(70);
            list.Print();


            
        }
      
    }
}