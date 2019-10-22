namespace WindowsFormsApp10
{
    partial class Register
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
            this.lbl_password = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.TextBox();
            this.register_send = new System.Windows.Forms.Button();
            this.lbl_cogn = new System.Windows.Forms.TextBox();
            this.Closer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.Location = new System.Drawing.Point(127, 287);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(167, 22);
            this.lbl_password.TabIndex = 7;
            // 
            // lbl_user
            // 
            this.lbl_user.Location = new System.Drawing.Point(127, 163);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(167, 22);
            this.lbl_user.TabIndex = 6;
            // 
            // register_send
            // 
            this.register_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.register_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_send.ForeColor = System.Drawing.Color.White;
            this.register_send.Location = new System.Drawing.Point(127, 335);
            this.register_send.Name = "register_send";
            this.register_send.Size = new System.Drawing.Size(167, 44);
            this.register_send.TabIndex = 5;
            this.register_send.Text = "Register";
            this.register_send.UseVisualStyleBackColor = false;
            this.register_send.Click += new System.EventHandler(this.register_send_Click);
            // 
            // lbl_cogn
            // 
            this.lbl_cogn.Location = new System.Drawing.Point(127, 226);
            this.lbl_cogn.Name = "lbl_cogn";
            this.lbl_cogn.Size = new System.Drawing.Size(167, 22);
            this.lbl_cogn.TabIndex = 10;
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.Closer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closer.Location = new System.Drawing.Point(333, 412);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(80, 30);
            this.Closer.TabIndex = 14;
            this.Closer.Text = "Chiudi";
            this.Closer.UseVisualStyleBackColor = false;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vineta BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(142, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 51);
            this.label4.TabIndex = 119;
            this.label4.Text = "VNB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(178, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(167, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 121;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(163, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 129;
            this.label5.Text = "Register";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(425, 454);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.lbl_cogn);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.register_send);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "Register";
            this.Text = "Modulo Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lbl_password;
        private System.Windows.Forms.TextBox lbl_user;
        private System.Windows.Forms.Button register_send;
        private System.Windows.Forms.TextBox lbl_cogn;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}