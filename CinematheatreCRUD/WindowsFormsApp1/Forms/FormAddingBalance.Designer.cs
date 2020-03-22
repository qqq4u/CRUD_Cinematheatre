namespace WindowsFormsApp1
{
    partial class FormAddingBalance
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
            this.labelUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddingBalance = new System.Windows.Forms.TextBox();
            this.buttonAddBalance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(83, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(98, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "lkogreo849";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма пополнения:";
            // 
            // textBoxAddingBalance
            // 
            this.textBoxAddingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddingBalance.Location = new System.Drawing.Point(90, 136);
            this.textBoxAddingBalance.Name = "textBoxAddingBalance";
            this.textBoxAddingBalance.Size = new System.Drawing.Size(100, 26);
            this.textBoxAddingBalance.TabIndex = 3;
            // 
            // buttonAddBalance
            // 
            this.buttonAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBalance.Location = new System.Drawing.Point(78, 177);
            this.buttonAddBalance.Name = "buttonAddBalance";
            this.buttonAddBalance.Size = new System.Drawing.Size(116, 33);
            this.buttonAddBalance.TabIndex = 4;
            this.buttonAddBalance.Text = "Пополнить ";
            this.buttonAddBalance.UseVisualStyleBackColor = true;
            this.buttonAddBalance.Click += new System.EventHandler(this.buttonAddBalance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущий баланс:";
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserBalance.Location = new System.Drawing.Point(209, 58);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(43, 24);
            this.labelUserBalance.TabIndex = 6;
            this.labelUserBalance.Text = "123";
            // 
            // FormAddingBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 235);
            this.Controls.Add(this.labelUserBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddBalance);
            this.Controls.Add(this.textBoxAddingBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUser);
            this.Name = "FormAddingBalance";
            this.Text = "FormAddingBalance";
            this.Load += new System.EventHandler(this.FormAddingBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddingBalance;
        private System.Windows.Forms.Button buttonAddBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserBalance;
    }
}