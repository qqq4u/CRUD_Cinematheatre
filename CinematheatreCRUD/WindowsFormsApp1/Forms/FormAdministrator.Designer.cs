namespace WindowsFormsApp1
{
    partial class FormAdministrator
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
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTicketCost = new System.Windows.Forms.TextBox();
            this.comboBoxFilms = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTicketsCount = new System.Windows.Forms.TextBox();
            this.ColumnFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTicketsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFilm,
            this.ColumnTicketsCount,
            this.ColumnCost,
            this.ColumnDate});
            this.dataGridViewSessions.Location = new System.Drawing.Point(5, 4);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.Size = new System.Drawing.Size(552, 323);
            this.dataGridViewSessions.TabIndex = 1;
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFilm.Location = new System.Drawing.Point(299, 416);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(252, 39);
            this.buttonAddFilm.TabIndex = 2;
            this.buttonAddFilm.Text = "Добавление фильма";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTicket.Location = new System.Drawing.Point(12, 416);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(216, 39);
            this.buttonAddTicket.TabIndex = 3;
            this.buttonAddTicket.Text = "Добавить билет";
            this.buttonAddTicket.UseVisualStyleBackColor = true;
            this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "yyyy-MM-dd  hh:mm:ss";
            this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTime.Location = new System.Drawing.Point(325, 364);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(145, 22);
            this.dateTimePickerTime.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(338, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Время сеанса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(186, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Фильм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Цена";
            // 
            // textBoxTicketCost
            // 
            this.textBoxTicketCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTicketCost.Location = new System.Drawing.Point(15, 363);
            this.textBoxTicketCost.Name = "textBoxTicketCost";
            this.textBoxTicketCost.Size = new System.Drawing.Size(100, 22);
            this.textBoxTicketCost.TabIndex = 9;
            // 
            // comboBoxFilms
            // 
            this.comboBoxFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFilms.FormattingEnabled = true;
            this.comboBoxFilms.Location = new System.Drawing.Point(128, 362);
            this.comboBoxFilms.Name = "comboBoxFilms";
            this.comboBoxFilms.Size = new System.Drawing.Size(179, 24);
            this.comboBoxFilms.TabIndex = 15;
            this.comboBoxFilms.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilms_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(481, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Билетов";
            // 
            // textBoxTicketsCount
            // 
            this.textBoxTicketsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTicketsCount.Location = new System.Drawing.Point(496, 362);
            this.textBoxTicketsCount.Name = "textBoxTicketsCount";
            this.textBoxTicketsCount.Size = new System.Drawing.Size(45, 22);
            this.textBoxTicketsCount.TabIndex = 16;
            // 
            // ColumnFilm
            // 
            this.ColumnFilm.HeaderText = "Фильм";
            this.ColumnFilm.Name = "ColumnFilm";
            this.ColumnFilm.Width = 200;
            // 
            // ColumnTicketsCount
            // 
            this.ColumnTicketsCount.HeaderText = "Количество билетов";
            this.ColumnTicketsCount.Name = "ColumnTicketsCount";
            this.ColumnTicketsCount.Width = 75;
            // 
            // ColumnCost
            // 
            this.ColumnCost.HeaderText = "Цена билета";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.Width = 75;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Время сеанса";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.Width = 150;
            // 
            // FormAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTicketsCount);
            this.Controls.Add(this.comboBoxFilms);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTicketCost);
            this.Controls.Add(this.buttonAddFilm);
            this.Controls.Add(this.dataGridViewSessions);
            this.Controls.Add(this.buttonAddTicket);
            this.Name = "FormAdministrator";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.FormAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.Button buttonAddTicket;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTicketCost;
        private System.Windows.Forms.ComboBox comboBoxFilms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTicketsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTicketsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    }
}