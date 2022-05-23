using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main("customer");
            string data = "";
            //bool temp = false;

            data += SSN.Text;
            //data += (", " + Fname.Text);
            //data += (", " + Lname.Text);
            //data += (", " + Address.Text);
            //data += (", " + Email.Text);
            //data += (", " + PassID.Text);
            //data += (", " + Dob.Text);
            //data += (", " + Sex.Text);
            //data += (", " + Job.Text);

            m.Insert(data);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
