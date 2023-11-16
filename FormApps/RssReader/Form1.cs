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

        private void rbFavorite2_CheckedChanged(object sender, EventArgs e) {
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

        private void rbFavorite3_CheckedChanged(object sender, EventArgs e) {
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
        }

        private void button1_Click(object sender, EventArgs e) {
            rbFavorite1.Text = tbInputText.Text;
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (rbFavorite1.Checked) {
                rbFavorite1.Text = tbInputText.Text;
                favo1 = tbInputUrl.Text;
                rbFavorite1.Checked = false;
            }else if (rbFavorite2.Checked) {
                rbFavorite2.Text = tbInputText.Text;
                favo2 = tbInputUrl.Text;
                rbFavorite2.Checked = false;
            }
            else if(rbFavorite3.Checked){
                rbFavorite3.Text = tbInputText.Text;
                favo3 = tbInputUrl.Text;
                rbFavorite3.Checked = false;
            }
            else {
            }
        }
    }
}
