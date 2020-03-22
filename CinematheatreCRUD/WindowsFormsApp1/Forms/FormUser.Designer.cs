namespace WindowsFormsApp1
{
    partial class FormUser
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
            this.ColumnFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTicketsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.textBoxTicketCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilmName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFilmYear = new System.Windows.Forms.TextBox();
            this.textBoxFilmProducer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilmCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFilm,
            this.ColumnCost,
            this.ColumnTime,
            this.ColumnTicketsCount});
            this.dataGridViewSessions.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.Size = new System.Drawing.Size(620, 310);
            this.dataGridViewSessions.TabIndex = 0;
            this.dataGridViewSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSessions_CellClick);
            this.dataGridViewSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSessions_CellContentClick);
            // 
            // ColumnFilm
            // 
            this.ColumnFilm.HeaderText = "Фильм";
            this.ColumnFilm.Name = "ColumnFilm";
            this.ColumnFilm.Width = 250;
            // 
            // ColumnCost
            // 
            this.ColumnCost.HeaderText = "Цена билета";
            this.ColumnCost.Name = "ColumnCost";
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время сеанса";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.Width = 150;
            // 
            // ColumnTicketsCount
            // 
            this.ColumnTicketsCount.HeaderText = "Билетов";
            this.ColumnTicketsCount.Name = "ColumnTicketsCount";
            this.ColumnTicketsCount.Width = 75;
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyTicket.Location = new System.Drawing.Point(668, 363);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(170, 47);
            this.buttonBuyTicket.TabIndex = 1;
            this.buttonBuyTicket.Text = "Купить билет";
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // textBoxTicketCost
            // 
            this.textBoxTicketCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTicketCost.Location = new System.Drawing.Point(144, 353);
            this.textBoxTicketCost.Name = "textBoxTicketCost";
            this.textBoxTicketCost.ReadOnly = true;
            this.textBoxTicketCost.Size = new System.Drawing.Size(100, 31);
            this.textBoxTicketCost.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цена";
            // 
            // textBoxFilmName
            // 
            this.textBoxFilmName.Location = new System.Drawing.Point(646, 58);
            this.textBoxFilmName.Name = "textBoxFilmName";
            this.textBoxFilmName.ReadOnly = true;
            this.textBoxFilmName.Size = new System.Drawing.Size(185, 20);
            this.textBoxFilmName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(365, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время сеанса";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "dd.MM.yyyy  hh:mm";
            this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTime.Location = new System.Drawing.Point(330, 358);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(184, 26);
            this.dateTimePickerTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(692, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фильм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(692, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Год выпуска";
            // 
            // textBoxFilmYear
            // 
            this.textBoxFilmYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmYear.Location = new System.Drawing.Point(694, 121);
            this.textBoxFilmYear.Name = "textBoxFilmYear";
            this.textBoxFilmYear.Size = new System.Drawing.Size(83, 22);
            this.textBoxFilmYear.TabIndex = 11;
            // 
            // textBoxFilmProducer
            // 
            this.textBoxFilmProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmProducer.Location = new System.Drawing.Point(659, 171);
            this.textBoxFilmProducer.Name = "textBoxFilmProducer";
            this.textBoxFilmProducer.Size = new System.Drawing.Size(149, 22);
            this.textBoxFilmProducer.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(699, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Режиссёр";
            // 
            // textBoxFilmCountry
            // 
            this.textBoxFilmCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmCountry.Location = new System.Drawing.Point(670, 220);
            this.textBoxFilmCountry.Name = "textBoxFilmCountry";
            this.textBoxFilmCountry.Size = new System.Drawing.Size(130, 22);
            this.textBoxFilmCountry.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(705, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Страна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(675, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Баланс:";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(757, 316);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(43, 24);
            this.labelBalance.TabIndex = 17;
            this.labelBalance.Text = "111";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 422);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFilmCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFilmProducer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFilmYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFilmName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTicketCost);
            this.Controls.Add(this.buttonBuyTicket);
            this.Controls.Add(this.dataGridViewSessions);
            this.Name = "FormUser";
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.Button buttonBuyTicket;
        private System.Windows.Forms.TextBox textBoxTicketCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilmName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilmYear;
        private System.Windows.Forms.TextBox textBoxFilmProducer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilmCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTicketsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBalance;
    }
}