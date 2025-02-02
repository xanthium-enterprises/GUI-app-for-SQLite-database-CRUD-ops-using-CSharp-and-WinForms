namespace SQLite_Connection
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
            Button_Select_Database = new Button();
            TextBox_Database_Path = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TextBox_Database_Name = new TextBox();
            Button_Load_SQlite_Data = new Button();
            TextBox_DB_Connection_String = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TextBox_SQL_Query_Executed = new TextBox();
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Button_Select_Database
            // 
            Button_Select_Database.Location = new Point(12, 72);
            Button_Select_Database.Name = "Button_Select_Database";
            Button_Select_Database.Size = new Size(136, 62);
            Button_Select_Database.TabIndex = 0;
            Button_Select_Database.Text = "Select Database";
            Button_Select_Database.UseVisualStyleBackColor = true;
            Button_Select_Database.Click += Button_Select_Database_Click;
            // 
            // TextBox_Database_Path
            // 
            TextBox_Database_Path.Location = new Point(242, 72);
            TextBox_Database_Path.Name = "TextBox_Database_Path";
            TextBox_Database_Path.Size = new Size(684, 27);
            TextBox_Database_Path.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 75);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Full Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 114);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "File Name";
            // 
            // TextBox_Database_Name
            // 
            TextBox_Database_Name.Location = new Point(242, 107);
            TextBox_Database_Name.Name = "TextBox_Database_Name";
            TextBox_Database_Name.Size = new Size(593, 27);
            TextBox_Database_Name.TabIndex = 4;
            // 
            // Button_Load_SQlite_Data
            // 
            Button_Load_SQlite_Data.Location = new Point(12, 183);
            Button_Load_SQlite_Data.Name = "Button_Load_SQlite_Data";
            Button_Load_SQlite_Data.Size = new Size(136, 62);
            Button_Load_SQlite_Data.TabIndex = 5;
            Button_Load_SQlite_Data.Text = "Load SQlite Data";
            Button_Load_SQlite_Data.UseVisualStyleBackColor = true;
            Button_Load_SQlite_Data.Click += Button_Load_SQlite_Data_Click;
            // 
            // TextBox_DB_Connection_String
            // 
            TextBox_DB_Connection_String.Location = new Point(302, 186);
            TextBox_DB_Connection_String.Name = "TextBox_DB_Connection_String";
            TextBox_DB_Connection_String.ReadOnly = true;
            TextBox_DB_Connection_String.Size = new Size(624, 27);
            TextBox_DB_Connection_String.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 186);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 7;
            label3.Text = "Connection String ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 225);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "SQL Query";
            // 
            // TextBox_SQL_Query_Executed
            // 
            TextBox_SQL_Query_Executed.Location = new Point(302, 225);
            TextBox_SQL_Query_Executed.Name = "TextBox_SQL_Query_Executed";
            TextBox_SQL_Query_Executed.ReadOnly = true;
            TextBox_SQL_Query_Executed.Size = new Size(624, 27);
            TextBox_SQL_Query_Executed.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 300);
            dataGridView1.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 22);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Youtube Tutorial";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(165, 22);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(164, 20);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Online Website Tutorial";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(358, 22);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(93, 20);
            linkLabel3.TabIndex = 13;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Source Code";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(467, 22);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(144, 20);
            linkLabel4.TabIndex = 14;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "(C) www.xanthium.in";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 628);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(TextBox_SQL_Query_Executed);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TextBox_DB_Connection_String);
            Controls.Add(Button_Load_SQlite_Data);
            Controls.Add(TextBox_Database_Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBox_Database_Path);
            Controls.Add(Button_Select_Database);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "SQLite Database Viewer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Select_Database;
        private TextBox TextBox_Database_Path;
        private Label label1;
        private Label label2;
        private TextBox TextBox_Database_Name;
        private Button Button_Load_SQlite_Data;
        private TextBox TextBox_DB_Connection_String;
        private Label label3;
        private Label label4;
        private TextBox TextBox_SQL_Query_Executed;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
    }
}
