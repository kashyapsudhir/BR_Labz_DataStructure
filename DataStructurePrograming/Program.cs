using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linked List Program");

            LinkedList list = new LinkedList();

            list.AddFirst(70);
            
            list.AddFirst(30);
            
            list.AddFirst(56);


            list.Print();

            //output 56,30,70
        }
      
    }
}