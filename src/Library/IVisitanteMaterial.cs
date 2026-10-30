namespace Ejercicio_103;
public interface IVisitanteMaterial
{
    void Visitar(Libro libro);
    void Visitar(Revista revista);
    void Visitar(DVD dvd);
}