namespace WindowsFormsApp10
{
    partial class Banca
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_form = new System.Windows.Forms.Button();
            this.reg_form = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.listaConti = new System.Windows.Forms.DataGridView();
            this.creaConto = new System.Windows.Forms.Button();
            this.ulist = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaConti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulist)).BeginInit();
            this.SuspendLayout();
            // 
            // login_form
            // 
            this.login_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.login_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_form.ForeColor = System.Drawing.Color.Snow;
            this.login_form.Location = new System.Drawing.Point(398, 93);
            this.login_form.Name = "login_form";
            this.login_form.Size = new System.Drawing.Size(120, 45);
            this.login_form.TabIndex = 6;
            this.login_form.Text = "Login";
            this.login_form.UseVisualStyleBackColor = false;
            this.login_form.Click += new System.EventHandler(this.login_form_Click);
            // 
            // reg_form
            // 
            this.reg_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.reg_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.reg_form.ForeColor = System.Drawing.Color.White;
            this.reg_form.Location = new System.Drawing.Point(272, 93);
            this.reg_form.Name = "reg_form";
            this.reg_form.Size = new System.Drawing.Size(120, 45);
            this.reg_form.TabIndex = 7;
            this.reg_form.Text = "Register";
            this.reg_form.UseVisualStyleBackColor = false;
            this.reg_form.Click += new System.EventHandler(this.reg_form_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Vineta BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Snow;
            this.label19.Location = new System.Drawing.Point(131, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(526, 51);
            this.label19.TabIndex = 116;
            this.label19.Text = "VNB Corporation";
            // 
            // listaConti
            // 
            this.listaConti.AllowUserToAddRows = false;
            this.listaConti.AllowUserToDeleteRows = false;
            this.listaConti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaConti.Location = new System.Drawing.Point(20, 207);
            this.listaConti.Name = "listaConti";
            this.listaConti.ReadOnly = true;
            this.listaConti.RowTemplate.Height = 24;
            this.listaConti.Size = new System.Drawing.Size(768, 150);
            this.listaConti.TabIndex = 117;
            // 
            // creaConto
            // 
            this.creaConto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.creaConto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creaConto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.creaConto.ForeColor = System.Drawing.Color.White;
            this.creaConto.Location = new System.Drawing.Point(20, 144);
            this.creaConto.Name = "creaConto";
            this.creaConto.Size = new System.Drawing.Size(162, 45);
            this.creaConto.TabIndex = 118;
            this.creaConto.Text = "Crea Conto";
            this.creaConto.UseVisualStyleBackColor = false;
            this.creaConto.Click += new System.EventHandler(this.creaConto_Click);
            // 
            // ulist
            // 
            this.ulist.AllowUserToAddRows = false;
            this.ulist.AllowUserToDeleteRows = false;
            this.ulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ulist.Location = new System.Drawing.Point(18, 363);
            this.ulist.Name = "ulist";
            this.ulist.ReadOnly = true;
            this.ulist.RowTemplate.Height = 24;
            this.ulist.Size = new System.Drawing.Size(770, 150);
            this.ulist.TabIndex = 119;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 120;
            // 
            // viewc
            // 
            this.viewc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.viewc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.viewc.ForeColor = System.Drawing.Color.White;
            this.viewc.Location = new System.Drawing.Point(626, 144);
            this.viewc.Name = "viewc";
            this.viewc.Size = new System.Drawing.Size(162, 45);
            this.viewc.TabIndex = 121;
            this.viewc.Text = "Visualizza";
            this.viewc.UseVisualStyleBackColor = false;
            this.viewc.Click += new System.EventHandler(this.viewc_Click);
            // 
            // Banca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.viewc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ulist);
            this.Controls.Add(this.creaConto);
            this.Controls.Add(this.listaConti);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.reg_form);
            this.Controls.Add(this.login_form);
            this.Name = "Banca";
            this.Text = "VNB";
            ((System.ComponentModel.ISupportInitialize)(this.listaConti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_form;
        private System.Windows.Forms.Button reg_form;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button creaConto;
        public System.Windows.Forms.DataGridView listaConti;
        public System.Windows.Forms.DataGridView ulist;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button viewc;
    }
}

