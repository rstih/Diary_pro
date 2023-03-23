using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_pro.My_forms
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            
            Int32 ic;
            ic = Diary_pro.Properties.Settings.Default.last_memo_id;
            //---------------
            Int32 i;
            for (i = 1; i <= ic; i++)
            {
                this.listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Diary_pro.My_forms.memo_form mf_form = new My_forms.memo_form();
            //mf_form.MdiParent = this;
            mf_form.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fn;
                string fn_title;
                string fn_date;
                Int32 last_id;
                Int32.TryParse(this.listBox1.Text, out last_id);
                //---------------------------------------------------
                fn = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";
                fn_title = Application.StartupPath + "\\data\\docs\\title_" + last_id.ToString() + ".txt";
                fn_date = Application.StartupPath + "\\data\\docs\\date_" + last_id.ToString() + ".txt";
                //--------load memo data-----------------------------
                this.richTextBox1.LoadFile(fn);
                this.title_textBox1.Text = System.IO.File.ReadAllText(fn_title, Encoding.UTF8);
                this.date_textBox2.Text = System.IO.File.ReadAllText(fn_date, Encoding.UTF8);
                //this.memo_Id_textBox1.Text = last_id.ToString();
                //-------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 i;
                i = this.listBox1.FindStringExact(this.search_box.Text);
                this.listBox1.SelectedIndex = i;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString);
            }
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            { 
            button2_Click(sender, e);
            }
        }
    }
}
