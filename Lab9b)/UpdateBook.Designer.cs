namespace Lab9b_
{
    partial class UpdateBook
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
            updateDGV = new DataGridView();
            lblwelcome = new Label();
            lblUser = new Label();
            txtUpdateid = new TextBox();
            label9 = new Label();
            txtPrice = new TextBox();
            btnUpdate = new Button();
            label8 = new Label();
            txtISBDNadd = new TextBox();
            DTPDate = new DateTimePicker();
            label7 = new Label();
            NUDRack = new NumericUpDown();
            NUDquantity = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cbctgry = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtaddpublisher = new TextBox();
            label2 = new Label();
            txtaddauthor = new TextBox();
            label1 = new Label();
            txtaddtitle = new TextBox();
            btnChkupdatedetails = new Button();
            ((System.ComponentModel.ISupportInitialize)updateDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDRack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDquantity).BeginInit();
            SuspendLayout();
            // 
            // updateDGV
            // 
            updateDGV.BackgroundColor = Color.FromArgb(240, 244, 255);
            updateDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            updateDGV.Location = new Point(10, 85);
            updateDGV.Name = "updateDGV";
            updateDGV.Size = new Size(776, 65);
            updateDGV.TabIndex = 13;
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.ForeColor = Color.FromArgb(13, 27, 42);
            lblwelcome.Location = new Point(338, 9);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(120, 32);
            lblwelcome.TabIndex = 12;
            lblwelcome.Text = "Updation";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(13, 27, 42);
            lblUser.Location = new Point(246, 56);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 20);
            lblUser.TabIndex = 11;
            lblUser.Text = "Book ID";
            // 
            // txtUpdateid
            // 
            txtUpdateid.BackColor = Color.White;
            txtUpdateid.Font = new Font("Segoe UI", 10F);
            txtUpdateid.Location = new Point(317, 54);
            txtUpdateid.Name = "txtUpdateid";
            txtUpdateid.Size = new Size(171, 25);
            txtUpdateid.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(13, 27, 42);
            label9.Location = new Point(511, 182);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 47;
            label9.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(598, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 25);
            txtPrice.TabIndex = 46;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(21, 101, 192);
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(401, 395);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 43);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update Book";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(13, 27, 42);
            label8.Location = new Point(528, 335);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 44;
            label8.Text = "ISBN";
            // 
            // txtISBDNadd
            // 
            txtISBDNadd.BackColor = Color.White;
            txtISBDNadd.Font = new Font("Segoe UI", 10F);
            txtISBDNadd.Location = new Point(599, 333);
            txtISBDNadd.Name = "txtISBDNadd";
            txtISBDNadd.Size = new Size(199, 25);
            txtISBDNadd.TabIndex = 43;
            // 
            // DTPDate
            // 
            DTPDate.Location = new Point(599, 295);
            DTPDate.Name = "DTPDate";
            DTPDate.Size = new Size(199, 23);
            DTPDate.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(13, 27, 42);
            label7.Location = new Point(530, 303);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 41;
            label7.Text = "Date";
            // 
            // NUDRack
            // 
            NUDRack.Location = new Point(599, 252);
            NUDRack.Name = "NUDRack";
            NUDRack.Size = new Size(199, 23);
            NUDRack.TabIndex = 40;
            // 
            // NUDquantity
            // 
            NUDquantity.Location = new Point(599, 210);
            NUDquantity.Name = "NUDquantity";
            NUDquantity.Size = new Size(199, 23);
            NUDquantity.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(13, 27, 42);
            label6.Location = new Point(516, 252);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 38;
            label6.Text = "Rack No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(13, 27, 42);
            label5.Location = new Point(511, 210);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 37;
            label5.Text = "Quantity";
            // 
            // cbctgry
            // 
            cbctgry.FormattingEnabled = true;
            cbctgry.Items.AddRange(new object[] { "Literary Fiction", "Mystery", "Science Fiction", "Fanatsy", "Romance", "Historic Fiction", "Horror", "Youth", "Contemporary Fiction", "Biography", "Memoir", "Self Help", "History", "True Crime", "Science/Nature", "Travel", "Business", "Philosophy", "Essays", "Novels", "CookBooks", "Poetry", "Story" });
            cbctgry.Location = new Point(97, 344);
            cbctgry.Name = "cbctgry";
            cbctgry.Size = new Size(167, 23);
            cbctgry.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(13, 27, 42);
            label4.Location = new Point(18, 347);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 35;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(13, 27, 42);
            label3.Location = new Point(13, 303);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 34;
            label3.Text = "Publisher";
            // 
            // txtaddpublisher
            // 
            txtaddpublisher.BackColor = Color.White;
            txtaddpublisher.Font = new Font("Segoe UI", 10F);
            txtaddpublisher.Location = new Point(93, 298);
            txtaddpublisher.Name = "txtaddpublisher";
            txtaddpublisher.Size = new Size(171, 25);
            txtaddpublisher.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(13, 27, 42);
            label2.Location = new Point(22, 249);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 32;
            label2.Text = "Author";
            // 
            // txtaddauthor
            // 
            txtaddauthor.BackColor = Color.White;
            txtaddauthor.Font = new Font("Segoe UI", 10F);
            txtaddauthor.Location = new Point(93, 247);
            txtaddauthor.Name = "txtaddauthor";
            txtaddauthor.Size = new Size(171, 25);
            txtaddauthor.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(13, 27, 42);
            label1.Location = new Point(22, 182);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 30;
            label1.Text = "Title";
            // 
            // txtaddtitle
            // 
            txtaddtitle.BackColor = Color.White;
            txtaddtitle.Font = new Font("Segoe UI", 10F);
            txtaddtitle.Location = new Point(93, 180);
            txtaddtitle.Name = "txtaddtitle";
            txtaddtitle.Size = new Size(171, 25);
            txtaddtitle.TabIndex = 29;
            // 
            // btnChkupdatedetails
            // 
            btnChkupdatedetails.BackColor = Color.FromArgb(21, 101, 192);
            btnChkupdatedetails.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChkupdatedetails.ForeColor = SystemColors.ControlLightLight;
            btnChkupdatedetails.Location = new Point(203, 395);
            btnChkupdatedetails.Name = "btnChkupdatedetails";
            btnChkupdatedetails.Size = new Size(171, 43);
            btnChkupdatedetails.TabIndex = 48;
            btnChkupdatedetails.Text = "Check Book Details";
            btnChkupdatedetails.UseVisualStyleBackColor = false;
            btnChkupdatedetails.Click += btnChkupdatedetails_Click;
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnChkupdatedetails);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(btnUpdate);
            Controls.Add(label8);
            Controls.Add(txtISBDNadd);
            Controls.Add(DTPDate);
            Controls.Add(label7);
            Controls.Add(NUDRack);
            Controls.Add(NUDquantity);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbctgry);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtaddpublisher);
            Controls.Add(label2);
            Controls.Add(txtaddauthor);
            Controls.Add(label1);
            Controls.Add(txtaddtitle);
            Controls.Add(updateDGV);
            Controls.Add(lblwelcome);
            Controls.Add(lblUser);
            Controls.Add(txtUpdateid);
            Name = "UpdateBook";
            Text = "UpdateBook";
            ((System.ComponentModel.ISupportInitialize)updateDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDRack).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDquantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView updateDGV;
        private Label lblwelcome;
        private Label lblUser;
        private TextBox txtUpdateid;
        private Label label9;
        private TextBox txtPrice;
        private Button btnUpdate;
        private Label label8;
        private TextBox txtISBDNadd;
        private DateTimePicker DTPDate;
        private Label label7;
        private NumericUpDown NUDRack;
        private NumericUpDown NUDquantity;
        private Label label6;
        private Label label5;
        private ComboBox cbctgry;
        private Label label4;
        private Label label3;
        private TextBox txtaddpublisher;
        private Label label2;
        private TextBox txtaddauthor;
        private Label label1;
        private TextBox txtaddtitle;
        private Button btnChkupdatedetails;
    }
}