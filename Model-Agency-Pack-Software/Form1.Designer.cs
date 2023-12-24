namespace Model_Agency_Pack_Software
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            modelgroupbox = new GroupBox();
            Save = new Button();
            Modellist = new ListBox();
            textBox1 = new TextBox();
            SelectAll = new Button();
            DeleteAll = new Button();
            Search = new TextBox();
            modeleditor = new Button();
            button2 = new Button();
            button1 = new Button();
            models = new GroupBox();
            modelgroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // modelgroupbox
            // 
            modelgroupbox.Controls.Add(Save);
            modelgroupbox.Controls.Add(Modellist);
            modelgroupbox.Location = new Point(10, 7);
            modelgroupbox.Name = "modelgroupbox";
            modelgroupbox.Size = new Size(298, 683);
            modelgroupbox.TabIndex = 0;
            modelgroupbox.TabStop = false;
            modelgroupbox.Text = "Model List";
            // 
            // Save
            // 
            Save.BackColor = Color.White;
            Save.FlatAppearance.BorderColor = Color.Black;
            Save.FlatAppearance.BorderSize = 2;
            Save.FlatAppearance.MouseDownBackColor = Color.Black;
            Save.FlatAppearance.MouseOverBackColor = Color.Black;
            Save.FlatStyle = FlatStyle.Popup;
            Save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ActiveCaptionText;
            Save.Location = new Point(7, 639);
            Save.Name = "Save";
            Save.Size = new Size(285, 33);
            Save.TabIndex = 1;
            Save.Text = "Save Selection";
            Save.UseVisualStyleBackColor = false;
            // 
            // Modellist
            // 
            Modellist.FormattingEnabled = true;
            Modellist.ItemHeight = 23;
            Modellist.Location = new Point(7, 30);
            Modellist.Name = "Modellist";
            Modellist.Size = new Size(284, 602);
            Modellist.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 697);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 30);
            textBox1.TabIndex = 1;
            textBox1.Text = "Link Will Be Here";
            // 
            // SelectAll
            // 
            SelectAll.BackColor = Color.White;
            SelectAll.Cursor = Cursors.Hand;
            SelectAll.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            SelectAll.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            SelectAll.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            SelectAll.FlatStyle = FlatStyle.Flat;
            SelectAll.ForeColor = Color.Black;
            SelectAll.Location = new Point(336, 14);
            SelectAll.Name = "SelectAll";
            SelectAll.Size = new Size(208, 33);
            SelectAll.TabIndex = 2;
            SelectAll.Text = "Select All";
            SelectAll.UseVisualStyleBackColor = false;
            // 
            // DeleteAll
            // 
            DeleteAll.BackColor = Color.White;
            DeleteAll.Cursor = Cursors.Hand;
            DeleteAll.FlatAppearance.BorderColor = Color.Red;
            DeleteAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            DeleteAll.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            DeleteAll.FlatStyle = FlatStyle.Flat;
            DeleteAll.ForeColor = Color.Black;
            DeleteAll.Location = new Point(551, 14);
            DeleteAll.Name = "DeleteAll";
            DeleteAll.Size = new Size(208, 33);
            DeleteAll.TabIndex = 3;
            DeleteAll.Text = "Delete All";
            DeleteAll.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            Search.Location = new Point(793, 14);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.Size = new Size(193, 32);
            Search.TabIndex = 4;
            Search.Text = "Search";
            // 
            // modeleditor
            // 
            modeleditor.BackColor = Color.Black;
            modeleditor.Cursor = Cursors.Hand;
            modeleditor.FlatStyle = FlatStyle.Flat;
            modeleditor.ForeColor = Color.White;
            modeleditor.Location = new Point(1009, 14);
            modeleditor.Name = "modeleditor";
            modeleditor.Size = new Size(169, 33);
            modeleditor.TabIndex = 5;
            modeleditor.Text = "+ Model Editor";
            modeleditor.UseVisualStyleBackColor = false;
            modeleditor.Click += modeleditor_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1558, 14);
            button2.Name = "button2";
            button2.Size = new Size(198, 33);
            button2.TabIndex = 7;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1353, 14);
            button1.Name = "button1";
            button1.Size = new Size(198, 33);
            button1.TabIndex = 6;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = true;
            // 
            // models
            // 
            models.Location = new Point(336, 54);
            models.Name = "models";
            models.Size = new Size(1420, 678);
            models.TabIndex = 8;
            models.TabStop = false;
            models.Text = "Models";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1764, 746);
            Controls.Add(models);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(modeleditor);
            Controls.Add(Search);
            Controls.Add(DeleteAll);
            Controls.Add(SelectAll);
            Controls.Add(textBox1);
            Controls.Add(modelgroupbox);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Model";
            Load += Form1_Load;
            modelgroupbox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox modelgroupbox;
        private Button Save;
        private ListBox Modellist;
        private TextBox textBox1;
        private Button SelectAll;
        private Button DeleteAll;
        private TextBox Search;
        private Button modeleditor;
        private Button button2;
        private Button button1;
        private GroupBox models;
    }
}