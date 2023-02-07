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
    public partial class FormProfileTeacher : Form
    {
        public FormProfileTeacher()
        {
            InitializeComponent();
            iduser = UserClass.id;
            load_guru();
        }

        DBHelper db = new DBHelper();

        int iduser;
        int id;
        string nama;
        string gender;
        string foto;

        public void load_guru()
        {
            DataTable dt = db.getTable("select * from teacher where UserID = '"+ iduser + "'");
            DataRow dr = dt.Rows[0];
            id = int.Parse(dr["TeacherID"].ToString());
            nama = dr["Name"].ToString();
            gender = dr["Gender"].ToString();
            foto = dr["Foto"].ToString();
            txtNama.Text = nama;
            pictureBox1.ImageLocation = foto;
            if(gender == "Laki-laki")
            {
                rdlaki.Checked = true;
            }else if(gender == "Perempuan")
            {
                rdperem.Checked = true;
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeTeacher ht = new HomeTeacher();
            ht.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdperem.Checked == true)
                {
                    gender = "Perempuan";
                }
                else if (rdlaki.Checked == true)
                {
                    gender = "Laki-laki";
                }
                if (txtNama.Text != "" && gender != "")
                {
                    string query = $"update teacher set name='{txtNama.Text}', gender='{gender}', foto='{foto}' where TeacherID = '{id}'";
                    db.insert(query);
                    MessageBox.Show("update profile success");
                }
                else
                {
                    MessageBox.Show("field empty");
                }
            }
            catch {
                MessageBox.Show("update profile fail");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                pictureBox1.ImageLocation = foto;


            }
        }
    }
}
