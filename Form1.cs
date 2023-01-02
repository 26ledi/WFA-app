namespace Lab9WinFormApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AdditionBttn_Click(object sender, EventArgs e)
        {
            var window = new AdditionForm();
            window.Show();
        }

        private void SoustractBttn_Click(object sender, EventArgs e)
        {
            var window = new MatriceA_B();
            window.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var window = new MultiplyForm();
            window.Show();
        }
    }
}