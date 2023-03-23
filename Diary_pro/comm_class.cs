using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary_pro
{
    public static class comm_class
    {
        public static void my_error_message(string error_Text)
        {
           System.Windows.Forms.MessageBox.Show("Error:" + error_Text);
        }
    }
}
