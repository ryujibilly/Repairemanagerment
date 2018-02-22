using Repairemanagerment.BLL;
using System;
using System.Windows.Forms;

namespace Repairemanagerment
{
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
            btn_login.Click += new EventHandler(btn_login_Click);
            btn_cancle.Click += new EventHandler(btn_cancle_Click);
        }
        public DialogResult r;
        private void btn_login_Click(object sender, EventArgs e)
        {
            repaireUserManager repaireUserManager = new repaireUserManager();
            if (repaireUserManager.IsLogin(txt_name.Text.Trim(), txt_pass.Text.Trim()))
            {
                CommonInfo.userName = txt_name.Text;
                r = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }
        }
        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {

        }
    }
}
