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
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Final.Clases.cContactos persona = new Final.Clases.cContactos();
            persona.Id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
            persona.Nombre = dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString();
            persona.Email = (dgv.Rows[dgv.CurrentRow.Index].Cells[2].Value.ToString());
            persona.Direccion = dgv.Rows[dgv.CurrentRow.Index].Cells[3].Value.ToString();
            persona.Cumpleaños = dgv.Rows[dgv.CurrentRow.Index].Cells[4].Value.ToString();
            persona.Telefono = dgv.Rows[dgv.CurrentRow.Index].Cells[5].Value.ToString();
            persona.Celular = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[6].Value.ToString());
            
            persona.Modificar();
            
            dgv.DataSource = persona.Mostrar();
            MessageBox.Show("Se modificaron los "+persona.Id+persona.Nombre+persona.Email);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Final.Clases.cContactos persona = new Final.Clases.cContactos();
            
            dgv.DataSource = persona.Mostrar();

        }

        private void Contactos_Load(object sender, EventArgs e)
        {
            Final.Clases.cContactos persona = new Final.Clases.cContactos();
            dgv.DataSource = persona.Mostrar();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Final.Clases.cContactos persona  = new Final.Clases.cContactos();
            persona.Id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
            persona.elimminarDato();
            MessageBox.Show("SE ELIMINO EL DATO", "ELINIMADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgv.DataSource = persona.Mostrar();


        }

        private void btnHom_Click(object sender, EventArgs e)
        {
            Home formulario = new Home ();
            formulario.Visible = true;
            Visible = false;



        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Final.Clases.cContactos persona = new Final.Clases.cContactos();
            persona.Id = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString());
            persona.Nombre = dgv.Rows[dgv.CurrentRow.Index].Cells[1].Value.ToString();
            persona.Email =(dgv.Rows[dgv.CurrentRow.Index].Cells[2].Value.ToString());
            persona.Direccion = dgv.Rows[dgv.CurrentRow.Index].Cells[3].Value.ToString();
            persona.Cumpleaños = dgv.Rows[dgv.CurrentRow.Index].Cells[4].Value.ToString();
            persona.Telefono = dgv.Rows[dgv.CurrentRow.Index].Cells[5].Value.ToString();
            persona.Celular = int.Parse(dgv.Rows[dgv.CurrentRow.Index].Cells[6].Value.ToString());




        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Final.Clases.cContactos persona = new Final.Clases.cContactos();
            //persona.Nombre = txtBuscar.Text;
            persona.Consultar();
            dgv.DataSource = persona.Mostrar();

        }
    }
}
