using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

      


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Final.Clases.cContactos persona = new Final.Clases.cContactos();

            persona.Nombre = txtNombres.Text;
            persona.Email = txtEmail.Text;
            persona.Direccion = txtDireccion.Text;
            persona.Cumpleaños = (dtCumpleaños.Text);
            persona.Telefono = txtTelefono.Text;
            persona.Celular = Convert.ToInt32(txtCelular.Text);
            persona.Guardar();

            txtNombres.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtTelefono.Clear();


            MessageBox.Show("Se guardo correctamente", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home formulario = new Home();
            formulario.Visible = true;
            Visible = false;
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            txtDireccion.BackColor = Color.White;
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            txtDireccion.BackColor = Color.LightSteelBlue;
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            txtNombres.BackColor = Color.White;
        }

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            txtNombres.BackColor = Color.LightSteelBlue;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.LightSteelBlue;
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.BackColor = Color.LightSteelBlue;
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            txtTelefono.BackColor = Color.White;
        }

        private void txtCelular_Enter(object sender, EventArgs e)
        {
            txtCelular.BackColor = Color.LightSteelBlue;
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            txtCelular.BackColor = Color.White;
        }


        private void validacion()
        {
            var vr = !string.IsNullOrEmpty(txtNombres.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtCelular.Text);
            btnGuardar.Enabled = vr;

        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtCelular, "Se debe de ingresar solo Numeros");
            }
            else
            {
                errorProvider1.SetError(txtCelular, "");
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }
    }
}
