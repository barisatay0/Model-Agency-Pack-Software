using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            string connectionString = "server=127.0.0.1;port=3306;database=pack;user=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connected.");

            string selectQuery = "SELECT name, image FROM items";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            int pictureBoxTop = 10;
            int pictureBoxLeft = 10;

            while (reader.Read())
            {
                string modelName = reader["name"].ToString();
                string imagePath = reader["image"].ToString();

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 300;
                pictureBox.Height = 400;
                pictureBox.Location = new Point(pictureBoxLeft, pictureBoxTop);

                try
                {
                    pictureBox.Image = Image.FromFile(@"C:\xampp\htdocs\data\" + imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }

                modelpictures.Controls.Add(pictureBox);

                Label label = new Label();
                label.Text = modelName;
                label.Location = new Point(pictureBoxLeft, pictureBoxTop + pictureBox.Height);
                label.Width = 100;
                label.TextAlign = ContentAlignment.MiddleCenter;

                modelpictures.Controls.Add(label);

                pictureBoxLeft += pictureBox.Width + 10;

                if (pictureBoxLeft + pictureBox.Width > modelpictures.Width)
                {
                    pictureBoxLeft = 10;
                    pictureBoxTop += pictureBox.Height + label.Height + 10;
                }
            }

            reader.Close();

        }

        private void modeleditor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modeleditorpage modeleditorPage = new Modeleditorpage();
            modeleditorPage.FormClosed += (s, args) => this.Close();
            modeleditorPage.Show();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void models_Enter(object sender, EventArgs e)
        {
        }

        private void website_Click(object sender, EventArgs e)
        {
            OpenWebsite();
        }
        private void OpenWebsite()
        {
            string url = "https://pack.reepmodel.com";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelpictures_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}