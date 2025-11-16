namespace Lab9b_
{
    partial class Searching
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
            lblheading = new Label();
            DGVsearch = new DataGridView();
            label3 = new Label();
            txtISBN = new TextBox();
            label2 = new Label();
            txtauthor = new TextBox();
            label1 = new Label();
            txttitle = new TextBox();
            btnTitleSearch = new Button();
            btnAuthorSearch = new Button();
            btnISBNsearch = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVsearch).BeginInit();
            SuspendLayout();
            // 
            // lblheading
            // 
            lblheading.AutoSize = true;
            lblheading.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblheading.ForeColor = Color.FromArgb(13, 27, 42);
            lblheading.Location = new Point(359, 9);
            lblheading.Name = "lblheading";
            lblheading.Size = new Size(123, 25);
            lblheading.TabIndex = 6;
            lblheading.Text = "Search Book";
            // 
            // DGVsearch
            // 
            DGVsearch.BackgroundColor = Color.FromArgb(240, 244, 255);
            DGVsearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVsearch.Location = new Point(12, 54);
            DGVsearch.Name = "DGVsearch";
            DGVsearch.Size = new Size(776, 141);
            DGVsearch.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(13, 27, 42);
            label3.Location = new Point(565, 221);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 21;
            label3.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.White;
            txtISBN.Font = new Font("Segoe UI", 10F);
            txtISBN.Location = new Point(565, 244);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(171, 25);
            txtISBN.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(13, 27, 42);
            label2.Location = new Point(311, 221);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 19;
            label2.Text = "Author";
            // 
            // txtauthor
            // 
            txtauthor.BackColor = Color.White;
            txtauthor.Font = new Font("Segoe UI", 10F);
            txtauthor.Location = new Point(311, 244);
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(171, 25);
            txtauthor.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(13, 27, 42);
            label1.Location = new Point(75, 221);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 17;
            label1.Text = "Title";
            // 
            // txttitle
            // 
            txttitle.BackColor = Color.White;
            txttitle.Font = new Font("Segoe UI", 10F);
            txttitle.Location = new Point(75, 244);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(171, 25);
            txttitle.TabIndex = 16;
            // 
            // btnTitleSearch
            // 
            btnTitleSearch.BackColor = Color.FromArgb(21, 101, 192);
            btnTitleSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTitleSearch.ForeColor = SystemColors.ControlLightLight;
            btnTitleSearch.Location = new Point(75, 337);
            btnTitleSearch.Name = "btnTitleSearch";
            btnTitleSearch.Size = new Size(171, 43);
            btnTitleSearch.TabIndex = 27;
            btnTitleSearch.Text = "Search By Title";
            btnTitleSearch.UseVisualStyleBackColor = false;
            btnTitleSearch.Click += btnTitleSearch_Click;
            // 
            // btnAuthorSearch
            // 
            btnAuthorSearch.BackColor = Color.FromArgb(21, 101, 192);
            btnAuthorSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuthorSearch.ForeColor = SystemColors.ControlLightLight;
            btnAuthorSearch.Location = new Point(311, 337);
            btnAuthorSearch.Name = "btnAuthorSearch";
            btnAuthorSearch.Size = new Size(171, 43);
            btnAuthorSearch.TabIndex = 28;
            btnAuthorSearch.Text = "Search By Author";
            btnAuthorSearch.UseVisualStyleBackColor = false;
            btnAuthorSearch.Click += btnAuthorSearch_Click;
            // 
            // btnISBNsearch
            // 
            btnISBNsearch.BackColor = Color.FromArgb(21, 101, 192);
            btnISBNsearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnISBNsearch.ForeColor = SystemColors.ControlLightLight;
            btnISBNsearch.Location = new Point(565, 337);
            btnISBNsearch.Name = "btnISBNsearch";
            btnISBNsearch.Size = new Size(171, 43);
            btnISBNsearch.TabIndex = 29;
            btnISBNsearch.Text = "Search By ISBN";
            btnISBNsearch.UseVisualStyleBackColor = false;
            btnISBNsearch.Click += btnISBNsearch_Click;
            // 
            // Searching
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnISBNsearch);
            Controls.Add(btnAuthorSearch);
            Controls.Add(btnTitleSearch);
            Controls.Add(label3);
            Controls.Add(txtISBN);
            Controls.Add(label2);
            Controls.Add(txtauthor);
            Controls.Add(label1);
            Controls.Add(txttitle);
            Controls.Add(DGVsearch);
            Controls.Add(lblheading);
            Name = "Searching";
            Text = "Searching";
            ((System.ComponentModel.ISupportInitialize)DGVsearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblheading;
        private DataGridView DGVsearch;
        private Label label3;
        private TextBox txtISBN;
        private Label label2;
        private TextBox txtauthor;
        private Label label1;
        private TextBox txttitle;
        private Button btnTitleSearch;
        private Button btnAuthorSearch;
        private Button btnISBNsearch;
    }
}