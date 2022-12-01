using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Project
{
    internal class Work
    {
        private List<string> strings=new();
        public static class Chack
        {
            public static void Likes(string[] name)
            {
                
            }
        }
        public void SetUsers()
        {
            Console.WriteLine($"Введите имя оценившего");
            string enter = Console.ReadLine();
            strings.Add(enter);
        }
        public void CheckingAvailabilityUsers()
        {
            if ( strings.Count==0)
            {
                Console.WriteLine($"Никто не оценил");
            }
            else if (strings.Count == 1||strings.Count==0)
            {
                Console.WriteLine($"{strings[0]} оценил запись");
            }
            else
            {
                for (int i = 0; i < strings.Count; i++)
                {
                    Console.Write($"{strings[i]}");
                    if (i == strings.Count - 2)
                    {
                        Console.Write($" and ");
                    }
                    else if (i == strings.Count-1)
                    {
                        Console.Write($" оценили запись");
                    }
                    else
                    {
                        Console.Write($", ");
                    }
                }
            }
        }
    }
}
