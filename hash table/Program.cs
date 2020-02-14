using System;

namespace hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
            hash table = new hash();
            bool continued = true;
            while (continued == true)
            {
            Console.WriteLine("Name:  ");
            
            string name;
            string age;
            name = Console.ReadLine();
                Console.WriteLine("age:  ");
            age = Console.ReadLine();
            table.AddToTable(name,age);
                Console.WriteLine("add or print");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "add")
                {

                }
                else
                {
                    continued = false;
                }

            } 
            

            table.Print();
            
        
        }
    }
}
