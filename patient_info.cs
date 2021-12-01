using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical_System
{
    public partial class patient_info : Form
    {
        public patient_info()
        {
            string selectedlang = Properties.Settings.Default.lang;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(selectedlang);

            InitializeComponent();
        }

        private void patient_info_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
