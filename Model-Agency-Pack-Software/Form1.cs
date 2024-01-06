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
                pictureBox.Width = 200;
                pictureBox.Height = 300;
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
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "Select";
                checkBox.Location = new Point(pictureBoxLeft, pictureBoxTop + pictureBox.Height + 20);
                checkBox.CheckedChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        if (!Modellist.Items.Contains(modelName))
                        {
                            Modellist.Items.Add(modelName);
                        }
                    }
                    else
                    {
                        Modellist.Items.Remove(modelName);
                    }
                };


                modelpictures.Controls.Add(checkBox);
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
            string searchKeyword = Search.Text.Trim(); 
            if (string.IsNullOrEmpty(searchKeyword))
            {
                foreach (Control control in modelpictures.Controls)
                {
                    control.Visible = true;
                }
            }
            else
            {
                foreach (Control control in modelpictures.Controls)
                {
                    if (control is Label label) 
                    {
                        string modelName = label.Text;
                        if (modelName.ToLower().Contains(searchKeyword.ToLower()))
                        {
                            int pictureBoxIndex = control.TabIndex + 1;
                            int checkBoxIndex = control.TabIndex + 2;
                            control.Visible = true;
                            if (pictureBoxIndex < control.Parent.Controls.Count &&
                checkBoxIndex < control.Parent.Controls.Count)
                            {
                                control.Parent.Controls[pictureBoxIndex].Visible = true;
                                control.Parent.Controls[checkBoxIndex].Visible = true;
                            }
                        }
                        else
                        {
                            control.Visible = false;

                            int pictureBoxIndex = control.TabIndex + 1;
                            int checkBoxIndex = control.TabIndex + 2;

                            if (pictureBoxIndex < control.Parent.Controls.Count &&
                                checkBoxIndex < control.Parent.Controls.Count)
                            {
                                control.Parent.Controls[pictureBoxIndex].Visible = false;
                                control.Parent.Controls[checkBoxIndex].Visible = false; 
                            }
                        }
                    }
                }
            }
        }

        private void modelpictures_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Modellist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in modelpictures.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = true;
                }
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in modelpictures.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Checked = false;
                }
            }

            List<string> itemsToRemove = new List<string>();

            foreach (var selectedItem in Modellist.SelectedItems.Cast<string>().ToList())
            {
                itemsToRemove.Add(selectedItem);
            }

            foreach (var itemToRemove in itemsToRemove)
            {
                Modellist.Items.Remove(itemToRemove);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            StringBuilder urlBuilder = new StringBuilder("localhost/pack.php?");
            List<string> modelIds = new List<string>();
            string connectionString = "server=127.0.0.1;port=3306;database=pack;user=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            foreach (var item in Modellist.Items)
            {
                string modelName = item.ToString();
                string selectQuery = "SELECT id FROM items WHERE name = @modelName";
                MySqlCommand idCommand = new MySqlCommand(selectQuery, connection);
                idCommand.Parameters.AddWithValue("@modelName", modelName);
                var idReader = idCommand.ExecuteReader();

                if (idReader.Read())
                {
                    string modelId = idReader["id"].ToString();
                    modelIds.Add($"id[]={modelId}");
                }

                idReader.Close();
            }
            textBox1.Text = "localhost/pack.php?" + string.Join("&", modelIds);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}