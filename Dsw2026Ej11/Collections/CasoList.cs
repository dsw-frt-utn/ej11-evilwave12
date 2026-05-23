namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>) ✅
//Incluir un método para agregar alumnos a la lista ✅
//Incluir un método para retornar la lista ✅
//Incluir un método para buscar un alumno por nombre ✅
//Incluir un método para eliminar un alumno (debe recibir un alumno) ✅
//Incluir un método para eliminar un alumno en una determinada posición de la lista ✅
public class CasoList
{
    private List<Alumno> alumnos = new();

    public void AgregarAlumno(params Alumno[] alumnos)
    {
        this.alumnos.AddRange(alumnos);
    }
    public List<Alumno> ObtenerLista()
    {
        return alumnos;
    }
    public Alumno? BuscarAlumnoPorNombre(string nombre)
    {
        return alumnos.Find(a => a.Nombre == nombre);
    }
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }
    public void EliminarAlumnoPorPosicion(int index)
    {
        alumnos.RemoveAt(index);
    }
}
