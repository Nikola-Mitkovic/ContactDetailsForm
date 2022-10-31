using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactDetailsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Surname";
            dataGridView1.Columns[2].Name = "Street";
            dataGridView1.Columns[3].Name = "City";
            dataGridView1.Columns[4].Name = "State";
            dataGridView1.Columns[5].Name = "Zip";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtName.Text, txtSurname.Text, txtStreet.Text, txtCity.Text, txtState.Text, txtZip.Text);
        }
    }
}
