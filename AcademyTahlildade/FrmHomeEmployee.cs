using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyTahlildade
{
    public partial class FrmHomeEmployee : Form
    {
        private string currentUserName;
        private Employee currentUser;
        public FrmHomeEmployee(Employee employee)
        {
           currentUser = employee;  
            InitializeComponent();
           lblCurrentUser.Text = currentUser.UserName;

        }
        public FrmHomeEmployee()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmHomeEmployee_Load(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            
        }

        private void مدیریتکارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistingInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmEmployee)
                {
                    ExistingInMyChildren = true;
                    frm.Activate();
                    frm.WindowState = FormWindowState.Maximized;
                }
            }
            if(!ExistingInMyChildren)
            {
                FrmEmployee frmemp = new FrmEmployee();
                frmemp.MdiParent = this;
                frmemp.WindowState = FormWindowState.Maximized;
                frmemp.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = new FrameWork.DateUtility().GetPersianDate(DateTime.Now);

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void خروجازبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void بازگشتبهصفحهورودToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            Close();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void اطلاعاتمالیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void مدیریتاساتیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistingInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmTeacher)
                {
                    ExistingInMyChildren = true;
                    frm.Activate();
                    frm.WindowState = FormWindowState.Maximized;
                }
            }
            if (!ExistingInMyChildren)
            {
                FrmTeacher frmTeach = new FrmTeacher();
                frmTeach.MdiParent = this;
                frmTeach.WindowState = FormWindowState.Maximized;
                frmTeach.Show();
            }
        }

        private void مدیریتدانشاموزانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistingInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmStudent)
                {
                    ExistingInMyChildren = true;
                    frm.Activate();
                    frm.WindowState = FormWindowState.Maximized;
                }
            }
            if (!ExistingInMyChildren)
            {
                FrmStudent frmstud = new FrmStudent(currentUser.EmployeeID);
                frmstud.MdiParent = this;
                frmstud.WindowState = FormWindowState.Maximized;
                frmstud.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bool ExistingInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmCourse)
                {
                    ExistingInMyChildren = true;
                    frm.Activate();
                    frm.WindowState = FormWindowState.Maximized;
                }
            }
            if (!ExistingInMyChildren)
            {
                FrmCourse frmstud = new FrmCourse();
                frmstud.MdiParent = this;
                frmstud.WindowState = FormWindowState.Maximized;
                frmstud.Show();
            }
        }

       

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
                
            
        }
    }
}
