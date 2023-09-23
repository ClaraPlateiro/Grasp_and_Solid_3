//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class AllInOnePrinter
    {
        private IPrinter printer; // Usamos la interfaz IPrinter

    
        public AllInOnePrinter(IPrinter printer)
        {
            this.printer = printer;
        }
        public void PrintRecipe(Recipe recipe)
        {
            string content = recipe.GetTextToPrint();
            this.printer.Print(content);
        }
    }
}


