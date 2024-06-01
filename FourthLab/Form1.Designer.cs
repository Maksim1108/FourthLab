namespace FourthLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            addButton = new Button();
            showButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.GradientInactiveCaption;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = Color.SlateGray;
            addButton.Location = new Point(422, 179);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(233, 96);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButtonClick;
            // 
            // showButton
            // 
            showButton.BackColor = SystemColors.GradientInactiveCaption;
            showButton.Cursor = Cursors.Hand;
            showButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showButton.ForeColor = Color.SlateGray;
            showButton.Location = new Point(422, 296);
            showButton.Margin = new Padding(3, 4, 3, 4);
            showButton.Name = "showButton";
            showButton.Size = new Size(233, 96);
            showButton.TabIndex = 1;
            showButton.Text = "Показать";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showListButtonClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(396, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 65);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1063, 556);
            Controls.Add(pictureBox1);
            Controls.Add(showButton);
            Controls.Add(addButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "LiveSport";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button showButton;
        private PictureBox pictureBox1;
    }
}
