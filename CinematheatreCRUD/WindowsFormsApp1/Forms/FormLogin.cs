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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `administrators` WHERE `login` = '{textBoxLogin.Text}' AND `password` = '{ textBoxPassword.Text}'";
            MySqlDataReader reader = DBConnector.mySqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                Form form = new FormAdministrator();
                this.Visible = false;
                form.ShowDialog();
                this.Visible = true;
                textBoxLogin.Clear();
                textBoxPassword.Clear();
            }
            else
            {
                reader.Close();
                DBConnector.mySqlCommand.CommandText = $@"SELECT * FROM `users` WHERE `login` = '{textBoxLogin.Text}' AND `password` = '{ textBoxPassword.Text}'";
               reader = DBConnector.mySqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    Form form = new FormUser();
                    this.Visible = false;
                    form.ShowDialog();
                    this.Visible = true;
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Такого пользователя не существует, проверьте правильность введённых данных или пройдите регистрацию!");
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                }
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DBConnector.mySqlConnection.Open();
            DBConnector.mySqlCommand.Connection = DBConnector.mySqlConnection;
        }
        // TODO сделать сортировку по дате, то есть вывод тех сеансов, которые ещё не прошли(в форме пользователя)

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            Form form = new FormRegistration();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
