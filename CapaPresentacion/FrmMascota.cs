using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;


namespace CapaPresentacion
{
    public partial class FrmMascota : Form
    {

        ClsMascotaEnt ent = new ClsMascotaEnt();
        ClsMascotaNeg neg = new ClsMascotaNeg();


        public FrmMascota()
        {
            InitializeComponent();
        }

        
        void ListarPropietario(ComboBox cbo)
        {

            cbo.DataSource = neg.ListarPropietarioneg();
            cbo.DisplayMember = "Nombres";
            cbo.ValueMember = "idpropietario";
        }
        

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            ListarPropietario(cboprop);
            
            txtnombre.ReadOnly = true;
            txttipo.ReadOnly = true;
            txttam.ReadOnly = true;
            txtedad.ReadOnly = true;
            txtbuscar.ReadOnly = false;
            cboprop.SelectedValue = 1;
            botones(true, false, false, false, true);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            
            ent.nombre = txtnombre.Text;
            ent.tipo = txttipo.Text;
            ent.tam = Convert.ToInt32(txttam.Text);
            ent.edad = Convert.ToInt32(txtedad.Text);
            ent.idpropietario = Convert.ToInt32(cboprop.SelectedValue);
            neg.InsertarMascotaNeg(ent);
            MessageBox.Show("Mascota ingresada correctamente");
            LimpiarTexto();
            cboprop.SelectedValue = 1;

        }

        public void botones(bool nuevo, bool grabar, bool actualizar, bool eliminar, bool buscar)
        {
            btnnuevo.Enabled = nuevo;
            btninsertar.Enabled = grabar;
            btnactualizar.Enabled = actualizar;
            btneliminar.Enabled = eliminar;
            btnbuscar.Enabled = buscar;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de la mascota a buscar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscar.Focus();
                return;
            }
            DataTable dt = new DataTable();
            
            ent.nombre = txtbuscar.Text;
            dt = neg.BuscarMascotaNombreNeg(ent);
            if(dt.Rows.Count > 0)
            {
                txtcod.Text = dt.Rows[0][0].ToString();
                txtnombre.Text = dt.Rows[0][1].ToString();
                txttipo.Text = dt.Rows[0][2].ToString();
                txttam.Text = dt.Rows[0][3].ToString();
                txtedad.Text = dt.Rows[0][4].ToString();
                cboprop.SelectedValue = dt.Rows[0][5].ToString();
            }
            txtnombre.ReadOnly = false;
            txttipo.ReadOnly = false;
            txttam.ReadOnly = false;
            txtedad.ReadOnly = false;
            txtbuscar.ReadOnly = false;
            botones(true, false, true, true, false);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Equals(""))
            {
                botones(true, false, false, false, true);
                txtnombre.ReadOnly = true;
                txttipo.ReadOnly = true;
                txttam.ReadOnly = true;
                txtedad.ReadOnly = true;
                txtbuscar.ReadOnly = false;
            }
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
            cboprop.SelectedValue = 1;

            txtnombre.ReadOnly = false;
            txttipo.ReadOnly = false;
            txttam.ReadOnly = false;
            txtedad.ReadOnly = false;
            txtbuscar.ReadOnly = false;
            botones(false, true, false, false, true);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcod.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un producto para poder eliminarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscar.Focus();
                return;
            }
            ent.codigo = Convert.ToInt32(txtcod.Text);
            neg.EliminarMascotaNeg(ent);
            MessageBox.Show("Mascota eliminada correctamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            ent.codigo = Convert.ToInt32(txtcod.Text);
            ent.nombre = txtnombre.Text;
            ent.tipo = txttipo.Text;
            ent.tam = Convert.ToInt32(txttam.Text);
            ent.edad = Convert.ToInt32(txtedad.Text);
            ent.idpropietario = Convert.ToInt32(cboprop.SelectedValue);
            neg.ActualizarMascotaNeg(ent);
            MessageBox.Show("Mascota actualizada correctamente");
            LimpiarTexto();
            cboprop.SelectedValue = 1;
        }

        void LimpiarTexto()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    this.txtnombre.Focus();
                }
            }
        }
    }
}
