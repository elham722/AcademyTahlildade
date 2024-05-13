namespace AcademyTahlildade
{
    partial class FrmRegisturation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.faDateRegidter = new FarsiLibrary.Win.Controls.FADatePicker();
            this.combcorse = new System.Windows.Forms.ComboBox();
            this.txtdescriptin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltuion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblemployee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstudent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmnfactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTiution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnpayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmndateregister = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.clmndescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnemploee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPaymen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی دانشجو :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.faDateRegidter);
            this.groupBox1.Controls.Add(this.combcorse);
            this.groupBox1.Controls.Add(this.txtdescriptin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbltuion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblemployee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblstudent);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات ثبت نام";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(6, 95);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(209, 22);
            this.txttotal.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "کل مبلغ پرداختی";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(524, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 24);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(696, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 24);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "ویرایش ثبت نام";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(696, 233);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(157, 24);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "ثبت نام";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // faDateRegidter
            // 
            this.faDateRegidter.Location = new System.Drawing.Point(608, 139);
            this.faDateRegidter.Name = "faDateRegidter";
            this.faDateRegidter.Size = new System.Drawing.Size(147, 20);
            this.faDateRegidter.TabIndex = 12;
            // 
            // combcorse
            // 
            this.combcorse.FormattingEnabled = true;
            this.combcorse.Location = new System.Drawing.Point(6, 30);
            this.combcorse.Name = "combcorse";
            this.combcorse.Size = new System.Drawing.Size(209, 22);
            this.combcorse.TabIndex = 11;
            this.combcorse.SelectedIndexChanged += new System.EventHandler(this.combcorse_SelectedIndexChanged);
            // 
            // txtdescriptin
            // 
            this.txtdescriptin.Location = new System.Drawing.Point(6, 139);
            this.txtdescriptin.Multiline = true;
            this.txtdescriptin.Name = "txtdescriptin";
            this.txtdescriptin.Size = new System.Drawing.Size(209, 93);
            this.txtdescriptin.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "توضیحات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "تاریخ ثبت نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام دوره";
            // 
            // lbltuion
            // 
            this.lbltuion.AutoSize = true;
            this.lbltuion.Location = new System.Drawing.Point(723, 98);
            this.lbltuion.Name = "lbltuion";
            this.lbltuion.Size = new System.Drawing.Size(0, 14);
            this.lbltuion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "شهریه :";
            // 
            // lblemployee
            // 
            this.lblemployee.AutoSize = true;
            this.lblemployee.Location = new System.Drawing.Point(438, 30);
            this.lblemployee.Name = "lblemployee";
            this.lblemployee.Size = new System.Drawing.Size(0, 14);
            this.lblemployee.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "کارمند ثبت کننده :";
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Location = new System.Drawing.Point(628, 30);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(0, 14);
            this.lblstudent.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnfactor,
            this.StudentID,
            this.clmnCourseName,
            this.clmnTiution,
            this.clmnpayment,
            this.clmndateregister,
            this.clmndescription,
            this.clmnemploee,
            this.clmnPaymen,
            this.clmnUpdate,
            this.clmndelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 185);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmnfactor
            // 
            this.clmnfactor.DataPropertyName = "RegistrationID";
            this.clmnfactor.HeaderText = "شماره ثبت نام";
            this.clmnfactor.Name = "clmnfactor";
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentFullInfo";
            this.StudentID.HeaderText = "نام و نام خانوادگی دانش آموز";
            this.StudentID.Name = "StudentID";
            // 
            // clmnCourseName
            // 
            this.clmnCourseName.DataPropertyName = "CourseName";
            this.clmnCourseName.HeaderText = "نام دوره";
            this.clmnCourseName.Name = "clmnCourseName";
            // 
            // clmnTiution
            // 
            this.clmnTiution.DataPropertyName = "Tuitionn";
            this.clmnTiution.HeaderText = "مبلغ واریزی";
            this.clmnTiution.Name = "clmnTiution";
            // 
            // clmnpayment
            // 
            this.clmnpayment.DataPropertyName = "TotalPayment";
            this.clmnpayment.HeaderText = "مجموع واریزی";
            this.clmnpayment.Name = "clmnpayment";
            // 
            // clmndateregister
            // 
            this.clmndateregister.DataPropertyName = "RegistrationDate";
            this.clmndateregister.HeaderText = "تاریخ ثبت نام";
            this.clmndateregister.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.clmndateregister.Name = "clmndateregister";
            this.clmndateregister.SelectedDateTime = new System.DateTime(((long)(0)));
            this.clmndateregister.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
            this.clmndateregister.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // clmndescription
            // 
            this.clmndescription.DataPropertyName = "Description";
            this.clmndescription.HeaderText = "توضیحات";
            this.clmndescription.Name = "clmndescription";
            // 
            // clmnemploee
            // 
            this.clmnemploee.DataPropertyName = "UserName";
            this.clmnemploee.HeaderText = "کارمندثبت کننده";
            this.clmnemploee.Name = "clmnemploee";
            // 
            // clmnPaymen
            // 
            this.clmnPaymen.HeaderText = "پرداختی ها";
            this.clmnPaymen.Name = "clmnPaymen";
            this.clmnPaymen.Text = "پرداختی ها";
            this.clmnPaymen.UseColumnTextForButtonValue = true;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            // 
            // clmndelete
            // 
            this.clmndelete.HeaderText = "حذف";
            this.clmndelete.Name = "clmndelete";
            this.clmndelete.Text = "حذف";
            this.clmndelete.UseColumnTextForButtonValue = true;
            // 
            // FrmRegisturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRegisturation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام";
            this.Load += new System.EventHandler(this.FrmRegisturation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private FarsiLibrary.Win.Controls.FADatePicker faDateRegidter;
        private System.Windows.Forms.ComboBox combcorse;
        private System.Windows.Forms.TextBox txtdescriptin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblemployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltuion;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnfactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTiution;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnpayment;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn clmndateregister;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmndescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnemploee;
        private System.Windows.Forms.DataGridViewButtonColumn clmnPaymen;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmndelete;
    }
}