namespace WindowsFormsApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            this.textBoxPhone1 = new System.Windows.Forms.TextBox();
            this.textBoxPhone2 = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.Phone1 = new System.Windows.Forms.Label();
            this.Phone2 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.Teal;
            this.buttonSave.Location = new System.Drawing.Point(425, 221);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Teal;
            this.buttonDelete.Location = new System.Drawing.Point(425, 273);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxInfo.ForeColor = System.Drawing.Color.Teal;
            this.textBoxInfo.Location = new System.Drawing.Point(49, 209);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(285, 96);
            this.textBoxInfo.TabIndex = 19;
            this.textBoxInfo.Text = "";
            // 
            // textBoxPhone1
            // 
            this.textBoxPhone1.BackColor = System.Drawing.Color.White;
            this.textBoxPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxPhone1.ForeColor = System.Drawing.Color.Teal;
            this.textBoxPhone1.Location = new System.Drawing.Point(280, 65);
            this.textBoxPhone1.Name = "textBoxPhone1";
            this.textBoxPhone1.Size = new System.Drawing.Size(227, 22);
            this.textBoxPhone1.TabIndex = 12;
            // 
            // textBoxPhone2
            // 
            this.textBoxPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxPhone2.ForeColor = System.Drawing.Color.Teal;
            this.textBoxPhone2.Location = new System.Drawing.Point(280, 124);
            this.textBoxPhone2.Name = "textBoxPhone2";
            this.textBoxPhone2.Size = new System.Drawing.Size(227, 22);
            this.textBoxPhone2.TabIndex = 13;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSurname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxSurname.ForeColor = System.Drawing.Color.Teal;
            this.textBoxSurname.Location = new System.Drawing.Point(49, 124);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(165, 22);
            this.textBoxSurname.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.textBoxName.ForeColor = System.Drawing.Color.Teal;
            this.textBoxName.Location = new System.Drawing.Point(49, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Verdana", 9F);
            this.Surname.ForeColor = System.Drawing.Color.Teal;
            this.Surname.Location = new System.Drawing.Point(46, 104);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(63, 14);
            this.Surname.TabIndex = 15;
            this.Surname.Text = "Surname";
            // 
            // Phone1
            // 
            this.Phone1.AutoSize = true;
            this.Phone1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone1.ForeColor = System.Drawing.Color.Teal;
            this.Phone1.Location = new System.Drawing.Point(277, 41);
            this.Phone1.Name = "Phone1";
            this.Phone1.Size = new System.Drawing.Size(80, 14);
            this.Phone1.TabIndex = 16;
            this.Phone1.Text = "Main Phone";
            // 
            // Phone2
            // 
            this.Phone2.AutoSize = true;
            this.Phone2.Font = new System.Drawing.Font("Verdana", 9F);
            this.Phone2.ForeColor = System.Drawing.Color.Teal;
            this.Phone2.Location = new System.Drawing.Point(277, 104);
            this.Phone2.Name = "Phone2";
            this.Phone2.Size = new System.Drawing.Size(85, 14);
            this.Phone2.TabIndex = 17;
            this.Phone2.Text = "Extra-phone";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Verdana", 9F);
            this.Info.ForeColor = System.Drawing.Color.Teal;
            this.Info.Location = new System.Drawing.Point(46, 184);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(44, 14);
            this.Info.TabIndex = 18;
            this.Info.Text = "Notes";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Verdana", 9F);
            this.FirstName.ForeColor = System.Drawing.Color.Teal;
            this.FirstName.Location = new System.Drawing.Point(46, 41);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(43, 14);
            this.FirstName.TabIndex = 11;
            this.FirstName.Text = "Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(582, 341);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxPhone1);
            this.Controls.Add(this.textBoxPhone2);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Phone1);
            this.Controls.Add(this.Phone2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Peter the Great Phone Book";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.TextBox textBoxPhone1;
        private System.Windows.Forms.TextBox textBoxPhone2;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Phone1;
        private System.Windows.Forms.Label Phone2;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label FirstName;
    }
}