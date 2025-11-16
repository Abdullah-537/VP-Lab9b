using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
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
    public partial class Searching : Form
    {
        public Searching()
        {
            InitializeComponent();
        }

        private void btnTitleSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttitle.Text))
            {
                MessageBox.Show("Please fill the Book TItle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();
                    string query = "SELECT * FROM Books WHERE Title = '" + txttitle.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DGVsearch.DataSource = dt;
                        MessageBox.Show("Result found", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        DGVsearch.DataSource = null;
                        DGVsearch.Refresh();
                        MessageBox.Show("No book found with this Title", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtauthor.Text))
            {
                MessageBox.Show("Please fill the Book Author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();
                    string query = "SELECT * FROM Books WHERE Author = '" + txtauthor.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DGVsearch.DataSource = dt;
                        MessageBox.Show("Result found", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        DGVsearch.DataSource = null;
                        DGVsearch.Refresh();
                        MessageBox.Show("No book found with this Author", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnISBNsearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Please fill the Book ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();
                    string query = "SELECT * FROM Books WHERE ISBN = '" + txtISBN.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DGVsearch.DataSource = dt;
                        MessageBox.Show("Result found", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No book found with this ISBN", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DGVsearch.DataSource = null;
                        DGVsearch.Refresh();
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
