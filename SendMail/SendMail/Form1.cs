using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class Form1 : Form
    {
        private Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                //アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先
                mailMessage.To.Add(tbTo.Text);
                if (tbCc.Text != "")
                {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbBcc.Text != "")
                {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }

                //件名
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使って送信する
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new NetworkCredential(settings.MailAddr,settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;

                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);

                //MessageBox.Show("送信完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //XMLファイルを読み込み(逆シリアル化)
            using (var reader = XmlReader.Create("mailsettings.xml"))
            {
                var serializer = new DataContractSerializer(typeof(Settings));
                var readSettings = serializer.ReadObject(reader) as Settings;
                settings.Host = readSettings.Host;
                settings.Port = readSettings.Port;
                settings.MailAddr = readSettings.MailAddr;
                settings.Pass = readSettings.Pass;
                settings.Ssl = readSettings.Ssl;
            }
        }
    }
}