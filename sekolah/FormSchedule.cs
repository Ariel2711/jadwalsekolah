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
    public partial class FormSchedule : Form
    {
        public FormSchedule()
        {
            InitializeComponent();
            load_data();
        }

        DBHelper db = new DBHelper();
        int id;

        public void load_data()
        {
            DataTable dt = db.getTable("select * from headerschedule");
            tblschedule.DataSource = dt;
            DataTable dtclass = db.getTable("select * from class");
            cbClass.DataSource = dtclass;
            cbClass.ValueMember = dtclass.Columns["ClassID"].ToString();
            cbClass.DisplayMember = dtclass.Columns["Name"].ToString();
            DataTable dtsubject = db.getTable("select * from subject");
            cbSubject.DataSource = dtsubject;
            cbSubject.ValueMember = dtsubject.Columns["SubjectID"].ToString();
            cbSubject.DisplayMember = dtsubject.Columns["Name"].ToString();
            DataTable dtteacher = db.getTable("select * from teacher");
            cbTeacher.DataSource = dtteacher;
            cbTeacher.ValueMember = dtteacher.Columns["TeacherID"].ToString();
            cbTeacher.DisplayMember = dtteacher.Columns["Name"].ToString();
        }

        public void clear_data()
        {
            id = 0;
            cbClass.Text = "";
            cbSubject.Text = "";
            cbTeacher.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {

        }

        private void tblschedule_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                id = int.Parse(tblschedule.Rows[i].Cells[0].Value.ToString());
                cbSubject.SelectedValue = tblschedule.Rows[i].Cells[1].Value.ToString();
                cbTeacher.SelectedValue = tblschedule.Rows[i].Cells[2].Value.ToString();
                cbClass.SelectedValue = tblschedule.Rows[i].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("invalid");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                    string query = $"insert into headerschedule (subjectid, classid, teacherid) values('{int.Parse(cbSubject.SelectedValue.ToString())}','{int.Parse(cbClass.SelectedValue.ToString())}','{int.Parse(cbTeacher.SelectedValue.ToString())}')";
                    db.insert(query);
                    MessageBox.Show("success");
                    load_data();
                    clear_data();
                
            }
            catch
            {
                MessageBox.Show("fail");
                clear_data();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string query = $"update headerschedule set subjectid='{int.Parse(cbSubject.SelectedValue.ToString())}',classid='{int.Parse(cbClass.SelectedValue.ToString())}',teacherid='{int.Parse(cbTeacher.SelectedValue.ToString())}' where scheduleid='{id}'";
                db.insert(query);
                MessageBox.Show("success");
                load_data();
                clear_data();

            }
            catch
            {
                MessageBox.Show("fail");
                clear_data();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string query = $"delete from headerschedule where scheduleid='{id}'";
                db.insert(query);
                MessageBox.Show("success");
                load_data();
                clear_data();

            }
            catch
            {
                MessageBox.Show("fail");
                clear_data();
            }
        }
    }
}
