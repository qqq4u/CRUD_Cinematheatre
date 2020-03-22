namespace WindowsFormsApp1
{
    partial class FormUsersBalance
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.dataGridViewUsersBalances = new System.Windows.Forms.DataGridView();
            this.buttonAddBalance = new System.Windows.Forms.Button();
            this.ColumnUserLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий баланс";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(348, 130);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 31);
            this.labelBalance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(298, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пользователь";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLogin.Location = new System.Drawing.Point(419, 39);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(0, 16);
            this.labelUserLogin.TabIndex = 3;
            // 
            // dataGridViewUsersBalances
            // 
            this.dataGridViewUsersBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUserLogin,
            this.ColumnUserBalance});
            this.dataGridViewUsersBalances.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUsersBalances.Name = "dataGridViewUsersBalances";
            this.dataGridViewUsersBalances.Size = new System.Drawing.Size(269, 294);
            this.dataGridViewUsersBalances.TabIndex = 4;
            this.dataGridViewUsersBalances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsersBalances_CellClick);
            this.dataGridViewUsersBalances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsersBalances_CellContentClick);
            // 
            // buttonAddBalance
            // 
            this.buttonAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBalance.Location = new System.Drawing.Point(324, 215);
            this.buttonAddBalance.Name = "buttonAddBalance";
            this.buttonAddBalance.Size = new System.Drawing.Size(166, 46);
            this.buttonAddBalance.TabIndex = 5;
            this.buttonAddBalance.Text = "Пополнить баланс пользователю";
            this.buttonAddBalance.UseVisualStyleBackColor = true;
            this.buttonAddBalance.Click += new System.EventHandler(this.buttonAddBalance_Click);
            // 
            // ColumnUserLogin
            // 
            this.ColumnUserLogin.HeaderText = "Login";
            this.ColumnUserLogin.Name = "ColumnUserLogin";
            this.ColumnUserLogin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnUserLogin.Width = 150;
            // 
            // ColumnUserBalance
            // 
            this.ColumnUserBalance.HeaderText = "Баланс";
            this.ColumnUserBalance.Name = "ColumnUserBalance";
            this.ColumnUserBalance.Width = 75;
            // 
            // FormUsersBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 327);
            this.Controls.Add(this.buttonAddBalance);
            this.Controls.Add(this.dataGridViewUsersBalances);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label1);
            this.Name = "FormUsersBalance";
            this.Text = "FormUsersBalance";
            this.Load += new System.EventHandler(this.FormUsersBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersBalances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.DataGridView dataGridViewUsersBalances;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserBalance;
        private System.Windows.Forms.Button buttonAddBalance;
    }
}