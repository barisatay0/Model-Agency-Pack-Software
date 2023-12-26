using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void models_Enter(object sender, EventArgs e)
        {
        }
    }
}