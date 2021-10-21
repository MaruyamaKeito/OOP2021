using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail
{
    public class Settings
    {
        private static Settings instance = null;

        public int Port { get; set; }//ポート番号
        public string Host { get; set; }//ホスト名
        public string MailAddr { get; set; }//メールアドレス
        public string Pass { get; set; }//パスワード
        public bool Ssl { get; set; }//SSL

        //コンストラクタ
        private Settings() 
        {

        }

        //インスタンスの取得
        public static Settings getInstance()
        {
            if(instance == null)
            {
                instance = new Settings();
                //XMLファイルを読み込み(逆シリアル化)
                using (var reader = XmlReader.Create("mailsettings.xml"))
                {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    var readSettings = serializer.ReadObject(reader) as Settings;

                    instance.Host = readSettings.Host;
                    instance.Port = readSettings.Port;
                    instance.MailAddr = readSettings.MailAddr;
                    instance.Pass = readSettings.Pass;
                    instance.Ssl = readSettings.Ssl;
                }
            }
            return instance;
        }
        //送信データ登録
        public void setSendConfig(string host,string port,string pass,bool ssl)
        {
            Host = host;
            Port = port;
            MailAddr = MailAddr;
        }

        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";
        }
        public string sPort()
        {
            return 587.ToString();
        }
        public string sMailAddr()
        {
            return "ojsinfosys01@gmail.com";
        }
        public string sPass()
        {
            return "Infosys2021";
        }
        public bool bSsl()
        {
            return true;
        }
    }
}