using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int resto = dividendo % divisor;
            txtResto.Text = resto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma1 = Convert.ToInt32(txtSoma1.Text); 
            int soma2 = Convert.ToInt32(txtSoma2.Text);
            int resto = soma1 + soma2;
            txtRestoSoma.Text = resto.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fator1 = Convert.ToInt32(txtFator1.Text);
            int fator2 = Convert.ToInt32(txtFator2.Text);
            int resultado = fator1 * fator2;
            txtResultado.Text = resultado.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int subtracao1 = Convert.ToInt32(txtSubtracao1.Text);
            int subtracao2 = Convert.ToInt32(txtsubtracao2.Text);
            int resultado = subtracao1 - subtracao2;
            txtResultado2.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int soma1 = Convert.ToInt32(txtSomaS1.Text);
            int soma2 = Convert.ToInt32(txtSomaS2.Text);
            int soma3 = Convert.ToInt32(txtSomaS3.Text);
            int resultado = soma1 + soma2 + soma3;
            txtResultado3.Text = resultado.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);
            int numero3 = Convert.ToInt32(txtNumero3.Text);
            int numero4 = Convert.ToInt32(txtNumero4.Text);
            int numero5 = Convert.ToInt32(txtNumero5.Text);
            int resultado = (numero1 + numero2) * (numero3 + numero4) /numero5s;
        }
    }
}
