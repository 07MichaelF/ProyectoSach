﻿
namespace ProyectoGestionSach
{
    partial class FrmEditarHabitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarHabitacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.tb_TempAlta = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_TempBaja = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Descrp = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_TipoHab = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_CodHab = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Guardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 44);
            this.panel1.TabIndex = 92;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(699, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 89;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tb_TempAlta
            // 
            this.tb_TempAlta.AutoRoundedCorners = true;
            this.tb_TempAlta.BorderRadius = 21;
            this.tb_TempAlta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TempAlta.DefaultText = "";
            this.tb_TempAlta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_TempAlta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_TempAlta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TempAlta.DisabledState.Parent = this.tb_TempAlta;
            this.tb_TempAlta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TempAlta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TempAlta.FocusedState.Parent = this.tb_TempAlta;
            this.tb_TempAlta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_TempAlta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TempAlta.HoverState.Parent = this.tb_TempAlta;
            this.tb_TempAlta.Location = new System.Drawing.Point(399, 218);
            this.tb_TempAlta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TempAlta.Name = "tb_TempAlta";
            this.tb_TempAlta.PasswordChar = '\0';
            this.tb_TempAlta.PlaceholderText = "";
            this.tb_TempAlta.SelectedText = "";
            this.tb_TempAlta.ShadowDecoration.Parent = this.tb_TempAlta;
            this.tb_TempAlta.Size = new System.Drawing.Size(292, 44);
            this.tb_TempAlta.TabIndex = 127;
            // 
            // tb_TempBaja
            // 
            this.tb_TempBaja.AutoRoundedCorners = true;
            this.tb_TempBaja.BorderRadius = 21;
            this.tb_TempBaja.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TempBaja.DefaultText = "";
            this.tb_TempBaja.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_TempBaja.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_TempBaja.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TempBaja.DisabledState.Parent = this.tb_TempBaja;
            this.tb_TempBaja.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TempBaja.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TempBaja.FocusedState.Parent = this.tb_TempBaja;
            this.tb_TempBaja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_TempBaja.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TempBaja.HoverState.Parent = this.tb_TempBaja;
            this.tb_TempBaja.Location = new System.Drawing.Point(399, 143);
            this.tb_TempBaja.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TempBaja.Name = "tb_TempBaja";
            this.tb_TempBaja.PasswordChar = '\0';
            this.tb_TempBaja.PlaceholderText = "";
            this.tb_TempBaja.SelectedText = "";
            this.tb_TempBaja.ShadowDecoration.Parent = this.tb_TempBaja;
            this.tb_TempBaja.Size = new System.Drawing.Size(292, 44);
            this.tb_TempBaja.TabIndex = 126;
            // 
            // tb_Descrp
            // 
            this.tb_Descrp.AutoRoundedCorners = true;
            this.tb_Descrp.BorderRadius = 21;
            this.tb_Descrp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Descrp.DefaultText = "";
            this.tb_Descrp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Descrp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Descrp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Descrp.DisabledState.Parent = this.tb_Descrp;
            this.tb_Descrp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Descrp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Descrp.FocusedState.Parent = this.tb_Descrp;
            this.tb_Descrp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Descrp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Descrp.HoverState.Parent = this.tb_Descrp;
            this.tb_Descrp.Location = new System.Drawing.Point(51, 303);
            this.tb_Descrp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Descrp.Name = "tb_Descrp";
            this.tb_Descrp.PasswordChar = '\0';
            this.tb_Descrp.PlaceholderText = "";
            this.tb_Descrp.SelectedText = "";
            this.tb_Descrp.ShadowDecoration.Parent = this.tb_Descrp;
            this.tb_Descrp.Size = new System.Drawing.Size(292, 44);
            this.tb_Descrp.TabIndex = 125;
            // 
            // tb_TipoHab
            // 
            this.tb_TipoHab.AutoRoundedCorners = true;
            this.tb_TipoHab.BorderRadius = 21;
            this.tb_TipoHab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TipoHab.DefaultText = "";
            this.tb_TipoHab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_TipoHab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_TipoHab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TipoHab.DisabledState.Parent = this.tb_TipoHab;
            this.tb_TipoHab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_TipoHab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TipoHab.FocusedState.Parent = this.tb_TipoHab;
            this.tb_TipoHab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_TipoHab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_TipoHab.HoverState.Parent = this.tb_TipoHab;
            this.tb_TipoHab.Location = new System.Drawing.Point(51, 223);
            this.tb_TipoHab.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TipoHab.Name = "tb_TipoHab";
            this.tb_TipoHab.PasswordChar = '\0';
            this.tb_TipoHab.PlaceholderText = "";
            this.tb_TipoHab.SelectedText = "";
            this.tb_TipoHab.ShadowDecoration.Parent = this.tb_TipoHab;
            this.tb_TipoHab.Size = new System.Drawing.Size(292, 44);
            this.tb_TipoHab.TabIndex = 124;
            // 
            // tb_CodHab
            // 
            this.tb_CodHab.AutoRoundedCorners = true;
            this.tb_CodHab.BorderRadius = 21;
            this.tb_CodHab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_CodHab.DefaultText = "";
            this.tb_CodHab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_CodHab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_CodHab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodHab.DisabledState.Parent = this.tb_CodHab;
            this.tb_CodHab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_CodHab.Enabled = false;
            this.tb_CodHab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodHab.FocusedState.Parent = this.tb_CodHab;
            this.tb_CodHab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_CodHab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_CodHab.HoverState.Parent = this.tb_CodHab;
            this.tb_CodHab.Location = new System.Drawing.Point(51, 143);
            this.tb_CodHab.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CodHab.Name = "tb_CodHab";
            this.tb_CodHab.PasswordChar = '\0';
            this.tb_CodHab.PlaceholderText = "";
            this.tb_CodHab.SelectedText = "";
            this.tb_CodHab.ShadowDecoration.Parent = this.tb_CodHab;
            this.tb_CodHab.Size = new System.Drawing.Size(292, 44);
            this.tb_CodHab.TabIndex = 123;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ActiveBorderThickness = 1;
            this.btn_Cancelar.ActiveCornerRadius = 20;
            this.btn_Cancelar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.ButtonText = "Cancelar";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.IdleBorderThickness = 1;
            this.btn_Cancelar.IdleCornerRadius = 20;
            this.btn_Cancelar.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Cancelar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Cancelar.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btn_Cancelar.Location = new System.Drawing.Point(384, 389);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(180, 62);
            this.btn_Cancelar.TabIndex = 122;
            this.btn_Cancelar.TabStop = false;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.ActiveBorderThickness = 1;
            this.btn_Guardar.ActiveCornerRadius = 20;
            this.btn_Guardar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btn_Guardar.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.ButtonText = "Guardar";
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.IdleBorderThickness = 1;
            this.btn_Guardar.IdleCornerRadius = 20;
            this.btn_Guardar.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btn_Guardar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Guardar.IdleLineColor = System.Drawing.Color.DarkGray;
            this.btn_Guardar.Location = new System.Drawing.Point(163, 389);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(180, 62);
            this.btn_Guardar.TabIndex = 121;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 119;
            this.label6.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 120;
            this.label5.Text = "Tipo Habitación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 118;
            this.label4.Text = "Precio Temp Baja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 117;
            this.label3.Text = "Precio Temp Alta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 116;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 40);
            this.label1.TabIndex = 115;
            this.label1.Text = "Editar Habitación";
            // 
            // FrmEditarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 508);
            this.Controls.Add(this.tb_TempAlta);
            this.Controls.Add(this.tb_TempBaja);
            this.Controls.Add(this.tb_Descrp);
            this.Controls.Add(this.tb_TipoHab);
            this.Controls.Add(this.tb_CodHab);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarHabitacion";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Guna.UI2.WinForms.Guna2TextBox tb_TempAlta;
        private Guna.UI2.WinForms.Guna2TextBox tb_TempBaja;
        private Guna.UI2.WinForms.Guna2TextBox tb_Descrp;
        private Guna.UI2.WinForms.Guna2TextBox tb_TipoHab;
        private Guna.UI2.WinForms.Guna2TextBox tb_CodHab;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}