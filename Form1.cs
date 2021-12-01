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
    public partial class Form1 : Form
    {
        public Form1()
        {
            string selectedlang = Properties.Settings.Default.lang;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(selectedlang);


            InitializeComponent();
        }

       

  
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            Doctor Doc1 = new Doctor();
            
            Doc1.MdiParent = this;
            Doc1.Hide();
            Doc1.Show();
            
        }
        

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
            HealthCareRecord hel = new HealthCareRecord();
            hel.MdiParent = this;
            hel.Show();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
         
            Patient Pa1 = new Patient();
            Pa1.MdiParent = this;
            Pa1.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
            Appointment app = new Appointment();
            app.MdiParent = this;
            app.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
            patient_info infor = new patient_info();
            infor.MdiParent = this;
            infor.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            patient_gealth patient = new patient_gealth();
            patient.MdiParent = this;
            patient.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }
    }
}
