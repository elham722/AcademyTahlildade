using DomainModel.Model;
using DomainModel.VeiwModel;
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
    public partial class FrmRegisturation : Form
    {
        private string CurrentUserName;
        private int EmployeeID;
        private int RegistrationID;
        private combosListItem student;
        private Employee currentUser;


        private void BindGrid()
        {
            using (DataAccess.RegistrationRepository repo = new DataAccess.RegistrationRepository())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.GetListRegistrationDetails();

            }
        }
        #region Utility
        private void ClearForm()
        {
            txtdescriptin.Text = string.Empty;
            combcorse.SelectedIndex = 0;
            lbltuion.Text = string.Empty;
            lblstudent.Text = string.Empty;
            txttotal.Clear();
            faDateRegidter.Text = string.Empty;

        }
        private void GotoAddMode()
        {
            btnAddNew.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }
        private void GotoEditMode()
        {
            btnAddNew.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
        }

        #endregion
        public FrmRegisturation(Employee employee, combosListItem studdent)
        {
            this.CurrentUserName = CurrentUserName;
            InitializeComponent();
            this.student = studdent;
            this.currentUser = employee;
        }
        #region DataBinder
        private void BindCourseReister()
        {
            DataAccess.CourseRepository repo = new DataAccess.CourseRepository();

            List<Course> cats = repo.GetAll();
            Course cit = new Course();
            cit.CourseID = -1;
            cit.CourseName = "دوره مورد نظر را انتخاب کنید";
            cats.Insert(0, cit);
            combcorse.ValueMember = "CourseID";
            combcorse.DisplayMember = "CourseName";
            combcorse.DataSource = cats;
        }
        #endregion
        private void FrmRegisturation_Load(object sender, EventArgs e)
        {
            BindCourseReister();
            combcorse.SelectedIndexChanged += combcorse_SelectedIndexChanged;
            lblemployee.Text = currentUser.UserName;
            lblstudent.Text = student.FirstName + " " + student.LastName;
            BindGrid();
            GotoAddMode();
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration
            {

                Description = txtdescriptin.Text,
                CourseID = Convert.ToInt32(combcorse.SelectedValue),
                RegistrationDate = faDateRegidter.SelectedDateTime,
                EmployeeID = currentUser.EmployeeID,
                Tuitionn = Convert.ToInt32(lbltuion.Text),
                TotalPayment = Convert.ToInt32(txttotal.Text),
                StudentID = student.StudentID,

            };
            using (DataAccess.RegistrationRepository repo = new DataAccess.RegistrationRepository())
            {
                RegistrationID = repo.RegisterationSabteName(reg);
                BindGrid();
                ClearForm();
                GotoAddMode() ;
            }
        }

        private void combcorse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess.CourseRepository repo = new DataAccess.CourseRepository();
            int CourseID = Convert.ToInt32(combcorse.SelectedValue);
            if (CourseID > 0)
            {
                var course = repo.Get(CourseID);
                lbltuion.Text = course.Tuition.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (combcorse.SelectedIndex <= 0)
            {
                MessageBox.Show("دوره را انتخاب نمایید");
                return;
            }

            var register = new Registration
            {
                RegistrationID = RegistrationID,
                EmployeeID = currentUser.EmployeeID,
                CourseID = Convert.ToInt32(combcorse.SelectedValue),
                RegistrationDate = faDateRegidter.SelectedDateTime.Date,
                StudentID = student.StudentID,
                Tuitionn = Convert.ToInt32(lbltuion.Text),
                TotalPayment = Convert.ToInt32(txttotal.Text),
                Description = txtdescriptin.Text

            };
            using (DataAccess.RegistrationRepository repo = new DataAccess.RegistrationRepository())
            {
                repo.Update(register);
                BindGrid();
                ClearForm();
                GotoAddMode();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 8)
            {

                int registerid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                FrmPayment frmpay = new FrmPayment(currentUser,registerid);

                frmpay.ShowDialog();

            }
            if (e.ColumnIndex == 9)
            {
                int registerid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                using (DataAccess.RegistrationRepository repo = new DataAccess.RegistrationRepository())
                {
                    var s = repo.Get(registerid);
                    txtdescriptin.Text = s.Description;
                    txttotal.Text = s.TotalPayment.ToString();
                    lblstudent.Text = student.FirstName + " " + student.LastName;
                    combcorse.SelectedValue = s.CourseID;
                    faDateRegidter.SelectedDateTime = s.RegistrationDate;
                    lbltuion.Text = s.Tuitionn.ToString();
                    RegistrationID = s.RegistrationID;
                    GotoEditMode();

                }
            }
            if (e.ColumnIndex == 10)
            {
                int registerid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("آیا دانش آموز حذف شود؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DataAccess.RegistrationRepository repo = new DataAccess.RegistrationRepository())
                    {
                        var f = repo.Get(registerid);
                        repo.Delete(registerid);
                        BindGrid();
                        MessageBox.Show("حذف انجام شد");

                    }
                }
            }
        }
    }
}
