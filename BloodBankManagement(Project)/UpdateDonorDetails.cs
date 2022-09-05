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
    public partial class UpdateDonorDetails : Form
    {
        Function fn = new Function();
        
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textdonorId.Text.ToString());
            string query = "select * from donorTable where donor_id =  " + id + "";
            DataSet ds = fn.getData(query);
            
            if(ds.Tables[0].Rows.Count !=0)
            {
                txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                textdob.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtCity.Text = ds.Tables[0].Rows[0][6].ToString();
                richTxtBoxAdress.Text = ds.Tables[0].Rows[0][7].ToString();
                txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                textGender.Text = ds.Tables[0].Rows[0][9].ToString();



            }
            else
            {
                MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textdonorId_TextChanged(object sender, EventArgs e)
        {
            if(textdonorId.Text=="")
            {
                txtName.Clear();
                txtFather.Clear();
                textdob.ResetText();
                txtMobile.Clear();
               
                txtEmail.Clear();
                txtCity.Clear();
                richTxtBoxAdress.Clear();
                txtBloodGroup.ResetText();
                textGender.ResetText();
                
                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textdonorId.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string query = "update donorTable set donor_name ='" + txtName.Text + "',donor_fname ='" + txtFather.Text + "',dob='" + textdob.Text + "',mobile='" + txtMobile.Text + "',email = '" + txtEmail.Text + "', city = '" + txtCity.Text + "', address ='" + richTxtBoxAdress.Text + "',bloodGroup'"+txtBloodGroup.Text +"', donorGender = '" + textGender + "' where donor_id ="+textdonorId.Text+"";
            fn.setData(query);
            UpdateDonorDetails_Load(this, null);
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            textdonorId.Clear();
        }
    }
}
