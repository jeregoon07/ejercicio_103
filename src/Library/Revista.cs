using System.Dynamic;

namespace Ejercicio_103;
public class Revista: IMaterial
{
    public string Titulo{get; private set;}
    public string Codigo{get; private set;}

    public Revista(string titulo, string codigo)
    {
        Titulo=titulo;
        Codigo=codigo;
    }
    public void Aceptar(IVisitanteMaterial visitante)
    {
        visitante.Visitar(this);
    }
}