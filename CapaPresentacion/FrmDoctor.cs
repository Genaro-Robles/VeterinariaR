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
    public partial class FrmDoctor : Form
    {

        ClsDoctorEnt ent = new ClsDoctorEnt();
        ClsDoctorNeg neg = new ClsDoctorNeg();


        public FrmDoctor()
        {
            InitializeComponent();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            
            txtnombre.ReadOnly = true;
            txtdni.ReadOnly = true;
            txtapellidos.ReadOnly = true;
            txtespecialidad.ReadOnly = true;
            txtbuscar.ReadOnly = false;
            botones(true, false, false, false, true);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            
            ent.nombre = txtnombre.Text;
            ent.apellidos = txtapellidos.Text;
            ent.dni = txtdni.Text;
            ent.especialidad = txtespecialidad.Text;
            neg.InsertarDoctorNeg(ent);
            MessageBox.Show("Doctor ingresado correctamente");
            LimpiarTexto();

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
                MessageBox.Show("Ingrese nombre del doctor a buscar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscar.Focus();
                return;
            }
            DataTable dt = new DataTable();
            
            ent.nombre = txtbuscar.Text;
            dt = neg.BuscarDoctorNeg(ent);
            if(dt.Rows.Count > 0)
            {
                txtcod.Text = dt.Rows[0][0].ToString();
                txtnombre.Text = dt.Rows[0][1].ToString();
                txtapellidos.Text = dt.Rows[0][2].ToString();
                txtdni.Text = dt.Rows[0][3].ToString();
                txtespecialidad.Text = dt.Rows[0][4].ToString();
            }
            txtnombre.ReadOnly = false;
            txtdni.ReadOnly = false;
            txtapellidos.ReadOnly = false;
            txtespecialidad.ReadOnly = false;
            txtbuscar.ReadOnly = false;
            botones(true, false, true, true, false);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Equals(""))
            {
                botones(true, false, false, false, true);
                txtnombre.ReadOnly = true;
                txtdni.ReadOnly = true;
                txtapellidos.ReadOnly = true;
                txtespecialidad.ReadOnly = true;
                txtbuscar.ReadOnly = false;
            }
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarTexto();

            txtnombre.ReadOnly = false;
            txtdni.ReadOnly = false;
            txtapellidos.ReadOnly = false;
            txtespecialidad.ReadOnly = false;
            txtbuscar.ReadOnly = false;
            botones(false, true, false, false, true);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcod.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un doctor para poder eliminarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscar.Focus();
                return;
            }
            ent.codigo = Convert.ToInt32(txtcod.Text);
            neg.EliminarDoctorNeg(ent);
            MessageBox.Show("Doctor eliminado correctamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            
            ent.codigo = Convert.ToInt32(txtcod.Text);
            ent.nombre = txtnombre.Text;
            ent.apellidos = txtapellidos.Text;
            ent.dni = txtdni.Text;
            ent.especialidad = txtespecialidad.Text;
            neg.ActualizarDoctorNeg(ent);
            MessageBox.Show("Doctor actualizado correctamente");
            LimpiarTexto();
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
            txtbuscar.Text = "";
        }
    }
}
