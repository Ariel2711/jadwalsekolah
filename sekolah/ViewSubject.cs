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
    public partial class ViewSubject : Form
    {
        public ViewSubject()
        {
            InitializeComponent();
            id = SubjectClass.subjectid;
            role = UserClass.role;
            load_data();
        }
        string role;
        int id;
        DBHelper db = new DBHelper();
        public void load_data() {
            DataTable dt = db.getTable($"select * from subject where subjectid='{id}'");
            DataRow dr = dt.Rows[0];
            SubjectClass.desc = dr["Description"].ToString();
            SubjectClass.name = dr["Name"].ToString();
            SubjectClass.assign = int.Parse(dr["Assignment"].ToString());
            SubjectClass.finalexam = int.Parse(dr["FinalExam"].ToString());
            SubjectClass.midexam = int.Parse(dr["MidExam"].ToString());
            labelname.Text = SubjectClass.name;
            labeldesc.Text = SubjectClass.desc;
            labelassign.Text = $"{SubjectClass.assign.ToString()} %";
            labelmid.Text = $"{SubjectClass.midexam.ToString()} %";
            labelfinal.Text = $"{SubjectClass.finalexam.ToString()} %";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(role == "student")
            {
                this.Hide();
                ViewSchedule vs = new ViewSchedule();
                vs.Show();
                
            }
            else if (role == "teacher")
            {
                this.Hide();
                TeachingSchedule ts = new TeachingSchedule();
                ts.Show();
                
            }
        }

        private void ViewSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
