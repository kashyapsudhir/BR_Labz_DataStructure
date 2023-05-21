using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linkedList \n Delete 40 from list");

            LinkedList list = new LinkedList();

            list.AddFirst(56);
            //list.Print();
            list.AddFirst(30);
            //list.Print();
            list.AddFirst(40);
            //list.Print();
            list.AddFirst(70);
            list.Print();

            list.Delete(40);
            Console.WriteLine("40 has deleted from Linkedlist");

            list.Print();





        }

    }
}