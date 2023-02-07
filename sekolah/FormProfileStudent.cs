using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekolah
{
    public partial class FormProfileStudent : Form
    {
        public FormProfileStudent()
        {
            InitializeComponent();
            iduser = UserClass.id;
            load_siswa();
        }

        DBHelper db = new DBHelper();

        int iduser;
        int id;
        string nama;
        string gender;
        string foto;
        string address;
        int phone;

        public void load_siswa()
        {
            DataTable dt = db.getTable("select * from student where UserID = '" + iduser + "'");
            DataRow dr = dt.Rows[0];
            id = int.Parse(dr["StudentID"].ToString());
            nama = dr["Name"].ToString();
            gender = dr["Gender"].ToString();
            foto = dr["Foto"].ToString();
            address = dr["Address"].ToString();
            phone = int.Parse(dr["NoHp"].ToString());
            tglBirth.Value = DateTime.Parse(dr["DateBirth"].ToString());
            txtNama.Text = nama;
            txtPhone.Text = phone.ToString();
            txtAlamat.Text = address;
            pictureBox1.ImageLocation = foto;
            if (gender == "Laki-laki")
            {
                rdlaki.Checked = true;
            }
            else if (gender == "Perempuan")
            {
                rdperem.Checked = true;
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                this.Hide();
                HomeStudent hs = new HomeStudent();
                hs.Show();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

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
                if (txtNama.Text != "" && gender != "" && txtAlamat.Text != "" && txtPhone.Text != "") 
                {
                    string query = $"update student set name='{txtNama.Text}', gender='{gender}', foto='{foto}', address='{txtAlamat.Text}', DateBirth=@datebirth, NoHp='{int.Parse(txtPhone.Text)}' where StudentID = '{id}'";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Parameters.AddWithValue("@datebirth", tglBirth.Value);
                    db.insertCmd(cmd);
                    MessageBox.Show("update profile success");
                }
                else
                {
                    MessageBox.Show("field empty");
                }
            }
            catch
            {
                MessageBox.Show("update profile fail");
            }
        }
    }
}
