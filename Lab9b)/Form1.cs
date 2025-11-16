using Microsoft.Data.SqlClient;
namespace Lab9b_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblwelcome.Hide();
            pbBooks.Hide();
            menuStrip1.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please Fill In all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SqlConnection con = null;
                SqlDataReader reader = null;
                try
                {
                    con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();
                    string query = "SELECT * FROM Users WHERE Username = '" + txtUser.Text + "' AND Password = '" + txtPass.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Login Successful.Welcome to Liberary Management System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblUser.Hide();
                        lblpass.Hide();
                        txtUser.Hide();
                        txtPass.Hide();
                        lblheading.Hide();
                        pbBooks.Show();
                        lblwelcome.Show();
                        menuStrip1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed, Check Login Credentials", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    con.Close();
                    reader.Close();
                }
            }

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DeleteBook dlt = new DeleteBook();
            dlt.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AddBook adbook = new AddBook();
            adbook.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateBook updates = new UpdateBook();
            updates.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBookList vbl = new ViewBookList();
            vbl.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searching search = new Searching();
            search.Show();
        }

        private void logoutExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LogOut Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblwelcome.Hide();
            pbBooks.Hide();
            menuStrip1.Hide();
            lblUser.Show();
            lblpass.Show();
            lblheading.Show();
            txtPass.Clear();
            txtUser.Clear();
            txtPass.Show();
            txtUser.Show();
        }

    }
}