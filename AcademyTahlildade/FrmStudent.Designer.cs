namespace AcademyTahlildade
{
    partial class FrmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFildofstudy = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.combProvince = new System.Windows.Forms.ComboBox();
            this.combCity = new System.Windows.Forms.ComboBox();
            this.combEducationDegree = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsearchname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchLastname = new System.Windows.Forms.TextBox();
            this.txt0searchNationalCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEducationDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFildOfStudy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnpicture = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnShowPicture = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnRegistration = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUptade = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1210, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد ملی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "شماره تماس";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1191, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "استان";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(869, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "شهر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "آدرس";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1151, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "مقطع تحصیلی";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(852, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "رشته تحصیلی";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1167, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "نام کاربری";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(878, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "کلمه عبور";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(1069, 55);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(103, 22);
            this.txtFirstname.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(837, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(103, 22);
            this.txtLastName.TabIndex = 12;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(633, 55);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(103, 22);
            this.txtNationalCode.TabIndex = 13;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(300, 55);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(215, 22);
            this.txtMobile.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(300, 127);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 71);
            this.txtAddress.TabIndex = 15;
            // 
            // txtFildofstudy
            // 
            this.txtFildofstudy.Location = new System.Drawing.Point(649, 223);
            this.txtFildofstudy.Name = "txtFildofstudy";
            this.txtFildofstudy.Size = new System.Drawing.Size(182, 22);
            this.txtFildofstudy.TabIndex = 16;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(958, 298);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(187, 22);
            this.txtUserName.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(649, 303);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // combProvince
            // 
            this.combProvince.FormattingEnabled = true;
            this.combProvince.Location = new System.Drawing.Point(958, 132);
            this.combProvince.Name = "combProvince";
            this.combProvince.Size = new System.Drawing.Size(187, 22);
            this.combProvince.TabIndex = 19;
            this.combProvince.SelectedIndexChanged += new System.EventHandler(this.combProvince_SelectedIndexChanged);
            // 
            // combCity
            // 
            this.combCity.FormattingEnabled = true;
            this.combCity.Location = new System.Drawing.Point(649, 130);
            this.combCity.Name = "combCity";
            this.combCity.Size = new System.Drawing.Size(182, 22);
            this.combCity.TabIndex = 20;
            // 
            // combEducationDegree
            // 
            this.combEducationDegree.FormattingEnabled = true;
            this.combEducationDegree.Location = new System.Drawing.Point(958, 223);
            this.combEducationDegree.Name = "combEducationDegree";
            this.combEducationDegree.Size = new System.Drawing.Size(187, 22);
            this.combEducationDegree.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtsearchname);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSearchLastname);
            this.groupBox1.Controls.Add(this.txt0searchNationalCode);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1301, 75);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1144, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 14);
            this.label14.TabIndex = 23;
            this.label14.Text = "نام";
            // 
            // txtsearchname
            // 
            this.txtsearchname.Location = new System.Drawing.Point(1005, 38);
            this.txtsearchname.Name = "txtsearchname";
            this.txtsearchname.Size = new System.Drawing.Size(112, 22);
            this.txtsearchname.TabIndex = 26;
            this.txtsearchname.TextChanged += new System.EventHandler(this.txtsearchname_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(890, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 14);
            this.label13.TabIndex = 24;
            this.label13.Text = "نام خانوادگی";
            // 
            // txtSearchLastname
            // 
            this.txtSearchLastname.Location = new System.Drawing.Point(745, 38);
            this.txtSearchLastname.Name = "txtSearchLastname";
            this.txtSearchLastname.Size = new System.Drawing.Size(112, 22);
            this.txtSearchLastname.TabIndex = 27;
            this.txtSearchLastname.TextChanged += new System.EventHandler(this.txtSearchLastname_TextChanged);
            // 
            // txt0searchNationalCode
            // 
            this.txt0searchNationalCode.Location = new System.Drawing.Point(491, 38);
            this.txt0searchNationalCode.Name = "txt0searchNationalCode";
            this.txt0searchNationalCode.Size = new System.Drawing.Size(114, 22);
            this.txt0searchNationalCode.TabIndex = 28;
            this.txt0searchNationalCode.TextChanged += new System.EventHandler(this.txt0searchNationalCode_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(642, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "کد ملی";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.clmnFirstName,
            this.clmnLastName,
            this.clmnNationalCode,
            this.clmnMobile,
            this.clmnProvince,
            this.clmnCity,
            this.clmnAddress,
            this.clmnEducationDegree,
            this.clmnFildOfStudy,
            this.clmnUserName,
            this.clmnpicture,
            this.clmnShowPicture,
            this.clmnRegistration,
            this.clmnUptade,
            this.clmnDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 541);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1325, 150);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.Visible = false;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.DataPropertyName = "FirstName";
            this.clmnFirstName.HeaderText = "نام";
            this.clmnFirstName.Name = "clmnFirstName";
            // 
            // clmnLastName
            // 
            this.clmnLastName.DataPropertyName = "LastName";
            this.clmnLastName.HeaderText = "نام خانوادگی";
            this.clmnLastName.Name = "clmnLastName";
            // 
            // clmnNationalCode
            // 
            this.clmnNationalCode.DataPropertyName = "NationalCode";
            this.clmnNationalCode.HeaderText = "کدملی";
            this.clmnNationalCode.Name = "clmnNationalCode";
            // 
            // clmnMobile
            // 
            this.clmnMobile.DataPropertyName = "Mobile";
            this.clmnMobile.HeaderText = "شماره تماس";
            this.clmnMobile.Name = "clmnMobile";
            // 
            // clmnProvince
            // 
            this.clmnProvince.DataPropertyName = "ProvinceName";
            this.clmnProvince.HeaderText = "استان";
            this.clmnProvince.Name = "clmnProvince";
            // 
            // clmnCity
            // 
            this.clmnCity.DataPropertyName = "CityName";
            this.clmnCity.HeaderText = "شهر";
            this.clmnCity.Name = "clmnCity";
            // 
            // clmnAddress
            // 
            this.clmnAddress.DataPropertyName = "Address";
            this.clmnAddress.HeaderText = "آدرس";
            this.clmnAddress.Name = "clmnAddress";
            // 
            // clmnEducationDegree
            // 
            this.clmnEducationDegree.DataPropertyName = "EducationDegreeName";
            this.clmnEducationDegree.HeaderText = "مقطع تحصیلی";
            this.clmnEducationDegree.Name = "clmnEducationDegree";
            // 
            // clmnFildOfStudy
            // 
            this.clmnFildOfStudy.DataPropertyName = "FildOfStudy";
            this.clmnFildOfStudy.HeaderText = "رشته تحصیلی";
            this.clmnFildOfStudy.Name = "clmnFildOfStudy";
            // 
            // clmnUserName
            // 
            this.clmnUserName.DataPropertyName = "UserName";
            this.clmnUserName.HeaderText = "نام کاربری";
            this.clmnUserName.Name = "clmnUserName";
            // 
            // clmnpicture
            // 
            this.clmnpicture.DataPropertyName = "Picture";
            this.clmnpicture.HeaderText = "ثبت تصویر";
            this.clmnpicture.Name = "clmnpicture";
            this.clmnpicture.Text = "ثبت تصویر";
            this.clmnpicture.UseColumnTextForButtonValue = true;
            // 
            // clmnShowPicture
            // 
            this.clmnShowPicture.DataPropertyName = "Picture";
            this.clmnShowPicture.HeaderText = "نمایش تصویر";
            this.clmnShowPicture.Name = "clmnShowPicture";
            this.clmnShowPicture.Text = "نمایش تصویر";
            this.clmnShowPicture.UseColumnTextForButtonValue = true;
            // 
            // clmnRegistration
            // 
            this.clmnRegistration.HeaderText = "ثبت نام";
            this.clmnRegistration.Name = "clmnRegistration";
            this.clmnRegistration.Text = "ثبت نام";
            this.clmnRegistration.UseColumnTextForButtonValue = true;
            // 
            // clmnUptade
            // 
            this.clmnUptade.HeaderText = "ویرایش";
            this.clmnUptade.Name = "clmnUptade";
            this.clmnUptade.Text = "ویرایش";
            this.clmnUptade.UseColumnTextForButtonValue = true;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddnew.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnew.Location = new System.Drawing.Point(468, 300);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(142, 25);
            this.btnAddnew.TabIndex = 30;
            this.btnAddnew.Text = "ثبت دانش آموز جدید";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(468, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 25);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "ویرایش اطلاعات";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(300, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 25);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNationalCode);
            this.groupBox2.Controls.Add(this.combCity);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.combEducationDegree);
            this.groupBox2.Controls.Add(this.txtFirstname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combProvince);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddnew);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFildofstudy);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1301, 346);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات فردی";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 691);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت دانش آموزان";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFildofstudy;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox combProvince;
        private System.Windows.Forms.ComboBox combCity;
        private System.Windows.Forms.ComboBox combEducationDegree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt0searchNationalCode;
        private System.Windows.Forms.TextBox txtSearchLastname;
        private System.Windows.Forms.TextBox txtsearchname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEducationDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFildOfStudy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUserName;
        private System.Windows.Forms.DataGridViewButtonColumn clmnpicture;
        private System.Windows.Forms.DataGridViewButtonColumn clmnShowPicture;
        private System.Windows.Forms.DataGridViewButtonColumn clmnRegistration;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUptade;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}