namespace WinForm1
{
    partial class DisplayScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayScreen));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colSalary = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            txtSalary = new TextBox();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Crimson;
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(btnLoad);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LavenderBlush;
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(txtSalary);
            splitContainer1.Panel2.Controls.Add(txtName);
            splitContainer1.Size = new Size(600, 400);
            splitContainer1.SplitterDistance = 224;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoad.Location = new Point(503, 186);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Pink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colSalary });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(594, 179);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 200;
            // 
            // colSalary
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            colSalary.DefaultCellStyle = dataGridViewCellStyle1;
            colSalary.HeaderText = "Salary";
            colSalary.MinimumWidth = 6;
            colSalary.Name = "colSalary";
            colSalary.ReadOnly = true;
            colSalary.Width = 120;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "เงินเดือน";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 50);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 2;
            label1.Text = "ชื่อ";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(268, 88);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 1;
            txtSalary.TextAlign = HorizontalAlignment.Right;
            // 
            // txtName
            // 
            txtName.Location = new Point(268, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // DisplayScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(splitContainer1);
            Name = "DisplayScreen";
            Size = new Size(600, 400);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button btnLoad;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSalary;
        private TextBox txtName;
        private Label label1;
        private TextBox txtSalary;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
