using System;
using System.Collections.Generic;

namespace CaraLibro
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNames listNames = new ListNames();
            listNames.Saludar("Juan", "Pedro");
            Console.WriteLine(listNames.ToString());
        }

    }
    
}


