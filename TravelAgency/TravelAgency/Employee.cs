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
    public partial class Employee : Form
    {
        Main E = new Main("Employee");
        List<string> LH = new List<string>();
        private string idemp;
        public Employee()
        {
            InitializeComponent();
        }
        void clear()
        {
            id.Text = "";
            job.Text = "";
            sex.Text = "";
            address.Text = "";
            name.Text = "";
            password.Text = "";
            salairy.Text = "";
            workinghours.Text = "";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string data = "";
            List<List<string>> R = E.Read();

            if (R.Count == 0)
            {
                data += 1;//ay kalam
            }
            else
            {
                List<string> C = R[R.Count - 1];
                int LID = Int32.Parse(C[0]) + 1;
                data += LID;
                idemp += data[0].ToString();

            }

            data += " , '" + sex.Text;
            data += "' , '" + job.Text;
            data += "' , '" + address.Text;
            data += "' , '" + name.Text ;
            data += "' , '" + password.Text;
            data += "' , " + salairy.Text;
            data += " , " + workinghours.Text;
            
            E.Insert(data);

            MessageBox.Show("Added is complete");
            Hotel form2 = new Hotel(idemp);
            form2.ShowDialog();
            
            //Invoice form = new Invoice(id.Text,idhotel);
            //form.ShowDialog();
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main E = new Main("Employee");

            List<List<string>> R = E.Read();

            //if (Int32.Parse(id.Text) > 0 && Int32.Parse(id.Text) <= R.Count)
            //{
                string set = "";
                bool temp = false;

                if (sex.Text != "")
                {
                    set += "sex = '" + sex.Text + "'";
                    temp = true;
                }

                if (job.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "job = '" + job.Text + "'";
                }

                if (address.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "EMP_address = '" + address.Text + "'";
                }

                if (name.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "EMP_name = '" + name.Text + "'";
                }

                if (password.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "emp_password = '" + password.Text + "'";
                }

                if (salairy.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "salairy = '" + salairy.Text + "'";
                }

                if (workinghours.Text != "")
                {
                    if (temp)
                    {
                        set += ", ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "working_hours = '" + workinghours.Text + "'";
                }

                

                E.Update("Emp_id = " + id.Text, set);

                MessageBox.Show("Updated is complete");
            //}
            //else
            //{
                //MessageBox.Show("Not found");
            ///}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main E = new Main("Employee");

            List<List<string>> R = E.Read();

            
                string set = "";
                bool temp = false;

            //if (id.Text != "")
            //{
            //    set += "Emp_id = " + id.Text;
            //    temp = true;
            //}
            if (id.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {

                    set += "Emp_id = " + id.Text;

                    temp = true;
                }
                //set += "Emp_id = " + id.Text;
            }

                if (sex.Text != "")
                {
                    if (temp)
                    {
                        set += " and ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "sex LIKE '" + sex.Text + "'";
                }

                if (job.Text != "")
                {
                    if (temp)
                    {
                        set += " and ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "job LIKE '" + job.Text + "'";
                }

                if (address.Text != "")
                {
                    if (temp)
                    {
                        set += " and ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "EMP_address LIKE '" + address.Text + "'";
                }

                if (name.Text != "")
                {
                    if (temp)
                    {
                        set += " and ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "EMP_name LIKE '" + name.Text + "'";
                }

                if (password.Text != "")
                {
                    if (temp)
                    {
                        set += " and ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "emp_password LIKE '" + password.Text + "'";
                }

                if (salairy.Text != "")
                {
                    if (temp)
                    {
                        set += " and ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "salairy = " + salairy.Text ;
                }

                if (workinghours.Text != "")
                {
                    if (temp)
                    {
                        set += " and ";
                    }
                    else
                    {
                        temp = true;
                    }
                    set += "working_hours = " + workinghours.Text ;
                }

                

                E.Delete(set);

                MessageBox.Show("Delete is complete");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            List<List<string>> Table = E.Read();
            LH.Add("Employee id");
            LH.Add("sex");
            LH.Add("job");
            LH.Add("address");
            LH.Add("Name");
            LH.Add("password");
            LH.Add("salairy");
            LH.Add("working hours");
            

            dataGridView1.DataSource = E.GetTable(LH, Table);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<List<string>> Table = E.Read();

            string set = "";
            bool temp = false;

            //if (id.Text != "")
            //{
            //    set += "Emp_id = " + id.Text;
            //    temp = true;
            //}
            if (id.Text != "")
            {
                
                set += "Emp_id = " + id.Text;
                temp = true;
            }

            if (sex.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "sex LIKE '" + sex.Text + "'";
            }

            if (job.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "Job LIKE '" + job.Text + "'";
            }

            if (address.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "EMP_address LIKE '" + address.Text + "'";
            }

            if (name.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "EMP_name LIKE '" + name.Text + "'";
            }

            if (password.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "emp_password LIKE '" + password.Text + "'";
            }

            if (salairy.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "salairy = " + salairy.Text ;
            }

            if (workinghours.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "working_hours = " + workinghours.Text ;
            }

            

            Table = E.Read(set);

            dataGridView1.DataSource = E.GetTable(LH, Table);
        }
    }
}
