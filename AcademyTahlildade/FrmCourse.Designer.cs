namespace AcademyTahlildade
{
    partial class FrmCourse
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
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtTiution = new System.Windows.Forms.TextBox();
            this.combTeacher = new System.Windows.Forms.ComboBox();
            this.combTerm = new System.Windows.Forms.ComboBox();
            this.combCourseStatus = new System.Windows.Forms.ComboBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtpreq = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtCoursecontent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsearchcourse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timepikerendDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.timepikerstat = new FarsiLibrary.Win.Controls.FADatePicker();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRuningtime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTuition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRuningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTermID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRegisture = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1204, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام دوره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "شهریه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام استاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "پیش نیاز دوره";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "روز برگزاری کلاس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "مدت زمان";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1165, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "تاریخ شروع دوره";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "تاریخ پایان دوره";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1179, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "سرفصل دوره";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "ترم";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "وضعیت دوره";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(861, 38);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(254, 21);
            this.txtCourseName.TabIndex = 11;
            // 
            // txtTiution
            // 
            this.txtTiution.Location = new System.Drawing.Point(219, 41);
            this.txtTiution.Name = "txtTiution";
            this.txtTiution.Size = new System.Drawing.Size(132, 21);
            this.txtTiution.TabIndex = 12;
            // 
            // combTeacher
            // 
            this.combTeacher.FormattingEnabled = true;
            this.combTeacher.Location = new System.Drawing.Point(484, 33);
            this.combTeacher.Name = "combTeacher";
            this.combTeacher.Size = new System.Drawing.Size(222, 21);
            this.combTeacher.TabIndex = 13;
            // 
            // combTerm
            // 
            this.combTerm.FormattingEnabled = true;
            this.combTerm.Location = new System.Drawing.Point(23, 102);
            this.combTerm.Name = "combTerm";
            this.combTerm.Size = new System.Drawing.Size(115, 21);
            this.combTerm.TabIndex = 14;
            // 
            // combCourseStatus
            // 
            this.combCourseStatus.FormattingEnabled = true;
            this.combCourseStatus.Location = new System.Drawing.Point(165, 185);
            this.combCourseStatus.Name = "combCourseStatus";
            this.combCourseStatus.Size = new System.Drawing.Size(186, 21);
            this.combCourseStatus.TabIndex = 15;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(484, 102);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(222, 21);
            this.txtDay.TabIndex = 16;
            // 
            // txtpreq
            // 
            this.txtpreq.Location = new System.Drawing.Point(484, 270);
            this.txtpreq.Multiline = true;
            this.txtpreq.Name = "txtpreq";
            this.txtpreq.Size = new System.Drawing.Size(222, 51);
            this.txtpreq.TabIndex = 17;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(219, 102);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(132, 21);
            this.txtHours.TabIndex = 18;
            // 
            // txtCoursecontent
            // 
            this.txtCoursecontent.Location = new System.Drawing.Point(861, 270);
            this.txtCoursecontent.Multiline = true;
            this.txtCoursecontent.Name = "txtCoursecontent";
            this.txtCoursecontent.Size = new System.Drawing.Size(254, 51);
            this.txtCoursecontent.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsearchcourse);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(26, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1263, 76);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtsearchcourse
            // 
            this.txtsearchcourse.Location = new System.Drawing.Point(859, 37);
            this.txtsearchcourse.Name = "txtsearchcourse";
            this.txtsearchcourse.Size = new System.Drawing.Size(213, 21);
            this.txtsearchcourse.TabIndex = 16;
            this.txtsearchcourse.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1104, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "نام دوره";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timepikerendDate);
            this.groupBox1.Controls.Add(this.timepikerstat);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.txtCoursecontent);
            this.groupBox1.Controls.Add(this.txtpreq);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.combCourseStatus);
            this.groupBox1.Controls.Add(this.txtTiution);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRuningtime);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combTerm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.combTeacher);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 335);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات دوره";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // timepikerendDate
            // 
            this.timepikerendDate.Location = new System.Drawing.Point(586, 182);
            this.timepikerendDate.Name = "timepikerendDate";
            this.timepikerendDate.Size = new System.Drawing.Size(120, 20);
            this.timepikerendDate.TabIndex = 30;
            // 
            // timepikerstat
            // 
            this.timepikerstat.Location = new System.Drawing.Point(940, 186);
            this.timepikerstat.Name = "timepikerstat";
            this.timepikerstat.Size = new System.Drawing.Size(120, 20);
            this.timepikerstat.TabIndex = 29;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(248, 247);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(154, 34);
            this.btnAddNew.TabIndex = 25;
            this.btnAddNew.Text = "ثبت دوره جدید";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(248, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 34);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "ویرایش اطلاعات";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(67, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 34);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRuningtime
            // 
            this.txtRuningtime.Location = new System.Drawing.Point(861, 107);
            this.txtRuningtime.Name = "txtRuningtime";
            this.txtRuningtime.Size = new System.Drawing.Size(254, 21);
            this.txtRuningtime.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1141, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "ساعت برگزاری کلاس";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.clmnCourseName,
            this.clmnTuition,
            this.clmnTeacherID,
            this.clmnPreq,
            this.clmnDay,
            this.clmnRuningTime,
            this.clmnHours,
            this.clmnStartDateTime,
            this.clmnEndDate,
            this.clmnCourseContent,
            this.clmnTermID,
            this.clmnCourseStatusID,
            this.clmnRegisture,
            this.clmnUpdate,
            this.clmnDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 566);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 132);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            this.CourseID.Visible = false;
            // 
            // clmnCourseName
            // 
            this.clmnCourseName.DataPropertyName = "CourseName";
            this.clmnCourseName.HeaderText = "نام دوره";
            this.clmnCourseName.Name = "clmnCourseName";
            // 
            // clmnTuition
            // 
            this.clmnTuition.DataPropertyName = "Tuition";
            this.clmnTuition.HeaderText = "شهریه";
            this.clmnTuition.Name = "clmnTuition";
            // 
            // clmnTeacherID
            // 
            this.clmnTeacherID.DataPropertyName = "TeacherName";
            this.clmnTeacherID.HeaderText = "نام استاد";
            this.clmnTeacherID.Name = "clmnTeacherID";
            // 
            // clmnPreq
            // 
            this.clmnPreq.DataPropertyName = "Preq";
            this.clmnPreq.HeaderText = "پیش نیاز ها";
            this.clmnPreq.Name = "clmnPreq";
            // 
            // clmnDay
            // 
            this.clmnDay.DataPropertyName = "Day";
            this.clmnDay.HeaderText = "روز برگزاری کلاس";
            this.clmnDay.Name = "clmnDay";
            // 
            // clmnRuningTime
            // 
            this.clmnRuningTime.DataPropertyName = "RuningTime";
            this.clmnRuningTime.HeaderText = "ساعت برگزاری کلاس";
            this.clmnRuningTime.Name = "clmnRuningTime";
            // 
            // clmnHours
            // 
            this.clmnHours.DataPropertyName = "Hours";
            this.clmnHours.HeaderText = "مدت زمان";
            this.clmnHours.Name = "clmnHours";
            // 
            // clmnStartDateTime
            // 
            this.clmnStartDateTime.DataPropertyName = "StartDate";
            this.clmnStartDateTime.HeaderText = "تاریخ شروع دوره";
            this.clmnStartDateTime.Name = "clmnStartDateTime";
            // 
            // clmnEndDate
            // 
            this.clmnEndDate.DataPropertyName = "EndDate";
            this.clmnEndDate.HeaderText = "تاریخ پایان دوره";
            this.clmnEndDate.Name = "clmnEndDate";
            // 
            // clmnCourseContent
            // 
            this.clmnCourseContent.DataPropertyName = "CourseContent";
            this.clmnCourseContent.HeaderText = "سرفصل دوره";
            this.clmnCourseContent.Name = "clmnCourseContent";
            // 
            // clmnTermID
            // 
            this.clmnTermID.DataPropertyName = "TermName";
            this.clmnTermID.HeaderText = "ترم";
            this.clmnTermID.Name = "clmnTermID";
            // 
            // clmnCourseStatusID
            // 
            this.clmnCourseStatusID.DataPropertyName = "CourseStatusName";
            this.clmnCourseStatusID.HeaderText = "وضعیت دوره";
            this.clmnCourseStatusID.Name = "clmnCourseStatusID";
            // 
            // clmnRegisture
            // 
            this.clmnRegisture.HeaderText = "ثبت نام";
            this.clmnRegisture.Name = "clmnRegisture";
            this.clmnRegisture.Text = "ثبت نام";
            this.clmnRegisture.UseColumnTextForButtonValue = true;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 698);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCourse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت دوره ها";
            this.Load += new System.EventHandler(this.FrmCourse_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtTiution;
        private System.Windows.Forms.ComboBox combTeacher;
        private System.Windows.Forms.ComboBox combTerm;
        private System.Windows.Forms.ComboBox combCourseStatus;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtpreq;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtCoursecontent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsearchcourse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRuningtime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTuition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRuningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStartDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTermID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseStatusID;
        private System.Windows.Forms.DataGridViewButtonColumn clmnRegisture;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private FarsiLibrary.Win.Controls.FADatePicker timepikerstat;
        private FarsiLibrary.Win.Controls.FADatePicker timepikerendDate;
    }
}