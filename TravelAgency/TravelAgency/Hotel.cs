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

        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            List<List<string>> Table = m.Read();

            LH.Add("ID Hotel");
            LH.Add("Type Room");
            LH.Add("Cost");
            LH.Add("Number of Days");
            LH.Add("Name of Hotel");

            dataGridView1.DataSource = m.GetTable(LH, Table);
        }
    }
}
