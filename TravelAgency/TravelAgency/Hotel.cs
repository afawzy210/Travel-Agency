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
    public partial class Hotel : Form
    {
        Main m = new Main("Hotel");
        List<string> LH = new List<string>();
        private string empid;
        public string iddd;
        void clear()
        {
            IDHotel.Text = "";
            TypeRoom.Text = "";
            //Cost.Text = "";
            NoD.Text = "";
            nHotel.Text = "";
        }

        public Hotel( string idemp)
        {
            InitializeComponent();
            empid = idemp;
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            TypeRoom.Items.Add("single");
            TypeRoom.Items.Add("double");
            TypeRoom.Items.Add("suite");


            List<List<string>> Table = m.Read();

            LH.Add("ID Hotel");
            LH.Add("Type Room");
            LH.Add("Cost");
            LH.Add("Number of Days");
            LH.Add("Name of Hotel");

            dataGridView1.DataSource = m.GetTable(LH, Table);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
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

                data += LID;
                 iddd = data[0].ToString();
            }

            
            data += " , '" + TypeRoom.Text;
            if (TypeRoom.Text=="single") {
                data += "' , " + 50;
            }
            if (TypeRoom.Text == "double")
            {
                data += "' , " + 100;
            }
            if (TypeRoom.Text == "suite")
            {
                data += "' , " + 200;
            }


            data += " , " + NoD.Text;
            data += " , '" + nHotel.Text + "'";


            m.Insert(data);

            MessageBox.Show("Added is complete");

            clear();
            Invoice form = new Invoice(empid,iddd);
            form.ShowDialog();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            List<List<string>> Table = m.Read();

            string set = "";
            bool temp = false;

            if (IDHotel.Text != "")
            {
                set += "Id_hotel = " + IDHotel.Text;
                temp = true;
            }

            if (TypeRoom.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "type_room LIKE '" + TypeRoom.Text + "'";
            }

            //if (Cost.Text != "")
            //{
            //    if (temp)
            //    {
            //        set += "and ";
            //    }
            //    else
            //    {
            //        temp = true;
            //    }
            //    set += "cost = " + Cost.Text;
            //}

            if (NoD.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "numberDays = " + NoD.Text;
            }

            if (nHotel.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "name_hotel LIKE '" + nHotel.Text + "'";
            }

            Table = m.Read(set);

            dataGridView1.DataSource = m.GetTable(LH, Table);

            clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            List<List<string>> R = m.Read();

            //if (Int32.Parse(SSN.Text) > 0 && Int32.Parse(SSN.Text) <= R.Count)
            //{
            string set = "";
            bool temp = false;

            if (TypeRoom.Text != "")
            {
                set += "type_room = '" + TypeRoom.Text + "'";
                temp = true;
            }

            //if (Cost.Text != "")
            //{
            //    if (temp)
            //    {
            //        set += ", ";
            //    }
            //    else
            //    {
            //        temp = true;
            //    }
            //    set += "cost = " + Cost.Text;
            //}

            if (NoD.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "numberDays = " + NoD.Text;
            }

            if (nHotel.Text != "")
            {
                if (temp)
                {
                    set += ", ";
                }
                else
                {
                    temp = true;
                }
                set += "name_hotel = '" + nHotel.Text + "'";
            }

            m.Update("Id_hotel = " + IDHotel.Text, set);

            MessageBox.Show("Updated is complete");
            clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            List<List<string>> R = m.Read();


            string set = "";
            bool temp = false;

            if (IDHotel.Text != "")
            {
                set += "Id_hotel = " + IDHotel.Text;
                temp = true;
            }

            if (TypeRoom.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "type_room LIKE '" + TypeRoom.Text + "'";
            }

            //if (Cost.Text != "")
            //{
            //    if (temp)
            //    {
            //        set += "and ";
            //    }
            //    else
            //    {
            //        temp = true;
            //    }
            //    set += "cost = " + Cost.Text;
            //}

            if (NoD.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "numberDays = " + NoD.Text;
            }

            if (nHotel.Text != "")
            {
                if (temp)
                {
                    set += "and ";
                }
                else
                {
                    temp = true;
                }
                set += "name_hotel LIKE '" + nHotel.Text + "'";
            }

            

            m.Delete(set);

            MessageBox.Show("Delete is complete");

            clear();
        }
    }
}
