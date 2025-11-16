namespace Lab9b_
{
    partial class AddBook
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
            txtaddtitle = new TextBox();
            label2 = new Label();
            txtaddauthor = new TextBox();
            label3 = new Label();
            txtaddpublisher = new TextBox();
            label4 = new Label();
            cbctgry = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            NUDquantity = new NumericUpDown();
            NUDRack = new NumericUpDown();
            label7 = new Label();
            DTPDate = new DateTimePicker();
            label8 = new Label();
            txtISBDNadd = new TextBox();
            btnAdd = new Button();
            txtPrice = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)NUDquantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDRack).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(13, 27, 42);
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // txtaddtitle
            // 
            txtaddtitle.BackColor = Color.White;
            txtaddtitle.Font = new Font("Segoe UI", 10F);
            txtaddtitle.Location = new Point(83, 77);
            txtaddtitle.Name = "txtaddtitle";
            txtaddtitle.Size = new Size(171, 25);
            txtaddtitle.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(13, 27, 42);
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 10;
            label2.Text = "Author";
            // 
            // txtaddauthor
            // 
            txtaddauthor.BackColor = Color.White;
            txtaddauthor.Font = new Font("Segoe UI", 10F);
            txtaddauthor.Location = new Point(83, 144);
            txtaddauthor.Name = "txtaddauthor";
            txtaddauthor.Size = new Size(171, 25);
            txtaddauthor.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(13, 27, 42);
            label3.Location = new Point(3, 200);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 12;
            label3.Text = "Publisher";
            // 
            // txtaddpublisher
            // 
            txtaddpublisher.BackColor = Color.White;
            txtaddpublisher.Font = new Font("Segoe UI", 10F);
            txtaddpublisher.Location = new Point(83, 195);
            txtaddpublisher.Name = "txtaddpublisher";
            txtaddpublisher.Size = new Size(171, 25);
            txtaddpublisher.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(13, 27, 42);
            label4.Location = new Point(8, 244);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 14;
            label4.Text = "Category";
            // 
            // cbctgry
            // 
            cbctgry.FormattingEnabled = true;
            cbctgry.Items.AddRange(new object[] { "Literary Fiction", "Mystery", "Science Fiction", "Fanatsy", "Romance", "Historic Fiction", "Horror", "Youth", "Contemporary Fiction", "Biography", "Memoir", "Self Help", "History", "True Crime", "Science/Nature", "Travel", "Business", "Philosophy", "Essays", "Novels", "CookBooks", "Poetry", "Story" });
            cbctgry.Location = new Point(87, 241);
            cbctgry.Name = "cbctgry";
            cbctgry.Size = new Size(167, 23);
            cbctgry.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(13, 27, 42);
            label5.Location = new Point(501, 107);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 17;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(13, 27, 42);
            label6.Location = new Point(506, 149);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 19;
            label6.Text = "Rack No";
            // 
            // NUDquantity
            // 
            NUDquantity.Location = new Point(589, 107);
            NUDquantity.Name = "NUDquantity";
            NUDquantity.Size = new Size(199, 23);
            NUDquantity.TabIndex = 20;
            // 
            // NUDRack
            // 
            NUDRack.Location = new Point(589, 149);
            NUDRack.Name = "NUDRack";
            NUDRack.Size = new Size(199, 23);
            NUDRack.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(13, 27, 42);
            label7.Location = new Point(520, 200);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 22;
            label7.Text = "Date";
            // 
            // DTPDate
            // 
            DTPDate.Location = new Point(589, 192);
            DTPDate.Name = "DTPDate";
            DTPDate.Size = new Size(199, 23);
            DTPDate.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(13, 27, 42);
            label8.Location = new Point(518, 232);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 25;
            label8.Text = "ISBN";
            // 
            // txtISBDNadd
            // 
            txtISBDNadd.BackColor = Color.White;
            txtISBDNadd.Font = new Font("Segoe UI", 10F);
            txtISBDNadd.Location = new Point(589, 230);
            txtISBDNadd.Name = "txtISBDNadd";
            txtISBDNadd.Size = new Size(199, 25);
            txtISBDNadd.TabIndex = 24;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(21, 101, 192);
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(307, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 43);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(588, 77);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 25);
            txtPrice.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(13, 27, 42);
            label9.Location = new Point(501, 79);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 28;
            label9.Text = "Price";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(btnAdd);
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
            Name = "AddBook";
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)NUDquantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDRack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtaddtitle;
        private Label label2;
        private TextBox txtaddauthor;
        private Label label3;
        private TextBox txtaddpublisher;
        private Label label4;
        private ComboBox cbctgry;
        private Label label5;
        private Label label6;
        private NumericUpDown NUDquantity;
        private NumericUpDown NUDRack;
        private Label label7;
        private DateTimePicker DTPDate;
        private Label label8;
        private TextBox txtISBDNadd;
        private Button btnAdd;
        private TextBox txtPrice;
        private Label label9;
    }
}