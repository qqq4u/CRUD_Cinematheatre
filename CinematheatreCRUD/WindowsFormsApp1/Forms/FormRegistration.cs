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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" || textBoxPassword.Text != "")
            {
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `administrators` WHERE `login` = '{textBoxLogin.Text}'";
                MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Такой пользователь уже существует!");
                }
                else
                {
                    reader.Close();
                    DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE `login` = '{textBoxLogin.Text}'";
                 reader = DBConnector.mySqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        MessageBox.Show("Такой пользователь уже существует!");
                    }
                    else
                    {
                        reader.Close();
                        if (radioButtonAdministrator.Checked)
                        {
                            DBConnector.mySqlCommand.CommandText = $@"INSERT INTO `administrators`(login,password) VALUES('{textBoxLogin.Text}','{textBoxPassword.Text}')";
                            DBConnector.mySqlCommand.ExecuteNonQuery();
                            MessageBox.Show($"Зарегестрирован новый администратор:\nЛогин: {textBoxLogin.Text}\nПароль:{textBoxPassword.Text}");
                            this.Close();
                        }
                        else if (radioButtonUser.Checked)
                        {
                            DBConnector.mySqlCommand.CommandText = $@"INSERT INTO `users`(login,password) VALUES('{textBoxLogin.Text}','{textBoxPassword.Text}')";
                            DBConnector.mySqlCommand.ExecuteNonQuery();
                            MessageBox.Show($"Зарегестрирован новый пользователь:\nЛогин: {textBoxLogin.Text}\nПароль:{textBoxPassword.Text}");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не выбрано роли");
                        }
                    }
                }

            }
            // TODO СДелать запрет регистрации одинакого логина

            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
