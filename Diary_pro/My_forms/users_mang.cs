using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_pro.My_forms
{
    public partial class users_mang : Form
    {
        public users_mang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Kod za logiranje slika od strane korisnika
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            this.pictureBox1.Load(fn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.user_name_tbox.Text == "")
            {
                MessageBox.Show("You must entry user name!");
                return;
            }
            //-------------------------------------
            if(this.pass_box.Text!=this.passconf_boc.Text)
            {
                MessageBox.Show("Password is not equal");
                return;
            }
            // kod za korisnicko ime i lozinku
            Diary_pro.Properties.Settings.Default.User_name = this.user_name_tbox.Text;
            Diary_pro.Properties.Settings.Default.User_pass = this.pass_box.Text;
            Diary_pro.Properties.Settings.Default.Save();
            //----------------SAVE USER IMAGE-------------------
            if (this.openFileDialog1.FileName!="openFileDialog1")
            {
                string fn;
                fn = this.openFileDialog1.FileName;
                //----------------------
                string df;
                df = Application.StartupPath + "\\data\\user_pics\\profile.png";
                System.IO.File.Copy(fn, df, true);
            }
            //--------------------------------------------------
            MessageBox.Show("Done");

        }

        private void users_mang_Load(object sender, EventArgs e)
        {
            user_info_loader();
            
        }

        public void user_info_loader()
        {
            this.user_name_tbox.Text = Diary_pro.Properties.Settings.Default.User_name;
            this.pass_box.Text = Diary_pro.Properties.Settings.Default.User_pass;
            //------------------ LOAD USER PIC-----------------------------
            string df;
            df = Application.StartupPath + "\\data\\user_pics\\profile.png";
            this.pictureBox1.Load(df);
        }
    }
}
