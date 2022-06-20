namespace CapaPresentacion
{
    partial class FrmMdiPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMdiPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transacionDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasAgendadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCont = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mENSUALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mASCOTASPORCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.mnuPrincipal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(874, 28);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.INICIOToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.doctorToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("artículosToolStripMenuItem.Image")));
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.artículosToolStripMenuItem.Text = "Mascotas";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.empleadosToolStripMenuItem.Text = "Propietarios";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.doctorToolStripMenuItem.Text = "Doctores";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transacionDeVentaToolStripMenuItem,
            this.citasAgendadasToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.operacionesToolStripMenuItem.Text = "Citas";
            // 
            // transacionDeVentaToolStripMenuItem
            // 
            this.transacionDeVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transacionDeVentaToolStripMenuItem.Image")));
            this.transacionDeVentaToolStripMenuItem.Name = "transacionDeVentaToolStripMenuItem";
            this.transacionDeVentaToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.transacionDeVentaToolStripMenuItem.Text = "Agendar una cita";
            this.transacionDeVentaToolStripMenuItem.Click += new System.EventHandler(this.transacionDeVentaToolStripMenuItem_Click);
            // 
            // citasAgendadasToolStripMenuItem
            // 
            this.citasAgendadasToolStripMenuItem.Name = "citasAgendadasToolStripMenuItem";
            this.citasAgendadasToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.citasAgendadasToolStripMenuItem.Text = "Citas agendadas";
            this.citasAgendadasToolStripMenuItem.Click += new System.EventHandler(this.citasAgendadasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENSUALToolStripMenuItem,
            this.mASCOTASPORCLIENTEToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // panelCont
            // 
            this.panelCont.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCont.Location = new System.Drawing.Point(0, 28);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(874, 464);
            this.panelCont.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(841, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mENSUALToolStripMenuItem
            // 
            this.mENSUALToolStripMenuItem.Name = "mENSUALToolStripMenuItem";
            this.mENSUALToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.mENSUALToolStripMenuItem.Text = "MENSUAL";
            this.mENSUALToolStripMenuItem.Click += new System.EventHandler(this.mENSUALToolStripMenuItem_Click);
            // 
            // mASCOTASPORCLIENTEToolStripMenuItem
            // 
            this.mASCOTASPORCLIENTEToolStripMenuItem.Name = "mASCOTASPORCLIENTEToolStripMenuItem";
            this.mASCOTASPORCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.mASCOTASPORCLIENTEToolStripMenuItem.Text = "MASCOTAS POR CLIENTE";
            this.mASCOTASPORCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.mASCOTASPORCLIENTEToolStripMenuItem_Click);
            // 
            // FrmMdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(874, 492);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMdiPrincipal";
            this.Text = "FrmMdiPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transacionDeVentaToolStripMenuItem;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasAgendadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENSUALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mASCOTASPORCLIENTEToolStripMenuItem;
    }
}