namespace Lab9b_
{
    partial class DeleteBook
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
            lblUser = new Label();
            txtDltId = new TextBox();
            lblwelcome = new Label();
            dltDGV = new DataGridView();
            btnDelete = new Button();
            btnchkdlt = new Button();
            ((System.ComponentModel.ISupportInitialize)dltDGV).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(13, 27, 42);
            lblUser.Location = new Point(248, 76);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "Book ID";
            // 
            // txtDltId
            // 
            txtDltId.BackColor = Color.White;
            txtDltId.Font = new Font("Segoe UI", 10F);
            txtDltId.Location = new Point(319, 74);
            txtDltId.Name = "txtDltId";
            txtDltId.Size = new Size(171, 25);
            txtDltId.TabIndex = 3;
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.ForeColor = Color.FromArgb(13, 27, 42);
            lblwelcome.Location = new Point(340, 29);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(111, 32);
            lblwelcome.TabIndex = 8;
            lblwelcome.Text = "Deletion";
            // 
            // dltDGV
            // 
            dltDGV.BackgroundColor = Color.FromArgb(240, 244, 255);
            dltDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dltDGV.Location = new Point(12, 105);
            dltDGV.Name = "dltDGV";
            dltDGV.Size = new Size(776, 77);
            dltDGV.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(21, 101, 192);
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(466, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 43);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnchkdlt
            // 
            btnchkdlt.BackColor = Color.FromArgb(21, 101, 192);
            btnchkdlt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnchkdlt.ForeColor = SystemColors.ControlLightLight;
            btnchkdlt.Location = new Point(256, 246);
            btnchkdlt.Name = "btnchkdlt";
            btnchkdlt.Size = new Size(171, 43);
            btnchkdlt.TabIndex = 11;
            btnchkdlt.Text = "Check Book Details";
            btnchkdlt.UseVisualStyleBackColor = false;
            btnchkdlt.Click += btnchkdlt_Click;
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnchkdlt);
            Controls.Add(btnDelete);
            Controls.Add(dltDGV);
            Controls.Add(lblwelcome);
            Controls.Add(lblUser);
            Controls.Add(txtDltId);
            Name = "DeleteBook";
            Text = "DeleteBook";
            ((System.ComponentModel.ISupportInitialize)dltDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txtDltId;
        private Label lblwelcome;
        private DataGridView dltDGV;
        private Button btnDelete;
        private Button btnchkdlt;
    }
}