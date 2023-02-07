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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
            load_data();
        }

        int id;
        int iduser;
        string foto = "";
        string pw = "pw";
        string gender;
        DBHelper db = new DBHelper();

        public void load_iduser()
        {
            try
            {
                DataTable dt = db.getTable($"select max(userid) as userid from [user]");
                DataRow dr = dt.Rows[0];
                iduser = int.Parse(dr["userid"].ToString());
            }
            catch
            {
                iduser = 0;
            }
            Console.WriteLine($"userid {iduser}");
        }

        public void load_data()
        {
            DataTable dt = db.getTable("select * from teacher");
            tblTeacher.DataSource = dt;
        }

        public void clear_data()
        {
            txtNama.Text = "";
            rdlaki.Checked = false;
            rdperem.Checked = false;
            id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblTeacher_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                id = int.Parse(tblTeacher.Rows[i].Cells[0].Value.ToString());
                txtNama.Text = tblTeacher.Rows[i].Cells[1].Value.ToString();
                gender = tblTeacher.Rows[i].Cells[2].Value.ToString();
                if (gender == "Laki-laki")
                {
                    rdlaki.Checked = true;
                }
                else if (gender == "Perempuan")
                {
                    rdperem.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("invalid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdlaki.Checked == true) {
                    gender = "Laki-laki"; 
                }
                else if(rdperem.Checked == true) {
                    gender = "Perempuan";
                }
                if(txtNama.Text != "" && gender != "")
                {
                    string queryuser = $"insert into [user] (username, password, role) values ('{txtNama.Text}', '{pw}','{"teacher"}')";
                    db.insert(queryuser);
                    load_iduser();
                    string query = $"insert into teacher (name,gender,foto,UserID) values('{txtNama.Text}','{gender}','{foto}','{int.Parse(iduser.ToString())}')";
                    db.insert(query);
                    MessageBox.Show("success");
                    load_data();
                    load_iduser();
                    clear_data();
                }
                else
                {
                    MessageBox.Show("field empty");
                }
            }
            catch
            {
                MessageBox.Show("fail");
                clear_data();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdlaki.Checked == true)
                {
                    gender = "Laki-laki";
                }
                else if (rdperem.Checked == true)
                {
                    gender = "Perempuan";
                }
                if (txtNama.Text != "" && gender != "")
                {
                    string query = $"update teacher set name='{txtNama.Text}', gender='{gender}' where TeacherID='{id}'";
                    db.insert(query);
                    MessageBox.Show("success");
                    load_data();
                    load_iduser();
                    clear_data();
                }
                else
                {
                    MessageBox.Show("field empty");
                }
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
                if (rdlaki.Checked == true)
                {
                    gender = "Laki-laki";
                }
                else if (rdperem.Checked == true)
                {
                    gender = "Perempuan";
                }
                if (txtNama.Text != "" && gender != "")
                {
                    string query = $"delete from teacher where TeacherID='{id}'";
                    db.insert(query);
                    MessageBox.Show("success");
                    load_data();
                    load_iduser();
                    clear_data();
                }
                else
                {
                    MessageBox.Show("field empty");
                }
            }
            catch
            {
                MessageBox.Show("fail");
                clear_data();
            }
        }
    }
}
