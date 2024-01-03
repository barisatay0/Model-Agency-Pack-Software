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
            models = new GroupBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            website = new Button();
            modelgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
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
            DeleteAll.Location = new Point(550, 12);
            DeleteAll.Name = "DeleteAll";
            DeleteAll.Size = new Size(208, 33);
            DeleteAll.TabIndex = 3;
            DeleteAll.Text = "Delete All";
            DeleteAll.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            Search.Location = new Point(777, 12);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.Size = new Size(326, 33);
            Search.TabIndex = 4;
            Search.Text = "Search";
            // 
            // modeleditor
            // 
            modeleditor.BackColor = Color.Black;
            modeleditor.Cursor = Cursors.Hand;
            modeleditor.FlatStyle = FlatStyle.Flat;
            modeleditor.ForeColor = Color.White;
            modeleditor.Location = new Point(1119, 12);
            modeleditor.Name = "modeleditor";
            modeleditor.Size = new Size(194, 33);
            modeleditor.TabIndex = 5;
            modeleditor.Text = "+ Model Editor";
            modeleditor.UseVisualStyleBackColor = false;
            modeleditor.Click += modeleditor_Click;
            // 
            // models
            // 
            models.Location = new Point(336, 54);
            models.Name = "models";
            models.Size = new Size(1420, 678);
            models.TabIndex = 8;
            models.TabStop = false;
            models.Text = "Models";
            models.Enter += models_Enter;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;
            // 
            // website
            // 
            website.BackColor = SystemColors.InfoText;
            website.FlatStyle = FlatStyle.Flat;
            website.ForeColor = Color.White;
            website.Location = new Point(1511, 15);
            website.Name = "website";
            website.Size = new Size(239, 33);
            website.TabIndex = 9;
            website.Text = "Website";
            website.UseVisualStyleBackColor = false;
            website.Click += website_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1764, 746);
            Controls.Add(website);
            Controls.Add(Search);
            Controls.Add(models);
            Controls.Add(DeleteAll);
            Controls.Add(modeleditor);
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
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private GroupBox models;
        private FileSystemWatcher fileSystemWatcher1;
        private Button website;
    }
}