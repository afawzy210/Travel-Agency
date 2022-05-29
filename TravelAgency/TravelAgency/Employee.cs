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
        public Employee()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main E = new Main("Employee");
            string data = "";
            List<List<string>> R = E.Read();

            if (R.Count == 0)
            {
                data += 1;
            }
            else
            {
                List<string> C = R[R.Count - 1];
                int LID = Int32.Parse(C[0]) + 1;

                data += LID;

                data += LID;
            }

            //bool temp = false;


            //data += ("' , " + id.Text);
            data += (" , '" + sex.Text);
            data += ("' , '" + job.Text);
            data += ("' , '" + address.Text);
            data += ("' , '" + name.Text );
            data += ("' , '" + password.Text);
            data += ("' , " + salairy.Text);
            data += (" , " + workinghours.Text);
            
            

            E.Insert(data);

            MessageBox.Show("Added is complete");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main E = new Main("Employee");

            List<List<string>> R = E.Read();

            if (Int32.Parse(id.Text) > 0 && Int32.Parse(id.Text) <= R.Count)
            {
                string set = "";
                bool temp = false;

                if (sex.Text != "")
                {
                    set += ("sex = '" + sex.Text + "'");
                    temp = true;
                }

                if (job.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("job = '" + job.Text + "'");
                }

                if (address.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("EMP_address = '" + address.Text + "'");
                }

                if (name.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("EMP_name = '" + name.Text + "'");
                }

                if (password.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("emp_password = '" + password.Text + "'");
                }

                if (salairy.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("salairy = '" + salairy.Text + "'");
                }

                if (workinghours.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("working_hours = '" + workinghours.Text + "'");
                }

                

                E.Update("Emp_id = " + id.Text, set);

                MessageBox.Show("Updated is complete");
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main E = new Main("customer");

            List<List<string>> R = E.Read();

            if (Int32.Parse(id.Text) > 0 && Int32.Parse(id.Text) <= R.Count)
            {
                string set = "";
                bool temp = false;

                if (id.Text != "")
                {
                    set += ("Emp_id = " + id.Text);
                    temp = true;
                }

                if (sex.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("sex = '" + sex.Text + "'");
                }

                if (job.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("job = '" + job.Text + "'");
                }

                if (address.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("EMP_address = '" + address.Text + "'");
                }

                if (name.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("EMP_name = '" + name.Text + "'");
                }

                if (password.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("emp_password = " + password.Text);
                }

                if (salairy.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("salairy = '" + salairy.Text + "'");
                }

                if (workinghours.Text != "")
                {
                    if (temp)
                    {
                        set += (", ");
                    }
                    else
                    {
                        temp = true;
                    }
                    set += ("working_hours = '" + workinghours.Text + "'");
                }

                

                E.Delete(set);

                MessageBox.Show("Delete is complete");
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
