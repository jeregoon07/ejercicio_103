using System.Dynamic;

namespace Ejercicio_103;
public class DVD: IMaterial
{
    public string Titulo{get; private set;}
    public string Codigo{get; private set;}

    public DVD(string titulo, string codigo)
    {
        Titulo=titulo;
        Codigo=codigo;
    }
    public void Aceptar(IVisitanteMaterial visitante)
    {
        visitante.Visitar(this);
    }
}