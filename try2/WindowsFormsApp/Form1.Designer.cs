namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.newPhone1textBox = new System.Windows.Forms.TextBox();
            this.newPhone2textBox = new System.Windows.Forms.TextBox();
            this.newSurnameTextBox = new System.Windows.Forms.TextBox();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.Phone1 = new System.Windows.Forms.Label();
            this.Phone2 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BOOK";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 277);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.Teal;
            this.buttonExit.Location = new System.Drawing.Point(491, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(582, 341);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newInfoTextBox);
            this.tabPage2.Controls.Add(this.newPhone1textBox);
            this.tabPage2.Controls.Add(this.newPhone2textBox);
            this.tabPage2.Controls.Add(this.newSurnameTextBox);
            this.tabPage2.Controls.Add(this.newNameTextBox);
            this.tabPage2.Controls.Add(this.Surname);
            this.tabPage2.Controls.Add(this.Phone1);
            this.tabPage2.Controls.Add(this.Phone2);
            this.tabPage2.Controls.Add(this.Info);
            this.tabPage2.Controls.Add(this.buttonAdd);
            this.tabPage2.Controls.Add(this.FirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NEW";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // newInfoTextBox
            // 
            this.newInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newInfoTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.newInfoTextBox.ForeColor = System.Drawing.Color.Teal;
            this.newInfoTextBox.Location = new System.Drawing.Point(33, 200);
            this.newInfoTextBox.Name = "newInfoTextBox";
            this.newInfoTextBox.Size = new System.Drawing.Size(285, 96);
            this.newInfoTextBox.TabIndex = 5;
            this.newInfoTextBox.Text = "";
            this.newInfoTextBox.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // newPhone1textBox
            // 
            this.newPhone1textBox.BackColor = System.Drawing.Color.White;
            this.newPhone1textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPhone1textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.newPhone1textBox.ForeColor = System.Drawing.Color.Teal;
            this.newPhone1textBox.Location = new System.Drawing.Point(277, 56);
            this.newPhone1textBox.Name = "newPhone1textBox";
            this.newPhone1textBox.Size = new System.Drawing.Size(205, 22);
            this.newPhone1textBox.TabIndex = 3;
            this.newPhone1textBox.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // newPhone2textBox
            // 
            this.newPhone2textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPhone2textBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.newPhone2textBox.ForeColor = System.Drawing.Color.Teal;
            this.newPhone2textBox.Location = new System.Drawing.Point(277, 115);
            this.newPhone2textBox.Name = "newPhone2textBox";
            this.newPhone2textBox.Size = new System.Drawing.Size(205, 22);
            this.newPhone2textBox.TabIndex = 3;
            this.newPhone2textBox.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // newSurnameTextBox
            // 
            this.newSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newSurnameTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.newSurnameTextBox.ForeColor = System.Drawing.Color.Teal;
            this.newSurnameTextBox.Location = new System.Drawing.Point(33, 115);
            this.newSurnameTextBox.Name = "newSurnameTextBox";
            this.newSurnameTextBox.Size = new System.Drawing.Size(190, 22);
            this.newSurnameTextBox.TabIndex = 3;
            this.newSurnameTextBox.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newNameTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.newNameTextBox.ForeColor = System.Drawing.Color.Teal;
            this.newNameTextBox.Location = new System.Drawing.Point(33, 56);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.newNameTextBox.TabIndex = 0;
            this.newNameTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Verdana", 9F);
            this.Surname.ForeColor = System.Drawing.Color.Teal;
            this.Surname.Location = new System.Drawing.Point(30, 95);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(63, 14);
            this.Surname.TabIndex = 4;
            this.Surname.Text = "Surname";
            this.Surname.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Phone1
            // 
            this.Phone1.AutoSize = true;
            this.Phone1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone1.ForeColor = System.Drawing.Color.Teal;
            this.Phone1.Location = new System.Drawing.Point(274, 32);
            this.Phone1.Name = "Phone1";
            this.Phone1.Size = new System.Drawing.Size(80, 14);
            this.Phone1.TabIndex = 4;
            this.Phone1.Text = "Main Phone";
            this.Phone1.Click += new System.EventHandler(this.Phone1_Click);
            // 
            // Phone2
            // 
            this.Phone2.AutoSize = true;
            this.Phone2.Font = new System.Drawing.Font("Verdana", 9F);
            this.Phone2.ForeColor = System.Drawing.Color.Teal;
            this.Phone2.Location = new System.Drawing.Point(274, 95);
            this.Phone2.Name = "Phone2";
            this.Phone2.Size = new System.Drawing.Size(85, 14);
            this.Phone2.TabIndex = 4;
            this.Phone2.Text = "Extra-phone";
            this.Phone2.Click += new System.EventHandler(this.Phone2_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Verdana", 9F);
            this.Info.ForeColor = System.Drawing.Color.Teal;
            this.Info.Location = new System.Drawing.Point(30, 175);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(44, 14);
            this.Info.TabIndex = 4;
            this.Info.Text = "Notes";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Teal;
            this.buttonAdd.Location = new System.Drawing.Point(407, 233);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.Button3_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Verdana", 9F);
            this.FirstName.ForeColor = System.Drawing.Color.Teal;
            this.FirstName.Location = new System.Drawing.Point(30, 32);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(43, 14);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "Name";
            this.FirstName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 341);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Peter the Great Phone Book";
            this.Load += new System.EventHandler(this.PhoneBook_Load);
            this.tabPage1.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox newInfoTextBox;
        private System.Windows.Forms.TextBox newPhone1textBox;
        private System.Windows.Forms.TextBox newPhone2textBox;
        private System.Windows.Forms.TextBox newSurnameTextBox;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Phone1;
        private System.Windows.Forms.Label Phone2;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

