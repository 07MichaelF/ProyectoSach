﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionSach
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            toolTips();
            AbrirFrm(new FrmInicio(), null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolTips()
        {
            this.ToolTip.SetToolTip(this.btnCerrar, "Cerrar");
            this.ToolTip.SetToolTip(this.btnMinimizar, "Minimizar");

        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmInicio(), sender);
        }

        private Form ActivoFrm;
        public void AbrirFrm(Form frmHijo, object btnSender)
        {
            if (ActivoFrm != null)
            {
                ActivoFrm.Close();
            }
            ActivoFrm = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            pnl_Contenedor.Controls.Add(frmHijo);
            pnl_Contenedor.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmEstadisticas(), sender);
        }

        private void btn_Habitaciones_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmRegistroHabitacion(), sender);
        }

        private void btn_Huespedes_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmRegistroHuesped(), sender);
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmRegistroReservaciones(), sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmRegistroUsuario(), sender);
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            AbrirFrm(new FrmReportes(), sender);
        }
    }
}
