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


namespace Model_Agency_Pack_Software
{
    public partial class model : Form
    {
        public model()
        {
            InitializeComponent();
        }

        private void eyeslabel_Click(object sender, EventArgs e)
        {

        }

        private void returntomainpage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            form1.FormClosed += (s, args) => this.Close();
        }
        public void SetModelName(string modelName)
        {
            MessageBox.Show("Selected model: " + modelName);
        }
    }

}
