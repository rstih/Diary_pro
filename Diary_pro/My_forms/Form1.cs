namespace Diary_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            get_time();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //--------------------------
                Diary_pro.My_forms.login lg_form = new My_forms.login();
                lg_form.ShowDialog();
                //--------------------------------------------
                get_time();
                //--------------------------
                get_calendar();
                //------LOAD MY BACKGROUND IMAGE---------------
                Int32 si;
                si = Diary_pro.Properties.Settings.Default.selected_back_image_index;
                load_pics(si);
                bimage_combo_load();
                this.comboBox1.SelectedIndex = si; // kod za vidljiv index u combo boxu
                                                   //------------- LOAD USER INFO--------------------
                user_info_loader();
            }
            catch (Exception ex)
            {
                comm_class.my_error_message(ex.ToString());               
            }
        }
        public void user_info_loader()
        {
            this.user_name_label.Text = Diary_pro.Properties.Settings.Default.User_name;
           
            //------------------ LOAD USER PIC-----------------------------
            string df;
            df = Application.StartupPath + "\\data\\user_pics\\profile.png";
            this.user_pictureBox1.Load(df);
        }
        public void bimage_combo_load()
        {
            Int32 i;
            for (i = 1; i <=6; i++)
            {
                this.comboBox1.Items.Add("Image "+i.ToString());
            }
        }
        public void load_pics(Int32 combo_index) // loading background image
        {
            string fn;
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\data\\pics\\"+ combo_index.ToString()+".jpg";
            this.BackgroundImage = Image.FromFile(fn);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        public void get_time() //method
        {
            this.timer_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void get_calendar()
        {
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.year_label.Text = g.GetYear(DateTime.Now).ToString();
            //this.month_textbox2.text = g.getMonth(datetime.now).Tostring();
            this.day_label.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.Day_week.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            //----------------------
            Int32 m;
            string mnum;
            mnum = g.GetMonth(DateTime.Now).ToString();
            Int32.TryParse(mnum, out m);
            this.month_label.Text = month_num_to_name(m);
        }
        public string month_num_to_name(Int32 month_num)
        {
            string mn;

            switch (month_num)
            {
                case 1:
                    mn = "January";
                    break;
                case 2:
                    mn = "February";
                    break;
                case 3:
                    mn = "March";
                    break;
                case 4:
                    mn = "April";
                    break;
                case 5:
                    mn = "May";
                    break;
                case 6:
                    mn = "June";
                    break;
                case 7:
                    mn = "July";
                    break;
                case 8:
                    mn = "August";
                    break;
                case 9:
                    mn = "September";
                    break;
                case 10:
                    mn = "October";
                    break;
                case 11:
                    mn = "November";
                    break;
                case 12:
                    mn = "December";
                    break;
                default:
                    mn = "Unknown";
                    break;
            }
            return mn;
        }

        private void year_label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 si;
            si=this.comboBox1.SelectedIndex;
            load_pics(si);
            //------------ save the selected image index --------------
            Diary_pro.Properties.Settings.Default.selected_back_image_index=this.comboBox1.SelectedIndex;
            Diary_pro.Properties.Settings.Default.Save();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diary_pro.My_forms.about_us ab_form = new Diary_pro.My_forms.about_us();
            ab_form.MdiParent = this;
            ab_form.Show();
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diary_pro.My_forms.users_mang us_form = new My_forms.users_mang();
            us_form.MdiParent = this;
            us_form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--------------------------
            Diary_pro.My_forms.login lg_form = new My_forms.login();
            lg_form.ShowDialog();
            //--------------------------------------------
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Diary_pro.My_forms.memo_form mf_form = new My_forms.memo_form();
            mf_form.MdiParent = this;
            mf_form.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Diary_pro.My_forms.search sf = new My_forms.search();
            sf.MdiParent = this;
            sf.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
            {
                toolStripButton5_Click(sender, e);

            }
            //------------------------
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton4_Click(sender, e);
            }
            //------------------------
            if (e.KeyCode == Keys.F4)
            {
                this.settButton3.ShowDropDown();
            }
            //------------------------
            if (e.KeyCode == Keys.F5)
            {
                this.toolButton2.ShowDropDown();
            }
            //------------------------
            if (e.KeyCode == Keys.F6)
            {
                this.aboutButton1.ShowDropDown();
            }
            //------------------------
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton7_Click(sender, e);
            }
            //------------------------
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}