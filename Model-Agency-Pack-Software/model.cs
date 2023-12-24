using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
