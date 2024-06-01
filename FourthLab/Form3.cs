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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FourthLab
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView
        {
            get { return dataGridView1; }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            saveOnFile();
        }

        public void showList()
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
                            dataGridView1.Rows.Clear();

                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4));
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

        private void saveOnFile()
        {
            int rowCounter = dataGridView1.RowCount;
            int columnCount = dataGridView1.ColumnCount;
            string[] line = new string[columnCount];
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt file (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            line[j] = (dataGridView1.Rows[i].Cells[j].Value ?? "").ToString();
                        }
                        writer.WriteLine(string.Join(" ", line));
                    }
                }
            }
        }

        private void openEditForm(int id)
        {
            Form4 newForm = new Form4(id, this.DataGridView);

            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить результат?", "Мяу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    int idToDelete = Convert.ToInt32(selectedRow.Cells["newColumn1"].Value);

                    using (SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\Максим\\Desktop\\4 сем\\РПС\\FourthLab\\FourthLab\\DataBase.db"))
                    {
                        connection.Open();
                        string sql = "DELETE FROM Results WHERE ID = @id";
                        using (SqliteCommand command = new SqliteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id", idToDelete);
                            command.ExecuteNonQuery();
                        }
                    }

                    dataGridView1.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Выберите ячейку для удаления строки.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
       
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["newColumn1"].Value);

                openEditForm(id);
            }
        }
    }
}