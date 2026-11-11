using System;
using BibliotecaClases; // Namespace de la biblioteca

namespace Curso_de_POO___GOB_CIUDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear tres objetos de la clase Estudiante
            Estudiante estudiante1 = new Estudiante("Juan", "Perez", "A001");
            Estudiante estudiante2 = new Estudiante("Maria", "Gomez", "A002");
            Estudiante estudiante3 = new Estudiante("Carlos", "Lopez", "A003");

            // Cargar notas para los tres alumnos
            // Estudiante 1: aprobado
            estudiante1.SetNotaPrimerParcial(8);
            estudiante1.SetNotaSegundoParcial(7);

            // Estudiante 2: aprobado
            estudiante2.SetNotaPrimerParcial(6);
            estudiante2.SetNotaSegundoParcial(9);

            // Estudiante 3: desaprobado (una nota menor a 4)
            estudiante3.SetNotaPrimerParcial(2);
            estudiante3.SetNotaSegundoParcial(6);

            // Mostrar los datos de los tres estudiantes
            Console.WriteLine("----- Datos de los estudiantes -----");
            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(estudiante3.Mostrar());
            Console.WriteLine("-----------------------------------");

            // Mostrar la cantidad total de objetos creados
            Console.WriteLine($"Cantidad de estudiantes creados: {Estudiante.ObtenerCantidadEstudiantes()}");
        }
    }
}