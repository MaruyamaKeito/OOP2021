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

namespace CarReportSystem
{
    public partial class fmMain : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain()
        {
            InitializeComponent();
            //dgv.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//アプリケーションの終了
        }

        private void pbPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void pbPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        private void btDataAdd_Click(object sender, EventArgs e)
        {
            if (cbAuthor.Text == "" || cbCarName.Text == "")
            {
                MessageBox.Show("入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarReport carReport = new CarReport
            {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            listCarReport.Add(carReport);

            setCbAuthor(cbAuthor.Text);
        }

        private CarReport.MakerGroup selectedGroup()
        {
            foreach (var rb in gbMaker.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    return (CarReport.MakerGroup)int.Parse(((String)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }
        private void setCbAuthor(string author)
        {
            if (!cbAuthor.Items.Contains(author))
            {
                cbAuthor.Items.Add(author);
            }
        }
        private void setCbCarName(string carname)
        {
            if (!cbCarName.Items.Contains(carname))
            {
                cbCarName.Items.Add(carname);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 1)
            {
                return;
            }

                //選択された行のデータを取得
                CarReport selectedCar = listCarReport[e.RowIndex];

                //取得したデータ項目を各コントロールへ設定
                dtpDate.Value = selectedCar.Date;
                cbAuthor.Text = selectedCar.Author;
                setMakerRadioButton(selectedCar.Maker);
                cbCarName.Text = selectedCar.CarName;
                tbReport.Text = selectedCar.Report;
                pbPicture.Image = selectedCar.Picture;

            
        }
        private void setMakerRadioButton(CarReport.MakerGroup mg)
        {
            switch (mg)
            {
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
        private void btSave_Click(object sender, EventArgs e)
        {
            //更新ボタンイベント処理
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    //記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  //メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   //車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    //レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);  //画像

            //データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202115DataSet);
        }

        private object ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            Image img = null;
            if (b.Length > 0)
            {
                ImageConverter imgconv = new ImageConverter();
                img = (Image)imgconv.ConvertFrom(b);
            }
            return img;
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //データグリッドビューのセレクションチェンジイベント
            if (carReportDataGridView.CurrentRow == null) return;
            try
            {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;    //日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();   //記録者
                                                                                              //メーカー（文字列 → 列挙型）
                setMakerRadioButton(
                    (CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup), carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();  //車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();   //レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);     //画像

            }
            catch(InvalidCastException)
            {
                pbPicture.Image = null;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                ssErrorLabel.Text = ex.Message; //ステータスエリアに表示
            }
#if false
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
#endif
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202115DataSet.CarReport);
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車種";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            //carReportDataGridView.Columns[6].HeaderText = "画像";
            carReportDataGridView.Columns[6].Visible = false;
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202115DataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            setMakerRadioButton(CarReport.MakerGroup.その他);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btOpen_Click_1(object sender, EventArgs e)
        {
            this.carReportTableAdapter.Fill(this.infosys202115DataSet.CarReport);
        }
    }
}
        
    

