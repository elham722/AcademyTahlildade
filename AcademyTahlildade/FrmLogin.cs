using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyTahlildade
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public void ClearForm()
        {
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginEmp_Click(object sender, EventArgs e)
        {
            DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
            bool exist = repo.LoginEmp(txtUserName.Text, txtPassword.Text);
            if (exist)
            {

                var currentUser = repo.GetEmployeeByUserName(txtUserName.Text); 
                FrmHomeEmployee frm = new FrmHomeEmployee(currentUser);
                frm.ShowDialog();
                  
                
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور صحیح نمی باشد,دوباره تلاش کنید");
                
            }

            ClearForm();
        }

        private void btnLoginStd_Click(object sender, EventArgs e)
        {
            DataAccess.StudentRepository repo = new DataAccess.StudentRepository();
            bool exist = repo.LoginStd(txtUserName.Text,txtPassword.Text);
            if (exist)
            {
                FrmHomeStudent frm = new FrmHomeStudent();
                frm.Show();
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور صحیح نمی باشد,دوباره تلاش کنید");
            }
            ClearForm();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
