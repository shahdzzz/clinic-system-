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
    public partial class HealthCareRecord : Form
    {
        public HealthCareRecord()
        {
            string selectedlang = Properties.Settings.Default.lang;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(selectedlang);

            InitializeComponent();
        }

        private void HealthCareRecord_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
