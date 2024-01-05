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
            string connectionString = "server=127.0.0.1;port=3306;database=pack;user=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected.");

                string selectQuery = "SELECT name, image FROM items";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                int verticalSpacing = 10;
                int startingHeight = 0;

                while (reader.Read())
                {
                    string modelName = reader.GetString("name");
                    string imageFileName = reader.GetString("image");

                    string imageFilePath = Path.Combine(@"C:\xampp\htdocs\data\", imageFileName);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(600, 600);
                    pictureBox.Location = new Point(600, startingHeight);

                    if (File.Exists(imageFilePath))
                    {
                        pictureBox.Image = Image.FromFile(imageFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Dosya bulunamadı: " + imageFilePath);
                    }

                    modelspanel.Controls.Add(pictureBox);

                    Button modelButton = new Button();
                    modelButton.Text = modelName;
                    modelButton.BackColor = Color.Black;
                    modelButton.ForeColor = Color.White;

                    modelButton.Width = 600;
                    modelButton.Height = 35;

                    modelButton.Location = new Point(600, startingHeight + pictureBox.Height);
                    modelButton.Click += (s, ev) =>
                    {
                        string selectedModel = modelName;
                        model modelForm = new model();
                        modelForm.SetModelName(selectedModel);
                        modelForm.Show();
                        this.Hide();
                        modelForm.FormClosed += (s, args) => this.Close();
                    };

                    modelspanel.Controls.Add(modelButton);

                    startingHeight = pictureBox.Location.Y + pictureBox.Height + 10;
                }


                reader.Close();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        List<string> imageFilePaths = new List<string>();
        List<string> bookFilePaths = new List<string>();
        List<string> digitalFilePaths = new List<string>();
        List<string> videoFilePaths = new List<string>();
        List<string> uniqueImageNames = new List<string>();
        List<string> uniqueBookNames = new List<string>();
        List<string> uniqueDigitalNames = new List<string>();
        List<string> uniqueVideoNames = new List<string>();

        private void imagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; 
            imageDialog.Title = "Select Image Files";
            imageDialog.Multiselect = true;

            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in imageDialog.FileNames)
                {
                    string uniqueName = Guid.NewGuid().ToString(); 
                    string fileExtension = Path.GetExtension(fileName);

                    string destinationPath = @"C:\xampp\htdocs\data\" + uniqueName + fileExtension;

                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);

                    imageFilePaths.Add(destinationPath);
                    uniqueImageNames.Add(uniqueName + fileExtension);
                }
            }

        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog bookDialog = new OpenFileDialog();
            bookDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            bookDialog.Title = "Select Book Files";
            bookDialog.Multiselect = true;

            if (bookDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in bookDialog.FileNames)
                {
                    string uniqueName = Guid.NewGuid().ToString();
                    string fileExtension = Path.GetExtension(fileName);

                    string destinationPath = @"C:\xampp\htdocs\data\" + uniqueName + fileExtension;

                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);

                    bookFilePaths.Add(destinationPath);
                    uniqueBookNames.Add(uniqueName + fileExtension);
                }
            }

        }

        private void Digitalbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog digitalDialog = new OpenFileDialog();
            digitalDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            digitalDialog.Title = "Select Digital Files";
            digitalDialog.Multiselect = true;

            if (digitalDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in digitalDialog.FileNames)
                {
                    string uniqueName = Guid.NewGuid().ToString(); 
                    string fileExtension = Path.GetExtension(fileName); 

                    string destinationPath = @"C:\xampp\htdocs\data\" + uniqueName + fileExtension;

                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);

                    digitalFilePaths.Add(destinationPath);
                    uniqueDigitalNames.Add(uniqueName + fileExtension);
                }
            }
        }

        private void Videobutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog videoDialog = new OpenFileDialog();
            videoDialog.Filter = "Video Files|*.mp4;*.wmv;*.wm;*.mov;*.mov"; 
            videoDialog.Title = "Select Video Files";
            videoDialog.Multiselect = true;

            if (videoDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in videoDialog.FileNames)
                {
                    string uniqueName = Guid.NewGuid().ToString();
                    string fileExtension = Path.GetExtension(fileName); 

                    string destinationPath = @"C:\xampp\htdocs\data\" + uniqueName + fileExtension;

                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);

                    videoFilePaths.Add(destinationPath);
                    uniqueVideoNames.Add(uniqueName + fileExtension); 
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

                string insertQuery = "INSERT INTO items (name, height, chest, waist, hips, shoes, eyes, instagram, image, book, digital, video) VALUES (@Name, @Height, @Chestbust, @Waist, @Hips, @Shoes, @Eyes, @Instagram, @Image, @Book, @Digital, @Video)";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Height", Height);
                command.Parameters.AddWithValue("@Chestbust", Chestbust);
                command.Parameters.AddWithValue("@Waist", Waist);
                command.Parameters.AddWithValue("@Hips", Hips);
                command.Parameters.AddWithValue("@Shoes", Shoes);
                command.Parameters.AddWithValue("@Eyes", Eyes);
                command.Parameters.AddWithValue("@Instagram", instagram);


                command.Parameters.AddWithValue("@Image", string.Join(",", uniqueImageNames));
                command.Parameters.AddWithValue("@Book", string.Join(",", uniqueBookNames));
                command.Parameters.AddWithValue("@Digital", string.Join(",", uniqueDigitalNames));
                command.Parameters.AddWithValue("@Video", string.Join(",", uniqueVideoNames));

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
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                foreach (string fileName in imageFilePaths)
                {
                    string destinationPath = @"C:\xampp\htdocs\data\" + Path.GetFileName(fileName);
                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);
                }
                foreach (string fileName in bookFilePaths)
                {
                    string destinationPath = @"C:\xampp\htdocs\data\" + Path.GetFileName(fileName);
                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);
                }
                foreach (string fileName in digitalFilePaths)
                {
                    string destinationPath = @"C:\xampp\htdocs\data\" + Path.GetFileName(fileName);
                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);
                }
                foreach (string fileName in videoFilePaths)
                {
                    string destinationPath = @"C:\xampp\htdocs\data\" + Path.GetFileName(fileName);
                    File.Copy(fileName, destinationPath, true);
                    Console.WriteLine("File copied to: " + destinationPath);
                }


                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                MessageBox.Show("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while copying files: " + ex.Message);
                MessageBox.Show("Error while copying files: " + ex.Message);
            }
        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void returntomainpage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            form1.FormClosed += (s, args) => this.Close();
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

        private void Models_Enter(object sender, EventArgs e)
        {

        }

        private void modelspanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
