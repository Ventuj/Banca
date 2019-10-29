namespace WindowsFormsApp10
{
    partial class Transazione
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
            this.value_text = new System.Windows.Forms.TextBox();
            this.Closer = new System.Windows.Forms.Button();
            this.execute_transaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.causale_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // value_text
            // 
            this.value_text.Location = new System.Drawing.Point(83, 153);
            this.value_text.Name = "value_text";
            this.value_text.Size = new System.Drawing.Size(120, 22);
            this.value_text.TabIndex = 0;
            this.value_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.value_text_KeyPress);
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.Closer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closer.ForeColor = System.Drawing.Color.Snow;
            this.Closer.Location = new System.Drawing.Point(359, 392);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(80, 30);
            this.Closer.TabIndex = 130;
            this.Closer.Text = "Chiudi";
            this.Closer.UseVisualStyleBackColor = false;
            this.Closer.Click += new System.EventHandler(this.Closer_Click_1);
            // 
            // execute_transaction
            // 
            this.execute_transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.execute_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute_transaction.ForeColor = System.Drawing.Color.Snow;
            this.execute_transaction.Location = new System.Drawing.Point(161, 293);
            this.execute_transaction.Name = "execute_transaction";
            this.execute_transaction.Size = new System.Drawing.Size(120, 45);
            this.execute_transaction.TabIndex = 131;
            this.execute_transaction.Text = "Esegui";
            this.execute_transaction.UseVisualStyleBackColor = false;
            this.execute_transaction.Click += new System.EventHandler(this.execute_transaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vineta BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(152, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 51);
            this.label4.TabIndex = 132;
            this.label4.Text = "VNB";
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Prelievo",
            "Ricarica"});
            this.tipo.Location = new System.Drawing.Point(229, 151);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(131, 24);
            this.tipo.TabIndex = 133;
            // 
            // causale_txt
            // 
            this.causale_txt.Location = new System.Drawing.Point(83, 219);
            this.causale_txt.Multiline = true;
            this.causale_txt.Name = "causale_txt";
            this.causale_txt.Size = new System.Drawing.Size(277, 56);
            this.causale_txt.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(167, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 137;
            this.label3.Text = "Causale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(86, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 138;
            this.label1.Text = "Ammontare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(235, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 139;
            this.label2.Text = "Transazione";
            // 
            // Transazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.causale_txt);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.execute_transaction);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.value_text);
            this.Name = "Transazione";
            this.Text = "Transazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value_text;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.Button execute_transaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.TextBox causale_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}