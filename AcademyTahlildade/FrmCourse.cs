using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyTahlildade
{
    public partial class FrmCourse : Form
    {
        private int CurrentCuorseID = 0;
        public FrmCourse()
        {
            InitializeComponent();
        }

        #region DataBinder
        private void BindGrid()
        {
            using (DataAccess.CourseRepository repo = new DataAccess.CourseRepository())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.GetListCourseNew();

            }
        }
        private void BindTeacher()
        {
            using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
            {
                List<Teacher> teac = repo.GetAll();
                Teacher teachi = new Teacher();
                teachi.TeacherID = -1;
                teachi.TeacherName = "...نام استاد را انتخاب کنید ...";
                teac.Insert(0, teachi);
                combTeacher.DisplayMember = "TeacherName";
                combTeacher.ValueMember = "TeacherID";
                combTeacher.DataSource = teac;

            }
        }
        private void BindTerm()
        {
            using (DataAccess.TermRepository repo = new DataAccess.TermRepository())
            {
                List<Term> ter = repo.GetAll();
                Term term = new Term();
                term.TermID = -1;
                term.TermName = "...ترم را انتخاب کنید ...";
                ter.Insert(0, term);
                combTerm.DisplayMember = "TermName";
                combTerm.ValueMember = "TermID";
                combTerm.DataSource = ter;

            }
        }
        private void BindCoursstatus()
        {
            using (DataAccess.CourseStatusRepository repo = new DataAccess.CourseStatusRepository())
            {
                List<CourseStatu> ter = repo.GetAll();
                CourseStatu term = new CourseStatu();
                term.CourseStatusID = -1;
                term.CourseStatusName = "وضعیت دوره را انتخاب کنید";
                ter.Insert(0, term);
                combCourseStatus.DisplayMember = "CourseStatusName";
                combCourseStatus.ValueMember = "CourseStatusID";
                combCourseStatus.DataSource = ter;

            }
        }
        #endregion

        #region Utility
        private void ClearForm()
        {
            txtCourseName.Text = string.Empty;
            txtTiution.Text = string.Empty;
            txtpreq.Text = string.Empty;
            combTeacher.SelectedIndex = 0;
            txtDay.Text = string.Empty;
            txtHours.Text = string.Empty;
            txtRuningtime.Text = string.Empty;
            txtCoursecontent.Text = string.Empty;
            timepikerstat.Text = string.Empty;
            timepikerendDate.Text = string.Empty;
            combTerm.SelectedIndex = 0;
            combCourseStatus.SelectedIndex = 0;

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (combTeacher.SelectedIndex <= 0)
            {
                MessageBox.Show("نام استاد را انتخاب نمایید");
                return;
            }
            if (combTerm.SelectedIndex <= 0)
            {
                MessageBox.Show("ترم را انتخاب نمایید");
                return;
            }
            if (combCourseStatus.SelectedIndex <= 0)
            {
                MessageBox.Show("وضعیت دوره را انتخاب نمایید");
                return;
            }

            Course cur = new Course();
            cur.CourseName = txtCourseName.Text;
            cur.Tuition = txtTiution.Text;
            cur.TeacherID = Convert.ToInt32(combTeacher.SelectedValue);
            cur.Preq = txtpreq.Text;
            cur.Day = txtDay.Text;
            cur.Hours = Convert.ToInt32(txtHours.Text);
            cur.RuningTime = txtRuningtime.Text;
            cur.StartDate = timepikerstat.SelectedDateTime;
            cur.EndDate = timepikerendDate.SelectedDateTime;
            cur.CourseContent = txtCoursecontent.Text;
            cur.TermID = Convert.ToInt32(combTerm.SelectedValue);
            cur.CourseStatusID = Convert.ToInt32(combCourseStatus.SelectedValue);
            using (DataAccess.CourseRepository repo = new DataAccess.CourseRepository())
            {
                repo.AddNew(cur);
                BindGrid();
                ClearForm();
            }

        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            BindTeacher();
            BindTerm();
            BindCoursstatus();
            BindGrid();
            GotoAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (combTeacher.SelectedIndex <= 0)
            {
                MessageBox.Show("نام استاد را انتخاب نمایید");
                return;
            }
            if (combTerm.SelectedIndex <= 0)
            {
                MessageBox.Show("ترم را انتخاب نمایید");
                return;
            }
            if (combCourseStatus.SelectedIndex <= 0)
            {
                MessageBox.Show("وضعیت دوره را انتخاب نمایید");
                return;
            }
            var s = new Course
            {
                CourseID =CurrentCuorseID,
                TeacherID = Convert.ToInt32(combTeacher.SelectedValue),
                TermID = Convert.ToInt32(combTerm.SelectedValue),
                CourseStatusID = Convert.ToInt32(combCourseStatus.SelectedValue),
                CourseName = txtCourseName.Text,
                Tuition = txtTiution.Text,
                RuningTime = txtRuningtime.Text,
                Day = txtDay.Text,
                Hours = Convert.ToInt32(txtHours.Text),
                StartDate = timepikerstat.SelectedDateTime.Date,
                EndDate = timepikerstat.SelectedDateTime.Date,
                Preq = txtpreq.Text,
                CourseContent = txtCoursecontent.Text,


            };
            using (DataAccess.CourseRepository repo = new DataAccess.CourseRepository())
            {
                repo.Update(s);
                BindGrid();
                ClearForm();
                GotoAddMode();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            DataAccess.CourseRepository repo = new DataAccess.CourseRepository();
            DataAccess.CourseSearchModel sm = new DataAccess.CourseSearchModel();
            if (txtsearchcourse.Text.Length > 0)
            {
                sm.CourseName = txtsearchcourse.Text;
            }

            dataGridView1.DataSource = repo.Search(sm);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                int courseID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                using (DataAccess.CourseRepository repo = new DataAccess.CourseRepository())
                {
                    var t = repo.Get(courseID);
                    txtCourseName.Text = t.CourseName;
                    txtTiution.Text = t.Tuition;
                    combTeacher.SelectedValue = t.TeacherID;
                    txtDay.Text = t.Day;
                    txtHours.Text = t.Hours.ToString();
                    txtCoursecontent.Text = t.CourseContent;
                    txtpreq.Text = t.Preq;
                    txtRuningtime.Text = t.RuningTime;
                    combCourseStatus.SelectedValue = t.CourseStatusID;
                    combTerm.SelectedValue = t.TermID;
                    timepikerstat.SelectedDateTime = t.StartDate;
                    timepikerendDate.SelectedDateTime = t.EndDate ?? DateTime.Now;
                    CurrentCuorseID = t.CourseID;
                    GotoEditMode();


                }
            }
            if (e.ColumnIndex == 15)
            {
                int courseid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("آیا دوره مورد نظر حذف شود؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DataAccess.CourseRepository repo = new DataAccess.CourseRepository())
                    {
                        var t = repo.Get(courseid);
                        repo.Delete(courseid);
                        BindGrid();
                        MessageBox.Show("حذف انجام شد");

                    }
                }

            }

        }

        private void timepikerendDate_SelectedDateTimeChanging(object sender, FarsiLibrary.Win.Events.SelectedDateTimeChangingEventArgs e)
        {
            MessageBox.Show("ok");
        }
    }
}
