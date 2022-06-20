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
    public partial class FrmAgendarCita : Form
    {

        ClsCitasEnt ent = new ClsCitasEnt();
        ClsCitasNeg neg = new ClsCitasNeg();


        public FrmAgendarCita()
        {
            InitializeComponent();
        }

        private void FrmAgendarCita_Load(object sender, EventArgs e)
        {
            ListarDoctor(cbodoctor);
            ListarMascota(cbomascota);
        }

        void ListarMascota(ComboBox cbo)
        {

            cbo.DataSource = neg.ListarMascotasneg();
            cbo.DisplayMember = "nombre";
            cbo.ValueMember = "idmascota";
        }

        void ListarDoctor(ComboBox cbo)
        {

            cbo.DataSource = neg.ListarDoctoresneg();
            cbo.DisplayMember = "nombres";
            cbo.ValueMember = "iddoctor";
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            
            ent.mascota = Convert.ToInt32(cbomascota.SelectedValue);
            ent.enfermedad = txtenfermedad.Text;
            ent.tratamiento = txttratamiento.Text;
            ent.doctor = Convert.ToInt32(cbodoctor.SelectedValue);
            ent.fecha = dtpfecha.Value;
            neg.InsertarCitasNeg(ent);
            MessageBox.Show("Cita registrada correctamente");
            LimpiarTexto();

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }

        void LimpiarTexto()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    this.txtenfermedad.Focus();
                }
            }
        }
    }
}
