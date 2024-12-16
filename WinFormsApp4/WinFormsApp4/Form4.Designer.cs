namespace WinFormsApp4
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ComplaintID = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            AdminComments = new DataGridViewTextBoxColumn();
            textBoxComplaintID = new TextBox();
            textBoxAdminComments = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ComplaintID, Description, Category, Status, AdminComments });
            dataGridView1.Location = new Point(1, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(704, 174);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ComplaintID
            // 
            ComplaintID.HeaderText = "ComplaintID";
            ComplaintID.MinimumWidth = 6;
            ComplaintID.Name = "ComplaintID";
            ComplaintID.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // AdminComments
            // 
            AdminComments.HeaderText = "AdminComments";
            AdminComments.MinimumWidth = 6;
            AdminComments.Name = "AdminComments";
            AdminComments.Width = 125;
            // 
            // textBoxComplaintID
            // 
            textBoxComplaintID.Location = new Point(125, 206);
            textBoxComplaintID.Name = "textBoxComplaintID";
            textBoxComplaintID.ReadOnly = true;
            textBoxComplaintID.Size = new Size(309, 27);
            textBoxComplaintID.TabIndex = 1;
            textBoxComplaintID.TextChanged += textBoxComplaintID_TextChanged;
            // 
            // textBoxAdminComments
            // 
            textBoxAdminComments.Location = new Point(140, 262);
            textBoxAdminComments.Name = "textBoxAdminComments";
            textBoxAdminComments.Size = new Size(309, 27);
            textBoxAdminComments.TabIndex = 2;
            textBoxAdminComments.TextChanged += textBoxAdminComments_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 209);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 3;
            label1.Text = "Complaint ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 265);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 4;
            label2.Text = "Admin Comments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 190);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pending", "", "In Progress", "", "Resolved" });
            comboBox1.Location = new Point(563, 224);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(259, 355);
            button1.Name = "button1";
            button1.Size = new Size(163, 37);
            button1.TabIndex = 7;
            button1.Text = "Update Complaint";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(665, 412);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAdminComments);
            Controls.Add(textBoxComplaintID);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ComplaintID;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn AdminComments;
        private TextBox textBoxComplaintID;
        private TextBox textBoxAdminComments;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button3;
    }
}