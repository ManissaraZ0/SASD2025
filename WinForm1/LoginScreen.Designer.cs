namespace WinForm1
{
    partial class LoginScreen
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
            label1 = new Label();
            txtUserName = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 172);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(281, 169);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(136, 27);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "Manissara";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(281, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LavenderBlush;
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "LoginScreen";
            Size = new Size(600, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Button btnLogin;
    }
}
