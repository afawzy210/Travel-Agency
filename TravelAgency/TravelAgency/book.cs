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
    public partial class book : Form
    {
        Main mc = new Main("customer");
        Main me = new Main("Employee");

        public book()
        {
            InitializeComponent();
        }

        private void book_Load(object sender, EventArgs e)
        {
            List<List<string>> LC = mc.Read();
            List<List<string>> LE = me.Read();

            for (int i = 0; i < LC.Count; i++) 
            {
                List<string> ptrvl = LC[i];

                comboBox2.Items.Add(ptrvl[0]);
            }


            for (int i = 0; i < LE.Count; i++)
            {
                List<string> ptrvl = LE[i];

                comboBox1.Items.Add(ptrvl[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "") 
            {
                Trip t = new Trip(comboBox2.Text, comboBox1.Text);
                t.ShowDialog();
            }
            
        }
    }
}
