namespace AcademyTahlildade
{
    partial class FrmPayment
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
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRegistrationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPaymentDate = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.clmnEmployeeID = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldatapayment = new System.Windows.Forms.Label();
            this.lblepmployee = new System.Windows.Forms.Label();
            this.lblregisterid = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.clmnRegistrationID,
            this.clmnAmount,
            this.clmnPaymentDate,
            this.clmnEmployeeID,
            this.clmnUpdate,
            this.clmnDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1272, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // PaymentID
            // 
            this.PaymentID.DataPropertyName = "PayementID";
            this.PaymentID.HeaderText = "PaymentID";
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Visible = false;
            // 
            // clmnRegistrationID
            // 
            this.clmnRegistrationID.DataPropertyName = "RegisterationID";
            this.clmnRegistrationID.HeaderText = "شماره ثبت نام";
            this.clmnRegistrationID.Name = "clmnRegistrationID";
            // 
            // clmnAmount
            // 
            this.clmnAmount.DataPropertyName = "Amount";
            this.clmnAmount.HeaderText = "باقی مانده حساب";
            this.clmnAmount.Name = "clmnAmount";
            // 
            // clmnPaymentDate
            // 
            this.clmnPaymentDate.DataPropertyName = "PaymentDate";
            this.clmnPaymentDate.HeaderText = "تاریخ پرداخت";
            this.clmnPaymentDate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.clmnPaymentDate.Name = "clmnPaymentDate";
            this.clmnPaymentDate.SelectedDateTime = new System.DateTime(((long)(0)));
            this.clmnPaymentDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
            this.clmnPaymentDate.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // clmnEmployeeID
            // 
            this.clmnEmployeeID.DataPropertyName = "UserName";
            this.clmnEmployeeID.HeaderText = "کارمند ثبت کننده";
            this.clmnEmployeeID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.clmnEmployeeID.Name = "clmnEmployeeID";
            this.clmnEmployeeID.SelectedDateTime = new System.DateTime(((long)(0)));
            this.clmnEmployeeID.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
            this.clmnEmployeeID.VerticalAlignment = System.Drawing.StringAlignment.Near;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره ثبت نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "مبلغ پرداختی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "کارمند ثبت کننده";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "تاریخ پرداخت";
            // 
            // lbldatapayment
            // 
            this.lbldatapayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldatapayment.Location = new System.Drawing.Point(523, 96);
            this.lbldatapayment.Name = "lbldatapayment";
            this.lbldatapayment.Size = new System.Drawing.Size(176, 26);
            this.lbldatapayment.TabIndex = 5;
            // 
            // lblepmployee
            // 
            this.lblepmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblepmployee.Location = new System.Drawing.Point(523, 39);
            this.lblepmployee.Name = "lblepmployee";
            this.lblepmployee.Size = new System.Drawing.Size(176, 26);
            this.lblepmployee.TabIndex = 6;
            // 
            // lblregisterid
            // 
            this.lblregisterid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblregisterid.Location = new System.Drawing.Point(952, 22);
            this.lblregisterid.Name = "lblregisterid";
            this.lblregisterid.Size = new System.Drawing.Size(176, 26);
            this.lblregisterid.TabIndex = 7;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(130, 94);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(175, 22);
            this.txtamount.TabIndex = 8;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(777, 94);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(170, 26);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "ثبت";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(965, 94);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(170, 26);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblregisterid);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 158);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 82);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(954, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1146, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "شماره ثبت نام";
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.lblepmployee);
            this.Controls.Add(this.lbldatapayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مدیریت مالی";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRegistrationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAmount;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn clmnPaymentDate;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn clmnEmployeeID;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldatapayment;
        private System.Windows.Forms.Label lblepmployee;
        private System.Windows.Forms.Label lblregisterid;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}