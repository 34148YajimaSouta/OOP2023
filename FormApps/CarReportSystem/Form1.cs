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

        }

        //追加ボタンがクリックされた時のイベントハンドラ―
        private void btAdd_Click(object sender, EventArgs e) {
            
            var carReport = new CarReport{
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker =getSelectedMarker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                
            };
            CarReports.Add(carReport);
        }
        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMarker() {
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
        private void getSelectMaker(CarReport.MakerGroup makerGroup) {
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
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        private void btDelete_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
        }

        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            getSelectMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        private void btModify_Click(object sender, EventArgs e) {

            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = getSelectedMarker();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
        }
    }
}
