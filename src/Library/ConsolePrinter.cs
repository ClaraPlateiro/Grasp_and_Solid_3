using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
}