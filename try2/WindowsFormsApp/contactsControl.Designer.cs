namespace WindowsFormsApp
{
    partial class contactsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.RichTextBox();
            this.phone1 = new System.Windows.Forms.Label();
            this.phone2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.ForeColor = System.Drawing.Color.Teal;
            this.firstName.Location = new System.Drawing.Point(4, 4);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(71, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "firstName";
            this.firstName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.ForeColor = System.Drawing.Color.Teal;
            this.surname.Location = new System.Drawing.Point(4, 17);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(57, 13);
            this.surname.TabIndex = 0;
            this.surname.Text = "surname";
            // 
            // info
            // 
            this.info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Font = new System.Drawing.Font("Verdana", 7F);
            this.info.ForeColor = System.Drawing.Color.Teal;
            this.info.Location = new System.Drawing.Point(417, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(151, 40);
            this.info.TabIndex = 1;
            this.info.Text = "";
            this.info.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // phone1
            // 
            this.phone1.AutoSize = true;
            this.phone1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone1.ForeColor = System.Drawing.Color.Teal;
            this.phone1.Location = new System.Drawing.Point(176, 4);
            this.phone1.Name = "phone1";
            this.phone1.Size = new System.Drawing.Size(55, 13);
            this.phone1.TabIndex = 0;
            this.phone1.Text = "phone1";
            // 
            // phone2
            // 
            this.phone2.AutoSize = true;
            this.phone2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone2.ForeColor = System.Drawing.Color.Teal;
            this.phone2.Location = new System.Drawing.Point(293, 4);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(49, 13);
            this.phone2.TabIndex = 0;
            this.phone2.Text = "phone2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // contactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.phone2);
            this.Controls.Add(this.phone1);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.firstName);
            this.Name = "contactsControl";
            this.Size = new System.Drawing.Size(568, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label phone1;
        private System.Windows.Forms.Label phone2;
        private System.Windows.Forms.Button button1;
    }
}
