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
            var CarReport = new CarReport{
                Date = dtpDate.Value,
                
            };
            CarReports.Add(CarReport);
        }

        private CarReport.MakerGroup getSelectedMarker() {

            return CarReport.MakerGroup.トヨタ;
        }
    }
}
