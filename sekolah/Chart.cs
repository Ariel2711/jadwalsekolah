using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolah
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
            load_datasiswa();
            load_datadate();
        }

        DBHelper db = new DBHelper();

        public void load_datasiswa()
        {
            DataTable dt = db.getTable("select ScheduleID, count(StudentID) as student from DetailSchedule group by ScheduleID");
            chartsiswa.Series["ScheduleID"].Points.Clear();
            chartsiswa.DataSource = dt;
            chartsiswa.Series["ScheduleID"].XValueMember = "ScheduleID";
            chartsiswa.Series["ScheduleID"].YValueMembers = "student";
            chartsiswa.Invalidate();
        }

        public void load_datadate()
        {
            DataTable dt = db.getTable("select datebirth,count(studentid) as student from student group by datebirth");
            chartdate.Series["Date"].Points.Clear();
            chartdate.DataSource = dt;
            chartdate.Series["Date"].XValueMember = "datebirth";
            chartdate.Series["Date"].YValueMembers = "student";
            chartdate.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtStudent.Text != "")
            {
                DataTable dt = db.getTable($"select ScheduleID, count(StudentID) as student from DetailSchedule where studentID ='{int.Parse(txtStudent.Text)}' group by ScheduleID");
                chartsiswa.Series["ScheduleID"].Points.Clear();
                chartsiswa.DataSource = dt;
                chartsiswa.Series["ScheduleID"].XValueMember = "ScheduleID";
                chartsiswa.Series["ScheduleID"].YValueMembers = "student";
                chartsiswa.Invalidate();
            }
            else
            {
                MessageBox.Show("field empty");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_datadate();
            load_datasiswa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select DateBirth,count(studentid) as student from student where DateBirth BETWEEN @start AND @end GROUP by DateBirth";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@start", datestart.Value);
            cmd.Parameters.AddWithValue("@end", dateend.Value);
            DataTable dt = db.getTableCmd(cmd);
            chartdate.Series["Date"].Points.Clear();
            chartdate.DataSource = dt;
            chartdate.Series["Date"].XValueMember = "DateBirth";
            chartdate.Series["Date"].YValueMembers = "student";
            chartdate.Invalidate();
        }
    }
}
