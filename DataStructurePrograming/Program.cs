using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linkedList \n Ability to insert 30 between 56 and 70");

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