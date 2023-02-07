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
    public partial class HomeStudent : Form
    {
        public HomeStudent()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSchedule vs = new ViewSchedule();
            vs.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfileStudent fp = new FormProfileStudent();
            fp.Show();
            
        }

        private void HomeStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
