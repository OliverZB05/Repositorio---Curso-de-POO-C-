using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Dejamos este método vacío para que el diseñador no tire error
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Limpiar la lista por si se calculó algo antes
            lstDetalle.Items.Clear();

            // 2. Validar que el monto sea un número entero positivo
            if (!int.TryParse(txtMonto.Text, out int monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto válido mayor que cero (solo números enteros).",
                                "Monto inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            // 3. Definir las denominaciones de billetes (de mayor a menor)
            int[] denominaciones = { 20000, 10000, 2000, 1000, 500 };

            // Variable para ir restando el dinero
            int restante = monto;

            // 4. Calcular cuántos billetes de cada denominación se necesitan
            foreach (int billete in denominaciones)
            {
                int cantidad = restante / billete; // División entera
                restante = restante % billete;     // El resto que queda

                // Mostrar en el ListBox (formateando con separador de miles)
                string textoBillete = billete.ToString("N0");
                lstDetalle.Items.Add($"{cantidad} billete(s) de ${textoBillete}");
            }

            // 5. Si quedó un resto que no se pudo entregar, avisar con un MessageBox
            if (restante > 0)
            {
                MessageBox.Show($"Importe no entregado: ${restante}",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}