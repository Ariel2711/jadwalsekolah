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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        
        DBHelper db = new DBHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Field Empty!");
            }
            else
            {
                DataTable dt = db.getTable($"select * from [user] where username = '{txtUsername.Text}'");
                if(dt.Rows.Count < 1)
                {
                    MessageBox.Show("User not found");
                }
                else
                {
                    DataRow dr = dt.Rows[0];
                    if(txtPassword.Text != dr["password"].ToString())
                    {
                        MessageBox.Show("Password don't match");
                    }
                    else
                    {
                        if (dr["role"].ToString().ToLower() == "admin")
                        {
                            UserClass.id = int.Parse(dr["UserID"].ToString());
                            UserClass.nama = dr["username"].ToString();
                            UserClass.role = dr["role"].ToString();
                            this.Hide();
                            HomeAdmin ha = new HomeAdmin();
                            ha.Show();
                            

                        }else if(dr["role"].ToString().ToLower() == "teacher")
                        {
                            UserClass.id = int.Parse(dr["UserID"].ToString());
                            UserClass.nama = dr["username"].ToString();
                            UserClass.role = dr["role"].ToString();
                            this.Hide();
                            HomeTeacher ht = new HomeTeacher();
                            ht.Show();
                            
                        }
                        else if(dr["role"].ToString().ToLower() == "student")
                        {
                            UserClass.id = int.Parse(dr["UserID"].ToString());
                            UserClass.nama = dr["username"].ToString();
                            UserClass.role = dr["role"].ToString();
                            this.Hide();
                            HomeStudent hs = new HomeStudent();
                            hs.Show();
                            
                        }
                        else { }
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            if (txtPassword.UseSystemPasswordChar == true)
            {
                label4.Text = "Show";
            }
            else
            {
                label4.Text = "Hide";
            }
        }
    }
}
