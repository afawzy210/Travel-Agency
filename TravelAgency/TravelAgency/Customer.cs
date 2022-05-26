﻿using System;
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
            List<List<string>> R = m.Read();

            if (R.Count == 0)
            {
                data += 1;
            }
            else 
            {
                List<string> C = R[R.Count - 1];
                int LID = Int32.Parse(C[0]) + 1;
                //data += LID ;
            }
            
            //bool temp = false;
            
            
            data += (" , '" + Fname.Text);
            data += ("' , '" + Lname.Text);
            data += ("' , '" + Address.Text);
            data += ("' , '" + Email.Text);
            data += ("' , " + PassID.Text);
            data += (" , '" + Dob.Text);
            data += ("' , '" + Sex.Text);
            data += ("' , '" + Job.Text + "'");

            m.Insert(data);

            MessageBox.Show("Added is complete");

        }

        private void label7_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main("customer");

            List<List<string>> R = m.Read();

            if (Int32.Parse(SSN.Text) > 0 && Int32.Parse(SSN.Text) <= R.Count)
            {
                string set = "";
                bool temp = false;

                if (Fname.Text != "")
                {
                    set += ("F_Name = '" + Fname.Text + "'");
                    temp = true;
                }

                if (Lname.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("L_Name = '" + Lname.Text + "'");
                }

                if (Address.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("cus_address = '" + Address.Text + "'");
                }

                if (Email.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("email = '" + Email.Text + "'");
                }

                if (PassID.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("passport_ID = '" + PassID.Text + "'");
                }

                if (Dob.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("birthdate = '" + Dob.Text + "'");
                }

                if (Sex.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("sex = '" + Sex.Text + "'");
                }

                if (Job.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("job = '" + Fname.Text + "'");
                }

                m.Update("SSN = " + SSN.Text, set);

                MessageBox.Show("Updated is complete");
            }
            else 
            {
                MessageBox.Show("Not found");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main m = new Main("customer");

            List<List<string>> R = m.Read();

            if (Int32.Parse(SSN.Text) > 0 && Int32.Parse(SSN.Text) <= R.Count)
            {
                string set = "";
                bool temp = false;

                if (SSN.Text != "")
                {
                    set += ("SSN = " + SSN.Text);
                    temp = true;
                }

                if (Fname.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("F_Name = '" + Fname.Text + "'");
                }

                if (Lname.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("L_Name = '" + Lname.Text + "'");
                }

                if (Address.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("cus_address = '" + Address.Text + "'");
                }

                if (Email.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("email = '" + Email.Text + "'");
                }

                if (PassID.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("passport_ID = " + PassID.Text);
                }

                if (Dob.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("birthdate = '" + Dob.Text + "'");
                }

                if (Sex.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("sex = '" + Sex.Text + "'");
                }

                if (Job.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("job = '" + Fname.Text + "'");
                }

                m.Delete(set);

                MessageBox.Show("Delete is complete");
            }
            else
            {
                MessageBox.Show("Not found");
            }

        }
    }
}