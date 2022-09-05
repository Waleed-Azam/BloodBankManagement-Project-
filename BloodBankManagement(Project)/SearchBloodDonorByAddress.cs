using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement_Project_
{
    public partial class SearchBloodDonorByAddress : Form
    {
        Function fn = new Function();
        
        public SearchBloodDonorByAddress()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBloodDonorByAddress_Load(object sender, EventArgs e)
        {
            string query = "Select * from donorTable";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtadress.Text != "")
            {
                string query = "select * from donorTable where city Like'" + txtadress.Text + "%' or address Like'" + txtadress.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string query = "select * from donorTable";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
