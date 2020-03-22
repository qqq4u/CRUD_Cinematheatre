using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {


            DBConnector.mySqlCommand.CommandText = "SELECT films.name, sessions.ticket_cost, sessions.time, sessions.tickets_count FROM films JOIN sessions ON sessions.film_id = films.id";

            MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();


            while (dataReader.Read())
            {
                if (dataReader.GetInt32("tickets_count")>0)
                {

                    dataGridViewSessions.Rows.Add((dataReader.GetString("name")), (Convert.ToString(dataReader.GetInt32("ticket_cost")) + "₽"), dataReader.GetMySqlDateTime("time"), dataReader.GetInt32("tickets_count"));
                }
               
            }
            dataReader.Close();
            DBConnector.mySqlCommand.CommandText = $@"SELECT balance FROM users WHERE login = '{GlobalVariables.activeUserLogin}'";

            dataReader = DBConnector.mySqlCommand.ExecuteReader();
            dataReader.Read();
            labelBalance.Text = dataReader.GetInt32("balance").ToString() + "₽";
            dataReader.Close();

            // dataGridViewSessions.Rows.RemoveAt(dataGridViewSessions.Rows.GetLastRow());
        }

        private void dataGridViewSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxFilmName.Text = dataGridViewSessions.SelectedRows[0].Cells[0].Value.ToString();
                textBoxTicketCost.Text = dataGridViewSessions.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePickerTime.Value = Convert.ToDateTime(dataGridViewSessions.SelectedRows[0].Cells[2].Value);



                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `films` WHERE `name` = '{textBoxFilmName.Text}'";

                MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();

                dataReader.Read();
                textBoxFilmYear.Text = Convert.ToString(dataReader.GetInt32("year")+"г."); 
                textBoxFilmProducer.Text = dataReader.GetString("producer"); 
                textBoxFilmCountry.Text = dataReader.GetString("country"); 
                dataReader.Close();


            }
            catch (Exception exc)
            {
                MessageBox.Show("Для выбора информации о фильме нажмите на боковой столбец");
                
            }
           
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            try
            {


                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `films` WHERE `name` = '{textBoxFilmName.Text}'";

                MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();
                int id = 0;
                if (dataReader.Read())
                {
                    id = dataReader.GetInt32("id");
                }
                dataReader.Close();

                string formatForMySql = dateTimePickerTime.Value.ToString("yyyy-MM-dd HH:mm:ss");

                DBConnector.mySqlCommand.CommandText = $@"UPDATE sessions SET sessions.tickets_count = sessions.tickets_count - 1 WHERE sessions.film_id = {id} AND sessions.time = '{formatForMySql}'";

                DBConnector.mySqlCommand.ExecuteNonQuery();

                DBConnector.mySqlCommand.CommandText = $@"UPDATE users SET users.balance = users.balance - {Convert.ToInt32(textBoxTicketCost.Text.Remove(textBoxTicketCost.Text.Length-1))} WHERE users.login = '{GlobalVariables.activeUserLogin}'";

                DBConnector.mySqlCommand.ExecuteNonQuery();

                MessageBox.Show($@"Билет на фильм '{textBoxFilmName.Text}', время сеанса {dateTimePickerTime.Value} успешно приобретён за {textBoxTicketCost.Text}!");;

                dataGridViewSessions.Rows.Clear();

                DBConnector.mySqlCommand.CommandText = "SELECT films.name, sessions.ticket_cost, sessions.time, sessions.tickets_count FROM films JOIN sessions ON sessions.film_id = films.id";
 dataReader = DBConnector.mySqlCommand.ExecuteReader();



                while (dataReader.Read())
                {
                    if (dataReader.GetInt32("tickets_count") > 0)
                    {

                        dataGridViewSessions.Rows.Add((dataReader.GetString("name")), (Convert.ToString(dataReader.GetInt32("ticket_cost")) + "₽"), dataReader.GetMySqlDateTime("time"), dataReader.GetInt32("tickets_count"));



                    }

                }
                dataReader.Close();

                textBoxFilmCountry.Clear();
                textBoxFilmName.Clear();
                textBoxFilmProducer.Clear();
                textBoxFilmYear.Clear();
                textBoxTicketCost.Clear();

                DBConnector.mySqlCommand.CommandText = $@"SELECT balance FROM users WHERE login = '{GlobalVariables.activeUserLogin}' AND password = '{GlobalVariables.activeUserPassword}'";

                dataReader = DBConnector.mySqlCommand.ExecuteReader();
                dataReader.Read();
                labelBalance.Text = dataReader.GetInt32("balance").ToString() + "₽";
                dataReader.Close();

            }
            catch (Exception qwe)
            {

                MessageBox.Show("Недостаточно средств на балансе");
            }
        }
    }
}
