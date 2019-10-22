namespace WindowsFormsApp10
{
    partial class CreaConto
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Closer = new System.Windows.Forms.Button();
            this.build_conto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vineta BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(132, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 51);
            this.label4.TabIndex = 120;
            this.label4.Text = "VNB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(154, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 124;
            this.label2.Text = "Nome Conto";
            // 
            // lbl_nc
            // 
            this.lbl_nc.Location = new System.Drawing.Point(126, 187);
            this.lbl_nc.Name = "lbl_nc";
            this.lbl_nc.Size = new System.Drawing.Size(167, 22);
            this.lbl_nc.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(140, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 125;
            this.label1.Text = "Tipologia Conto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 127;
            this.label3.Text = "Crea Conto";
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.Closer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closer.ForeColor = System.Drawing.Color.Snow;
            this.Closer.Location = new System.Drawing.Point(332, 416);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(80, 30);
            this.Closer.TabIndex = 129;
            this.Closer.Text = "Chiudi";
            this.Closer.UseVisualStyleBackColor = false;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // build_conto
            // 
            this.build_conto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.build_conto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build_conto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.build_conto.ForeColor = System.Drawing.Color.White;
            this.build_conto.Location = new System.Drawing.Point(126, 310);
            this.build_conto.Name = "build_conto";
            this.build_conto.Size = new System.Drawing.Size(167, 44);
            this.build_conto.TabIndex = 128;
            this.build_conto.Text = "Crea";
            this.build_conto.UseVisualStyleBackColor = false;
            this.build_conto.Click += new System.EventHandler(this.build_conto_Click);
            // 
            // CreaConto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(425, 454);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.build_conto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nc);
            this.Controls.Add(this.label4);
            this.Name = "CreaConto";
            this.Text = "Crea Conto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbl_nc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.Button build_conto;
    }
}