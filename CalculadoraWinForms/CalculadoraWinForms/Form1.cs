namespace CalculadoraWinForms
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        string operacion = "";
        bool nuevoNumero = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "1";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "2";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "3";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "4";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "5";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "6";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "7";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "8";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "9";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (nuevoNumero)
            {
                txtPantalla.Text = "0";
                nuevoNumero = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "0";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "+";
            nuevoNumero = true;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "-";
            nuevoNumero = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "*";
            nuevoNumero = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = "/";
            nuevoNumero = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            if (operacion == "+")
            {
                resultado = primerNumero + segundoNumero;
            }
            else if (operacion == "-")
            {
                resultado = primerNumero - segundoNumero;
            }
            else if (operacion == "*")
            {
                resultado = primerNumero * segundoNumero;
            }
            else if (operacion == "/")
            {
                if (segundoNumero == 0)
                {
                    MessageBox.Show("No se puede dividir por cero");
                    return;
                }
                resultado = primerNumero / segundoNumero;
            }

            txtPantalla.Text = resultado.ToString();
            nuevoNumero = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            primerNumero = 0;
            operacion = "";
            nuevoNumero = false;
        }
    }
}