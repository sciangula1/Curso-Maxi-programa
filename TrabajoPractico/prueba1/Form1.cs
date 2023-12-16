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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;

                MessageBox.Show("Error");
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            }

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                MessageBox.Show("Error");
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                MessageBox.Show("Error");
            }
            else
            {
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;

            }
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            }

            if (txtApellido.Text.Length > 0)
                if (txtNombre.Text.Length > 0)
                    if (txtEdad.Text.Length > 0)
                        if (txtDireccion.Text.Length > 0)
                        { 
                            lwDatos.Items.Add(txtApellido.Text);

                            lwDatos.Items.Add(txtNombre.Text);

                            lwDatos.Items.Add(txtEdad.Text);

                            lwDatos.Items.Add(txtDireccion.Text); 
                        }

             else 
            {
                MessageBox.Show("¡NO PUEDE QUEDAR NINGUN CAMPO VACIO!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = string.Empty;

            txtNombre.Text = string.Empty;

            txtEdad.Text = string.Empty;

            txtDireccion.Text = string.Empty;

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length > 15)
            {
                MessageBox.Show("Error");
                txtApellido.Text = "";
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 15)
            {
                MessageBox.Show("Error");
                txtNombre.Text="";
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Length > 25)
            {
                MessageBox.Show("Error");
                txtDireccion.Text = "";
            }
        }
    }
}
