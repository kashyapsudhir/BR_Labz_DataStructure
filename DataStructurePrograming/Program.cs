using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linkedList \n Search the element available or not in list ");

            LinkedList list = new LinkedList();

            list.AddFirst(56);
            //list.Print();
            list.AddFirst(30);
            //list.Print();
            list.AddFirst(70);
            list.Print();

            DsNode result = list.Search(30);
            if (result != null)
            {
                Console.WriteLine("node 30 is availabe.");
            }
            else
            {
                Console.WriteLine("node 30 is not availabe.");
            }

            list.Print();




        }
      
    }
}