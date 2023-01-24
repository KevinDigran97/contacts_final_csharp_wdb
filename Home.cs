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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Agregar formulario = new Agregar();
            formulario.ShowDialog();

            formulario.Visible = true;
            Visible = false;
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            Contactos formulario = new Contactos();
            formulario.ShowDialog();
            Home formulario1 = new Home();
            formulario1.Visible = false;
            Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");

            int hora = DateTime.Now.Hour;
            if (hora >=6  && hora <12)
            {
                label2.Text = "Hola Buenos dias ";   
            }
            if (hora >=12 && hora < 17)
            {
                label2.Text = "Buenas tardes ";
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
