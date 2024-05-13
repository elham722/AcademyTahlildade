namespace AcademyTahlildade
{
    partial class Frmcoursstudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRunintime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStartdate = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.Column1 = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.clmncontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmncoursestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsabt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsearchcourse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.Tuition,
            this.clmnTeacherName,
            this.clmnPreq,
            this.clmnDay,
            this.clmnRunintime,
            this.clmnHour,
            this.clmnStartdate,
            this.Column1,
            this.clmncontent,
            this.clmnTerm,
            this.clmncoursestatus,
            this.clnsabt});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1370, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            this.CourseID.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "نام دوره";
            this.CourseName.Name = "CourseName";
            // 
            // Tuition
            // 
            this.Tuition.DataPropertyName = "Tuition";
            this.Tuition.HeaderText = "شهریه";
            this.Tuition.Name = "Tuition";
            // 
            // clmnTeacherName
            // 
            this.clmnTeacherName.DataPropertyName = "TeacherName";
            this.clmnTeacherName.HeaderText = "نام استاد";
            this.clmnTeacherName.Name = "clmnTeacherName";
            // 
            // clmnPreq
            // 
            this.clmnPreq.DataPropertyName = "Preq";
            this.clmnPreq.HeaderText = "پیش نیاز دوره";
            this.clmnPreq.Name = "clmnPreq";
            // 
            // clmnDay
            // 
            this.clmnDay.DataPropertyName = "Day";
            this.clmnDay.HeaderText = "روز های برگزاری کلاس";
            this.clmnDay.Name = "clmnDay";
            // 
            // clmnRunintime
            // 
            this.clmnRunintime.DataPropertyName = "RuningTime";
            this.clmnRunintime.HeaderText = "ساعت برگزاری کلاس";
            this.clmnRunintime.Name = "clmnRunintime";
            // 
            // clmnHour
            // 
            this.clmnHour.DataPropertyName = "Hours";
            this.clmnHour.HeaderText = "مدت زمان";
            this.clmnHour.Name = "clmnHour";
            // 
            // clmnStartdate
            // 
            this.clmnStartdate.DataPropertyName = "StartDate";
            this.clmnStartdate.HeaderText = "تاریخ شروع دوره";
            this.clmnStartdate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.clmnStartdate.Name = "clmnStartdate";
            this.clmnStartdate.SelectedDateTime = new System.DateTime(((long)(0)));
            this.clmnStartdate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
            this.clmnStartdate.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EndDate";
            this.Column1.HeaderText = "تاریخ پایان دوره";
            this.Column1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.Column1.Name = "Column1";
            this.Column1.SelectedDateTime = new System.DateTime(((long)(0)));
            this.Column1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
            this.Column1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // clmncontent
            // 
            this.clmncontent.DataPropertyName = "CourseContent";
            this.clmncontent.HeaderText = "سرفصل دوره";
            this.clmncontent.Name = "clmncontent";
            // 
            // clmnTerm
            // 
            this.clmnTerm.DataPropertyName = "TermName";
            this.clmnTerm.HeaderText = "ترم";
            this.clmnTerm.Name = "clmnTerm";
            // 
            // clmncoursestatus
            // 
            this.clmncoursestatus.DataPropertyName = "CourseStatusName";
            this.clmncoursestatus.HeaderText = "وضعیت دوره";
            this.clmncoursestatus.Name = "clmncoursestatus";
            // 
            // clnsabt
            // 
            this.clnsabt.HeaderText = "ثبت نام";
            this.clnsabt.Name = "clnsabt";
            this.clnsabt.Text = "ثبت نام";
            this.clnsabt.UseColumnTextForButtonValue = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsearchcourse);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(14, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1449, 82);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // txtsearchcourse
            // 
            this.txtsearchcourse.Location = new System.Drawing.Point(995, 40);
            this.txtsearchcourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsearchcourse.Name = "txtsearchcourse";
            this.txtsearchcourse.Size = new System.Drawing.Size(248, 22);
            this.txtsearchcourse.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1315, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 14);
            this.label13.TabIndex = 14;
            this.label13.Text = "نام دوره";
            // 
            // Frmcoursstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frmcoursstudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "دوره ها";
            this.Load += new System.EventHandler(this.Frmcoursstudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRunintime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHour;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn clmnStartdate;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmncontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmncoursestatus;
        private System.Windows.Forms.DataGridViewButtonColumn clnsabt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsearchcourse;
        private System.Windows.Forms.Label label13;
    }
}