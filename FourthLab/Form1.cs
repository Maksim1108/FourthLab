namespace FourthLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("\t М. В. Лянко, группа 423, СПбГТИ \n \tКонтрольная работа #4, вариант 10 \n");
        }

        private void addButtonClick(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void showListButtonClick(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            MessageBox.Show("Для редактирования нажмите два раза по элементу");
            newForm.showList();
        }
    }
}
