using System;
using GestionVehiculos;

namespace GestionVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============================================
            // PRUEBA 1: Crear tres vehículos y mostrar datos iniciales
            // ============================================
            Console.WriteLine("=== PRUEBA 1: Datos iniciales ===\n");

            Vehiculo v1 = new Vehiculo("ABC123", 10000, "Toyota", "Corolla", 2020, TipoVehiculo.Auto);
            Vehiculo v2 = new Vehiculo("DEF456", 15000, "Ford", "Ranger", 2019, TipoVehiculo.Utilitario);
            Vehiculo v3 = new Vehiculo("GHI789", 25000, "BMW", "X5", 2022, TipoVehiculo.Premium);

            Console.WriteLine(v1.MostrarDatos());
            Console.WriteLine(v2.MostrarDatos());
            Console.WriteLine(v3.MostrarDatos());

            // ============================================
            // PRUEBA 2: Modificar marca y modelo de v1
            // ============================================
            Console.WriteLine("=== PRUEBA 2: Modificar marca y modelo de v1 ===\n");

            v1.Marca = "Honda";
            v1.Modelo = "Civic";
            Console.WriteLine(v1.MostrarDatos());

            // ============================================
            // PRUEBA 3: Registrar kilómetros y comprobar nuevo kilometraje
            // ============================================
            Console.WriteLine("=== PRUEBA 3: Registrar recorrido ===\n");

            Console.WriteLine("Kilometraje antes: " + v1.Kilometraje + " km");
            v1.RegistrarRecorrido(350);
            Console.WriteLine("Kilometraje después de 350 km: " + v1.Kilometraje + " km");

            v1.RegistrarRecorrido(-50);
            Console.WriteLine("Intento con -50 km (inválido): " + v1.Kilometraje + " km");

            v1.RegistrarRecorrido(0);
            Console.WriteLine("Intento con 0 km (inválido): " + v1.Kilometraje + " km");

            // ============================================
            // PRUEBA 4: Modificar precio base y ver nuevo precio final
            // ============================================
            Console.WriteLine("\n=== PRUEBA 4: Modificar precio base ===\n");

            Console.WriteLine("Precio final antes: $" + v1.PrecioFinal);
            v1.PrecioBase = 20000;
            Console.WriteLine("Precio final después de cambiar precio base a 20000: $" + v1.PrecioFinal);

            // ============================================
            // PRUEBA 5: Intentar datos inválidos y comprobar validaciones
            // ============================================
            Console.WriteLine("\n=== PRUEBA 5: Validaciones ===\n");

            Vehiculo v4 = new Vehiculo("", 10000, "Fiat", "Cronos", 2021, TipoVehiculo.Auto);
            Console.WriteLine("Patente inválida (vacía), patente real: " + (v4.Patente ?? "null"));

            Vehiculo v5 = new Vehiculo("XYZ999", -5000, "Fiat", "Cronos", 2021, TipoVehiculo.Auto);
            Console.WriteLine("Precio base inválido (-5000), precio final: $" + v5.PrecioFinal);

            Vehiculo v6 = new Vehiculo("XYZ999", 10000, "Fiat", "Cronos", 1800, TipoVehiculo.Auto);
            Console.WriteLine("Año inválido (1800), antigüedad calculada: " + v6.Antiguedad);

            // ============================================
            // PRUEBA 6: Usar EsPatenteValida() sin crear un vehículo
            // ============================================
            Console.WriteLine("\n=== PRUEBA 6: EsPatenteValida sin crear vehículo ===\n");

            Console.WriteLine("¿'ABC123' es válida? " + Vehiculo.EsPatenteValida("ABC123"));
            Console.WriteLine("¿'' es válida? " + Vehiculo.EsPatenteValida(""));
            Console.WriteLine("¿null es válida? " + Vehiculo.EsPatenteValida(null));
            Console.WriteLine("¿'AB1' es válida? " + Vehiculo.EsPatenteValida("AB1"));

            // ============================================
            // PRUEBA 7: Mostrar datos finales
            // ============================================
            Console.WriteLine("\n=== PRUEBA 7: Datos finales de v1 ===\n");

            Console.WriteLine(v1.MostrarDatos());

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}