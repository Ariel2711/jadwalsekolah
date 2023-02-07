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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
            lblName.Text = UserClass.nama;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStudent fstu = new FormStudent();
            fstu.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTeacher ft = new FormTeacher();
            ft.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClass fc = new FormClass();
            fc.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSubject fsub = new FormSubject();
            fsub.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSchedule fs = new FormSchedule();
            fs.Show();
            
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chart ch = new Chart();
            ch.Show();
        }
    }
}
