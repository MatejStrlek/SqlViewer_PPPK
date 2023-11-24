namespace SqlViewer.View
{
    partial class LoginForm
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
            label1 = new Label();
            tbServer = new TextBox();
            tbUsername = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            lbError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 31);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Server:";
            // 
            // tbServer
            // 
            tbServer.Location = new Point(123, 29);
            tbServer.Margin = new Padding(1, 1, 1, 1);
            tbServer.Name = "tbServer";
            tbServer.Size = new Size(204, 23);
            tbServer.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(123, 84);
            tbUsername.Margin = new Padding(1, 1, 1, 1);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(204, 23);
            tbUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 86);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(123, 143);
            tbPassword.Margin = new Padding(1, 1, 1, 1);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(204, 23);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 145);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(123, 191);
            btnLogin.Margin = new Padding(1, 1, 1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(202, 27);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.ForeColor = Color.Red;
            lbError.Location = new Point(125, 230);
            lbError.Margin = new Padding(1, 0, 1, 0);
            lbError.Name = "lbError";
            lbError.Size = new Size(103, 15);
            lbError.TabIndex = 7;
            lbError.Text = "Wrong credentials";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 260);
            Controls.Add(lbError);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(tbServer);
            Controls.Add(label1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbServer;
        private TextBox tbUsername;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private Button btnLogin;
        private Label lbError;
    }
}