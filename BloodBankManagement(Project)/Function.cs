using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement_Project_
{
    class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=WA-WORKSTATION\SQLEXPRESS;database=BloodBankManagement;integrated security=True";
            return con;
        }

        public DataSet getData(string query) // Fetch data from database
        {
            SqlConnection getcon = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon;
            cmd.CommandText =query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
            

        }

        public void setData(string query) //Insertion , deletion,updation
        {
            SqlConnection getcon = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = getcon;
            getcon.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            getcon.Close();
            MessageBox.Show("Data Processed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

    }
}
