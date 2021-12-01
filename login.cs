using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinical_System
{
    public partial class login : Form
    {
        private const string V = @"Data Source = DESKTOP - 8G3M2OC\TESTINSTANCE; Initial Catalog = clincal_management_system; Integrated Security = True";

        public login()
        {
            string selectedlang = Properties.Settings.Default.lang;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(selectedlang);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            
            this.Controls.Clear();

            this.RightToLeftLayout = false;
            InitializeComponent();

            Properties.Settings.Default["lang"] = "en-US";
            Properties.Settings.Default.Save();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            this.Controls.Clear();
            InitializeComponent();
            Properties.Settings.Default["lang"] = "ar";
            Properties.Settings.Default.Save();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
