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
    public partial class Trip : Form
    {
        Main E = new Main("Trip");
        List<string> LH = new List<string>();
        private string CUSN;
        private string empid;

        public Trip(string CUSNN,string empidd)
        {
            InitializeComponent();
            CUSN = CUSNN;
            empid = empidd;

        }

        private void insert_Click(object sender, EventArgs e)
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
                //idemp += data[0].ToString();

            }

            data += " , '" + tripcoun.Text;
            data += "' , " + cost.Text;

            data += " , '" + transp.Text;
            //if (transp.Text == "Car")
            //{
            //    data += "' , " + 50;
            //}
            //if (transp.Text == "Bus")
            //{
            //    data += "' , " + 100;
            //}
            //if (transp.Text == "Boat")
            //{
            //    data += "' , " + 200;
            //}
            //if (transp.Text == "Plane")
            //{
            //    data += "' , " + 500;
            //}
            data += "' , '" + TCC.Text;
            data += "', '" + DD.Text;
            data += "' , '" + AD.Text ;
            data += "' , " + CUSN;
            data += " , " + empid;

            E.Insert(data);

            MessageBox.Show("Added is complete");
            //Hotel form2 = new Hotel(idemp);
            //form2.ShowDialog();

            //clear();
        }

        private void Trip_Load(object sender, EventArgs e)
        {


            List<List<string>> Table = E.Read();
            LH.Add("Trip ID");
            LH.Add("Trip Country");
            LH.Add("Cost");
            LH.Add("Transportation Method");
            LH.Add("Trip City");
            LH.Add("Departure date");
            LH.Add("Arrival date");
            LH.Add("SSN");
            LH.Add("EMP ID");

            dataGridView1.DataSource = E.GetTable(LH, Table);

            tripcoun.Items.Add("Egypt");
            tripcoun.Items.Add("USA");
            tripcoun.Items.Add("UAE");
            tripcoun.Items.Add("IATLY");
            tripcoun.Items.Add("Russia");

            tripcoun.Items.Add("Canada");
            tripcoun.Items.Add("Japan");
            tripcoun.Items.Add("China");
            tripcoun.Items.Add("Malaysia");
            tripcoun.Items.Add("Argentine");



            tripcoun.Items.Add("spain");
            tripcoun.Items.Add("Germany");
            tripcoun.Items.Add("Holland");
            tripcoun.Items.Add("Sudan");
            tripcoun.Items.Add("India");



            transp.Items.Add("Car");
            transp.Items.Add("Bus");
            transp.Items.Add("Boat");
            transp.Items.Add("Plane");



        }
        private void update_Click(object sender, EventArgs e)
        {
            //List<List<string>> R = I.Read();

            //if (Int32.Parse(id.Text) > 0 && Int32.Parse(id.Text) <= R.Count)
            //{


            string set = "";
            bool temp = false;

            if (id.Text != "")
            {
                set += "ID_trip = " + id.Text;
                temp = true;
            }

            if (tripcoun.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "trip_name = '" + tripcoun.Text + "'";
            }

            if (cost.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "cost = " + cost.Text;
            }

            if (transp.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "transportation_method = '" + transp.Text + "'";
            }

            if (TCC.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "Tlocation = '" + TCC.Text + "'";
            }
            if (DD.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "Tstart_date = '" + DD.Text + "'";
            }
            if (AD.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "Tend_date = '" + AD.Text + "'";
            }
            if (CUSN != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "SSN = " + CUSN;
            }
            if (empid != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "Emp_id = " + empid;
            }




            E.Update("ID_trip = " + id.Text, set);

            MessageBox.Show("Updated is complete");

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string set = "";
            bool temp = false;

            if (id.Text != "")
            {
                set += "ID_trip = " + id.Text;
                temp = true;
            }

            if (tripcoun.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "trip_name LIKE  '" + tripcoun.Text + "'";
            }

            if (cost.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "cost = " + cost.Text;
            }

            if (transp.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "transportation_method LIKE  '" + transp.Text + "'";
            }

            if (TCC.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Tlocation LIKE '" + TCC.Text + "'";
            }
            if (DD.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Tstart_date LIKE '" + DD.Text + "'";
            }
            if (AD.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Tend_date LIKE '" + AD.Text + "'";
            }
            if (CUSN != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "SSN = " + CUSN;
            }
            if (empid != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Emp_id = " + empid;
            }

            E.Delete(set);

            MessageBox.Show("Delete is complete");


        }



        private void search_Click(object sender, EventArgs e)
        {
            List<List<string>> Table = E.Read();
            string set = "";
            bool temp = false;

            if (id.Text != "")
            {
                set += "ID_trip = " + id.Text;
                temp = true;
            }

            if (tripcoun.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "trip_name LIKE  '" + tripcoun.Text + "'";
            }

            if (cost.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "cost = " + cost.Text;
            }

            if (transp.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "transportation_method LIKE  '" + transp.Text + "'";
            }

            if (TCC.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Tlocation LIKE '" + TCC.Text + "'";
            }
            if (DD.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Tstart_date LIKE '" + DD.Text + "'";
            }
            if (AD.Text != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Tend_date LIKE '" + AD.Text + "'";
            }
            if (CUSN != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "SSN = " + CUSN;
            }
            if (empid != "")
            {
                if (temp)
                {
                    set += " and ";
                }
                else
                {
                    temp = true;
                }
                set += "Emp_id = " + empid;
            }
            Table = E.Read(set);

            dataGridView1.DataSource = E.GetTable(LH, Table);
        }
    }
}
