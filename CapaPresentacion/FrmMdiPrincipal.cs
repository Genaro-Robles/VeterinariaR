using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;


namespace CapaPresentacion
{
    public partial class FrmMdiPrincipal : Form
    {
        public FrmMdiPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AbrirFormularioHijo(object formularioHijo)
        {
            if (this.panelCont.Controls.Count > 0)
            {
                this.panelCont.Controls.RemoveAt(0);
            }
            Form fh = formularioHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();

        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMascota());
        }

        private void INICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelCont.Controls.Count > 0)
            {
                this.panelCont.Controls.RemoveAt(0);
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmPropietario());
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmDoctor());
        }

        private void transacionDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAgendarCita());
        }

        private void citasAgendadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmCitasAgendadas());
        }

        private void mENSUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Reportes.FrmCitas());
        }

        private void mASCOTASPORCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Reportes.frmPropMascota());
        }
    }
}
