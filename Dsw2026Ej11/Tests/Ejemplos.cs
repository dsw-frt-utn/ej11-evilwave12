namespace Dsw2026Ej11.Tests;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista ✅
    //Listar por consola los alumnos ✅
    //Buscar por nombre un alumno que exista y mostrar por consola ✅
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe" ✅
    //Eliminar un alumno y listar por consola los alumnos ✅
    //Eliminar el primer elemento de la lista y listar por consola los alumnos ✅
    public static void EjemploList()
    {
        var casoList = new CasoList();

        var al1 = new Alumno(1,"sapo", 7.85);
        var al2 = new Alumno(2,"naza", 7.89);
        var al3 = new Alumno(3,"berna", 7.5);

        casoList.AgregarAlumno(al1,al2,al3);

        Console.WriteLine(casoList.BuscarAlumnoPorNombre("naza"));

        if(casoList.BuscarAlumnoPorNombre("Tejerizo") is null)
        {
            Console.WriteLine("No existe");
        }

        casoList.EliminarAlumno(al2);
        Console.WriteLine($"\nAlumnos después de eliminar a {al2.Nombre}");
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

        var nombrePrimerAlumno = casoList.ObtenerLista().ElementAt(0).Nombre;
        casoList.EliminarAlumnoPorPosicion(0);
        Console.WriteLine($"\nAlumnos después de eliminar al primer elemento ({nombrePrimerAlumno})");
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario ✅
    //Listar por consola los alumnos ✅
    //Buscar un alumno por clave y mostrar por consola ✅
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe" ✅
    //Eliminar un alumno por clave y listar por consola los alumnos ✅
    public static void EjemploDictionary()
    {
        var casoDictionary = new CasoDictionary();

        var al1 = new Alumno(1, "sapo", 7.85);
        var al2 = new Alumno(2, "naza", 7.89);
        var al3 = new Alumno(3, "berna", 7.5);
        casoDictionary.AgregarAlumno(57799, al1);
        casoDictionary.AgregarAlumno(58340, al2);
        casoDictionary.AgregarAlumno(56123, al3);

        foreach (var al in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine(al);
        }

        Console.WriteLine($"\nAlumno encontrado: {casoDictionary.BuscarAlumno(57799)}");

        if (casoDictionary.BuscarAlumno(577) is null)
        {
            Console.WriteLine("\nNo existe");
        }
        else
        {
            Console.WriteLine($"\nAlumno encontrado: {casoDictionary.BuscarAlumno(577)}");
        }

        casoDictionary.EliminarAlumno(56123);
        Console.WriteLine($"\nAlumno con legajo 56123 eliminado\n");
        foreach(var al in casoDictionary.ObtenerDiccionario())
        {
            Console.WriteLine(al);
        }
        

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var casoLinq = new CasoLinq();
        Console.WriteLine($"Primer libro: {casoLinq.GetPrimero()}\n");
        Console.WriteLine($"Último libro: {casoLinq.GetUltimo()}\n");
        Console.WriteLine($"Total de precios: ${casoLinq.GetTotalPrecios()}\n");
        Console.WriteLine($"Promedio de precios: ${casoLinq.GetPromedioPrecios():F2}\n");

        Console.WriteLine("Libros con Id mayor a 15:");
        foreach (var l in casoLinq.GetListById())
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("\nListado de libros");
        foreach (var l in casoLinq.GetLibros())
        {
            Console.WriteLine(l);
        }

        Console.WriteLine($"\nLibro con el mayor precio: {casoLinq.GetMayorPrecio()}\n");
        Console.WriteLine($"Libro con el menor precio: {casoLinq.GetMenorPrecio()}\n");

        Console.WriteLine($"Libros con precio mayor al promedio (${Libro.CrearLista().Average(l => l.Precio):F2}):");
        foreach (var l in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("\nListado de libros en forma descentente por título:");
        foreach (var l in casoLinq.GetLibrosOrdenadosxNombre())
        {
            Console.WriteLine(l);
        }
    }
}
