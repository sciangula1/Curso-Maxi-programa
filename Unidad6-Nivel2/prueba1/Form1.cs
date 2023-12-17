using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int Resultado;
            try
            {
                Resultado = calcular();
                lblResultado.Text =" "+ Resultado;
            }
            catch (Exception)
            {
                MessageBox.Show("ingresar solo numeros");
                lblResultado.Text = " ";

            }

            finally
            {
                txbNum1.Text = "";
                txbNum2.Text = "";
            }
        }

        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txbNum1.Text);
                b = int.Parse(txbNum2.Text);

                r = a * b;

                return r;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
