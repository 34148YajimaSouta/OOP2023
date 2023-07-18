using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        private void Form1_Load(object sender, EventArgs e) {
            btDelete.Enabled = false;
            btModify.Enabled = false;
        }

        //追加ボタンがクリックされた時のイベントハンドラ―
        private void btAdd_Click(object sender, EventArgs e) {
            
            var carReport = new CarReport{
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker =getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage =pbCarImage.Image,
            };
            if (cbAuthor.Text == "") {
                tsInfoText.Text = "記録者を入力してください";
               
                return;
            }else if(cbCarName.Text == "") {
                tsInfoText.Text = "車名を入力してください";
               
                return;
            }
            CarReports.Add(carReport);
            clearselect();
            btDelete.Enabled = true;
            btModify.Enabled = true;
            tsInfoText.Text="";
            editItemClear();
        }

        private void editItemClear() {
            cbAuthor.Text = "";
            setSelectedMaker(CarReport.MakerGroup.トヨタ);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;

            dgvCarReports.ClearSelection();     //選択解除
            btModify.Enabled = false;     //修正ボタン
            btDelete.Enabled = false;
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            }
            else if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            }
            else if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            }
            else if (rbImported.Checked) {
                return CarReport.MakerGroup.輸入車;
            }
            else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            }
            else if (rbSuzuki.Checked) {
                return CarReport.MakerGroup.スズキ;
            }
            else {
                return CarReport.MakerGroup.その他;
                
            }
            //int tag = 0;
            //foreach (var item in gbMaker.Controls) {
            //    if (((RadioButton)item).Checked) {
            //        tag =int.Parse(((RadioButton)item).Tag.ToString());
            //        return (CarReport.MakerGroup)((RadioButton)item).Tag.ToString();
            //    }
            //}
            //return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
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
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }

        private void btDelete_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            if (dgvCarReports.CurrentRow == null) {
                btDelete.Enabled = false;
                btModify.Enabled = false;
            }
            editItemClear();
        }

        private void dgvCarReports_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

                btModify.Enabled = true;
                btDelete.Enabled = true;
            }
        }

        private void setCbCarName() {
            if (!cbCarName.Items.Contains(cbCarName)) {

            }
        }

        private void btModify_Click(object sender, EventArgs e) {

            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
        }

        private void clearselect() {
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            switch (getSelectedMaker()) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked =false;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = false;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = false;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = false;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = false;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = false;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = false;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = false;
                    break;
                default:
                    break;
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {

            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
            }
        }
        int mode = 0;
        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ? ++mode : 0;
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
            

        }
    }
}
