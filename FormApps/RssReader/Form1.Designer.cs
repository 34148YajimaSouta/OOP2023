﻿
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
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btFavoInput = new System.Windows.Forms.Button();
            this.tbInputUrl = new System.Windows.Forms.TextBox();
            this.cbFavoImp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.wbBrowser.Size = new System.Drawing.Size(848, 458);
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
            this.rbFavorite1.Location = new System.Drawing.Point(642, 40);
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
            this.rbFavorite2.Location = new System.Drawing.Point(642, 62);
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
            this.rbFavorite3.Location = new System.Drawing.Point(642, 84);
            this.rbFavorite3.Name = "rbFavorite3";
            this.rbFavorite3.Size = new System.Drawing.Size(47, 16);
            this.rbFavorite3.TabIndex = 7;
            this.rbFavorite3.TabStop = true;
            this.rbFavorite3.Text = "科学";
            this.rbFavorite3.UseVisualStyleBackColor = true;
            this.rbFavorite3.CheckedChanged += new System.EventHandler(this.rbFavorite3_CheckedChanged);
            // 
            // tbInputText
            // 
            this.tbInputText.Location = new System.Drawing.Point(675, 135);
            this.tbInputText.Name = "tbInputText";
            this.tbInputText.Size = new System.Drawing.Size(121, 19);
            this.tbInputText.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "お気に入り登録";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "タイトル";
            // 
            // btFavoInput
            // 
            this.btFavoInput.Location = new System.Drawing.Point(802, 156);
            this.btFavoInput.Name = "btFavoInput";
            this.btFavoInput.Size = new System.Drawing.Size(65, 23);
            this.btFavoInput.TabIndex = 22;
            this.btFavoInput.Text = "登録";
            this.btFavoInput.UseVisualStyleBackColor = true;
            this.btFavoInput.Click += new System.EventHandler(this.btFavoInput_Click);
            // 
            // tbInputUrl
            // 
            this.tbInputUrl.Location = new System.Drawing.Point(675, 160);
            this.tbInputUrl.Name = "tbInputUrl";
            this.tbInputUrl.Size = new System.Drawing.Size(121, 19);
            this.tbInputUrl.TabIndex = 23;
            // 
            // cbFavoImp
            // 
            this.cbFavoImp.FormattingEnabled = true;
            this.cbFavoImp.Location = new System.Drawing.Point(802, 134);
            this.cbFavoImp.Name = "cbFavoImp";
            this.cbFavoImp.Size = new System.Drawing.Size(65, 20);
            this.cbFavoImp.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(810, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "登録先";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFavoImp);
            this.Controls.Add(this.tbInputUrl);
            this.Controls.Add(this.btFavoInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInputText);
            this.Controls.Add(this.rbFavorite3);
            this.Controls.Add(this.rbFavorite2);
            this.Controls.Add(this.rbFavorite1);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "RssReader";
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
        private System.Windows.Forms.TextBox tbInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btFavoInput;
        private System.Windows.Forms.TextBox tbInputUrl;
        private System.Windows.Forms.ComboBox cbFavoImp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

