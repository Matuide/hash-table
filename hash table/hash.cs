using System;
using System.Collections.Generic;
using System.Text;

namespace hash_table
{
    class hash
    {
        string[,] tableofHash = new string[10, 2];
        public void AddToTable(string name,string age)
        {
            bool hashed = false;
            int ASCIIsum = 0, modValue;
            for(int i = 0; i < name.Length; i++)
            {
                ASCIIsum = ASCIIsum + name[i];
            }
            modValue = ASCIIsum % 10;
            while (!hashed)
            {
                int count = 0;
                if (tableofHash[modValue, 0] == null)
                {
                    tableofHash[modValue, 0] = name;
                    tableofHash[modValue, 1] = Convert.ToString(age);
                    hashed = true;
                }
                else
                {
                    modValue++;
                    count++;
                }
                if (count == 10)
                {
                    hashed = true;
                    Console.WriteLine("table is full");
                }
            }
        }
       public void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tableofHash[i, 0] + " : " + tableofHash[i, 1] + " ||| ");
            }
        }
    }
}
