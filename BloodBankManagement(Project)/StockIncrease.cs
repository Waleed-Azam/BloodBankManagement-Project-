﻿using System;
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
    public partial class StockIncrease : Form
    {
        Function fn = new Function();
        string query;
        public StockIncrease()
        {
            InitializeComponent();
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockIncrease_Load(object sender, EventArgs e)
        {
            query = "select bloodGroup,quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity=quantity+" + txtUnits.Text + "where bloodGroup='" + txtBloodGroup.Text + "'";
            fn.setData(query);
            StockIncrease_Load(this, null);
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

    }
}