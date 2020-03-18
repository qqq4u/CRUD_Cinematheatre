using MySql.Data.MySqlClient;
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

    public partial class FormAdministrator : Form
    {
        public FormAdministrator()
        {
            InitializeComponent();
        }

        private void dataGridViewSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {






            DBConnector.mySqlCommand.CommandText = "SELECT films.name, sessions.ticket_cost, sessions.time, sessions.tickets_count FROM films JOIN sessions ON sessions.film_id = films.id";

            MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();


            while (dataReader.Read())
            {

 dataGridViewSessions.Rows.Add((dataReader.GetString("name")), (Convert.ToString(dataReader.GetInt32("ticket_cost")) + "₽"), dataReader.GetMySqlDateTime("time"), dataReader.GetInt32("tickets_count"));
        
                //dataGridViewSessions.Columns["ColumnCost"](Convert.ToString(dataReader.GetInt32("ticket_cost")) + "₽");
                //dataGridViewSessions.Columns["ColumnDate"](dataReader.GetMySqlDateTime("time"));
            }
            dataReader.Close();


            DBConnector.mySqlCommand.CommandText = "SELECT * FROM films";

           dataReader = DBConnector.mySqlCommand.ExecuteReader();


            while (dataReader.Read())
            {

                comboBoxFilms.Items.Add(dataReader.GetString("name"));
                
            }
            dataReader.Close();


        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            Form form = new FormCreateFilm();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;


            comboBoxFilms.Items.Clear();

            DBConnector.mySqlCommand.CommandText = "SELECT * FROM films";

            MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();


            while (dataReader.Read())
            {

                comboBoxFilms.Items.Add(dataReader.GetString("name"));

            }
            dataReader.Close();


        }

        private void comboBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            try
            {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `films` WHERE `name` = '{comboBoxFilms.Text}'";

            MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();
                int id = 0;
                if (dataReader.Read())
                {

           id = dataReader.GetInt32("id");
                }
            dataReader.Close();

                string formatForMySql = dateTimePickerTime.Value.ToString("yyyy-MM-dd HH:mm:ss");

                DBConnector.mySqlCommand.CommandText = $@"INSERT INTO `sessions`(film_id,ticket_cost,time,tickets_count) VALUES('{id}','{Convert.ToInt32(textBoxTicketCost.Text)}','{formatForMySql}','{Convert.ToInt32(textBoxTicketsCount.Text)}')";

            DBConnector.mySqlCommand.ExecuteNonQuery();


                MessageBox.Show("Билет добавлен");

                dataGridViewSessions.Rows.Clear();

                DBConnector.mySqlCommand.CommandText = "SELECT films.name, sessions.ticket_cost, sessions.time, sessions.tickets_count FROM films JOIN sessions ON sessions.film_id = films.id";
 dataReader = DBConnector.mySqlCommand.ExecuteReader();


                while (dataReader.Read())
                {

                    dataGridViewSessions.Rows.Add((dataReader.GetString("name")), (Convert.ToString(dataReader.GetInt32("ticket_cost")) + "₽"), dataReader.GetMySqlDateTime("time"), dataReader.GetInt32("tickets_count"));

                    //dataGridViewSessions.Columns["ColumnCost"](Convert.ToString(dataReader.GetInt32("ticket_cost")) + "₽");
                    //dataGridViewSessions.Columns["ColumnDate"](dataReader.GetMySqlDateTime("time"));
                }
                dataReader.Close();

                // НЕ ДОБАВЛЯЕТСЯ ИЗ-ЗА НЕПРАВИЛЬНОГО ВРЕМЕНИ


            }
            catch (Exception q)
            {

                MessageBox.Show("Ошибка добавления");
            }
        }
    }
}
