
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.rbFavorite1 = new System.Windows.Forms.RadioButton();
            this.rbFavorite2 = new System.Windows.Forms.RadioButton();
            this.rbFavorite3 = new System.Windows.Forms.RadioButton();
            this.rbFavorite4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(640, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 0;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 37);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(622, 148);
            this.lbRssTitle.TabIndex = 1;
            this.lbRssTitle.Click += new System.EventHandler(this.btGet_Click);
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(12, 191);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(738, 458);
            this.wbBrowser.TabIndex = 3;
            // 
            // cbUrl
            // 
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(12, 12);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(622, 20);
            this.cbUrl.TabIndex = 4;
            // 
            // rbFavorite1
            // 
            this.rbFavorite1.AutoSize = true;
            this.rbFavorite1.Location = new System.Drawing.Point(640, 37);
            this.rbFavorite1.Name = "rbFavorite1";
            this.rbFavorite1.Size = new System.Drawing.Size(57, 16);
            this.rbFavorite1.TabIndex = 5;
            this.rbFavorite1.TabStop = true;
            this.rbFavorite1.Text = "エンタメ";
            this.rbFavorite1.UseVisualStyleBackColor = true;
            this.rbFavorite1.CheckedChanged += new System.EventHandler(this.rbFavorite1_CheckedChanged);
            // 
            // rbFavorite2
            // 
            this.rbFavorite2.AutoSize = true;
            this.rbFavorite2.Location = new System.Drawing.Point(640, 60);
            this.rbFavorite2.Name = "rbFavorite2";
            this.rbFavorite2.Size = new System.Drawing.Size(61, 16);
            this.rbFavorite2.TabIndex = 6;
            this.rbFavorite2.TabStop = true;
            this.rbFavorite2.Text = "スポーツ";
            this.rbFavorite2.UseVisualStyleBackColor = true;
            this.rbFavorite2.CheckedChanged += new System.EventHandler(this.rbFavorite2_CheckedChanged);
            // 
            // rbFavorite3
            // 
            this.rbFavorite3.AutoSize = true;
            this.rbFavorite3.Location = new System.Drawing.Point(640, 83);
            this.rbFavorite3.Name = "rbFavorite3";
            this.rbFavorite3.Size = new System.Drawing.Size(47, 16);
            this.rbFavorite3.TabIndex = 7;
            this.rbFavorite3.TabStop = true;
            this.rbFavorite3.Text = "科学";
            this.rbFavorite3.UseVisualStyleBackColor = true;
            this.rbFavorite3.CheckedChanged += new System.EventHandler(this.rbFavorite3_CheckedChanged);
            // 
            // rbFavorite4
            // 
            this.rbFavorite4.AutoSize = true;
            this.rbFavorite4.Location = new System.Drawing.Point(640, 106);
            this.rbFavorite4.Name = "rbFavorite4";
            this.rbFavorite4.Size = new System.Drawing.Size(33, 16);
            this.rbFavorite4.TabIndex = 8;
            this.rbFavorite4.TabStop = true;
            this.rbFavorite4.Text = "IT";
            this.rbFavorite4.UseVisualStyleBackColor = true;
            this.rbFavorite4.CheckedChanged += new System.EventHandler(this.rbFavorite4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.rbFavorite4);
            this.Controls.Add(this.rbFavorite3);
            this.Controls.Add(this.rbFavorite2);
            this.Controls.Add(this.rbFavorite1);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.ComboBox cbUrl;
        private System.Windows.Forms.RadioButton rbFavorite1;
        private System.Windows.Forms.RadioButton rbFavorite2;
        private System.Windows.Forms.RadioButton rbFavorite3;
        private System.Windows.Forms.RadioButton rbFavorite4;
    }
}

