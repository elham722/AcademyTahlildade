using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyTahlildade
{
    public partial class FrmTeacher : Form
    {
        private int CurrentTeacherID = 0;
        public FrmTeacher()
        {
            InitializeComponent();
        }
        private void Search()
        {
            DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository();
            DataAccess.TeacherSearchModel sm = new DataAccess.TeacherSearchModel();
            if (txtSearchteacheName.Text.Length > 0)
            {
                sm.TeacherName = txtSearchteacheName.Text;
            }
            if (txtsearchMobile.Text.Length > 0)
            {
                sm.Mobile = txtsearchMobile.Text;
            }

            dataGridView1.DataSource = repo.Search(sm);
        }
        #region Utility
        private void ClearForm()
        {
            txtTeacherName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtResumeDescription.Text = string.Empty;
            txtAboutTeacher.Text = string.Empty;
            
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
        private void BindGrid()
        {
            using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = repo.GetAll();
               
            }

        }


        private void btnAddnew_Click(object sender, EventArgs e)
        {
            
            Teacher tec = new Teacher();    
            tec.TeacherName = txtTeacherName.Text;
            tec.Mobile=txtMobile.Text;
            tec.AboutTeacher=txtAboutTeacher.Text;
            tec.ResumeDescription=txtResumeDescription.Text;
            using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
            {
                repo.AddNew(tec);
                BindGrid();
                ClearForm();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void txtResumeDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var t = new Teacher
            { 
             TeacherName = txtTeacherName.Text,
             Mobile = txtMobile.Text,
             AboutTeacher=txtAboutTeacher.Text,
             ResumeDescription=txtResumeDescription.Text,
             TeacherID = CurrentTeacherID
            };
            using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
            {
                repo.Update(t);
                BindGrid();
                ClearForm(); 
                GotoAddMode();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSearchteacheName_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtsearchMobile_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
               
        
            if (e.ColumnIndex == 5)
            {
                int TeacheriD = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                OpenFileDialog opf = new OpenFileDialog();
                opf.Multiselect = false;
                opf.Filter = "Text Files | *.pdf";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    string FileName = opf.FileName;
                    string relativePath = @"/ResumeTeacher/"
                        + new FrameWork.DateUtility().GetPersianTimeForFileName(DateTime.Now) + System.IO.Path.GetFileName(FileName);
                    var ExecutingAddres = Environment.CurrentDirectory + relativePath;
                    System.IO.File.Copy(FileName, ExecutingAddres);
                    using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
                    {
                        repo.AssignResumeToTeacher(TeacheriD, relativePath);
                    }
                    MessageBox.Show("فایل ثبت گردید");

                }
            }
            if (e.ColumnIndex == 6)
            {
                int TeacheriD = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
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
                    string relativePath = @"/ImgTeacher/"
                        + new FrameWork.DateUtility().GetPersianTimeForFileName(DateTime.Now) + System.IO.Path.GetFileName(FileName);
                    var ExecutingAddres = Environment.CurrentDirectory + relativePath;
                    System.IO.File.Copy(FileName, ExecutingAddres);
                    using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
                    {
                        repo.AssignPictureToTeacher(TeacheriD, relativePath);
                    }
                    MessageBox.Show("تصویر ثبت گردید");

                }
            }
            if (e.ColumnIndex == 7)
            {
                    DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository();
                    int TeacherID =Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var Teacher = repo.Get(TeacherID);
                var ExecutingAddres = Environment.CurrentDirectory + Teacher.Picture;
                pictureBox1.ImageLocation = ExecutingAddres;

            }
            if (e.ColumnIndex == 8)
            {
                int TeacherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
                {
                    var t = repo.Get(TeacherID);
                    txtTeacherName.Text = t.TeacherName;
                    txtMobile.Text = t.Mobile;
                    txtResumeDescription.Text = t.ResumeDescription;
                    txtAboutTeacher.Text = t.AboutTeacher;
                    CurrentTeacherID = t.TeacherID;
                    GotoEditMode();


                }
            }
        

            if (e.ColumnIndex == 9)
            {
                int TeacherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                if (MessageBox.Show("آیا استاد مورد نظر حذف شود؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DataAccess.TeacherRepository repo = new DataAccess.TeacherRepository())
                    {
                        var t = repo.Get(TeacherID);
                        string path = Environment.CurrentDirectory + "/" + t.Picture;
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                        else
                        {
                            MessageBox.Show("فایلی یافت نشد");
                        }
                        string r = Environment.CurrentDirectory + "/" + t.ResumeFile;
                        if (System.IO.File.Exists(r))
                        {
                            System.IO.File.Delete(r);
                        }
                        else
                        {
                            MessageBox.Show("فایلی یافت نشد");
                        }
                        repo.Delete(TeacherID);
                        BindGrid();
                        MessageBox.Show("حذف انجام شد");
                        pictureBox1.ImageLocation = string.Empty;
                    }
                }

            }
        }

    
    }
}
