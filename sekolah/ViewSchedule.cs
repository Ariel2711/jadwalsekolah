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
    public partial class ViewSchedule : Form
    {
        public ViewSchedule()
        {
            InitializeComponent();
            load_data();
        }

        DBHelper db = new DBHelper();

        public void load_data() {
        DataTable dt = db.getTable("select hs.ScheduleID as scheduleID, t.Name as teacher, c.Name as class, s.Name as subject from HeaderSchedule hs inner join DetailSchedule ds on hs.ScheduleID=ds.ScheduleID inner join class c on c.ClassID = hs.ClassID inner join subject s on s.SubjectID=hs.SubjectID inner join teacher t on t.TeacherID=hs.TeacherID");
        tblSchedule.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeStudent hs = new HomeStudent();
            hs.Show();
            
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

        private void ViewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblSchedule_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                int idsub = int.Parse(tblSchedule.Rows[index].Cells["scheduleID"].Value.ToString());
                DataTable dt = db.getTable($"select SubjectID as idsub from HeaderSchedule where ScheduleID = '{idsub}'");
                DataRow dr = dt.Rows[0];
                SubjectClass.subjectid = int.Parse(dr["idsub"].ToString());
            }
            catch
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
