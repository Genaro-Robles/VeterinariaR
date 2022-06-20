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
    public partial class FrmCitasAgendadas : Form
    {
        public FrmCitasAgendadas()
        {
            InitializeComponent();
        }

        ClsCitasNeg neg1 = new ClsCitasNeg();
        ClsCitasDetalles neg2 = new ClsCitasDetalles();

        void ListarMascota(ComboBox cbo)
        {
            cbo.DataSource = neg1.ListarMascotasneg();
            cbo.DisplayMember = "nombre";
            cbo.ValueMember = "idmascota";
        }

        private void FrmCitasAgendadas_Load(object sender, EventArgs e)
        {
            ListarMascota(cbomascota);
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            dgw1.DataSource = neg2.CitasFechaNeg(Convert.ToDateTime(dtpfechainicio.Value), 
                Convert.ToDateTime(dtpfechafin.Value),Convert.ToInt32(cbomascota.SelectedValue));
            Total();

        }

        private void dgw1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int n;
                this.dgw2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                n = Convert.ToInt32(dgw1.CurrentRow.Cells[0].Value);
                dgw2.DataSource = neg2.CitasDetalleNeg(n);
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        void Total()
        {
            double acumulador = 0;
            foreach (DataGridViewRow fila in dgw1.Rows)
            {
                acumulador += 1;
            }
            lbdTotal.Text = acumulador.ToString();
        }
    }
}
