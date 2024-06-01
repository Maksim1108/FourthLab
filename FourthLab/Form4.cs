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
    public partial class Form4 : Form
    {
        private int id;
        private DataGridView mainDataGridView;
        public Form4(int id, DataGridView dataGridView1)
        {
            InitializeComponent();
            this.id = id;
            this.mainDataGridView = dataGridView1;
            textBox1.Text = id.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            searchResultById();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        public void searchResultById()
        {
            string dbPath = "Data Source=C:\\Users\\Максим\\Desktop\\4 сем\\РПС\\FourthLab\\FourthLab\\DataBase.db";

            try
            {
                using (SqliteConnection connection = new SqliteConnection(dbPath))
                {
                    connection.Open();

                    string query = $"SELECT * FROM Results WHERE id={id};";

                    using (SqliteCommand command = new SqliteCommand(query, connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox2.Text = reader.GetString(1);
                                textBox3.Text = reader.GetInt32(2).ToString();
                                textBox4.Text = reader.GetInt32(3).ToString();
                                dateTimePicker1.Text = reader.GetString(4);
                            }
                            else
                            {
                                MessageBox.Show("Результат с таким ID не найден");
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void saveChanges()
        {
            string dbPath = "Data Source=C:\\Users\\Максим\\Desktop\\4 сем\\РПС\\FourthLab\\FourthLab\\DataBase.db";

            if (!int.TryParse(textBox1.Text, out int resultID))
            {
                MessageBox.Show("Некорректное значение ID результата.");
                return;
            }

            string name = textBox2.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя.");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int numberOfPlayers))
            {
                MessageBox.Show("Некорректное значение количества игроков.");
                return;
            }

            if (!int.TryParse(textBox4.Text, out int place))
            {
                MessageBox.Show("Некорректное значение места.");
                return;
            }

            string date = dateTimePicker1.Text;

            try
            {
                using (SqliteConnection connection = new SqliteConnection(dbPath))
                {
                    connection.Open();

                    string query = "UPDATE Results SET name=@Name, numberOfPlayers=@NumberOfPlayers, place=@Place, date=@Date WHERE id=@ResultID";

                    SqliteCommand command = new SqliteCommand(query, connection);

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@NumberOfPlayers", numberOfPlayers);
                    command.Parameters.AddWithValue("@Place", place);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@ResultID", resultID);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Изменения сохранены успешно.");

                    updateMainDataGridView();

                    connection.Close();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void updateMainDataGridView()
        {
            string dbPath = "Data Source=C:\\Users\\Максим\\Desktop\\4 сем\\РПС\\FourthLab\\FourthLab\\DataBase.db";

            try
            {
                using (SqliteConnection connection = new SqliteConnection(dbPath))
                {
                    connection.Open();

                    using (SqliteCommand command = new SqliteCommand("SELECT * FROM Results", connection))
                    {
                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            mainDataGridView.Rows.Clear();

                            while (reader.Read())
                            {
                                mainDataGridView.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

    }
}
