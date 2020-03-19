namespace WindowsFormsApp1
{
    partial class FormCreateFilm
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
            this.textBoxFilmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilmYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFilmProducer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilmCountry = new System.Windows.Forms.TextBox();
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFilmName
            // 
            this.textBoxFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmName.Location = new System.Drawing.Point(19, 29);
            this.textBoxFilmName.Name = "textBoxFilmName";
            this.textBoxFilmName.Size = new System.Drawing.Size(261, 26);
            this.textBoxFilmName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Год выпуска:";
            // 
            // textBoxFilmYear
            // 
            this.textBoxFilmYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmYear.Location = new System.Drawing.Point(122, 79);
            this.textBoxFilmYear.Name = "textBoxFilmYear";
            this.textBoxFilmYear.Size = new System.Drawing.Size(73, 22);
            this.textBoxFilmYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Режиссёр:";
            // 
            // textBoxFilmProducer
            // 
            this.textBoxFilmProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmProducer.Location = new System.Drawing.Point(99, 116);
            this.textBoxFilmProducer.Name = "textBoxFilmProducer";
            this.textBoxFilmProducer.Size = new System.Drawing.Size(181, 22);
            this.textBoxFilmProducer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Страна:";
            // 
            // textBoxFilmCountry
            // 
            this.textBoxFilmCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilmCountry.Location = new System.Drawing.Point(89, 154);
            this.textBoxFilmCountry.Name = "textBoxFilmCountry";
            this.textBoxFilmCountry.Size = new System.Drawing.Size(149, 22);
            this.textBoxFilmCountry.TabIndex = 6;
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFilm.Location = new System.Drawing.Point(84, 201);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(129, 40);
            this.buttonAddFilm.TabIndex = 8;
            this.buttonAddFilm.Text = "Добавить";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // FormCreateFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 253);
            this.Controls.Add(this.buttonAddFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFilmCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFilmProducer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFilmYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilmName);
            this.Name = "FormCreateFilm";
            this.Text = "FormCreateFilm";
            this.Load += new System.EventHandler(this.FormCreateFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilmYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilmProducer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilmCountry;
        private System.Windows.Forms.Button buttonAddFilm;
    }
}