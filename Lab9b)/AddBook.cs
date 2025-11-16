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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtaddauthor.Text) || string.IsNullOrWhiteSpace(txtISBDNadd.Text) || DTPDate.Value > DateTime.Now || string.IsNullOrWhiteSpace(txtaddtitle.Text) || string.IsNullOrWhiteSpace(txtISBDNadd.Text) || NUDquantity.Value <= 0 || NUDRack.Value<= 0 || cbctgry.SelectedIndex == -1 )   
            {
                MessageBox.Show("Please Fill all the fields\nValidate Date\nValidate rack and quantity","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try 
                {
                    SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                    con.Open();

                    string query = "INSERT INTO Books (Title, Author, Publisher, Category, ISBN, Quantity, Price, RackNo, DateAdded) VALUES ('" +
                                   txtaddtitle.Text + "', '" +
                                   txtaddauthor.Text + "', '" +
                                   txtaddpublisher.Text + "', '" +
                                   cbctgry.SelectedItem.ToString() + "', '" +
                                   txtISBDNadd.Text + "', " +
                                   Convert.ToInt32(NUDquantity.Value) + ", " +
                                   Convert.ToDecimal(txtPrice.Text) + ", " +
                                   Convert.ToInt32(NUDRack.Value) + ", '" +
                                   DTPDate.Value + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if(rows > 0)
                    {
                        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
