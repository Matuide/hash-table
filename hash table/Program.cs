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
                Tag:
                Console.WriteLine("add or print or remove");
                string answer = Console.ReadLine();
                if(answer.ToLower() == "add")
                {

                }
                else if(answer.ToLower()== "print")
                {
                    continued = false;
                }else if(answer.ToLower()== "remove")
                {
                    Console.WriteLine("name to remove");
                    name = Console.ReadLine();
                    table.Remove(name);
                    goto Tag;
                }

            } 
            

            table.Print();
            
        
        }
    }
}
