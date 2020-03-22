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
    public partial class FormUsersBalance : Form
    {
        public FormUsersBalance()
        {
            InitializeComponent();
        }

        private void FormUsersBalance_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = "SELECT * FROM users";

            MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();


            while (dataReader.Read())
            {

                dataGridViewUsersBalances.Rows.Add((dataReader.GetString("login")), (Convert.ToString(dataReader.GetInt32("balance")) + "₽"));

            }
            dataReader.Close();
        }

        private void dataGridViewUsersBalances_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                labelBalance.Text = dataGridViewUsersBalances.SelectedRows[0].Cells[1].Value.ToString();
                labelUserLogin.Text = dataGridViewUsersBalances.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Для выбора информации о балансе пользователя нажмите на крайний боковой столбец");

            }
        }

        private void buttonAddBalance_Click(object sender, EventArgs e)
        {
            GlobalVariables.activeUserAddingMoneyLogin = labelUserLogin.Text;
            Form form = new FormAddingBalance();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;

            dataGridViewUsersBalances.Rows.Clear();

            DBConnector.mySqlCommand.CommandText = "SELECT users.login, users.balance FROM users";

            MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();


            while (dataReader.Read())
            {

                dataGridViewUsersBalances.Rows.Add((dataReader.GetString("login")), (Convert.ToString(dataReader.GetInt32("balance")) + "₽"));

            }
            dataReader.Close();

            labelBalance.Text = "";
            labelUserLogin.Text = "";

        }

        private void dataGridViewUsersBalances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
