using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9b_
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void btnchkdlt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDltId.Text))
            {
                MessageBox.Show("Please fill the Book ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();
                    string query = "SELECT * FROM Books WHERE Book_id = '" + Convert.ToInt32(txtDltId.Text) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dltDGV.DataSource = dt;
                        MessageBox.Show("Book Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No book found with this ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Error " + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (SqlException se)
                {
                    MessageBox.Show("Error sql: " + se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDltId.Text))
            {
                MessageBox.Show("Please fill the Book ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();
                    string query = "DELETE FROM Books WHERE Book_id = '" + Convert.ToInt32(txtDltId.Text) + "'";
                    DialogResult dg = MessageBox.Show("Are you sure you want to delete the record of book: " + txtDltId.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();
                        if (rows == 0)
                        {
                            MessageBox.Show($"Record of book with book id: "+txtDltId.Text+" not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           
                        }
                        else
                        {
                            MessageBox.Show($"Record of book with book id: "+txtDltId.Text +" deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dltDGV.DataSource = null;
                            dltDGV.Refresh();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Error " + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (SqlException se)
                {
                    MessageBox.Show("Error sql: " + se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
