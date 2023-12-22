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
    public partial class Modeleditorpage : Form
    {
        public Modeleditorpage()
        {
            InitializeComponent();
        }

        private void Modeleditorpage_Load(object sender, EventArgs e)
        {

        }

        private void imagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select an Image File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

            }
        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select Image Files";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFileNames = openFileDialog1.FileNames;

                foreach (string fileName in selectedFileNames)
                {
                    Console.WriteLine(fileName);

                }

            }
        }

        private void Digitalbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select Image Files";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFileNames = openFileDialog1.FileNames;

                foreach (string fileName in selectedFileNames)
                {
                    Console.WriteLine(fileName);
                }
            }
        }

        private void Videobutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select Image Files";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFileNames = openFileDialog1.FileNames;

                foreach (string fileName in selectedFileNames)
                {
                    Console.WriteLine(fileName);
                }
            }
        }

        private void Uploadbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
