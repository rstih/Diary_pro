namespace Diary_pro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name_label = new System.Windows.Forms.Label();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Day_week = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.month_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.settButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lock_cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.lock_cm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.timer_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 614);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.user_name_label);
            this.panel4.Controls.Add(this.user_pictureBox1);
            this.panel4.Location = new System.Drawing.Point(3, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 202);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name:";
            // 
            // user_name_label
            // 
            this.user_name_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_name_label.ForeColor = System.Drawing.Color.DarkRed;
            this.user_name_label.Location = new System.Drawing.Point(94, 150);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(90, 23);
            this.user_name_label.TabIndex = 3;
            this.user_name_label.Text = "-";
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(141, 137);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox1.TabIndex = 1;
            this.user_pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::Diary_pro.Properties.Resources.calendar1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.Day_week);
            this.panel3.Controls.Add(this.day_label);
            this.panel3.Controls.Add(this.month_label);
            this.panel3.Controls.Add(this.year_label);
            this.panel3.Location = new System.Drawing.Point(3, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 248);
            this.panel3.TabIndex = 1;
            // 
            // Day_week
            // 
            this.Day_week.BackColor = System.Drawing.Color.Transparent;
            this.Day_week.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Day_week.Location = new System.Drawing.Point(38, 164);
            this.Day_week.Name = "Day_week";
            this.Day_week.Size = new System.Drawing.Size(84, 30);
            this.Day_week.TabIndex = 3;
            this.Day_week.Text = "N of day";
            this.Day_week.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day_label
            // 
            this.day_label.BackColor = System.Drawing.Color.Transparent;
            this.day_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.day_label.Location = new System.Drawing.Point(38, 129);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(84, 30);
            this.day_label.TabIndex = 2;
            this.day_label.Text = "Day";
            this.day_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month_label
            // 
            this.month_label.BackColor = System.Drawing.Color.Transparent;
            this.month_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.month_label.Location = new System.Drawing.Point(38, 94);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(84, 30);
            this.month_label.TabIndex = 1;
            this.month_label.Text = "Month";
            this.month_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_label
            // 
            this.year_label.BackColor = System.Drawing.Color.Transparent;
            this.year_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.year_label.Location = new System.Drawing.Point(38, 59);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(84, 30);
            this.year_label.TabIndex = 0;
            this.year_label.Text = "Year";
            this.year_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.year_label.Click += new System.EventHandler(this.year_label_Click);
            // 
            // timer_label
            // 
            this.timer_label.BackColor = System.Drawing.Color.Black;
            this.timer_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timer_label.ForeColor = System.Drawing.Color.White;
            this.timer_label.Location = new System.Drawing.Point(-1, 88);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(195, 40);
            this.timer_label.TabIndex = 0;
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(192, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 38);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(562, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton4,
            this.settButton3,
            this.toolButton2,
            this.aboutButton1,
            this.toolStripButton7,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(192, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 78);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.Image = global::Diary_pro.Properties.Resources.add;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(130, 75);
            this.toolStripButton5.Text = "Add  F2";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Image = global::Diary_pro.Properties.Resources.search;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(130, 75);
            this.toolStripButton4.Text = "Search  F3";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // settButton3
            // 
            this.settButton3.AutoSize = false;
            this.settButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.settButton3.Image = global::Diary_pro.Properties.Resources.sett;
            this.settButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settButton3.Name = "settButton3";
            this.settButton3.Size = new System.Drawing.Size(130, 75);
            this.settButton3.Text = "Settings  F4";
            this.settButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Diary_pro.Properties.Resources.sett;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolButton2
            // 
            this.toolButton2.AutoSize = false;
            this.toolButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem});
            this.toolButton2.Image = global::Diary_pro.Properties.Resources.add48;
            this.toolButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButton2.Name = "toolButton2";
            this.toolButton2.Size = new System.Drawing.Size(130, 75);
            this.toolButton2.Text = "Tools  F5";
            this.toolButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Image = global::Diary_pro.Properties.Resources.add48;
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.setToolStripMenuItem.Text = "Users";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // aboutButton1
            // 
            this.aboutButton1.AutoSize = false;
            this.aboutButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.aboutButton1.Image = global::Diary_pro.Properties.Resources.about;
            this.aboutButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton1.Name = "aboutButton1";
            this.aboutButton1.Size = new System.Drawing.Size(130, 75);
            this.aboutButton1.Text = "About us  F6";
            this.aboutButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::Diary_pro.Properties.Resources.tool;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = global::Diary_pro.Properties.Resources.about;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Diary_pro.Properties.Resources.close;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 75);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Diary_pro.Properties.Resources.mini;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lock_cm
            // 
            this.lock_cm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lock_cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockApplicationToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.lock_cm.Name = "lock_cm";
            this.lock_cm.Size = new System.Drawing.Size(190, 52);
            // 
            // lockApplicationToolStripMenuItem
            // 
            this.lockApplicationToolStripMenuItem.Name = "lockApplicationToolStripMenuItem";
            this.lockApplicationToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.lockApplicationToolStripMenuItem.Text = "Lock Application";
            this.lockApplicationToolStripMenuItem.Click += new System.EventHandler(this.lockApplicationToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 614);
            this.ContextMenuStrip = this.lock_cm;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.lock_cm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton6;
        private ToolStripDropDownButton toolButton2;
        private ToolStripMenuItem setToolStripMenuItem;
        private ToolStripDropDownButton aboutButton1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripButton toolStripButton7;
        private Label timer_label;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Label Day_week;
        private Label day_label;
        private Label month_label;
        private Label year_label;
        private ComboBox comboBox1;
        private Panel panel4;
        private PictureBox user_pictureBox1;
        private Label label2;
        private Label user_name_label;
        private ContextMenuStrip lock_cm;
        private ToolStripMenuItem lockApplicationToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripDropDownButton settButton3;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}