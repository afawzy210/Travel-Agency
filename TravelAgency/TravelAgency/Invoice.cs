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
    public partial class Invoice : Form
    {
        Main I = new Main("Invoice");
        List<string> LM = new List<string>();
        string data2 = "";
        string iii;
        string i2;
        
        public Invoice(string empid,string idhotel)
        {
            InitializeComponent();
            //iii += "' , " + empid;
            iii = empid;
            //i2 += " , " + idhotel;
            i2 = idhotel;
        }
        void clear()
        {
            invoiceid.Text = "";
            amount.Text = "";
            date.Text = "";
            paymentmethod.Text = "";
            empid.Text = "";
            //i2.Text = "";

        }
        private void insert_Click(object sender, EventArgs e)
        {
            //string data2 = "";
            List<List<string>> R = I.Read();
            if (R.Count == 0)
            {
                data2 += 1;
            }
            else
            {
                List<string> C = R[R.Count - 1];
                int LID = Int32.Parse(C[0]) + 1;

                data2 += LID;

                //data2 += LID;
            }


            //data2 += "' , '";
            data2 += " , " + amount.Text;
            data2 += " , '" + date.Text;
            data2 += "', '" + paymentmethod.Text;
            data2 += "' , " + iii;
            data2 += " , " + i2;



            I.Insert(data2);

            MessageBox.Show("Added is complete");
            //iii = "a";
            clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paymentmethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            paymentmethod.Items.Add("visa");
            paymentmethod.Items.Add("MasterCard");
            paymentmethod.Items.Add("Cash");

            List<List<string>> Table = I.Read();
            LM.Add("Ivoice ID");
            LM.Add("amount");
            LM.Add("date");
            LM.Add("payment method");
            LM.Add("EMP ID");
            

            dataGridView1.DataSource = I.GetTable(LM, Table);

        }

        private void update_Click(object sender, EventArgs e)
        {
            //Main I = new Main("Invoice");

            List<List<string>> R = I.Read();

            //if (Int32.Parse(id.Text) > 0 && Int32.Parse(id.Text) <= R.Count)
            //{
            string set = "";
            bool temp = false;

            if (invoiceid.Text != "")
            {
                set += "Invoice_ID = '" + invoiceid.Text + "'";
                temp = true;
            }

            if (amount.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "amount = '" + amount.Text + "'";
            }

            if (date.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "Idate = '" + date.Text + "'";
            }

            if (paymentmethod.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "payment_method = '" + paymentmethod.Text + "'";
            }

            if (empid.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "emp_id = '" + empid.Text + "'";
            }
            if (i2 != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "Id_hotel = " + i2 ;
            }





            I.Update("Invoice_ID = " + invoiceid.Text, set);

            MessageBox.Show("Updated is complete");
            //}
            //else
            //{
            //MessageBox.Show("Not found");
            ///}
        }

        private void delete_Click(object sender, EventArgs e)
        {
            List<List<string>> R = I.Read();


            string set = "";
            bool temp = false;

           
            if (invoiceid.Text != "")
            {
                set += "Invoice_ID = " + invoiceid.Text ;
                temp = true;
            }

            if (amount.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "amount = " + amount.Text ;
            }

            if (date.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "Idate = '" + date.Text + "'";
            }
            
            if (paymentmethod.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "payment_method LIKE '" + paymentmethod.Text + "'";
            }

            if (empid.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "emp_id = " + empid.Text ;
            }
            if (i2 != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "Id_hotel = " + i2 ;
            }




            I.Delete(set);

            MessageBox.Show("Delete is complete");
        }

        private void search_Click(object sender, EventArgs e)
        {
            List<List<string>> Table = I.Read();

            string set = "";
            bool temp = false;


            if (invoiceid.Text != "")
            {
                set += "Invoice_ID = " + invoiceid.Text;
                temp = true;
            }

            if (amount.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "amount = " + amount.Text ;
            }

            if (date.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "Idate LIKE " + date.Text ;
            }

            if (paymentmethod.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "payment_method LIKE '" + paymentmethod.Text + "'";
            }

            if (empid.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "Emp_id = " + empid.Text ;
            }
            if (i2 != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "Id_hotel = " + i2;
            }



            //if (invoiceid.Text != "")
            //{
            //    set += "Invoice_ID = " + invoiceid.Text;
            //    temp = true;
            //}

            //if (amount.Text != "")
            //{
            //    if (temp)
            //    {
            //        set += " and ";
            //    }
            //    else
            //    {
            //        temp = true;
            //    }
            //    set += "amount LIKE " + amount.Text  ;
            //}

            //if (date.Text != "")
            //{
            //    if (temp)
            //    {
            //        set += " and ";
            //    }
            //    else
            //    {
            //        temp = true;
            //    }
            //    set += "date LIKE '" + date.Text + "'";
            //}

            //if (paymentmethod.Text != "")
            //{
            //    if (temp)
            //    {
            //        set += " and ";
            //    }
            //    else
            //    {
            //        temp = true;
            //    }
            //    set += "payment_method LIKE '" + paymentmethod.Text + "'";
            //}

            //if (empid.Text != "")
            //{
            //    if (temp)
            //    {
            //        set += " and ";
            //    }
            //    else
            //    {
            //        temp = true;
            //    }
            //    set += "Emp_id LIKE " + empid.Text ;
            //}


            Table = I.Read(set);

            dataGridView1.DataSource = I.GetTable(LM, Table);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
