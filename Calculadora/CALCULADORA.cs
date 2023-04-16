using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraLibrary2;
namespace Calculadoraa
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }
        bool secuencia = true;
        Class1 op = new Class1();
        string operacion, borrado;
        double numero1, numero2, resultado;
        private void bt1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "1";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "2";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "2";
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "3";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "3";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "4";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "5";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "5";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "6";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "6";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "7";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "8";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Resultado.Text = "";
                Resultado.Text = "9";
                secuencia = false;
            }
            else
            {
                Resultado.Text = Resultado.Text + "9";
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (Resultado.Text == "0")
            {
                return;
            }
            else
            {
                Resultado.Text = Resultado.Text + "0";
            }
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(Resultado.Text);
            secuencia = true;
        }

        private void btmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(Resultado.Text);
            secuencia = true;
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(Resultado.Text);
            secuencia = true;
        }

        private void btporcentaje_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = ((numero1 * numero2) / 100);
            Resultado.Text = resultado.ToString();
            secuencia = true;
        }

        private void btfraccion_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = 1 / numero1;
            Resultado.Text = resultado.ToString();
            secuencia = true;
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Resultado.Text);
            if (operacion == "+")
            {
                Resultado.Text = op.Sumar(numero1, numero2).ToString();
               /* resultado = numero1 + numero2;
                Resultado.Text = resultado.ToString();
                secuencia = true;*/
            }
            if (operacion == "-")
            {
                Resultado.Text = op.Restar(numero1, numero2).ToString();
                /*
                resultado = numero1 - numero2;
                Resultado.Text = resultado.ToString();
                secuencia = true;*/
            }
            if (operacion == "*")
            {
                Resultado.Text = op.Multiplicar(numero1, numero2).ToString();
                /* resultado = numero1 * numero2;
                Resultado.Text = resultado.ToString();
                secuencia = true;*/
            }
            if (operacion == "/")
            {
                Resultado.Text = op.Dividir(numero1, numero2).ToString();
                /* resultado = numero1 / numero2;
                Resultado.Text = resultado.ToString();
                secuencia = true;*/
            }


        }

        private void btretroceso_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = Resultado.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            Resultado.Text = borrado;

            if (Resultado.Text == "")
            {
                Resultado.Text = "0";
                secuencia = true;
            }
            if (Resultado.Text == "-")
            {
                Resultado.Text = "0";
                secuencia = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;

        }

        private void btraiz_Click(object sender, EventArgs e)
        {
            Resultado.Text = op.RaizCuadrada(numero1).ToString();
            /*
            numero1 = double.Parse(Resultado.Text);
            resultado = Math.Sqrt(numero1);
            Resultado.Text = resultado.ToString();
            secuencia = true;*/
        }

        private void btpotencia_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = numero1 * numero1;
            Resultado.Text = resultado.ToString();
            secuencia = true;
        }

        private void CALCULADORA_Load(object sender, EventArgs e)
        {

        }

        private void btpunto_Click(object sender, EventArgs e)
        {

        }

        private void btsen_Click(object sender, EventArgs e)
        {
            Resultado.Text = op.Seno(numero1).ToString();
            /*
            numero1 = Convert.ToDouble(Resultado.Text);
            double x = numero1* Math.PI / 180.0;
            Resultado.Text = Math.Sin(x).ToString();*/
            
        }

        private void btcos_Click(object sender, EventArgs e)
        {
            Resultado.Text = op.Coseno(numero1).ToString();
            /*numero1 = Convert.ToDouble(Resultado.Text);
            double x = numero1 * Math.PI / 180.0;
            Resultado.Text = Math.Cos(x).ToString();*/
        }

        private void bttan_Click(object sender, EventArgs e)
        {
            Resultado.Text = op.Tangente(numero1).ToString();
            /*numero1 = Convert.ToDouble(Resultado.Text);
            double x = numero1 * Math.PI / 180.0;
            Resultado.Text = Math.Tan(x).ToString();*/
        }

        private void btFactorial_Click(object sender, EventArgs e)
        {
            Resultado.Text = op.factorial(numero1).ToString();
            /*
            int factorial = 0, total = 1;
            factorial = Convert.ToInt32(Resultado.Text);
            for (int i = 1; i <= factorial; i++)
            {
                total *= i;
            }
            Resultado.Text = total.ToString();*/
        }

        private void btMenosUno_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = Math.Pow(numero1, -1);
            Resultado.Text = resultado.ToString();
        }

        private void btlog_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Resultado.Text);
            resultado = Math.Log(numero1);
            Resultado.Text = resultado.ToString();
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btresta_Click(object sender, EventArgs e)
        {
            Resultado.Text = op.Restar(numero1, numero2).ToString();

            /*operacion = "-";
            numero1 = double.Parse(Resultado.Text);
            secuencia = true;*/
        }
    }
}