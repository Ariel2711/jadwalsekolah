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
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();
            load_datastudent();
        }

        int id;
        int studentid;
        DBHelper db = new DBHelper();

        public void clear_data() {
            studentid = 0;
        }
        public void load_datastudent()
        {
            DataTable dt = db.getTable("select * from student");
            tblStudent.DataSource = dt;
            DataTable dtschedule = db.getTable("select scheduleid from headerschedule");
            cbSchedule.DataSource = dtschedule;
            cbSchedule.ValueMember = dtschedule.Columns["scheduleid"].ToString();
            cbSchedule.DisplayMember = dtschedule.Columns["scheduleid"].ToString();
        }

        public void load_data()
        {
            id = int.Parse(cbSchedule.SelectedValue.ToString());
            DataTable dt = db.getTable($"select * from detailschedule where scheduleid='{id}'");
            tblSchedule.DataSource = dt;
        }

        private void FormClass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            
        }

        private void cbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(cbSchedule.SelectedValue.ToString());
                string query = $"insert into detailschedule values('{id}','{studentid}')";
                db.insert(query);
                MessageBox.Show("success");
                load_data();
                clear_data();
            }
            catch
            {
                MessageBox.Show("fail");
            }
        }

        private void tblStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            studentid = int.Parse(tblStudent.Rows[i].Cells[0].Value.ToString());
        }

        private void tblSchedule_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                studentid = int.Parse(tblSchedule.Rows[i].Cells[1].Value.ToString());
                id = int.Parse(tblSchedule.Rows[i].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("invalid");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"delete from detailschedule where scheduleid='{id}' AND studentid='{studentid}'";
                db.insert(query);
                MessageBox.Show("success");
                load_data();
                clear_data();
            }
            catch
            {
                MessageBox.Show("fail");
            }
        }

        private void cbSchedule_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void cbSchedule_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
