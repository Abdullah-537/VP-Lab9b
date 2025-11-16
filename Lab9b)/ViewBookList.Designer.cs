namespace Lab9b_
{
    partial class ViewBookList
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
            viewDGV = new DataGridView();
            btnViewBookList = new Button();
            ((System.ComponentModel.ISupportInitialize)viewDGV).BeginInit();
            SuspendLayout();
            // 
            // lblheading
            // 
            lblheading.AutoSize = true;
            lblheading.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblheading.ForeColor = Color.FromArgb(13, 27, 42);
            lblheading.Location = new Point(293, 9);
            lblheading.Name = "lblheading";
            lblheading.Size = new Size(150, 25);
            lblheading.TabIndex = 6;
            lblheading.Text = "View Books List";
            // 
            // viewDGV
            // 
            viewDGV.BackgroundColor = Color.FromArgb(240, 244, 255);
            viewDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewDGV.Location = new Point(12, 48);
            viewDGV.Name = "viewDGV";
            viewDGV.Size = new Size(776, 342);
            viewDGV.TabIndex = 14;
            // 
            // btnViewBookList
            // 
            btnViewBookList.BackColor = Color.FromArgb(21, 101, 192);
            btnViewBookList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBookList.ForeColor = SystemColors.ControlLightLight;
            btnViewBookList.Location = new Point(314, 396);
            btnViewBookList.Name = "btnViewBookList";
            btnViewBookList.Size = new Size(171, 43);
            btnViewBookList.TabIndex = 46;
            btnViewBookList.Text = "View";
            btnViewBookList.UseVisualStyleBackColor = false;
            btnViewBookList.Click += btnViewBookList_Click;
            // 
            // ViewBookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewBookList);
            Controls.Add(viewDGV);
            Controls.Add(lblheading);
            Name = "ViewBookList";
            Text = "ViewBookList";
            ((System.ComponentModel.ISupportInitialize)viewDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblheading;
        private DataGridView viewDGV;
        private Button btnViewBookList;
    }
}