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
    public partial class FormAddingBalance : Form
    {
        public FormAddingBalance()
        {
            InitializeComponent();
        }

        private void FormAddingBalance_Load(object sender, EventArgs e)
        {
            labelUser.Text = GlobalVariables.activeUserAddingMoneyLogin;


            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM users WHERE login = '{GlobalVariables.activeUserAddingMoneyLogin}'";

            MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();


            dataReader.Read();

              labelUserBalance.Text = dataReader.GetString("balance") +"₽";

           
            dataReader.Close();


        }

        private void buttonAddBalance_Click(object sender, EventArgs e)
        {
            if (textBoxAddingBalance.Text != "")
            {
                try
                {
                    DBConnector.mySqlCommand.CommandText = $@"UPDATE users SET users.balance = users.balance + {Convert.ToInt32(textBoxAddingBalance.Text)} WHERE users.login = '{GlobalVariables.activeUserAddingMoneyLogin}'";
                    DBConnector.mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show($"Баланс успешно пополнен для {labelUser.Text} на сумму {textBoxAddingBalance.Text}₽");


                    textBoxAddingBalance.Clear();

                    labelUser.Text = GlobalVariables.activeUserAddingMoneyLogin;



                    DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM users WHERE login = '{GlobalVariables.activeUserAddingMoneyLogin}'";

                    MySqlDataReader dataReader = DBConnector.mySqlCommand.ExecuteReader();


                    dataReader.Read();

                    labelUserBalance.Text = dataReader.GetString("balance") + "₽";


                    dataReader.Close();
                }
                catch (Exception wqe)
                {

                    MessageBox.Show("Неверный формат ввода баланса!");
                    textBoxAddingBalance.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Введите сумму пополнения!");
            }
        }
    }
}
