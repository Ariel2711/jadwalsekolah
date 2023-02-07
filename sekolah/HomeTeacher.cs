using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolah
{
    public partial class HomeTeacher : Form
    {
        public HomeTeacher()
        {
            InitializeComponent();
            lblNama.Text = UserClass.nama;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfileTeacher fp = new FormProfileTeacher();
            fp.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachingSchedule ts = new TeachingSchedule();
            ts.Show();
            
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
