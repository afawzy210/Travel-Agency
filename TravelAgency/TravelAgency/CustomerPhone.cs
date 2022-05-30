using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class CustomerPhone : Form
    {
        Main CP = new Main("Customer_phone");
        List<string> LH = new List<string>();
        public string ssn;
        public CustomerPhone(string cusn)
        {
            InitializeComponent();
            ssn = cusn;
            customerssn.Text = cusn;
        }

        private void CustomerPhone_Load(object sender, EventArgs e)
        {
            List<List<string>> Table = CP.Read();
            LH.Add("phone");
            LH.Add("SSN");

            dataGridView1.DataSource = CP.GetTable(LH, Table);
        }

        private void insert_Click(object sender, EventArgs e)
        {

            string data = "";
            //List<List<string>> R = CP.Read();
            data += phone.Text;
            data += " , " + ssn;
            
            CP.Insert(data);
            MessageBox.Show("Added is complete");
            //clear();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string set = "";
            bool temp = false;

            

            if (phone.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "phone = " + phone.Text;
            }


            
            CP.Update("SSN = " + ssn, set);

            MessageBox.Show("Updated is complete");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string set = "";
            bool temp = false;

            if (ssn != "")
            {
                set += "SSN = " + ssn;
                temp = true;
            }

            if (phone.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "phone = " + phone.Text;
            }






            CP.Delete(set);

            MessageBox.Show("Delete is complete");


        }

        private void search_Click(object sender, EventArgs e)
        {

            List<List<string>> Table = CP.Read();

            string set = "";
            bool temp = false;

            if (ssn != "")
            {
                set += "SSN = " + ssn;
                temp = true;
            }


            if (phone.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "phone = " + phone.Text;
            }



            Table = CP.Read(set);

            dataGridView1.DataSource = CP.GetTable(LH, Table);



        }
    }
}
