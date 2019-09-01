using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "1";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "0";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Respuesta.Text = Respuesta.Text + "9";
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Respuesta.Text);
            Respuesta.Clear();
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Respuesta.Text);
            Respuesta.Clear();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Respuesta.Text);
            Respuesta.Clear();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Respuesta.Text);
            Respuesta.Clear();
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            operacion = "%";
            primero = double.Parse(Respuesta.Text);
            Respuesta.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Respuesta.Text);

            switch(operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    Respuesta.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    Respuesta.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    Respuesta.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    Respuesta.Text = resultado.ToString();
                    break;
                case "%":
                    resultado = primero - (primero*(segundo*.01));
                    Respuesta.Text = resultado.ToString();
                    break;
            }
        }

        private void ClearRecent_Click(object sender, EventArgs e)
        {
            Respuesta.Clear();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            Respuesta.Clear();
        }
    }
}
