using System;
using System.Text;

namespace GestionVehiculos
{
    public enum TipoVehiculo
    {
        Auto,
        Utilitario,
        SUV,
        Premium
    }

    public class Vehiculo
    {
        private string patente = "";
        private double precioBase;
        private int anioFabricacion;

        public string Patente
        {
            get { return patente; }
            set
            {
                if (EsPatenteValida(value))
                {
                    patente = value;
                }
            }
        }

        public double PrecioBase
        {
            set
            {
                if (value > 0)
                {
                    precioBase = value;
                }
            }
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Kilometraje { get; private set; }
        public TipoVehiculo Tipo { get; set; }

        public int AnioFabricacion
        {
            get { return anioFabricacion; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                {
                    anioFabricacion = value;
                }
            }
        }

        public int Antiguedad
        {
            get { return DateTime.Now.Year - anioFabricacion; }
        }

        public double PrecioFinal
        {
            get
            {
                double recargo = 0;

                switch (Tipo)
                {
                    case TipoVehiculo.Auto:
                        recargo = 0;
                        break;
                    case TipoVehiculo.Utilitario:
                        recargo = 0.10;
                        break;
                    case TipoVehiculo.SUV:
                        recargo = 0.20;
                        break;
                    case TipoVehiculo.Premium:
                        recargo = 0.35;
                        break;
                    default:
                        recargo = 0;
                        break;
                }

                return precioBase * (1 + recargo);
            }
        }

        public Vehiculo(string patente, double precioBase, string marca, string modelo, int anioFabricacion, TipoVehiculo tipo)
        {
            this.Patente = patente;
            this.PrecioBase = precioBase;
            this.Marca = marca;
            this.Modelo = modelo;
            this.AnioFabricacion = anioFabricacion;
            this.Tipo = tipo;
        }

        public void RegistrarRecorrido(int kilometros)
        {
            if (kilometros > 0)
            {
                Kilometraje += kilometros;
            }
        }

        public string ObtenerDescripcionTipo()
        {
            switch (Tipo)
            {
                case TipoVehiculo.Auto:
                    return "Vehículo compacto ideal para ciudad.";
                case TipoVehiculo.Utilitario:
                    return "Vehículo de carga y transporte.";
                case TipoVehiculo.SUV:
                    return "Vehículo familiar y todoterreno.";
                case TipoVehiculo.Premium:
                    return "Vehículo de lujo y alta gama.";
                default:
                    return "Tipo de vehículo desconocido.";
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--- Datos del Vehículo ---");
            sb.AppendLine("Patente: " + Patente);
            sb.AppendLine("Marca: " + Marca);
            sb.AppendLine("Modelo: " + Modelo);
            sb.AppendLine("Año de fabricación: " + AnioFabricacion);
            sb.AppendLine("Antigüedad: " + Antiguedad + " años");
            sb.AppendLine("Kilometraje: " + Kilometraje + " km");
            sb.AppendLine("Tipo: " + Tipo);
            sb.AppendLine("Descripción: " + ObtenerDescripcionTipo());
            sb.AppendLine("Precio final de alquiler: $" + PrecioFinal);

            return sb.ToString();
        }

        public static bool EsPatenteValida(string patente)
        {
            if (patente == null)
            {
                return false;
            }

            if (patente.Trim() == "")
            {
                return false;
            }

            if (patente.Length < 6 || patente.Length > 7)
            {
                return false;
            }

            return true;
        }
    }
}