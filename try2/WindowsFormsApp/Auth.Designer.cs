namespace WindowsFormsApp
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.textBoxLoggin = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLoggin
            // 
            this.textBoxLoggin.BackColor = System.Drawing.Color.White;
            this.textBoxLoggin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoggin.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.textBoxLoggin.ForeColor = System.Drawing.Color.Teal;
            this.textBoxLoggin.Location = new System.Drawing.Point(154, 90);
            this.textBoxLoggin.Name = "textBoxLoggin";
            this.textBoxLoggin.Size = new System.Drawing.Size(292, 40);
            this.textBoxLoggin.TabIndex = 6;
            this.textBoxLoggin.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.userName.Font = new System.Drawing.Font("Verdana", 20F);
            this.userName.ForeColor = System.Drawing.Color.Teal;
            this.userName.Location = new System.Drawing.Point(216, 37);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(163, 32);
            this.userName.TabIndex = 7;
            this.userName.Text = "Your login:";
            this.userName.Click += new System.EventHandler(this.Phone1_Click);
            // 
            // buttonConnection
            // 
            this.buttonConnection.BackColor = System.Drawing.Color.White;
            this.buttonConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnection.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnection.ForeColor = System.Drawing.Color.Teal;
            this.buttonConnection.Location = new System.Drawing.Point(232, 292);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(125, 23);
            this.buttonConnection.TabIndex = 5;
            this.buttonConnection.Text = "Try to connect";
            this.buttonConnection.UseVisualStyleBackColor = false;
            this.buttonConnection.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Teal;
            this.textBoxPassword.Location = new System.Drawing.Point(154, 210);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '@';
            this.textBoxPassword.Size = new System.Drawing.Size(292, 40);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxpassword_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.PaleTurquoise;
            this.password.Font = new System.Drawing.Font("Verdana", 20F);
            this.password.ForeColor = System.Drawing.Color.Teal;
            this.password.Location = new System.Drawing.Point(187, 156);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(227, 32);
            this.password.TabIndex = 9;
            this.password.Text = "Your password:";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(582, 341);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBoxLoggin);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.buttonConnection);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auth";
            this.Text = "Press F for povishennaya stipendia";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoggin;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Label password;
        internal System.Windows.Forms.TextBox textBoxPassword;
    }
}