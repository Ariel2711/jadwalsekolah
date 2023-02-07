using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolah
{
    public partial class TeachingSchedule : Form
    {
        public TeachingSchedule()
        {
            InitializeComponent();
            load_data();
        }

        DBHelper db = new DBHelper();

        public void load_data()
        {
            DataTable dt = db.getTable("select distinct hs.ScheduleID as scheduleID, t.Name as teacher, c.Name as class, s.Name as subject from HeaderSchedule hs inner join DetailSchedule ds on ds.ScheduleID=hs.ScheduleID inner join class c on c.ClassID = hs.ClassID inner join subject s on s.SubjectID=hs.SubjectID inner join teacher t on t.TeacherID=hs.TeacherID");
            tblSchedule.DataSource = dt;
            DataTable dt2 = db.getTable("select * from student");
            tblStudent.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeTeacher ht = new HomeTeacher();
            ht.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SubjectClass.subjectid == 0)
            {
                MessageBox.Show("select schedule first!");
            }
            else
            {
                this.Hide();
                ViewSubject vsub = new ViewSubject();
                vsub.Show();
            }

        }

        private void TeachingSchedule_Load(object sender, EventArgs e)
        {

        }

        private void tblSchedule_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                int idsub = int.Parse(tblSchedule.Rows[i].Cells["scheduleID"].Value.ToString());
                DataTable dt = db.getTable($"select SubjectID as idsub from HeaderSchedule where ScheduleID = '{idsub}'");
                DataRow dr = dt.Rows[0];
                SubjectClass.subjectid = int.Parse(dr["idsub"].ToString());
                int idstud = int.Parse(tblSchedule.Rows[i].Cells["scheduleID"].Value.ToString());
                DataTable dt2 = db.getTable($"select * from DetailSchedule ds inner join student s on s.StudentID = ds.StudentID where ds.ScheduleID = '{idsub}'");
                tblStudent.DataSource = dt2;
            }
            catch
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
