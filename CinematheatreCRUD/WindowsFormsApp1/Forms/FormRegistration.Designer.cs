namespace WindowsFormsApp1
{
    partial class FormRegistration
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonAdministrator = new System.Windows.Forms.RadioButton();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(59, 165);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(188, 27);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Зарегестрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonUser.Location = new System.Drawing.Point(98, 108);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(121, 20);
            this.radioButtonUser.TabIndex = 1;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "Пользователь";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdministrator
            // 
            this.radioButtonAdministrator.AutoSize = true;
            this.radioButtonAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAdministrator.Location = new System.Drawing.Point(98, 132);
            this.radioButtonAdministrator.Name = "radioButtonAdministrator";
            this.radioButtonAdministrator.Size = new System.Drawing.Size(129, 20);
            this.radioButtonAdministrator.TabIndex = 2;
            this.radioButtonAdministrator.TabStop = true;
            this.radioButtonAdministrator.Text = "Администратор";
            this.radioButtonAdministrator.UseVisualStyleBackColor = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(91, 23);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(128, 22);
            this.textBoxLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(91, 71);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(128, 22);
            this.textBoxPassword.TabIndex = 5;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.radioButtonAdministrator);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.buttonRegister);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonAdministrator;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}