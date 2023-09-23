using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void Print(string content)
        {
            File.WriteAllText("Recipe.txt", content);
        }
    }
}