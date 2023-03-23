namespace Diary_pro.My_forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice day");
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.pass_box.Text == "")
                {
                    MessageBox.Show("You must entry password!");
                    return;
                }
                //----------------------PASSWORD CODE-------------          
                if (this.pass_box.Text == Diary_pro.Properties.Settings.Default.User_pass)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your password is not correct. Try again");
                }
            }
            catch (Exception ex)
            {
                comm_class.my_error_message(ex.ToString());
            }
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
            //---------------
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }
    }
}
