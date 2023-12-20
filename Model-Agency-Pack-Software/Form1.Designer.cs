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
            groupBox1 = new GroupBox();
            modelgroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // modelgroupbox
            // 
            modelgroupbox.Controls.Add(Save);
            modelgroupbox.Controls.Add(Modellist);
            modelgroupbox.Location = new Point(9, 6);
            modelgroupbox.Name = "modelgroupbox";
            modelgroupbox.Size = new Size(265, 594);
            modelgroupbox.TabIndex = 0;
            modelgroupbox.TabStop = false;
            modelgroupbox.Text = "Model List";
            // 
            // Save
            // 
            Save.Location = new Point(6, 556);
            Save.Name = "Save";
            Save.Size = new Size(253, 29);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            // 
            // Modellist
            // 
            Modellist.FormattingEnabled = true;
            Modellist.ItemHeight = 20;
            Modellist.Location = new Point(6, 26);
            Modellist.Name = "Modellist";
            Modellist.Size = new Size(253, 524);
            Modellist.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 606);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 1;
            // 
            // SelectAll
            // 
            SelectAll.Location = new Point(299, 12);
            SelectAll.Name = "SelectAll";
            SelectAll.Size = new Size(185, 29);
            SelectAll.TabIndex = 2;
            SelectAll.Text = "Select All";
            SelectAll.UseVisualStyleBackColor = true;
            // 
            // DeleteAll
            // 
            DeleteAll.Location = new Point(490, 12);
            DeleteAll.Name = "DeleteAll";
            DeleteAll.Size = new Size(185, 29);
            DeleteAll.TabIndex = 3;
            DeleteAll.Text = "Delete All";
            DeleteAll.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.Location = new Point(705, 12);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.Size = new Size(172, 28);
            Search.TabIndex = 4;
            Search.Text = "Search";
            // 
            // modeleditor
            // 
            modeleditor.Location = new Point(897, 12);
            modeleditor.Name = "modeleditor";
            modeleditor.Size = new Size(150, 29);
            modeleditor.TabIndex = 5;
            modeleditor.Text = "+ Model Editor";
            modeleditor.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1264, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1164, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "SignUp";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(299, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1059, 590);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 649);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(modeleditor);
            Controls.Add(Search);
            Controls.Add(DeleteAll);
            Controls.Add(SelectAll);
            Controls.Add(textBox1);
            Controls.Add(modelgroupbox);
            Name = "Form1";
            Text = "Model";
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
        private GroupBox groupBox1;
    }
}