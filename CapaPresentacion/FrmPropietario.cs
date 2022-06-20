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
    public partial class FrmPropietario : Form
    {

        ClsPropietarioEnt ent = new ClsPropietarioEnt();
        ClsPropietarioNeg neg = new ClsPropietarioNeg();


        public FrmPropietario()
        {
            InitializeComponent();
        }
        

        private void FrmPropietario_Load(object sender, EventArgs e)
        {
            
            txtnombre.ReadOnly = true;
            txtdni.ReadOnly = true;
            txtapellidos.ReadOnly = true;
            txtedad.ReadOnly = true;
            txtbuscar.ReadOnly = false;
            botones(true, false, false, false, true);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            bool a;
            if (chkboxA.Checked == true)
            {
                a = true;
            }
            else
            {
                a = false;
            }

            ent.nombre = txtnombre.Text;
            ent.apellidos = txtapellidos.Text;
            ent.edad = Convert.ToInt32(txtedad.Text);
            ent.dni = txtdni.Text;
            ent.activo = a;
            neg.InsertarPropietarioNeg(ent);
            MessageBox.Show("Propietario ingresado correctamente");
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
                MessageBox.Show("Ingrese nombre de la mascota a buscar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscar.Focus();
                return;
            }
            DataTable dt = new DataTable();
            
            ent.nombre = txtbuscar.Text;
            dt = neg.BuscarPropietarioNeg(ent);
            bool a;
            if(dt.Rows.Count > 0)
            {
                txtcod.Text = dt.Rows[0][0].ToString();
                txtnombre.Text = dt.Rows[0][1].ToString();
                txtapellidos.Text = dt.Rows[0][2].ToString();
                txtedad.Text = dt.Rows[0][3].ToString();
                txtdni.Text = dt.Rows[0][4].ToString();
                a = Convert.ToBoolean(dt.Rows[0][5]);
                if (a == true)
                {
                    chkboxA.Checked = true;
                }
                else
                {
                    chkboxA.Checked = false;
                }
            }
            txtnombre.ReadOnly = false;
            txtdni.ReadOnly = false;
            txtapellidos.ReadOnly = false;
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
                txtdni.ReadOnly = true;
                txtapellidos.ReadOnly = true;
                txtedad.ReadOnly = true;
                txtbuscar.ReadOnly = false;
            }
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarTexto();

            txtnombre.ReadOnly = false;
            txtdni.ReadOnly = false;
            txtapellidos.ReadOnly = false;
            txtedad.ReadOnly = false;
            txtbuscar.ReadOnly = false;
            botones(false, true, false, false, true);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcod.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un propietario para poder eliminarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbuscar.Focus();
                return;
            }
            ent.codigo = Convert.ToInt32(txtcod.Text);
            neg.EliminarPropietarioNeg(ent);
            MessageBox.Show("Propietario eliminado correctamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            bool a;
            if (chkboxA.Checked == true)
            {
                a = true;
            }
            else
            {
                a = false;
            }

            ent.codigo = Convert.ToInt32(txtcod.Text);
            ent.nombre = txtnombre.Text;
            ent.apellidos = txtapellidos.Text;
            ent.edad = Convert.ToInt32(txtedad.Text);
            ent.dni = txtdni.Text;
            ent.activo = a;
            neg.ActualizarPropietarioNeg(ent);
            MessageBox.Show("Propietario actualizado correctamente");
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
            chkboxA.Checked = false;
            txtbuscar.Text = "";
        }
    }
}
