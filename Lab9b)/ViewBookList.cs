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
    public partial class ViewBookList : Form
    {
        public ViewBookList()
        {
            InitializeComponent();
        }

        private void btnViewBookList_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=SADI\\SQLEXPRESS;Initial Catalog=Uni_library;Integrated Security=True;Trust Server Certificate=True");
                con.Open();
                string query = "SELECT * FROM Books ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    viewDGV.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No book found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
   