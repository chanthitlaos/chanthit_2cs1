namespace Chanthit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 _form2 = new Form2();
            _form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 _form3 = new Form3();
            _form3.Show();
        }
    }
}