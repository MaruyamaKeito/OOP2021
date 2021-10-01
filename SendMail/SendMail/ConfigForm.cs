using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings setting = Settings.getInstance();
        public ConfigForm()
        {
            InitializeComponent();
        }
        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = setting.sHost(); //ホスト名
            tbPort.Text = setting.sPort(); //ポート番号
            tbUserName.Text = setting.sMailAddr(); //ユーザー名
            tbPass.Text = setting.sPass(); //パスワード
            cbSsl.Checked = setting.bSsl(); //SSL
            tbSender.Text = setting.sMailAddr(); //送信元
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            settingregist();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            settingregist();
        }
        private void settingregist()
        {
            setting.Host = tbHost.Text;
            setting.Port = int.Parse(tbPort.Text);
            setting.MailAddr = tbUserName.Text;
            setting.Pass = tbPass.Text;
            setting.Ssl = cbSsl.Checked;
        }
    }
}
