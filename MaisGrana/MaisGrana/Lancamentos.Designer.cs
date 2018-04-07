namespace MaisGrana
{
    partial class frmLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLancamentos = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnRegistrarGasto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pctLogo);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(-272, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 59);
            this.panel1.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(698, 18);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(21, 27);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 3;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(273, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(202, 62);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 3;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLancamentos
            // 
            this.lblLancamentos.AutoSize = true;
            this.lblLancamentos.BackColor = System.Drawing.Color.Transparent;
            this.lblLancamentos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamentos.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblLancamentos.Location = new System.Drawing.Point(118, 83);
            this.lblLancamentos.Name = "lblLancamentos";
            this.lblLancamentos.Size = new System.Drawing.Size(226, 18);
            this.lblLancamentos.TabIndex = 4;
            this.lblLancamentos.Text = "Qual foi seu gasto? Me conte!";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.Location = new System.Drawing.Point(168, 14);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(122, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "0";
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txtValor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategoria, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Contas",
            "Educação",
            "Lazer",
            "Mercado",
            "Restaurante / Bar",
            "Transporte"});
            this.cmbCategoria.Location = new System.Drawing.Point(169, 52);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 6;
            this.cmbCategoria.Text = "Selecione o gasto";
            // 
            // btnRegistrarGasto
            // 
            this.btnRegistrarGasto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRegistrarGasto.FlatAppearance.BorderSize = 0;
            this.btnRegistrarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarGasto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(34)))));
            this.btnRegistrarGasto.Location = new System.Drawing.Point(163, 212);
            this.btnRegistrarGasto.Name = "btnRegistrarGasto";
            this.btnRegistrarGasto.Size = new System.Drawing.Size(135, 34);
            this.btnRegistrarGasto.TabIndex = 5;
            this.btnRegistrarGasto.Text = "Pronto";
            this.btnRegistrarGasto.UseVisualStyleBackColor = false;
            // 
            // frmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 266);
            this.Controls.Add(this.btnRegistrarGasto);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblLancamentos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lancamentos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLancamentos;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnRegistrarGasto;
    }
}