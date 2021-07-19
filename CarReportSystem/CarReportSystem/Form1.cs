using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            dgv.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーションの終了
        }

        private void pbPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void pbPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuther.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            listCarReport.Add(carReport);

            setCbAuther(cbAuther.Text);
        }

        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((String)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }
        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                cbAuther.Items.Add(auther);
            }
        }
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == 1) {
                return;

                //選択された行のデータを取得
                CarReport selectedCar = listCarReport[e.RowIndex];

                //取得したデータ項目を各コントロールへ設定
                dtpDate.Value = selectedCar.Date;
                cbAuther.Text = selectedCar.Auther;
                setMakerRadioButton(selectedCar.Maker);
                cbCarName.Text = selectedCar.CarName;
                tbReport.Text = selectedCar.Report;
                pbPicture.Image = selectedCar.Picture;

            }
        }
        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgv.CurrentRow.Index);
        }

        private void btDataFix_Click(object sender, EventArgs e) {
            listCarReport[dgv.CurrentRow.Index].UpDate(dtpDate.Value, cbAuther.Text, selectedGroup(), cbCarName.Text, tbReport.Text, pbPicture.Image);
            dgv.Refresh();//コントロールの強制再描画
        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    var bf = new BinaryFormatter();
                    //バイナリ形式でシリアル化
                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void btOpen_Click(object sender, EventArgs e) {
                if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgv.DataSource = null;
                        dgv.DataSource = listCarReport;
                    }
                }catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                foreach (var item in listCarReport) {
                    setCbAuther(item.Auther);
                    setCbCarName(item.CarName);
                }
            }
        }

        private void fmMain_Load(object sender, EventArgs e) {
            dgv.Columns[5].Visible = false;
        }
    }
}
