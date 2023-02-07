using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolah
{
    public partial class FormStudent : Form
    {
        public FormStudent()
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
        }

        public void load_data()
        {
            DataTable dt = db.getTable("select * from student");
            tblStudent.DataSource = dt;
        }

        public void clear_data()
        {
            txtNama.Text = "";
            rdlaki.Checked = false;
            rdperem.Checked = false;
            id = 0;
            tglBirth.Value = DateTime.Today;
            txtAlamat.Text = "";
            txtPhone.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void tblStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                id = int.Parse(tblStudent.Rows[i].Cells[0].Value.ToString());
                txtNama.Text = tblStudent.Rows[i].Cells[1].Value.ToString();
                txtAlamat.Text = tblStudent.Rows[i].Cells[2].Value.ToString();
                gender = tblStudent.Rows[i].Cells[3].Value.ToString();
                tglBirth.Value = DateTime.Parse(tblStudent.Rows[i].Cells[4].Value.ToString());
                txtPhone.Text = tblStudent.Rows[i].Cells[5].Value.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button2_Click(object sender, EventArgs e)
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
                if (txtNama.Text != "" && gender != "" && txtAlamat.Text != "" && txtPhone.Text != "")
                {
                    string queryuser = $"insert into [user] (username, password, role) values ('{txtNama.Text}', '{pw}','{"student"}')";
                    db.insert(queryuser);
                    load_iduser();
                    string query = $"insert into student (name,gender,foto,UserID,address,DateBirth,NoHp) values('{txtNama.Text}','{gender}','{foto}','{int.Parse(iduser.ToString())}','{txtAlamat.Text}',@datebirth,'{int.Parse(txtPhone.Text)}')";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Parameters.AddWithValue("@datebirth", tglBirth.Value);
                    db.insertCmd(cmd);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                clear_data();
            }
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
                if (txtNama.Text != "" && gender != "" && txtAlamat.Text != "" && txtPhone.Text != "")
                {
                    string query = $"update student set name='{txtNama.Text}', gender='{gender}', address='{txtAlamat.Text}', NoHp='{int.Parse(txtPhone.Text)}', DateBirth=@datebirth where StudentID='{id}'";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Parameters.AddWithValue("@datebirth", tglBirth.Value);
                    db.insertCmd(cmd);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    string query = $"delete from student where StudentID='{id}'";
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
