using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    
    
    
    public partial class Form1 : Form {
        string favo1 = "https://news.yahoo.co.jp/rss/topics/it.xml";
        string favo2 = "https://news.yahoo.co.jp/rss/topics/sports.xml";
        string favo3 = "https://news.yahoo.co.jp/rss/topics/science.xml";
        //   string favo4 = "https://news.yahoo.co.jp/rss/topics/it.xml";



        //取得データ保存用
        List<ItemData> ItemDatas = new List<ItemData>();
        public Form1() {
            InitializeComponent();

        }

        private void setCbUrl(string author) {
            if (!cbUrl.Items.Contains(author)) {
                cbUrl.Items.Add(author);
            }
        }
        private void btGet_Click(object sender, EventArgs e) {
            if (cbUrl.Text == "")
                return;

            lbRssTitle.Items.Clear();
            using (var wc=new WebClient()) {
                var url = wc.OpenRead(cbUrl.Text);
                setCbUrl(cbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = (string)x.Element("title"),
                                             Link = (string)x.Element("link")
                                        }).ToList();

                foreach (var item in ItemDatas) {
                    lbRssTitle.Items.Add(item.Title);
                    
                }
                
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex == -1)
                return;
            wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);

        }

        private void rbFavorite1_CheckedChanged(object sender, EventArgs e) {
            try {
                using (var wc = new WebClient()) {
                    lbRssTitle.Items.Clear();
                    // var favo = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
                    var url = wc.OpenRead(favo1);
                    setCbUrl(favo1);
                    XDocument xdoc = XDocument.Load(url);

                    ItemDatas = xdoc.Root.Descendants("item")
                                            .Select(x => new ItemData {
                                                Title = (string)x.Element("title"),
                                                Link = (string)x.Element("link")
                                            }).ToList();

                    foreach (var item in ItemDatas) {
                        lbRssTitle.Items.Add(item.Title);

                    }

                }
            }
            catch (Exception) {
                MessageBox.Show("URLが無効です、お気に入り登録をしなおしてください");
                rbFavorite1.Checked = false;
            }
        }



        private void rbFavorite2_CheckedChanged(object sender, EventArgs e) {
            try {
                using (var wc = new WebClient()) {
                    lbRssTitle.Items.Clear();
                    //var favo = "https://news.yahoo.co.jp/rss/topics/sports.xml";
                    var url = wc.OpenRead(favo2);
                    setCbUrl(favo2);
                    XDocument xdoc = XDocument.Load(url);

                    ItemDatas = xdoc.Root.Descendants("item")
                                            .Select(x => new ItemData {
                                                Title = (string)x.Element("title"),
                                                Link = (string)x.Element("link")
                                            }).ToList();

                    foreach (var item in ItemDatas) {
                        lbRssTitle.Items.Add(item.Title);

                    }

                }
            }
            catch (Exception) {
                MessageBox.Show("URLが無効です、お気に入り登録をしなおしてください");
                rbFavorite2.Checked = false;
            }
        }

        private void rbFavorite3_CheckedChanged(object sender, EventArgs e) {
            try {
                using (var wc = new WebClient()) {
                    lbRssTitle.Items.Clear();
                    //var favo= "https://news.yahoo.co.jp/rss/topics/science.xml";
                    var url = wc.OpenRead(favo3);
                    setCbUrl(favo3);
                    XDocument xdoc = XDocument.Load(url);

                    ItemDatas = xdoc.Root.Descendants("item")
                                            .Select(x => new ItemData {
                                                Title = (string)x.Element("title"),
                                                Link = (string)x.Element("link")
                                            }).ToList();

                    foreach (var item in ItemDatas) {
                        lbRssTitle.Items.Add(item.Title);

                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("URLが無効です、お気に入り登録をしなおしてください");
                rbFavorite3.Checked = false;
            }
        }

        //private void rbFavorite4_CheckedChanged(object sender, EventArgs e) {
        //    using (var wc = new WebClient()) {
        //        lbRssTitle.Items.Clear();
        //        //var favo = "https://news.yahoo.co.jp/rss/topics/it.xml";
        //        var url = wc.OpenRead(favo4);
        //        setCbUrl(favo4);
        //        XDocument xdoc = XDocument.Load(url);

        //        ItemDatas = xdoc.Root.Descendants("item")
        //                                .Select(x => new ItemData {
        //                                    Title = (string)x.Element("title"),
        //                                    Link = (string)x.Element("link")
        //                                }).ToList();

        //        foreach (var item in ItemDatas) {
        //            lbRssTitle.Items.Add(item.Title);

        //        }

        //    }
        //}

        private void Form1_Load(object sender, EventArgs e) {
            chengecbFavoImp();
        }

       private void chengecbFavoImp() {
            cbFavoImp.Items.Clear();
            cbFavoImp.Items.Add("*未選択*");
            cbFavoImp.SelectedIndex = 0;
            cbFavoImp.Items.Add(rbFavorite1.Text);
            cbFavoImp.Items.Add(rbFavorite2.Text);
            cbFavoImp.Items.Add(rbFavorite3.Text);
        }


        private void btFavoInput_Click(object sender, EventArgs e) {
            if (tbInputText.Text != string.Empty) {
                if (tbInputUrl.Text != string.Empty) {
                    if (rbFavorite1.Text == cbFavoImp.SelectedItem.ToString()) {
                        rbFavorite1.Text = tbInputText.Text;
                        favo1 = tbInputUrl.Text;
                        rbFavorite1.Checked = false;
                        chengecbFavoImp();
                    }
                    else if (rbFavorite2.Text == cbFavoImp.SelectedItem.ToString()) {
                        rbFavorite2.Text = tbInputText.Text;
                        favo2 = tbInputUrl.Text;
                        rbFavorite2.Checked = false;
                        chengecbFavoImp();
                    }
                    else if (rbFavorite3.Text == cbFavoImp.SelectedItem.ToString()) {
                        rbFavorite3.Text = tbInputText.Text;
                        favo3 = tbInputUrl.Text;
                        rbFavorite3.Checked = false;
                        chengecbFavoImp();
                    }
                    else {
                    }
                }
            }

        }
    }
}
