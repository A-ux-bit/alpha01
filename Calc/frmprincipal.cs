using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class frmprincipal : Form
    {
        

        public frmprincipal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            Txt1valor.Focus();
            Txt1valor.Select();
        }

        private void Btnsomar_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 + valor2;
            LblMostrar.Text = resultado.ToString();
            Txt1valor.Text = "";
            txt2valor.Text = "";
        }

        private void Btnsubtrair_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 - valor2;
            LblMostrar.Text = resultado.ToString();
            Txt1valor.Text = "";
            txt2valor.Text = "";
        }

        private void Btnmultiplicar_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 * valor2;
            LblMostrar.Text = resultado.ToString();
            Txt1valor.Text = "";
            txt2valor.Text = "";

        }

        private void Btndividir_Click(object sender, EventArgs e)
        {
            Double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(Txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 / valor2;
            LblMostrar.Text = resultado.ToString();
            Txt1valor.Text = "";
            txt2valor.Text = "";
        }
    }
}
