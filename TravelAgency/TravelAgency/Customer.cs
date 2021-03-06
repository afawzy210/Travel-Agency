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
        Main m = new Main("customer");
        List<string> LH = new List<string>();
        public string CUSN;
        public Customer()
        {
            InitializeComponent();
        }

        void clear() 
        {
            SSN.Text = "";
            Fname.Text = "";
            Lname.Text = "";
            Address.Text = "";
            Email.Text = "";
            PassID.Text = "";
            Dob.Text = "";
            Sex.Text = "";
            Job.Text = "";
        }


        private void Customer_Load(object sender, EventArgs e)
        {
            List<List<string>> Table = m.Read();
            LH.Add("SSN");
            LH.Add("First Name");
            LH.Add("Last Name");
            LH.Add("Address");
            LH.Add("Email");
            LH.Add("Passport ID");
            LH.Add("Birth date");
            LH.Add("Sex");
            LH.Add("Job");

            dataGridView1.DataSource = m.GetTable(LH, Table);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string data = "";


            


            data += SSN.Text;
            CUSN = data[0].ToString();
                //data += LID ;
            
            
            


            data += SSN.Text;         
            data += " , '" + Fname.Text;
            data += "' , '" + Lname.Text;
            data += "' , '" + Address.Text;
            data += "' , '" + Email.Text;
            data += "' , " + PassID.Text;
            data += " , '" + Dob.Text;
            data += "' , '" + Sex.Text;
            data += "' , '" + Job.Text + "'";


            m.Insert(data);

            MessageBox.Show("Added is complete");



            // Mohemaaa Employee form2 = new Employee(CUSN);
            //form2.ShowDialog();

            //clear();
            //  MOHEMA   CustomerPhone form = new CustomerPhone(SSN.Text);
            //form.ShowDialog();

            
            CustomerPhone form = new CustomerPhone(SSN.Text);
            form.ShowDialog();



        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<List<string>> R = m.Read();

            //if (Int32.Parse(SSN.Text) > 0 && Int32.Parse(SSN.Text) <= R.Count)
            //{
                string set = "";
                bool temp = false;

                if (Fname.Text != "")
                {
                    set += "F_Name = '" + Fname.Text + "'";
                    temp = true;
                }

                if (Lname.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "L_Name = '" + Lname.Text + "'";
                }

                if (Address.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "cus_address = '" + Address.Text + "'";
                }

                if (Email.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "email = '" + Email.Text + "'";
                }

                if (PassID.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "passport_ID = " + PassID.Text;
                }

                if (Dob.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "birthdate = '" + Dob.Text + "'";
                }

                if (Sex.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "sex = '" + Sex.Text + "'";
                }

                if (Job.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }

                    set += "job = '" + Job.Text + "'";
                }

            if (set != "") 
            {
                m.Update("SSN = " + SSN.Text, set);


            
            

                MessageBox.Show("Updated is complete");
            }


            CustomerPhone form = new CustomerPhone(SSN.Text);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            List<List<string>> R = m.Read();


            string set = "";
            bool temp = false;

            if (SSN.Text != "")
            {
                set += "SSN = " + SSN.Text;
                temp = true;
            }

            if (Fname.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "F_Name LIKE '" + Fname.Text + "'";
            }

            if (Lname.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "L_Name LIKE '" + Lname.Text + "'";
            }

            if (Address.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "cus_address LIKE '" + Address.Text + "'";
            }

            if (Email.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "email LIKE '" + Email.Text + "'";
            }

            if (PassID.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "passport_ID = " + PassID.Text;
            }






            if (Dob.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "birthdate = '" + Dob.Text + "'";
            }

            if (Sex.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "sex LIKE '" + Sex.Text + "'";
            }

            if (Job.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "job LIKE '" + Job.Text + "'";
            }

            List<List<string>> Del = m.Read(set);
            Main dM = new Main("Customer_phone");

            for (int i = 0; i < Del.Count; i++) 
            {
                List<string> ptrvl = Del[i];

                dM.Delete("SSN = " + ptrvl[0]);
            }

            m.Delete(set);

            MessageBox.Show("Delete is complete");
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            //dataGridView1.DataSource = m.GetTable(LH, Table);

            List<List<string>> Table = m.Read();

            string set = "";
            bool temp = false;

            if (SSN.Text != "")
            {
                set += "SSN = " + SSN.Text;
                temp = true;
            }

            if (Fname.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "F_Name LIKE '" + Fname.Text + "'";
            }

            if (Lname.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "L_Name LIKE '" + Lname.Text + "'";
            }

            if (Address.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "cus_address LIKE '" + Address.Text + "'";
            }

            if (Email.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "email LIKE '" + Email.Text + "'";
            }

            if (PassID.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "passport_ID = " + PassID.Text;
            }

            if (Dob.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }

                set += " birthdate like '" + Dob.Text + "'";

            }

            if (Sex.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "sex LIKE '" + Sex.Text + "'";
            }

            if (Job.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "job LIKE '" + Job.Text + "'";
            }

            Table = m.Read(set);

            dataGridView1.DataSource = m.GetTable(LH, Table);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

