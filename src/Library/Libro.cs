namespace Ejercicio_103;
public class Libro : IMaterial
{
    public string Titulo{get; private set;}
    public string Codigo{get; private set;}



    public Libro(string titulo, string codigo)
    {
        Titulo=titulo;
        Codigo=codigo;
    }
    public void Aceptar(IVisitanteMaterial visitante)
    {
        visitante.Visitar(this);
    }
}