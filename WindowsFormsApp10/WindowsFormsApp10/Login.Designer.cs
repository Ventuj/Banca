namespace WindowsFormsApp10
{
    partial class Login
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
            this.login_send = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.Closer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.Location = new System.Drawing.Point(118, 245);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(167, 22);
            this.lbl_password.TabIndex = 15;
            // 
            // lbl_user
            // 
            this.lbl_user.Location = new System.Drawing.Point(118, 184);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(167, 22);
            this.lbl_user.TabIndex = 14;
            // 
            // login_send
            // 
            this.login_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.login_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_send.ForeColor = System.Drawing.Color.White;
            this.login_send.Location = new System.Drawing.Point(118, 303);
            this.login_send.Name = "login_send";
            this.login_send.Size = new System.Drawing.Size(167, 44);
            this.login_send.TabIndex = 13;
            this.login_send.Text = "Login";
            this.login_send.UseVisualStyleBackColor = false;
            this.login_send.Click += new System.EventHandler(this.login_send_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Vineta BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Snow;
            this.label19.Location = new System.Drawing.Point(118, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 51);
            this.label19.TabIndex = 118;
            this.label19.Text = "VNB";
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.Closer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closer.ForeColor = System.Drawing.Color.White;
            this.Closer.Location = new System.Drawing.Point(333, 412);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(80, 30);
            this.Closer.TabIndex = 119;
            this.Closer.Text = "Chiudi";
            this.Closer.UseVisualStyleBackColor = false;
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(138, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 122;
            this.label2.Text = "Codice Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(150, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 123;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 128;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(425, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.login_send);
            this.Name = "Login";
            this.Text = "Modulo Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lbl_password;
        private System.Windows.Forms.TextBox lbl_user;
        private System.Windows.Forms.Button login_send;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Closer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}