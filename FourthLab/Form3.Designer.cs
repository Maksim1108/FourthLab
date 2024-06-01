using System.Data;

namespace FourthLab
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            datatabl = new DataTable();
            dataGridView1 = new DataGridView();
            newColumn1 = new DataGridViewTextBoxColumn();
            newColumn2 = new DataGridViewTextBoxColumn();
            newColumn3 = new DataGridViewTextBoxColumn();
            newColumn4 = new DataGridViewTextBoxColumn();
            newColumn5 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)datatabl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = UpdateRowSource.None;
            // 
            // datatabl
            // 
            datatabl.Namespace = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { newColumn1, newColumn2, newColumn3, newColumn4, newColumn5 });
            dataGridView1.Location = new Point(94, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(613, 269);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // newColumn1
            // 
            newColumn1.HeaderText = "ID";
            newColumn1.MinimumWidth = 6;
            newColumn1.Name = "newColumn1";
            newColumn1.ReadOnly = true;
            newColumn1.Width = 60;
            // 
            // newColumn2
            // 
            newColumn2.HeaderText = "Название";
            newColumn2.MinimumWidth = 6;
            newColumn2.Name = "newColumn2";
            newColumn2.ReadOnly = true;
            newColumn2.Width = 125;
            // 
            // newColumn3
            // 
            newColumn3.HeaderText = "Количество участников";
            newColumn3.MinimumWidth = 6;
            newColumn3.Name = "newColumn3";
            newColumn3.ReadOnly = true;
            newColumn3.Width = 125;
            // 
            // newColumn4
            // 
            newColumn4.HeaderText = "Место";
            newColumn4.MinimumWidth = 6;
            newColumn4.Name = "newColumn4";
            newColumn4.ReadOnly = true;
            newColumn4.Width = 125;
            // 
            // newColumn5
            // 
            newColumn5.HeaderText = "Дата";
            newColumn5.MinimumWidth = 6;
            newColumn5.Name = "newColumn5";
            newColumn5.ReadOnly = true;
            newColumn5.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(408, 375);
            button2.Name = "button2";
            button2.Size = new Size(206, 43);
            button2.TabIndex = 3;
            button2.Text = "Сохранить в файл";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 62);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(184, 375);
            button1.Name = "button1";
            button1.Size = new Size(206, 43);
            button1.TabIndex = 5;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "LiveSport";
            ((System.ComponentModel.ISupportInitialize)datatabl).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataTable datatabl;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn newColumn1;
        private DataGridViewTextBoxColumn newColumn2;
        private DataGridViewTextBoxColumn newColumn3;
        private DataGridViewTextBoxColumn newColumn4;
        private DataGridViewTextBoxColumn newColumn5;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}