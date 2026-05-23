namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno ✅
//Incluir un método para agregar un alumno al diccionario ✅
//Incluir un método para buscar un alumno utilizando la clave ✅
//Incluir un método para retornar el diccionario ✅
//Incluir un método para eliminar un alumno utilizando la clave ✅
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos = new();

    public void AgregarAlumno(int legajo, Alumno al)
    {
        alumnos.Add(legajo, al);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        return alumnos.TryGetValue(legajo, out Alumno alumno) ? alumno : null;           
    }

    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        alumnos.Remove(legajo);
    }
}
