namespace Model_Agency_Pack_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modeleditor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modeleditorpage modeleditorPage = new Modeleditorpage();
            modeleditorPage.Show();
        }
    }
}