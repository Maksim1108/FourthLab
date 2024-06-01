using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FourthLab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkIfDataExists();
        }

        private void checkIfDataExists()
        {
            string dbPath = "Data Source=C:\\Users\\Максим\\Desktop\\4 сем\\РПС\\FourthLab\\FourthLab\\DataBase.db";

            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
                {
                    MessageBox.Show("[!] Заполните все поля");
                    return;
                }

                string name = textBox1.Text;
    
                if (!int.TryParse(textBox2.Text, out int numberOfPlayers) || numberOfPlayers <= 0)
                {
                    MessageBox.Show("Введите корректное количество участников.");
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int place) || place <= 0)
                {
                    MessageBox.Show("Введите корректное место.");
                    return;
                }

                string date = dateTimePicker1.Text;

                using (SqliteConnection connection = new SqliteConnection(dbPath))
                {
                    connection.Open();

                    string query = "INSERT INTO Results(name, numberOfPlayers, place, date) VALUES (@Name, @NumberOfPlayers, @Place, @Date)";

                    SqliteCommand command = new SqliteCommand(query, connection);

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@NumberOfPlayers", numberOfPlayers);
                    command.Parameters.AddWithValue("@Place", place);
                    command.Parameters.AddWithValue("@Date", date);

                    command.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("Данные успешно сохранены");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}