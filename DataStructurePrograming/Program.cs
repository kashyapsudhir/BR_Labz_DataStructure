using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linkedList \n Insert 40 after 30 56,30,40,70");

            LinkedList list = new LinkedList();

            list.AddFirst(56);
            //list.Print();
            list.AddFirst(30);
            //list.Print();
            list.AddFirst(70);
            list.Print();

            Console.WriteLine("insert 40 after 30");

            list.InsertAfter(30, 40);

            list.Print();




        }
      
    }
}