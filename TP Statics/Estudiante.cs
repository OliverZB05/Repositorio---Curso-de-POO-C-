using System;
using System.Text;


namespace BibliotecaClases
{
    public class Estudiante
    {
        // ==================== ATRIBUTOS DE INSTANCIA ====================
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;

        // ==================== ATRIBUTOS ESTÁTICOS ====================
        private static Random random;
        private static int cantidadEstudiantes;

        // ==================== CONSTRUCTOR ESTÁTICO ====================
        static Estudiante()
        {
            random = new Random();
        }

        // ==================== CONSTRUCTOR DE INSTANCIA ====================
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            // Las notas se inicializan en 0 por defecto (int)
            cantidadEstudiantes++;
        }

        // ==================== MÉTODOS SETTER ====================
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        // ==================== MÉTODO PRIVADO CalcularPromedio ====================
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2.0f;
        }

        // ==================== MÉTODO CalcularNotaFinal ====================
        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }

        // ==================== MÉTODO Mostrar ====================
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");

            double notaFinal = this.CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }

        // ==================== MÉTODOS ESTÁTICOS ====================
        public static int ObtenerCantidadEstudiantes()
        {
            return cantidadEstudiantes;
        }

        public static void ReiniciarContador()
        {
            cantidadEstudiantes = 0;
        }
    }
}