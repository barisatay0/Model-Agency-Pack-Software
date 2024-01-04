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
            string connectionString = "server=127.0.0.1;port=3306;database=pack;user=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string selectQuery = "SELECT * FROM items WHERE name = @modelName";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@modelName", modelName);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Nametext.Text = reader["name"].ToString();
                    Heighttext.Text = reader["height"].ToString();
                    Chesttext.Text = reader["chest"].ToString();
                    Waisttext.Text = reader["waist"].ToString();
                    Hipstext.Text = reader["hips"].ToString();
                    Shoestext.Text = reader["shoes"].ToString();
                    Eyestext.Text = reader["eyes"].ToString();
                    Nametext.ReadOnly = true;

                    string bookPhotos = reader["book"].ToString();
                    string digitalPhotos = reader["digital"].ToString();

                    string[] bookPhotoList = bookPhotos.Split(',');
                    string[] digitalPhotoList = digitalPhotos.Split(',');
                    string photoDirectory = @"C:\xampp\htdocs\data\";

                    int pictureBoxHeight = 100;
                    int spacing = 10;
                    int currentY = 0;

                    bookpanel.Controls.Clear();
                    foreach (string photoName in bookPhotoList)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile(System.IO.Path.Combine(photoDirectory, photoName.Trim()));
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Height = pictureBoxHeight;
                        pb.Width = bookpanel.Width - 50;
                        pb.Location = new Point(0, currentY);

                        bookpanel.Controls.Add(pb);
                        currentY += pictureBoxHeight + spacing;
                    }

                    currentY = 0;

                    digitalpanel.Controls.Clear();
                    foreach (string photoName in digitalPhotoList)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile(System.IO.Path.Combine(photoDirectory, photoName.Trim()));
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Height = pictureBoxHeight;
                        pb.Width = digitalpanel.Width - 50;
                        pb.Location = new Point(0, currentY);

                        digitalpanel.Controls.Add(pb);
                        currentY += pictureBoxHeight + spacing;
                    }
                }
                else
                {
                    MessageBox.Show("Model not found.");
                }


            }
        }

        private void Eyestext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shoestext_TextChanged(object sender, EventArgs e)
        {
        }

        private void Hipstext_TextChanged(object sender, EventArgs e)
        {
        }

        private void Waisttext_TextChanged(object sender, EventArgs e)
        {
        }

        private void Chesttext_TextChanged(object sender, EventArgs e)
        {
        }

        private void Heighttext_TextChanged(object sender, EventArgs e)
        {
        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string newmodelName = Nametext.Text;
                string newHeight = Heighttext.Text;
                string newChest = Chesttext.Text;
                string newWaist = Waisttext.Text;
                string newHips = Hipstext.Text;
                string newShoes = Shoestext.Text;
                string newEyes = Eyestext.Text;

                string connectionString = "server=127.0.0.1;port=3306;database=pack;user=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string updateQuery = "UPDATE items SET height = @newHeight, chest = @newChest, " +
                                     "waist = @newWaist, hips = @newHips, shoes = @newShoes, eyes = @newEyes " +
                                     "WHERE name = @modelName";

                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@newHeight", newHeight);
                command.Parameters.AddWithValue("@newChest", newChest);
                command.Parameters.AddWithValue("@newWaist", newWaist);
                command.Parameters.AddWithValue("@newHips", newHips);
                command.Parameters.AddWithValue("@newShoes", newShoes);
                command.Parameters.AddWithValue("@newEyes", newEyes);
                command.Parameters.AddWithValue("@modelName", newmodelName);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Successfully Updated.");
                }
                else
                {
                    MessageBox.Show("Update doesnt work.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void addbook_Click(object sender, EventArgs e)
        {

        }

        private void AddDigital_Click(object sender, EventArgs e)
        {

        }

        private void Newimagebutton_Click(object sender, EventArgs e)
        {

        }
    }

}
