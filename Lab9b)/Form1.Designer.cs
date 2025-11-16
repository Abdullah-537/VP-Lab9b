namespace Lab9b_
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblUser = new Label();
            lblpass = new Label();
            btnLogin = new Button();
            lblheading = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            logoutExitToolStripMenuItem = new ToolStripMenuItem();
            lblwelcome = new Label();
            pbBooks = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBooks).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.Location = new Point(329, 175);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(171, 25);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10F);
            txtPass.Location = new Point(329, 217);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(171, 25);
            txtPass.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(13, 27, 42);
            lblUser.Location = new Point(230, 178);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(84, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username:";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblpass.ForeColor = Color.FromArgb(13, 27, 42);
            lblpass.Location = new Point(230, 220);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(80, 20);
            lblpass.TabIndex = 3;
            lblpass.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(21, 101, 192);
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(329, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 43);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblheading
            // 
            lblheading.AutoSize = true;
            lblheading.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblheading.ForeColor = Color.FromArgb(13, 27, 42);
            lblheading.Location = new Point(294, 77);
            lblheading.Name = "lblheading";
            lblheading.Size = new Size(267, 25);
            lblheading.TabIndex = 5;
            lblheading.Text = "Library Management System";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(30, 136, 229);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem2, toolStripMenuItem1, addBookToolStripMenuItem, logoutExitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.FromArgb(30, 136, 229);
            toolStripMenuItem3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem3.ForeColor = SystemColors.ControlLightLight;
            toolStripMenuItem3.Margin = new Padding(25, 0, 0, 0);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(106, 24);
            toolStripMenuItem3.Text = "Delete Book";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.FromArgb(30, 136, 229);
            toolStripMenuItem4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem4.ForeColor = SystemColors.ControlLightLight;
            toolStripMenuItem4.Margin = new Padding(25, 0, 0, 0);
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(90, 24);
            toolStripMenuItem4.Text = "Add Book";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.FromArgb(30, 136, 229);
            toolStripMenuItem2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem2.ForeColor = SystemColors.ControlLightLight;
            toolStripMenuItem2.Margin = new Padding(25, 0, 0, 0);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(112, 24);
            toolStripMenuItem2.Text = "Update Book";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(30, 136, 229);
            toolStripMenuItem1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = SystemColors.ControlLightLight;
            toolStripMenuItem1.Margin = new Padding(25, 0, 0, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(124, 24);
            toolStripMenuItem1.Text = "View Book List";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.BackColor = Color.FromArgb(30, 136, 229);
            addBookToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBookToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            addBookToolStripMenuItem.Margin = new Padding(25, 0, 0, 0);
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.RightToLeft = RightToLeft.No;
            addBookToolStripMenuItem.Size = new Size(107, 24);
            addBookToolStripMenuItem.Text = "Search Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // logoutExitToolStripMenuItem
            // 
            logoutExitToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutExitToolStripMenuItem.ForeColor = Color.White;
            logoutExitToolStripMenuItem.Margin = new Padding(25, 0, 0, 0);
            logoutExitToolStripMenuItem.Name = "logoutExitToolStripMenuItem";
            logoutExitToolStripMenuItem.Size = new Size(104, 24);
            logoutExitToolStripMenuItem.Text = "Logout/Exit";
            logoutExitToolStripMenuItem.Click += logoutExitToolStripMenuItem_Click;
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.ForeColor = Color.FromArgb(13, 27, 42);
            lblwelcome.Location = new Point(123, 45);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(538, 32);
            lblwelcome.TabIndex = 7;
            lblwelcome.Text = "WELCOME TO LIBRARY MANGEMENT SYSTEM";
            // 
            // pbBooks
            // 
            pbBooks.BackColor = Color.FromArgb(240, 244, 255);
            pbBooks.Image = (Image)resources.GetObject("pbBooks.Image");
            pbBooks.Location = new Point(265, 90);
            pbBooks.Name = "pbBooks";
            pbBooks.Size = new Size(286, 227);
            pbBooks.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBooks.TabIndex = 8;
            pbBooks.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pbBooks);
            Controls.Add(lblwelcome);
            Controls.Add(lblheading);
            Controls.Add(btnLogin);
            Controls.Add(lblpass);
            Controls.Add(lblUser);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblUser;
        private Label lblpass;
        private Button btnLogin;
        private Label lblheading;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private Label lblwelcome;
        private PictureBox pbBooks;
        private ToolStripMenuItem logoutExitToolStripMenuItem;
    }
}
