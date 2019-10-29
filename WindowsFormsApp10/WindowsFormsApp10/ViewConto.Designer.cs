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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ext = new System.Windows.Forms.Button();
            this.transazione = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.Closer = new System.Windows.Forms.Button();
            this.transazioni_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.transazioni_table)).BeginInit();
            this.SuspendLayout();
            // 
            // ext
            // 
            this.ext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ext.ForeColor = System.Drawing.Color.White;
            this.ext.Location = new System.Drawing.Point(36, 100);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(162, 45);
            this.ext.TabIndex = 125;
            this.ext.Text = "Estratto Conto";
            this.ext.UseVisualStyleBackColor = false;
            // 
            // transazione
            // 
            this.transazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.transazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.transazione.ForeColor = System.Drawing.Color.White;
            this.transazione.Location = new System.Drawing.Point(204, 100);
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
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.Closer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closer.ForeColor = System.Drawing.Color.Snow;
            this.Closer.Location = new System.Drawing.Point(708, 408);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(80, 30);
            this.Closer.TabIndex = 130;
            this.Closer.Text = "Chiudi";
            this.Closer.UseVisualStyleBackColor = false;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // transazioni_table
            // 
            this.transazioni_table.AllowUserToAddRows = false;
            this.transazioni_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.transazioni_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transazioni_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transazioni_table.Location = new System.Drawing.Point(36, 167);
            this.transazioni_table.Name = "transazioni_table";
            this.transazioni_table.ReadOnly = true;
            this.transazioni_table.RowTemplate.Height = 24;
            this.transazioni_table.Size = new System.Drawing.Size(685, 215);
            this.transazioni_table.TabIndex = 131;
            // 
            // ViewConto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transazioni_table);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.transazione);
            this.Name = "ViewConto";
            this.Text = "ViewConto";
            ((System.ComponentModel.ISupportInitialize)(this.transazioni_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.Button transazione;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.DataGridView transazioni_table;
    }
}