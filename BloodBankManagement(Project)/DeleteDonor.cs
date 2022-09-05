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
    public partial class DeleteDonor : Form
    {
        Function fn = new Function();
        string query;
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(txtDonorID.Text!="")
            {
                query = "select * from donorTable where donor_id=" + txtDonorID.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                    textdob.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][6].ToString();
                    richTxtBoxAdress.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][9].ToString();
                }

                else
                {
                    MessageBox.Show("No Record Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonorID.Clear();
                }
                    


                
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Delete",MessageBoxButtons.OK,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                query = "delete from donorTable where donor_id=" + txtDonorID.Text + "";
                fn.setData(query);
            }

        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text=="")
            {
                txtDonorID.Clear();
                txtFather.Clear();
                textdob.Clear();
                txtMobile.Clear();
                txtEmail.Clear();
                txtCity.Clear();
                richTxtBoxAdress.Clear();
                txtBloodGroup.Clear();
                txtGender.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }
    }
}
