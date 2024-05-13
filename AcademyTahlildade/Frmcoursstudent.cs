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
    public partial class Frmcoursstudent : Form
    {
        public Frmcoursstudent()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            using (DataAccess.CourseRepository repo = new DataAccess.CourseRepository())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.GetListCourseNew();

            }
        }
        private void Frmcoursstudent_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
