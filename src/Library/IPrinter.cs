using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void Print(Recipe recipe);
    }
}

//Principio de Segregación de Interfaces (ISP): Al definir la interfaz IPrinter con un único método (Print) específico para la funcionalidad de impresión.