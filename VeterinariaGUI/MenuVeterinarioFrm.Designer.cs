﻿namespace VeterinariaGUI
{
    partial class MenuVeterinarioFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVeterinarioFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.VeterinarioCmb = new System.Windows.Forms.Panel();
            this.AgregarVeterinarioBtn = new System.Windows.Forms.Button();
            this.BuscarVeterinarioBtn = new System.Windows.Forms.Button();
            this.TipoVeterinarioCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VeterinarioDtg = new System.Windows.Forms.DataGridView();
            this.DateVeterinarios = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            this.VeterinarioCmb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinarioDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Controls.Add(this.MinimizarBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu Mascotas";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(787, 6);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(25, 25);
            this.CerrarBtn.TabIndex = 7;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBtn.Image")));
            this.MinimizarBtn.Location = new System.Drawing.Point(756, 6);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.TabIndex = 6;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click);
            // 
            // VeterinarioCmb
            // 
            this.VeterinarioCmb.BackColor = System.Drawing.Color.DarkOrange;
            this.VeterinarioCmb.Controls.Add(this.DateVeterinarios);
            this.VeterinarioCmb.Controls.Add(this.AgregarVeterinarioBtn);
            this.VeterinarioCmb.Controls.Add(this.BuscarVeterinarioBtn);
            this.VeterinarioCmb.Controls.Add(this.TipoVeterinarioCmb);
            this.VeterinarioCmb.Controls.Add(this.label2);
            this.VeterinarioCmb.Location = new System.Drawing.Point(0, 37);
            this.VeterinarioCmb.Name = "VeterinarioCmb";
            this.VeterinarioCmb.Size = new System.Drawing.Size(1080, 190);
            this.VeterinarioCmb.TabIndex = 4;
            // 
            // AgregarVeterinarioBtn
            // 
            this.AgregarVeterinarioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AgregarVeterinarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarVeterinarioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarVeterinarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgregarVeterinarioBtn.Image")));
            this.AgregarVeterinarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarVeterinarioBtn.Location = new System.Drawing.Point(71, 84);
            this.AgregarVeterinarioBtn.Name = "AgregarVeterinarioBtn";
            this.AgregarVeterinarioBtn.Size = new System.Drawing.Size(89, 70);
            this.AgregarVeterinarioBtn.TabIndex = 9;
            this.AgregarVeterinarioBtn.Text = "Agregar Veterinario";
            this.AgregarVeterinarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarVeterinarioBtn.UseVisualStyleBackColor = false;
            this.AgregarVeterinarioBtn.Click += new System.EventHandler(this.AgregarVeterinarioBtn_Click);
            // 
            // BuscarVeterinarioBtn
            // 
            this.BuscarVeterinarioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarVeterinarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarVeterinarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarVeterinarioBtn.Image")));
            this.BuscarVeterinarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarVeterinarioBtn.Location = new System.Drawing.Point(631, 84);
            this.BuscarVeterinarioBtn.Name = "BuscarVeterinarioBtn";
            this.BuscarVeterinarioBtn.Size = new System.Drawing.Size(75, 57);
            this.BuscarVeterinarioBtn.TabIndex = 2;
            this.BuscarVeterinarioBtn.Text = "Buscar";
            this.BuscarVeterinarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarVeterinarioBtn.UseVisualStyleBackColor = false;
            this.BuscarVeterinarioBtn.Click += new System.EventHandler(this.BuscarVeterinarioBtn_Click);
            // 
            // TipoVeterinarioCmb
            // 
            this.TipoVeterinarioCmb.FormattingEnabled = true;
            this.TipoVeterinarioCmb.Items.AddRange(new object[] {
            "Veterinarios",
            "ConsultaPorFechaVeterinarios"});
            this.TipoVeterinarioCmb.Location = new System.Drawing.Point(465, 108);
            this.TipoVeterinarioCmb.Name = "TipoVeterinarioCmb";
            this.TipoVeterinarioCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoVeterinarioCmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Veterinarios Activos";
            // 
            // VeterinarioDtg
            // 
            this.VeterinarioDtg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.VeterinarioDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VeterinarioDtg.Location = new System.Drawing.Point(0, 224);
            this.VeterinarioDtg.Name = "VeterinarioDtg";
            this.VeterinarioDtg.Size = new System.Drawing.Size(823, 322);
            this.VeterinarioDtg.TabIndex = 8;
            this.VeterinarioDtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VeterinarioDtg_CellContentClick);
            // 
            // DateVeterinarios
            // 
            this.DateVeterinarios.Location = new System.Drawing.Point(215, 108);
            this.DateVeterinarios.Name = "DateVeterinarios";
            this.DateVeterinarios.Size = new System.Drawing.Size(200, 20);
            this.DateVeterinarios.TabIndex = 9;
            // 
            // MenuVeterinarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(815, 540);
            this.Controls.Add(this.VeterinarioDtg);
            this.Controls.Add(this.VeterinarioCmb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVeterinarioFrm";
            this.Text = "MenuVeterinarioFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            this.VeterinarioCmb.ResumeLayout(false);
            this.VeterinarioCmb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinarioDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.Panel VeterinarioCmb;
        private System.Windows.Forms.Button BuscarVeterinarioBtn;
        private System.Windows.Forms.ComboBox TipoVeterinarioCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarVeterinarioBtn;
        private System.Windows.Forms.DataGridView VeterinarioDtg;
        private System.Windows.Forms.DateTimePicker DateVeterinarios;
    }
}