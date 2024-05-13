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
    public partial class FrmStudent : Form
    {
        private readonly DataAccess.StudentRepository repo = new DataAccess.StudentRepository();
        private string CurrentUserName;
        private int EmployeeID;
        private Employee currentUser;
        public FrmStudent(int employeeId)
        {

            this.EmployeeID = employeeId;
            var empRepo = new DataAccess.EmployeeRepository();
            this.currentUser = empRepo.Get(EmployeeID);
            InitializeComponent();
        }
        #region DataBinder
        private void BindGrid()
        {
            using (DataAccess.StudentRepository repo = new DataAccess.StudentRepository())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.GetAllCombosList();

            }


        }
        private void BindProvince()
        {
            using (DataAccess.ProvinceRepository repo = new DataAccess.ProvinceRepository())
            {
                List<Province> cats = repo.GetAll();
                Province prov = new Province();
                prov.ProvinveID = -1;
                prov.ProvinceName = "استان مورد نظر را انتخاب کنید";
                cats.Insert(0, prov);
                combProvince.DisplayMember = "ProvinceName";
                combProvince.ValueMember = "ProvinveID";
                combProvince.DataSource = cats;

            }
        }
        private void BindEducationDegree()
        {
            using (DataAccess.EducationDegreeRepository repo = new DataAccess.EducationDegreeRepository())
            {
                List<EducationDegree> cats = repo.GetAll();
                EducationDegree education = new EducationDegree();
                education.EducationDegreeID = -1;
                education.EducationDegreeName = "مقطع تحصیلی را انتخاب کنید";
                cats.Insert(0, education);
                combEducationDegree.DisplayMember = "EducationDegreeName";
                combEducationDegree.ValueMember = "EducationDegreeID";
                combEducationDegree.DataSource = cats;

            }
        }

        private void BindCity()
        {
            using (DataAccess.CityRepository repo = new DataAccess.CityRepository())
            {
                List<City> cats = repo.GetAll();
                City cit = new City();
                cit.CityID = -1;
                cit.CityName = "شهر مورد نظر را انتخاب کنید";
                cats.Insert(0, cit);
                combCity.DisplayMember = "CityName";
                combCity.ValueMember = "CityID";
                combCity.DataSource = cats;

            }
        }
        #endregion
        #region Utility
        private void ClearForm()
        {
            txtFirstname.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtNationalCode.Text = string.Empty;
            txtMobile.Text = string.Empty;
            combProvince.SelectedIndex = 0;
            combCity.SelectedIndex = 0;
            txtAddress.Text = string.Empty;
            combEducationDegree.SelectedIndex = 0;
            txtFildofstudy.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        private void GotoAddMode()
        {
            btnAddnew.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }
        private void GotoEditMode()
        {
            btnAddnew.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
        }

        #endregion
        private int CurrentStudentID = 0;

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            GotoAddMode();
            BindProvince();
            BindCity();
            BindEducationDegree();
            BindGrid();

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            if (combProvince.SelectedIndex <= 0)
            {
                MessageBox.Show("استان را انتخاب نمایید");
                return;
            }
            if (combCity.SelectedIndex <= 0)
            {
                MessageBox.Show("شهر را انتخاب نمایید");
                return;
            }
            if (combEducationDegree.SelectedIndex <= 0)
            {
                MessageBox.Show("مقطع تحصیلی را انتخاب نمایید");
                return;
            }
            var S = new Student
            {
                ProvinceID = Convert.ToInt32(combProvince.SelectedValue),
                CityID = Convert.ToInt32(combCity.SelectedValue),
                EducationDegreeID = Convert.ToInt32(combEducationDegree.SelectedValue),
                FirstName = txtFirstname.Text,
                LastName = txtLastName.Text,
                NationalCode = txtNationalCode.Text,
                Mobile = txtMobile.Text,
                Address = txtAddress.Text,
                FildOfStudy = txtFildofstudy.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Picture = String.Empty,

            };
            using (DataAccess.StudentRepository repo = new DataAccess.StudentRepository())
            {
                repo.AddNew(S);
                BindGrid();
                ClearForm();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                int Studentid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                OpenFileDialog opf = new OpenFileDialog();
                opf.Multiselect = false;
                opf.Filter = @"All Images Files(*.png; *.jpeg; *.gif; *.jpg; *.bmp; *.tiff; *.tif)| *.png; *.jpeg; *.gif; *.jpg; *.bmp; *.tiff; *.tif" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp" +
            "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
            "|GIF Graphics Interchange Format (*.gif)|*.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    string FileName = opf.FileName;
                    string RelativePath = @"/ImgStudent/"
                        + new FrameWork.DateUtility().GetPersianTimeForFileName(DateTime.Now) + System.IO.Path.GetFileName(FileName);
                    var ExecutingAddres = Environment.CurrentDirectory + RelativePath;
                    System.IO.File.Copy(FileName, ExecutingAddres);
                    using (DataAccess.StudentRepository repo = new DataAccess.StudentRepository())
                    {
                        repo.AssignPictureToStudent(Studentid, RelativePath);
                    }
                    MessageBox.Show("تصویر ثبت گردید");

                }
            }
            if (e.ColumnIndex == 12)
            {
                DataAccess.StudentRepository repo = new DataAccess.StudentRepository();
                int studentid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var Student = repo.Get(studentid);
                var ExecutingAddres = Environment.CurrentDirectory + Student.Picture;
                pictureBox1.ImageLocation = ExecutingAddres;

            }

            if (e.ColumnIndex == 13)
            {

                var student = dataGridView1.Rows[e.RowIndex].DataBoundItem as combosListItem;
                
                FrmRegisturation frmemp = new FrmRegisturation(this.currentUser, student);

                frmemp.WindowState = FormWindowState.Normal;
                frmemp.Show();

            }



            if (e.ColumnIndex == 14)
            {
                int studentid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                using (DataAccess.StudentRepository repo = new DataAccess.StudentRepository())
                {
                    var s = repo.Get(studentid);
                    txtFirstname.Text = s.FirstName;
                    txtLastName.Text = s.LastName;
                    txtNationalCode.Text = s.NationalCode;
                    txtMobile.Text = s.Mobile;
                    combProvince.SelectedValue = s.ProvinceID;
                    combCity.SelectedValue = s.CityID;
                    txtAddress.Text = s.Address;
                    combEducationDegree.SelectedValue = s.EducationDegreeID;
                    txtFildofstudy.Text = s.FildOfStudy;
                    txtUserName.Text = s.UserName;
                    txtPassword.Text = s.Password;
                    pictureBox1.Text = s.Picture;
                    CurrentStudentID = s.StudentID;
                    GotoEditMode();


                }
            }
            if (e.ColumnIndex == 15)
            {
                int studentid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("آیا دانش آموز حذف شود؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DataAccess.StudentRepository repo = new DataAccess.StudentRepository())
                    {
                        var f = repo.Get(studentid);
                        string path = Environment.CurrentDirectory + "/" + f.Picture;

                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                        else
                        {
                            MessageBox.Show("فایلی یافت نشد");
                        }
                        repo.Delete(studentid);
                        BindGrid();
                        MessageBox.Show("حذف انجام شد");
                        pictureBox1.ImageLocation = string.Empty;
                    }
                }

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (combProvince.SelectedIndex <= 0)
            {
                MessageBox.Show("استان را انتخاب نمایید");
                return;
            }
            if (combCity.SelectedIndex <= 0)
            {
                MessageBox.Show("شهر را انتخاب نمایید");
                return;
            }
            if (combEducationDegree.SelectedIndex <= 0)
            {
                MessageBox.Show("مقطع تحصیلی را انتخاب نمایید");
                return;
            }
            var s = new Student
            {
                ProvinceID = Convert.ToInt32(combProvince.SelectedValue),
                CityID = Convert.ToInt32(combCity.SelectedValue),
                EducationDegreeID = Convert.ToInt32(combEducationDegree.SelectedValue),
                FirstName = txtFirstname.Text,
                LastName = txtLastName.Text,
                NationalCode = txtNationalCode.Text,
                Address = txtAddress.Text,
                Mobile = txtMobile.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                FildOfStudy = txtFildofstudy.Text,
                StudentID = CurrentStudentID
            };
            using (DataAccess.StudentRepository repo = new DataAccess.StudentRepository())
            {
                repo.Update(s);
                BindGrid();
                ClearForm();
                GotoAddMode();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void combProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Search()
        {
            DataAccess.StudentRepository repo = new DataAccess.StudentRepository();
            DataAccess.StudentSearchModel sm = new DataAccess.StudentSearchModel();
            if (txtsearchname.Text.Length > 0)
            {
                sm.FirstName = txtsearchname.Text;
            }
            if (txtSearchLastname.Text.Length > 0)
            {
                sm.LastName = txtSearchLastname.Text;
            }
            if (txt0searchNationalCode.Text.Length > 0)
            {
                sm.NationalCode = txt0searchNationalCode.Text;
            }

            dataGridView1.DataSource = repo.Search(sm);
        }

        private void txtsearchname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchLastname_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txt0searchNationalCode_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
