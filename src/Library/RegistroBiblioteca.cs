using System.Collections.Generic;

namespace Ejercicio_103;
public class RegistroBiblioteca
{
    private static readonly RegistroBiblioteca _instancia = new RegistroBiblioteca();
    private List<IMaterial> _materiales;


    private RegistroBiblioteca()
    {
        _materiales = new List<IMaterial>();
    }

    public static RegistroBiblioteca ObtenerInstancia()
    {
        return _instancia;
    }

    public void AgregarMaterial (IMaterial material)
    {
        _materiales.Add(material);
    }

    public List<IMaterial> ObtenerMateriales()
    {
        return _materiales;
    }

}