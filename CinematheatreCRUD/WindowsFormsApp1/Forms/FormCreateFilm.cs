using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCreateFilm : Form
    {
        public FormCreateFilm()
        {
            InitializeComponent();
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnector.mySqlCommand.CommandText = $@"INSERT INTO `films`(name,year,producer,country) VALUES ('{textBoxFilmName.Text}','{Convert.ToInt32(textBoxFilmYear.Text)}','{textBoxFilmProducer.Text}','{textBoxFilmCountry.Text}')";
                DBConnector.mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Успешно добавлено");

                textBoxFilmCountry.Clear();
                textBoxFilmName.Clear();
                textBoxFilmProducer.Clear();
                textBoxFilmYear.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления");
                
            }
            
            
        }

        private void FormCreateFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
