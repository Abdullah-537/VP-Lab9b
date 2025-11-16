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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void btnChkupdatedetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateid.Text))
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
                    string query = "SELECT * FROM Books WHERE Book_id = '" + Convert.ToInt32(txtUpdateid.Text) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        updateDGV.DataSource = dt;
                        MessageBox.Show("Book Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtaddtitle.Text = dt.Rows[0]["Title"].ToString();
                        txtaddauthor.Text = dt.Rows[0]["Author"].ToString();
                        txtaddpublisher.Text = dt.Rows[0]["Publisher"].ToString();
                        cbctgry.SelectedItem = dt.Rows[0]["Category"].ToString();
                        txtISBDNadd.Text = dt.Rows[0]["ISBN"].ToString();
                        NUDquantity.Value = Convert.ToInt32(dt.Rows[0]["Quantity"]);
                        txtPrice.Text = dt.Rows[0]["Price"].ToString();
                        NUDRack.Value = Convert.ToInt32(dt.Rows[0]["RackNo"]);
                        DTPDate.Value = Convert.ToDateTime(dt.Rows[0]["DateAdded"]);
                    }
                    else
                    {
                        txtaddtitle.Clear();
                        txtaddauthor.Clear();
                        txtaddpublisher.Clear();
                        cbctgry.SelectedIndex = -1;
                        txtISBDNadd.Clear();
                        NUDquantity.Value = 0;
                        NUDRack.Value = 0;
                        txtPrice.Clear();
                        DTPDate.Value = DateTime.Now;
                        updateDGV.DataSource = null;
                        updateDGV.Refresh();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtaddauthor.Text) || string.IsNullOrWhiteSpace(txtISBDNadd.Text) || DTPDate.Value > DateTime.Now || string.IsNullOrWhiteSpace(txtaddtitle.Text) || string.IsNullOrWhiteSpace(txtISBDNadd.Text) || NUDquantity.Value <= 0 || NUDRack.Value <= 0 || cbctgry.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all the fields\nValidate Date\nValidate rack and quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();

                    string query = "UPDATE Books SET Title = '" + txtaddtitle.Text + "', " +
                                    "Author = '" + txtaddauthor.Text + "', " +
                                    "Publisher = '" + txtaddpublisher.Text + "', " +
                                    "Category = '" + cbctgry.SelectedItem.ToString() + "', " +
                                    "ISBN = '" + txtISBDNadd.Text + "', " +
                                    "Quantity = " + Convert.ToInt32(NUDquantity.Value) + ", " +
                                    "Price = " + Convert.ToDecimal(txtPrice.Text) + ", " +
                                    "RackNo = " + Convert.ToInt32(NUDRack.Value) + ", " +
                                    "DateAdded = '" + DTPDate.Value + "' " +
                                    "WHERE Book_id = " + Convert.ToInt32(txtUpdateid.Text);
                    SqlCommand cmd = new SqlCommand(query, con);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("Book Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDGV.DataSource = null;
                        updateDGV.Refresh();
                        txtaddtitle.Clear();
                        txtaddauthor.Clear();
                        txtaddpublisher.Clear();
                        txtISBDNadd.Clear();
                        txtPrice.Clear();
                        cbctgry.SelectedIndex = -1;
                        NUDquantity.Value = 0;
                        NUDRack.Value = 0;
                        DTPDate.Value = DateTime.Now;
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Format Error " + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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