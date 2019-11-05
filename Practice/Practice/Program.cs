using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            //Adding names
            names.Add("Dan");
            names.Add("Ryan");
            names.Add("Ann");
            names.Add("Sarah");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
