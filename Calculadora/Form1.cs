using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double operador1;
        Double operador2;
        Double resultado;
        string operacion;
        Boolean inicioOperacion = true;


        public Form1()
        {
            InitializeComponent();
        }


        //NUMEROS
        private void btn0_Click(object sender, EventArgs e)
        {

            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
       
                pantalla.Text += btn0.Text;
            
            
        }                              

        private void btn1_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (inicioOperacion)
            {
                pantalla.Text = "";
                inicioOperacion = false;
            }
            pantalla.Text += btn9.Text;
        }

        //OPERACIONES DE 2 OPERADORES

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            operacion = "+";
            label1.Text = pantalla.Text;
            inicioOperacion = true;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            operacion = "-";
            label1.Text = pantalla.Text;
            inicioOperacion = true;
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            operacion = "X";
            label1.Text = pantalla.Text;
            inicioOperacion = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            operacion = "/";
            label1.Text = pantalla.Text;
            inicioOperacion = true;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Boolean chivato = true;
            operador2 = Double.Parse(pantalla.Text);
            switch (operacion)
            {
                case "+":
                    resultado = operador1 + operador2;
                    break;
                case "-":
                    resultado = operador1 - operador2;
                    break;
                case "X":
                    resultado = operador1 * operador2;
                    break;
                case "/":
                    if(operador2 == 0)
                    {
                        pantalla.Text = "No se puede dividir entre 0";
                        chivato = true;
                    }
                    else
                    {
                        resultado = operador1 / operador2;
                    }
                    break;
            }
            if (!chivato)
            {
                pantalla.Text = resultado.ToString();
            }
            
            label1.Text = "";
            inicioOperacion = true;
        }

        //OPERACIONES DE UBN SOLO OPERANDO

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            resultado = Math.Sqrt(operador1);
            pantalla.Text = resultado.ToString();
            inicioOperacion = true;
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            resultado = Math.Pow(operador1,2);
            pantalla.Text = resultado.ToString();
            inicioOperacion = true;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            if(operador1 == 90)
            {
                resultado = 0;
            }
            else
            {
                resultado = Math.Cos(operador1 * Math.PI / 180);
            }            
            pantalla.Text = resultado.ToString();
            inicioOperacion = true;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
           
            resultado = Math.Sin(operador1 * Math.PI / 180);
            pantalla.Text = resultado.ToString();
            inicioOperacion = true;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            operador1 = Double.Parse(pantalla.Text);
            resultado = Math.Tan(operador1 * Math.PI / 180);
            pantalla.Text = resultado.ToString();
            inicioOperacion = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            inicioOperacion = true;
        }
    }

   

}
