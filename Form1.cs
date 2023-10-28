using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, resultado;
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            resultado = peso / (altura * altura);

            txtResultado.Text = resultado.ToString();

            if (resultado <= 18.5)
            {
                lblResultado.Text = ("Abaixo do peso");
            }else if(resultado <  24.9)
            {
                lblResultado.Text = ("Peso ideal(parabéns)");
            }else if(resultado < 29.9)
            {
                lblResultado.Text = ("Levemente acima do peso");
            }else if(resultado < 34.9)
            {
                lblResultado.Text = ("Obesidade grau 1");
            }else if(resultado < 39.9)
            {
                lblResultado.Text = ("Obesidade grau 2( severa)");
            }else 
            {
                lblResultado.Text = ("Obesidade 3(mórbida)");
            }
          
            

            
        }
    }
}
