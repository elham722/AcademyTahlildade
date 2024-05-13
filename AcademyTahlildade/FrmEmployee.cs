using DomainModel.Model;
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
    public partial class FrmEmployee : Form
    {
        int id = 0;

        private void SearchEmployee()
        {
            DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
            DataAccess.EmployeeSearchModel emp = new DataAccess.EmployeeSearchModel();
            if (txtsearchLastname.Text.Length > 0)
            {
                emp.LastName = txtsearchLastname.Text;
            }
            if (txtSearchMobile.Text.Length > 0)
            {
                emp.Mobile = txtSearchMobile.Text;
            }
            
            
            dataGridView1.DataSource = repo.SearchEmployee(emp);
        }

        public FrmEmployee()
        {
            InitializeComponent();
        }
        #region DataBinder
        private void BindGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();   
            dataGridView1.DataSource = repo.GetAll();
           
        }
        #endregion
        #region Utility
        private void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFirstname.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobile.Text = string.Empty;
        }
        private void GotoAddMode()
        {
            btnAddNew.Visible = true;
            btnCancle.Visible = false;
            btnUpdate.Visible = false;
        }
        private void GotoEditMode()
        {
            btnAddNew.Visible = false;
            btnCancle.Visible = true;
            btnUpdate.Visible = true;
        }
        #endregion
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
            Employee emp = new Employee();
            emp.UserName=txtUsername.Text;
            emp.Password=txtPassword.Text;
            emp.FirstName= txtFirstname.Text;
            emp.LastName= txtLastName.Text;
            emp.Mobile= txtMobile.Text;
            repo.AddNew( emp );
            BindGrid();
            ClearForm();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            BindGrid();
            GotoAddMode();
            using (DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository())
            {

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا کاربر حذف شود؟","هشدار",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    DataAccess.EmployeeRepository repo  =new DataAccess.EmployeeRepository();
                    if (repo.Delete(id))
                    {
                        BindGrid();
                    }
                    else
                    {
                        MessageBox.Show("خطایی در حذف روی داده است,دوباره تلاش کنید");
                    }
                }
            }
            if (e.ColumnIndex == 5) 
            { 
                this.id= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var emp = new DataAccess.EmployeeRepository().Get(id);
                txtUsername.Text = emp.UserName;
                txtPassword.Text = emp.Password;
                txtFirstname.Text = emp.FirstName;
                txtLastName.Text = emp.LastName;
                txtMobile.Text = emp.Mobile;
                GotoEditMode();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ClearForm();
            GotoAddMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.UserName = txtUsername.Text;
            emp.Password = txtPassword.Text;
            emp.FirstName = txtFirstname.Text;
            emp.LastName = txtLastName.Text;
            emp.Mobile= txtMobile.Text;
            emp.EmployeeID = id;
            DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
            repo.Update(emp);
            ClearForm();
            GotoAddMode();
            BindGrid();
        }

        private void txtsearchLastname_TextChanged(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void txtSearchMobile_TextChanged(object sender, EventArgs e)
        {
            SearchEmployee();
        }
    }
}
