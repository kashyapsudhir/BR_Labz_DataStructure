using System;
 namespace DataStructurePrograming
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello linkedList \n Ability to delete the first element in the LinkedList of sequence 56->30->70");

            LinkedList list = new LinkedList();

            list.AddFirst(70);
            //list.Print();
            list.AddFirst(56);
            //list.Print();
            list.AddFirst(30);
            list.Print();

            list.Pop();
            Console.WriteLine("....Delete first.....");
            list.Print();


            
        }
      
    }
}