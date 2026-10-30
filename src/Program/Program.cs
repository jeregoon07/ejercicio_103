//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Library;

using Ejercicio_103;
public class Program
{
    static void Main()
    {
        RegistroBiblioteca registro = RegistroBiblioteca.ObtenerInstancia();

        Libro libro1 = new Libro("El coronel no tiene quien le escriba", "LOM3");
        Libro libro2 = new Libro("Cronica de una muerta anunciada", "LOM4");

        Revista revista1= new Revista("El Observador", "ROM2");

        DVD dVD1= new DVD("El padrino", "D0T");

        registro.AgregarMaterial(libro1);
        registro.AgregarMaterial(libro2);
        registro.AgregarMaterial(revista1);
        registro.AgregarMaterial(dVD1);

        Console.WriteLine("== Inspeccion de materiales ==");

        InsepectorMateriales insepector = new InsepectorMateriales();
        foreach(IMaterial material in registro.ObtenerMateriales())
        {
            material.Aceptar(insepector);
        }
        RegistroBiblioteca registro1 = RegistroBiblioteca.ObtenerInstancia();
        RegistroBiblioteca registro2 = RegistroBiblioteca.ObtenerInstancia();
    }
}