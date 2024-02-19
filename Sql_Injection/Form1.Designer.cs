namespace Sql_Injection
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtSearchCategoryName = new TextBox();
            label3 = new Label();
            listViewCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            contextMenuStripCategory = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnTest = new Button();
            btnUpdateCategory = new Button();
            btnAddCategory = new Button();
            txtCategoryDescription = new TextBox();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            contextMenuStripCategory.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchCategoryName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(listViewCategory);
            groupBox1.Controls.Add(btnTest);
            groupBox1.Controls.Add(btnUpdateCategory);
            groupBox1.Controls.Add(btnAddCategory);
            groupBox1.Controls.Add(txtCategoryDescription);
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 637);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categories";
            // 
            // txtSearchCategoryName
            // 
            txtSearchCategoryName.Location = new Point(42, 357);
            txtSearchCategoryName.Name = "txtSearchCategoryName";
            txtSearchCategoryName.Size = new Size(349, 23);
            txtSearchCategoryName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 333);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 9;
            label3.Text = "Search Category Name :";
            // 
            // listViewCategory
            // 
            listViewCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewCategory.ContextMenuStrip = contextMenuStripCategory;
            listViewCategory.FullRowSelect = true;
            listViewCategory.Location = new Point(6, 456);
            listViewCategory.Name = "listViewCategory";
            listViewCategory.Size = new Size(430, 145);
            listViewCategory.TabIndex = 7;
            listViewCategory.UseCompatibleStateImageBehavior = false;
            listViewCategory.View = View.Details;
            listViewCategory.Click += listViewCategory_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 100;
            // 
            // contextMenuStripCategory
            // 
            contextMenuStripCategory.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStripCategory.Name = "contextMenuStripCategory";
            contextMenuStripCategory.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnTest
            // 
            btnTest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTest.BackColor = Color.Red;
            btnTest.Font = new Font("PMingLiU-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTest.ForeColor = SystemColors.ControlLightLight;
            btnTest.Location = new Point(6, 395);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(422, 38);
            btnTest.TabIndex = 8;
            btnTest.Text = "Sql Injection Test";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(42, 273);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(349, 23);
            btnUpdateCategory.TabIndex = 6;
            btnUpdateCategory.Text = "Update Category";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(42, 235);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(349, 23);
            btnAddCategory.TabIndex = 5;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.AllowDrop = true;
            txtCategoryDescription.Location = new Point(42, 149);
            txtCategoryDescription.Multiline = true;
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(349, 69);
            txtCategoryDescription.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(42, 78);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(349, 23);
            txtCategoryName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 114);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Category Description : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Category Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(488, 90);
            label4.Name = "label4";
            label4.Size = new Size(442, 165);
            label4.TabIndex = 1;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(488, 355);
            label5.Name = "label5";
            label5.Size = new Size(443, 90);
            label5.TabIndex = 2;
            label5.Text = "Test Sql Query\r\n\r\n     {CategoryName}' DELETE FROM Categories -- \r\n\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(488, 37);
            label6.Name = "label6";
            label6.Size = new Size(191, 38);
            label6.TabIndex = 3;
            label6.Text = "SQL Injection";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 667);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStripCategory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnUpdateCategory;
        private Button btnAddCategory;
        private TextBox txtCategoryDescription;
        private TextBox txtCategoryName;
        private Label label2;
        private ContextMenuStrip contextMenuStripCategory;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ListView listViewCategory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnTest;
        private TextBox txtSearchCategoryName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}