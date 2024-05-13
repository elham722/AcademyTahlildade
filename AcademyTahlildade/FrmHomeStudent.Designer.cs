namespace AcademyTahlildade
{
    partial class FrmHomeStudent
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.دورههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اساتیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازگشتبهصفحهاصلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجازبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.ToolStripLabel();
            this.lblDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblDate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 421);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(800, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دورههاToolStripMenuItem,
            this.اساتیدToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // دورههاToolStripMenuItem
            // 
            this.دورههاToolStripMenuItem.Name = "دورههاToolStripMenuItem";
            this.دورههاToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.دورههاToolStripMenuItem.Text = "دوره ها";
            this.دورههاToolStripMenuItem.Click += new System.EventHandler(this.دورههاToolStripMenuItem_Click);
            // 
            // اساتیدToolStripMenuItem
            // 
            this.اساتیدToolStripMenuItem.Name = "اساتیدToolStripMenuItem";
            this.اساتیدToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.اساتیدToolStripMenuItem.Text = "اساتید";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بازگشتبهصفحهاصلیToolStripMenuItem,
            this.خروجازبرنامهToolStripMenuItem});
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // بازگشتبهصفحهاصلیToolStripMenuItem
            // 
            this.بازگشتبهصفحهاصلیToolStripMenuItem.Name = "بازگشتبهصفحهاصلیToolStripMenuItem";
            this.بازگشتبهصفحهاصلیToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.بازگشتبهصفحهاصلیToolStripMenuItem.Text = "بازگشت به صفحه اصلی";
            this.بازگشتبهصفحهاصلیToolStripMenuItem.Click += new System.EventHandler(this.بازگشتبهصفحهاصلیToolStripMenuItem_Click);
            // 
            // خروجازبرنامهToolStripMenuItem
            // 
            this.خروجازبرنامهToolStripMenuItem.Name = "خروجازبرنامهToolStripMenuItem";
            this.خروجازبرنامهToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.خروجازبرنامهToolStripMenuItem.Text = "خروج از برنامه";
            this.خروجازبرنامهToolStripMenuItem.Click += new System.EventHandler(this.خروجازبرنامهToolStripMenuItem_Click);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 16);
            this.lblTime.Text = "تاریخ";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 22);
            this.lblDate.Text = "زمان";
            // 
            // FrmHomeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHomeStudent";
            this.Text = "FrmHomeStudent";
            this.Load += new System.EventHandler(this.FrmHomeStudent_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem دورههاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اساتیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازگشتبهصفحهاصلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجازبرنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblTime;
        private System.Windows.Forms.ToolStripLabel lblDate;
    }
}