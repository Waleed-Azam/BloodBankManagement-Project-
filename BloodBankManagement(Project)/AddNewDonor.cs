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
    public partial class AddNewDonor : Form
    {
        Function fn = new Function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            string query = "select max(donor_id) from donorTable";
            DataSet ds = fn.getData(query);
            int count= int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelnewid.Text = (count + 1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && txtFather.Text!="" && txtEmail.Text!="" && txtDateOfBirth.Text!="" && txtCity.Text!="" && richTxtBoxAdress.Text!="" && txtMobile.Text!="" && txtBloodgroup.Text!="" && comboGender.Text!="")
            {
                string dname = txtName.Text;
                string fname = txtFather.Text;
                string dob = txtDateOfBirth.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string email = txtEmail.Text;
                string city = txtCity.Text;
                string address = richTxtBoxAdress.Text;
                string bgroup = txtBloodgroup.Text;

                string gender = comboGender.Text;
              
                
               
                

                string query = "Insert into donorTable(donor_name,donor_fname,dob,mobile,email,city,address,bloodGroup,donorGender) values ('" + dname + "','" + fname + "','" + dob + "'," + mobile + ",'" + email + "','" + city + "','" + address + "','" + bgroup + "','" + gender + "')";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtCity.Clear();
            txtBloodgroup.ResetText();
            txtDateOfBirth.ResetText();
            txtEmail.Clear();
            txtMobile.Clear();
            comboGender.ResetText();
            richTxtBoxAdress.Clear();
        }
    }
}
