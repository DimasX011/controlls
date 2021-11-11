using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLesson3
{
    class Inverter
    {
        
        public Inverter(string value)
        {
            List<string> storage = new List<string>();
            char[] reverse = value.ToCharArray();
            foreach(var c in reverse)
            {
                string a = c.ToString();
                storage.Add(a);
            }
            Inv(storage);
        }
        
        public void Inv(List<string> storage)
        {
            string Answer = "";

            for(int i =storage.Count-1; i > 0; i--)
            {
                Answer = Answer + storage[i];
            }
            Console.WriteLine(Answer);
        }

    }
}
