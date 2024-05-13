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
    public partial class FrmHomeStudent : Form
    {
       
      
        public FrmHomeStudent()
        {
            InitializeComponent();
        }

        private void FrmHomeStudent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void دورههاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistingInMyChildren = false;
            
                Frmcoursstudent frmemp = new Frmcoursstudent();
                
                frmemp.WindowState = FormWindowState.Maximized;
                frmemp.Show();
            
        }

        private void خروجازبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void بازگشتبهصفحهاصلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = new FrameWork.DateUtility().GetPersianDate(DateTime.Now);
        }
    }
}
