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
        Main E = new Main("Employee");
        List<List<string>> LH = new List<List<string>>();
        public string iddd;

        public string pass;
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LH = E.Read("Emp_id = " + EmpID.Text + " and emp_password like '" + password.Text + "'");

            
            if ( LH.Count > 0)
            {
                Customer form = new Customer();
                //this.Hide;
                form.ShowDialog();
                //this.close;
            }
            else
            {
                MessageBox.Show("INvalid Username or password");
            }








            




            
        }
    }
}
