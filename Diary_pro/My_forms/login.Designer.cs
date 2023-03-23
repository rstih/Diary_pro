namespace Diary_pro.My_forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name_label = new System.Windows.Forms.Label();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pass_box);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.user_name_label);
            this.panel4.Controls.Add(this.user_pictureBox1);
            this.panel4.Location = new System.Drawing.Point(36, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 299);
            this.panel4.TabIndex = 3;
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.Color.Honeydew;
            this.pass_box.Location = new System.Drawing.Point(94, 188);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(173, 27);
            this.pass_box.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name:";
            // 
            // user_name_label
            // 
            this.user_name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_name_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_name_label.ForeColor = System.Drawing.Color.DarkRed;
            this.user_name_label.Location = new System.Drawing.Point(95, 150);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(172, 23);
            this.user_name_label.TabIndex = 3;
            this.user_name_label.Text = "-";
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pictureBox1.Location = new System.Drawing.Point(62, 3);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(141, 137);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox1.TabIndex = 1;
            this.user_pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to My Diary Application";
            // 
            // button2
            // 
            this.button2.Image = global::Diary_pro.Properties.Resources.ok24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(36, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ok";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Diary_pro.Properties.Resources.exit24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(255, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(346, 453);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Diary Pro";
            this.Load += new System.EventHandler(this.login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Label label2;
        private Label user_name_label;
        private PictureBox user_pictureBox1;
        private Label label1;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox pass_box;
    }
}