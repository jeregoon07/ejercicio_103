using System;
using System.Diagnostics.Contracts;

namespace Ejercicio_103;
public class InsepectorMateriales: IVisitanteMaterial
{
    public void Visitar(Libro libro)
    {
        Console.WriteLine("Libro: revisando estad de las páginas");
    }
    public void Visitar(Revista revista)
    {
        Console.WriteLine("Revista: revisando estad de la tapa");
    }
    public void Visitar(DVD dVD)
    {
        Console.WriteLine("DVD: verificando lectura del disco");
    }

}