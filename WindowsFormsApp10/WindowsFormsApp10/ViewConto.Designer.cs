namespace WindowsFormsApp10
{
    partial class ViewConto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.transazione = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.transazioni_table = new System.Windows.Forms.DataGridView();
            this.entrate = new System.Windows.Forms.Button();
            this.uscite = new System.Windows.Forms.Button();
            this.tutto = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.DateTimePicker();
            this.data2 = new System.Windows.Forms.DateTimePicker();
            this.filtro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transazioni_table)).BeginInit();
            this.SuspendLayout();
            // 
            // transazione
            // 
            this.transazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.transazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.transazione.ForeColor = System.Drawing.Color.White;
            this.transazione.Location = new System.Drawing.Point(48, 84);
            this.transazione.Name = "transazione";
            this.transazione.Size = new System.Drawing.Size(162, 45);
            this.transazione.TabIndex = 124;
            this.transazione.Text = "Transazione";
            this.transazione.UseVisualStyleBackColor = false;
            this.transazione.Click += new System.EventHandler(this.ricarica_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(354, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(122, 32);
            this.lbl_nome.TabIndex = 129;
            this.lbl_nome.Text = "Conto - ";
            // 
            // transazioni_table
            // 
            this.transazioni_table.AllowUserToAddRows = false;
            this.transazioni_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.transazioni_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.transazioni_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transazioni_table.Location = new System.Drawing.Point(48, 135);
            this.transazioni_table.Name = "transazioni_table";
            this.transazioni_table.ReadOnly = true;
            this.transazioni_table.RowTemplate.Height = 24;
            this.transazioni_table.Size = new System.Drawing.Size(523, 255);
            this.transazioni_table.TabIndex = 131;
            // 
            // entrate
            // 
            this.entrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.entrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.entrate.ForeColor = System.Drawing.Color.White;
            this.entrate.Location = new System.Drawing.Point(576, 136);
            this.entrate.Name = "entrate";
            this.entrate.Size = new System.Drawing.Size(162, 45);
            this.entrate.TabIndex = 132;
            this.entrate.Text = "Solo Entrate";
            this.entrate.UseVisualStyleBackColor = false;
            this.entrate.Click += new System.EventHandler(this.entrate_Click);
            // 
            // uscite
            // 
            this.uscite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.uscite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uscite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.uscite.ForeColor = System.Drawing.Color.White;
            this.uscite.Location = new System.Drawing.Point(576, 238);
            this.uscite.Name = "uscite";
            this.uscite.Size = new System.Drawing.Size(162, 45);
            this.uscite.TabIndex = 133;
            this.uscite.Text = "Solo Uscite";
            this.uscite.UseVisualStyleBackColor = false;
            this.uscite.Click += new System.EventHandler(this.uscite_Click);
            // 
            // tutto
            // 
            this.tutto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.tutto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.tutto.ForeColor = System.Drawing.Color.White;
            this.tutto.Location = new System.Drawing.Point(576, 187);
            this.tutto.Name = "tutto";
            this.tutto.Size = new System.Drawing.Size(162, 45);
            this.tutto.TabIndex = 134;
            this.tutto.Text = "Estratto Conto";
            this.tutto.UseVisualStyleBackColor = false;
            this.tutto.Click += new System.EventHandler(this.tutto_Click);
            // 
            // data1
            // 
            this.data1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data1.Location = new System.Drawing.Point(576, 340);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(162, 22);
            this.data1.TabIndex = 135;
            // 
            // data2
            // 
            this.data2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data2.Location = new System.Drawing.Point(576, 368);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(162, 22);
            this.data2.TabIndex = 136;
            // 
            // filtro
            // 
            this.filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.filtro.ForeColor = System.Drawing.Color.White;
            this.filtro.Location = new System.Drawing.Point(576, 289);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(162, 45);
            this.filtro.TabIndex = 137;
            this.filtro.Text = "Filtro";
            this.filtro.UseVisualStyleBackColor = false;
            this.filtro.Click += new System.EventHandler(this.filtro_Click);
            // 
            // ViewConto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.tutto);
            this.Controls.Add(this.uscite);
            this.Controls.Add(this.entrate);
            this.Controls.Add(this.transazioni_table);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.transazione);
            this.Name = "ViewConto";
            this.Text = "ViewConto";
            ((System.ComponentModel.ISupportInitialize)(this.transazioni_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button transazione;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView transazioni_table;
        private System.Windows.Forms.Button entrate;
        private System.Windows.Forms.Button uscite;
        private System.Windows.Forms.Button tutto;
        private System.Windows.Forms.DateTimePicker data1;
        private System.Windows.Forms.DateTimePicker data2;
        private System.Windows.Forms.Button filtro;
    }
}