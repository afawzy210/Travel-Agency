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
    public partial class LogIn : Form
    {
        Main E = new Main("LogIN");
        List<string> LH = new List<string>();
        public string iddd;

        public string pass;
        public LogIn(string empid,string idpass,string[] R)
        {
            InitializeComponent();
            iddd = empid;
            pass = idpass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            if (textBox1.Text.ToString() == iddd && textBox2.Text.ToString() == pass)
            {
                Customer form = new Customer();
                //this.Hide;
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("INvalid Username or password");
            }








            




            
        }
    }
}
