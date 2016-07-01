namespace TestDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnAsyncGet = new System.Windows.Forms.Button();
            this.btnAsyncPost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnGetWebbrowserCookie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVcode = new System.Windows.Forms.TextBox();
            this.btnWininet = new System.Windows.Forms.Button();
            this.btnWininetPost = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnWininetGet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(241, 20);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(99, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "测试普通Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(241, 49);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(99, 23);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "测试普通Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnAsyncGet
            // 
            this.btnAsyncGet.Location = new System.Drawing.Point(504, 20);
            this.btnAsyncGet.Name = "btnAsyncGet";
            this.btnAsyncGet.Size = new System.Drawing.Size(95, 23);
            this.btnAsyncGet.TabIndex = 2;
            this.btnAsyncGet.Text = "测试异步GET";
            this.btnAsyncGet.UseVisualStyleBackColor = true;
            this.btnAsyncGet.Click += new System.EventHandler(this.btnAsyncGet_Click);
            // 
            // btnAsyncPost
            // 
            this.btnAsyncPost.Location = new System.Drawing.Point(505, 49);
            this.btnAsyncPost.Name = "btnAsyncPost";
            this.btnAsyncPost.Size = new System.Drawing.Size(94, 23);
            this.btnAsyncPost.TabIndex = 3;
            this.btnAsyncPost.Text = "测试异步POST";
            this.btnAsyncPost.UseVisualStyleBackColor = true;
            this.btnAsyncPost.Click += new System.EventHandler(this.btnAsyncPost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnProxy);
            this.groupBox1.Controls.Add(this.btnSaveImage);
            this.groupBox1.Controls.Add(this.btnGetWebbrowserCookie);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtVcode);
            this.groupBox1.Controls.Add(this.btnWininet);
            this.groupBox1.Controls.Add(this.btnWininetPost);
            this.groupBox1.Controls.Add(this.pic);
            this.groupBox1.Controls.Add(this.btnWininetGet);
            this.groupBox1.Controls.Add(this.btnPost);
            this.groupBox1.Controls.Add(this.btnAsyncPost);
            this.groupBox1.Controls.Add(this.btnGet);
            this.groupBox1.Controls.Add(this.btnAsyncGet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试区域";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(361, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Wininet增加自定义头";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(361, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "字符串Cookie使用";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "设置证书";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(753, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "设置IECookie并打开";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(753, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "清除IE COOKIE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProxy
            // 
            this.btnProxy.Location = new System.Drawing.Point(505, 78);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(94, 23);
            this.btnProxy.TabIndex = 12;
            this.btnProxy.Text = "使用代理访问";
            this.btnProxy.UseVisualStyleBackColor = true;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(135, 74);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 11;
            this.btnSaveImage.Text = "保存当前图像";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnGetWebbrowserCookie
            // 
            this.btnGetWebbrowserCookie.Location = new System.Drawing.Point(753, 20);
            this.btnGetWebbrowserCookie.Name = "btnGetWebbrowserCookie";
            this.btnGetWebbrowserCookie.Size = new System.Drawing.Size(169, 23);
            this.btnGetWebbrowserCookie.TabIndex = 10;
            this.btnGetWebbrowserCookie.Text = "获取Webbrowser";
            this.btnGetWebbrowserCookie.UseVisualStyleBackColor = true;
            this.btnGetWebbrowserCookie.Click += new System.EventHandler(this.btnGetWebbrowserCookie_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "一键Post";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "一键Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVcode
            // 
            this.txtVcode.Location = new System.Drawing.Point(241, 76);
            this.txtVcode.Name = "txtVcode";
            this.txtVcode.Size = new System.Drawing.Size(100, 21);
            this.txtVcode.TabIndex = 8;
            // 
            // btnWininet
            // 
            this.btnWininet.Location = new System.Drawing.Point(628, 49);
            this.btnWininet.Name = "btnWininet";
            this.btnWininet.Size = new System.Drawing.Size(119, 23);
            this.btnWininet.TabIndex = 7;
            this.btnWininet.Text = "Wininet 获取图片";
            this.btnWininet.UseVisualStyleBackColor = true;
            this.btnWininet.Click += new System.EventHandler(this.btnWininet_Click);
            // 
            // btnWininetPost
            // 
            this.btnWininetPost.Location = new System.Drawing.Point(628, 78);
            this.btnWininetPost.Name = "btnWininetPost";
            this.btnWininetPost.Size = new System.Drawing.Size(119, 23);
            this.btnWininetPost.TabIndex = 4;
            this.btnWininetPost.Text = "测试Wininet Post";
            this.btnWininetPost.UseVisualStyleBackColor = true;
            this.btnWininetPost.Click += new System.EventHandler(this.btnWininetPost_Click);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(9, 20);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(112, 75);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // btnWininetGet
            // 
            this.btnWininetGet.Location = new System.Drawing.Point(628, 20);
            this.btnWininetGet.Name = "btnWininetGet";
            this.btnWininetGet.Size = new System.Drawing.Size(119, 23);
            this.btnWininetGet.TabIndex = 4;
            this.btnWininetGet.Text = "测试Wininet Get";
            this.btnWininetGet.UseVisualStyleBackColor = true;
            this.btnWininetGet.Click += new System.EventHandler(this.btnWininetGet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1129, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(3, 17);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(1123, 135);
            this.txtInfo.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 118);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1129, 122);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("http://www.taobao.com", System.UriKind.Absolute);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(958, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "得到服务器时间";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(958, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "设置本地时间";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(958, 78);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "急速请求";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 395);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HttpCodeDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnAsyncGet;
        private System.Windows.Forms.Button btnAsyncPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnWininetGet;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnWininetPost;
        private System.Windows.Forms.Button btnWininet;
        private System.Windows.Forms.TextBox txtVcode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetWebbrowserCookie;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
    }
}

