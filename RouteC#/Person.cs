using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RouteC_
{
    internal struct Person
    {
        public string[] name { get; set; }
        public int[] age { get; set; }

        public Person(int size)
        {
            name = new string[size];
            age = new int[size];
        }
       

        public void SetPerson(string name,int age,int index)
        {
            if (index >= 0 && index < name.Length)
            {
                this.name[index] = name;
                this.age[index] = age;
            }
        }
        public int GetPerson(string name) 
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name == this.name[i])
                   return this.age[i];
            }
            return -1;
        }
        public void DisplayAllPerson()
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"Name: {name[i]} || Age: {age[i]}");
            }
        }
        public int GetOldestPerson()
        {
            int oldestIndex = 0;
            for (int i = 1; i < age.Length; i++)
            {
                if (age[i] > age[oldestIndex])
                {
                    oldestIndex = i;
                }
            }
            return oldestIndex;
        }
    }
}
