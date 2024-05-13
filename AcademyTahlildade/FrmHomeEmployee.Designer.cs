namespace AcademyTahlildade
{
    partial class FrmHomeEmployee
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.مدیریتکارمندانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتاساتیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتدانشاموزانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازگشتبهصفحهورودToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجازبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتکارمندانToolStripMenuItem,
            this.مدیریتاساتیدToolStripMenuItem,
            this.مدیریتدانشاموزانToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.خروجToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(807, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // مدیریتکارمندانToolStripMenuItem
            // 
            this.مدیریتکارمندانToolStripMenuItem.Name = "مدیریتکارمندانToolStripMenuItem";
            this.مدیریتکارمندانToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.مدیریتکارمندانToolStripMenuItem.Text = "مدیریت کارمندان";
            this.مدیریتکارمندانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکارمندانToolStripMenuItem_Click);
            // 
            // مدیریتاساتیدToolStripMenuItem
            // 
            this.مدیریتاساتیدToolStripMenuItem.Name = "مدیریتاساتیدToolStripMenuItem";
            this.مدیریتاساتیدToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.مدیریتاساتیدToolStripMenuItem.Text = "مدیریت اساتید";
            this.مدیریتاساتیدToolStripMenuItem.Click += new System.EventHandler(this.مدیریتاساتیدToolStripMenuItem_Click);
            // 
            // مدیریتدانشاموزانToolStripMenuItem
            // 
            this.مدیریتدانشاموزانToolStripMenuItem.Name = "مدیریتدانشاموزانToolStripMenuItem";
            this.مدیریتدانشاموزانToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.مدیریتدانشاموزانToolStripMenuItem.Text = "مدیریت دانش اموزان";
            this.مدیریتدانشاموزانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتدانشاموزانToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 20);
            this.toolStripMenuItem2.Text = "مدیریت دوره ها";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.خروجToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بازگشتبهصفحهورودToolStripMenuItem,
            this.خروجازبرنامهToolStripMenuItem});
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.خروجToolStripMenuItem.ShowShortcutKeys = false;
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // بازگشتبهصفحهورودToolStripMenuItem
            // 
            this.بازگشتبهصفحهورودToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.بازگشتبهصفحهورودToolStripMenuItem.Name = "بازگشتبهصفحهورودToolStripMenuItem";
            this.بازگشتبهصفحهورودToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.بازگشتبهصفحهورودToolStripMenuItem.Text = "بازگشت به صفحه ورود";
            this.بازگشتبهصفحهورودToolStripMenuItem.Click += new System.EventHandler(this.بازگشتبهصفحهورودToolStripMenuItem_Click);
            // 
            // خروجازبرنامهToolStripMenuItem
            // 
            this.خروجازبرنامهToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.خروجازبرنامهToolStripMenuItem.Name = "خروجازبرنامهToolStripMenuItem";
            this.خروجازبرنامهToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.خروجازبرنامهToolStripMenuItem.Text = "خروج از برنامه";
            this.خروجازبرنامهToolStripMenuItem.Click += new System.EventHandler(this.خروجازبرنامهToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.toolStripSeparator2,
            this.lblTime,
            this.toolStripSeparator3,
            this.lblCurrentUser,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 584);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip1.Size = new System.Drawing.Size(807, 40);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 35);
            this.lblDate.Text = "زمان";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(10);
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(51, 35);
            this.lblTime.Text = "تاریخ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(56, 35);
            this.lblCurrentUser.Text = "کاربر جاری";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 35);
            this.toolStripLabel1.Text = "برنامه نویس:الهام حیدری";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItem3.Text = "مدیریت مالی";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // FrmHomeEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 624);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmHomeEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سیستم مدیریت آموزشگاه تحلیل داده";
            this.Load += new System.EventHandler(this.FrmHomeEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکارمندانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتاساتیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتدانشاموزانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.ToolStripLabel lblCurrentUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem بازگشتبهصفحهورودToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجازبرنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripLabel lblDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}