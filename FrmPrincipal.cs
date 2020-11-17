using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcimc
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtvalor1;
            txtvalor1.Focus();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, resultado;
            peso = Convert.ToDouble(txtvalor1.Text);
            altura = Convert.ToDouble(txtvalor2.Text);
            resultado = (peso / (altura * altura));
            Lblmostrar.Text = resultado.ToString("F");
            txtvalor1.Text = "";
            txtvalor2.Text = "";
            if (resultado < 18){
                MessageBox.Show("Magreza", "IMC", MessageBoxButtons.OK);
            }
            else if (resultado <= 24){
                MessageBox.Show("Normal", "IMC", MessageBoxButtons.OK);
            }
            else if (resultado <= 29){
                MessageBox.Show("Sobrepeso", "IMC", MessageBoxButtons.OK);
            }
            else if (resultado <= 39){
                MessageBox.Show("Obesidade", "IMC", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("obesidade grave", "IMC", MessageBoxButtons.OK);
            }
        }
    }
}
