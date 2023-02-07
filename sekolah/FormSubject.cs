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
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
            load_data();
        }

        DBHelper db = new DBHelper();

        int id;

        public void load_data() {
            DataTable dt = db.getTable("select * from subject");
            tblSubject.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAdmin ha = new HomeAdmin();
            ha.Show();
            
        }

        public void clear_data()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            txtfinal.Text = "";
            txtAssign.Text = "";
            txtMid.Text = "";
            id = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDesc.Text != "" && txtAssign.Text != ""&& txtMid.Text !="" && txtfinal.Text != "")
            {
                try
                {
                    string query = $"insert into subject (name, description, assignment, midexam, finalexam) values('{txtName.Text}','{txtDesc.Text}','{txtAssign.Text}','{txtMid.Text}', '{txtfinal.Text}')";
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
            else
            {
                MessageBox.Show("field empty");
            }
        }

        private void tblSubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                id = int.Parse(tblSubject.Rows[i].Cells[0].Value.ToString());
                txtName.Text = tblSubject.Rows[i].Cells[1].Value.ToString();
                txtDesc.Text = tblSubject.Rows[i].Cells[2].Value.ToString();
                txtAssign.Text = tblSubject.Rows[i].Cells[3].Value.ToString();
                txtMid.Text = tblSubject.Rows[i].Cells[4].Value.ToString();
                txtfinal.Text = tblSubject.Rows[i].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("invalid");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDesc.Text != "" && txtAssign.Text != "" && txtMid.Text != "" && txtfinal.Text != "")
            {
                try
                {
                    string query = $"update subject set name='{txtName.Text}', description='{txtDesc.Text}', assignment='{int.Parse(txtAssign.Text)}', midexam='{int.Parse(txtMid.Text)}', finalexam='{int.Parse(txtfinal.Text)}' where SubjectID='{id}'";
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
            else
            {
                MessageBox.Show("field empty");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDesc.Text != "" && txtAssign.Text != "" && txtMid.Text != "" && txtfinal.Text != "")
            {
                try
                {
                    string query = $"delete from subject where SubjectID='{id}'";
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
            else
            {
                MessageBox.Show("field empty");
            }
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {

        }
    }
}
