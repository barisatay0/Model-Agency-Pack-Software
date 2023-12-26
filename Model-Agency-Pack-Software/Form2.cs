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

            openFileDialog1.Filter = "Video Files|*.mp4;*.wmv;*.wm;*.mov;*.mov";
            openFileDialog1.Title = "Select Video Files";
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
            string Name = Nametext.Text;
            string Height = Heighttext.Text;
            string Chestbust = Chestbusttext.Text;
            string Waist = waisttext.Text;
            string Hips = Hipstext.Text;
            string Shoes = Shoestext.Text;
            string Eyes = Eyestext.Text;
            string instagram = İnstagramtext.Text;

            string connectionString = "server=127.0.0.1;port=3306;database=pack;user=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected.");

                string insertQuery = "INSERT INTO items (name, height, chest, waist, hips, shoes, eyes, instagram) VALUES (@Name, @Height, @Chestbust, @Waist, @Hips, @Shoes, @Eyes, @Instagram)";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Height", Height);
                command.Parameters.AddWithValue("@Chestbust", Chestbust);
                command.Parameters.AddWithValue("@Waist", Waist);
                command.Parameters.AddWithValue("@Hips", Hips);
                command.Parameters.AddWithValue("@Shoes", Shoes);
                command.Parameters.AddWithValue("@Eyes", Eyes);
                command.Parameters.AddWithValue("@Instagram", instagram);



                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    Console.WriteLine("Model Added.");
                    MessageBox.Show("Model Added");
                }
                else
                {
                    Console.WriteLine("Model Couldn't add");
                    MessageBox.Show("Model Couldn't add");
                }

                connection.Close(); // Veritabanı bağlantısını kapat
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                MessageBox.Show("Database Error: " + ex.Message);
            }

        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void returntomainpage_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void İnstagramtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Heighttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chestbusttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void waisttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hipstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shoestext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eyestext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
