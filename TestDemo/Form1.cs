using System;
using System.Windows.Forms;
using HttpCodeLib;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Diagnostics;
namespace TestDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Net.CookieContainer cc;
        HttpItems item = new HttpItems();
        HttpHelpers http = new HttpHelpers();
        HttpResults hr;
        Wininet wnet = new Wininet();
        string BaseUrl = "bbs.msdn5.com";
        string PostUrl = "www.msdn5.com";
        string picurl = "http://www.zk5u.com/ashx/authcode.ashx?t=";
        

        private void btnGet_Click(object sender, EventArgs e)
        {

           
            Random r = new Random();
            //初始化Cookie变量
            cc = new System.Net.CookieContainer(); 
            item = new HttpItems();
            //get 主页 
            item.URL = "http://www.mp4ba.com";
            item.Cookie = "__cfduid=123456789; search_state=1463675467;";
            item.UseUnsafe = true;
            hr = http.GetHtml(item);

            string cookie = hr.Cookie;
            XJHTTP xjhttp = new XJHTTP();
            cc = xjhttp.AddCookieToContainer(cc, cookie);
            //get 验证码
            picurl += r.NextDouble();
            item.URL = picurl;
            item.Referer = BaseUrl;
            item.ResultType = ResultType.Byte; //设置返回值类型
            hr = http.GetHtml(item);

            pic.Image = http.GetImg(hr);



        }
        private void AddText(string msg)
        {
            this.Invoke(new ThreadStart(delegate
            {
                txtInfo.Text += msg + "  " + DateTime.Now.ToString() + "\r\n";
            }));

        }

        private void btnAsyncGet_Click(object sender, EventArgs e)
        {
            HttpHelpers http = new HttpHelpers();//请求发起对象
            HttpItems item = new HttpItems(); //请求设置对象
            System.Net.CookieContainer cc = new System.Net.CookieContainer();//自动处理cookie对象
            item.URL = "bbs.msdn5.com";//请求地址
            item.Container = cc;//初始化cookie  
            item.Timeout = 3 * 5000;
            Action<HttpResults> ActionCallback = new Action<HttpResults>(GetCallBack);//完成后的回调地址
            http.AsyncGetHtml(item, ActionCallback);//执行异步请求,结果在ActionCallback的回调函数(GetCallBack)中查看
        }
        /// <summary>
        /// 结果回调方法
        /// </summary>
        /// <param name="result">请求结果对象</param>
        void GetCallBack(HttpResults result)
        {
            MessageBox.Show(result.Html);
        }
        private void btnWininet_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Wininet wnet = new Wininet();
            pic.Image = wnet.GetImage(picurl);
        }

        private void btnWininetGet_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = wnet.GetData("http://www.baidu.com"); //正常请求. 
            txtInfo.Text = str;
            wnet.WininetTimeOut = 5000;
            string str1 = wnet.GetData("http://www.google.com"); //测试超时,超时后返回长度为0的字符串

            MessageBox.Show(str1);
        }
        private void btnWininetPost_Click(object sender, EventArgs e)
        {

            string PostD = string.Format("{0}", txtVcode.Text);
            string str = wnet.PostUtf8(PostUrl, PostD);
            if (!string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Wininet Post 成功");
            }
        }
        private void btnPost_Click(object sender, EventArgs e)
        {

            //post 数据
            string PostD = string.Format("{0}", txtVcode.Text);
            item.URL = PostUrl;
            item.Referer = BaseUrl;
            item.Method = "Post";
            item.IsAjax = true;
            item.ResultType = ResultType.String;
            item.Postdata = PostD;
            item.Container = cc;
            hr = http.GetHtml(item);
            if (!string.IsNullOrEmpty(hr.Html))
            {

            }
        }

        private void btnAsyncPost_Click(object sender, EventArgs e)
        {
            string PostD = string.Format("{0}", txtVcode.Text);
            item.URL = PostUrl;
            item.Referer = BaseUrl;
            item.Method = "Post";
            item.IsAjax = true;
            item.ResultType = ResultType.String;
            item.Postdata = PostD;
            item.Container = cc;
            Action<HttpResults> ActionCallback = new Action<HttpResults>(Post_AsyncCallBack);
            http.AsyncGetHtml(item, ActionCallback);
        }
        private void Post_AsyncCallBack(HttpResults hrt)
        {
            if (!string.IsNullOrEmpty(hrt.Html))
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XJHTTP xjhttp = new XJHTTP();
            string strall = "input type=\"hidden\" name=\"uuid\" value=\"0018h2ZztdI-jKb-\">";
            List<string> s = xjhttp.GetStringMids(strall, "value=\"", "\"");
            string str = xjhttp.GetStringMid(strall, "value=\"", "\"");
            string s1 = xjhttp.GetMidHtml(strall, "value=\"", "\"");

            CookieContainer cc = new CookieContainer();
            HttpResults hr = xjhttp.GetHtml(BaseUrl, cc);
            txtInfo.Text = hr.Html;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XJHTTP xjhttp = new XJHTTP();
            CookieContainer cc = new CookieContainer();
            string referer = "www.msdn5.com"; //上一次请求地址
            string postdata = "这里是提交的数据"; //post提交数据
            HttpResults hr = xjhttp.PostHtml(PostUrl, referer, postdata, true, cc);
        }

        private void btnGetWebbrowserCookie_Click(object sender, EventArgs e)
        {
            //只能以字符串方式获得
            XJHTTP xjhttp = new XJHTTP();
            string cookie = xjhttp.GetCookieByWininet("https://www.taobao.com");
            HttpHelpers http = new HttpHelpers();
            HttpItems hi = new HttpItems();
            hi = new HttpItems();

            hi.URL = "http://i.taobao.com/my_taobao.htm?spm=a21bo.7724922.1997525045.1.2gOl9t";
            hi.Cookie = cookie;
            hr = http.GetHtml(hi);
            if (hr.Html.Contains("我的淘宝"))
            {
                MessageBox.Show("登录成功");
            }

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            //保存图片的格式
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "图片保存";
            saveImageDialog.Filter = @"jpeg|*.jpg|bmp|*.bmp|gif|*.gif";

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveImageDialog.FileName.ToString();

                if (fileName != "" && fileName != null)
                {
                    string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToString();

                    System.Drawing.Imaging.ImageFormat imgformat = null;

                    if (fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            case "gif":
                                imgformat = System.Drawing.Imaging.ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("只能存取为: jpg,bmp,gif 格式");
                                break;
                        }

                    }

                    //默认保存为JPG格式  
                    if (imgformat == null)
                    {
                        imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    }
                    //常用方式,如果出现gdi+错误后请使用下面的方法
                    // pic.Image.Save("存储路径", imgformat);

                    Bitmap bmp = new Bitmap(this.pic.Image);
                    //新建第二个bitmap
                    Bitmap bmp2 = new Bitmap(bmp);
                    //将第一个bmp拷贝到bmp2中
                    Graphics draw = Graphics.FromImage(bmp2);
                    draw.DrawImage(bmp, 0, 0);
                    this.pic.Image = (Image)bmp2;//读取bmp2到picturebox
                    draw.Dispose();
                    bmp.Save("存储路径", imgformat); //用它来存储.
                    bmp.Dispose();//释放bmp文件资源
                }
            }


        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            string url = "http://1111.ip138.com/ic.asp"; //请求地址
            string ip = "127.0.0.1:8888"; //设置代理IP地址
            HttpItems item = new HttpItems();
            item.URL = url;
            item.ProxyIp = ip;
            //如果代理服务器需要用户名与密码请参考此设置
            //item.ProxyUserName = "用户名";//如果代理服务器需要用户名
            //item.ProxyPwd = "密码";//如果代理服务器需要密码
            HttpResults hr = http.GetHtml(item);
            // hr.Html; 请求具体结果  
            Wininet winet = new Wininet();
            //Post
            string postdata = "GetHtmlPro 如果传入PostData参数则认为当前是Post请求";
            string Posthtml = winet.GetDataPro(winet.GetHtmlPro(url, postdata, ip));
            //Get
            string Gethtml = winet.GetDataPro(winet.GetHtmlPro(url, "", ip));
            //使用代理请求图片时
            Image img = winet.GetImage(winet.GetHtmlPro("图片URL", "", ip));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                XJHTTP xj = new XJHTTP();
                xj.ClearIECookie();
            }
            catch (Exception)
            {  //如果清除发生异常,请在这里捕获
                throw;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            XJHTTP xj = new XJHTTP();
            xj.SetIeCookie("需要设置的URL", "字符串cookie");
            //获取字符串cookie信息方法
            // string cookie = xj.CookieTostring(cc); //从cc对象获得
            // List<Cookie> clist = xj.GetAllCookieByHttpItems(item); //从HttpItems对象获得
            //如果设置失败
            //1 读取旧cookie文件
            StringBuilder cookie = new StringBuilder(new String(' ', 2048));
            int datasize = cookie.Length;
            bool b = XJHTTP.InternetGetCookie("需要读取的URL", null, cookie, ref datasize);
            //删除旧的
            foreach (string fileName in System.IO.Directory.GetFiles(System.Environment.GetFolderPath(Environment.SpecialFolder.Cookies)))
            {
                if (fileName.ToLower().IndexOf("需要删除的URL") > 0)
                {
                    System.IO.File.Delete("需要删除的URL");
                }
            }
            //生成新的
            foreach (string c in "新cookie".Split(';'))
            {
                //重组COOKIE信息
                string[] item = c.Split('=');
                string name = item[0];
                string value = item[1] + ";expires=Sun,22-Feb-2099 00:00:00 GMT";
                XJHTTP.InternetSetCookie("需要设置的URL", name, value);
                XJHTTP.InternetSetCookie("需要设置的URL", name, value);
                XJHTTP.InternetSetCookie("需要设置的URL", name, value);
            }
            //完成后调用IE打开即可
            xj.OpenUrl("需要设置的URL");
            //或者webbrowser中打开
            webBrowser1.Navigate("需要设置的URL");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //设置httpitem属性即可携带证书
            item.CerPath = "证书绝对路径.cer";

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CookieContainer cc = new CookieContainer();
            HttpItems items = new HttpItems();
            HttpHelpers helper = new HttpHelpers();
            HttpResults hr = new HttpResults();

            string cookie = "";//字符串方式处理
            items = new HttpItems();
            //items.Container = cc; 自动处理方式
            items.Cookie = cookie;
            items.URL = "http://www.u193.com/opt.php?do=login";
            items.Referer = "http://mrtx.u193.com/";
            items.Method = "Post";
            items.Postdata = "username=ceshiyixia1&password=111111";
            items.Allowautoredirect = true;
            hr = helper.GetHtml(items);

            #region 手动处理字符串Cookie方式
            //hr.Cookie调用时会自动清理cookie 自动剔除无用信息.等同于
            // new XJHTTP().ClearCookie(hr.Cookie);
            cookie = new XJHTTP().UpdateCookie(cookie, hr.Cookie);//手动合并两个Cookie 
            #endregion


            #region 自动处理字符串Cookie方式
            //使用ref将cookie传递进方法,每次会自动合并上次与本次返回的cookie
            hr = helper.GetHtml(items, ref cookie);

            #endregion
            //第二次请求
            items = new HttpItems();
            items.URL = "http://mrtx.u193.com/";
            items.Referer = "http://mrtx.u193.com/";
            items.Cookie = cookie;
            //  items.Container = cc; 当cc无法被携带提交失败时使用字符串方式即可 
            hr = helper.GetHtml(items);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wininet wi = new Wininet();
            StringBuilder sb = new StringBuilder();
            sb.Append("Accept:text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8\r\n");
            sb.Append("Content-Type:application/x-www-form-urlencoded\r\n");
            sb.Append("Accept-Language:zh-cn\r\n");
            sb.Append("Referer:" + "http://mrtx.u193.com/");//增加referer头
            string str = wi.PostData("http://www.u193.com/opt.php?do=login", "username=ceshiyixia1&password=111111", sb);
            str = wi.GetData("http://mrtx.u193.com/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XJHTTP xj = new XJHTTP();
            item = new HttpItems();
            item.URL = "www.msdn5.com";
            hr = http.GetHtml(item);
            DateTime dt = xj.GetServerTime(hr);  //返回正常格式的时间
            //例如 Date:Sat, 14 Nov 2015 15:55:35 GMT   返回为正常的 2015-11-15 00:21:19 格式
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XJHTTP xj = new XJHTTP();
            DateTime dt = xj.GetTime4Gmt("Sat, 14 Nov 2015 17:02:33 GMT");
            //这里可以get百度或者get任意一个页面获得datetime对象
            //使用获取的对象为当前电脑校时
            xj.SetLocalTime(DateTime.Now); //使用API设置当前电脑时间
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //只返回数据头,不返回结果
            item = new HttpItems();
            item.URL = "www.msdn5.com";
            item.ResultType = ResultType.So;//设置返回结果为急速请求
            hr = http.GetHtml(item);
            //枚举的方式判断
            if (hr.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("请求成功");

            }
            //或 数字形式  HttpCode 2.4 后支持
            if (hr.StatusCodeNum == 200)
            {
                MessageBox.Show("请求成功");

            }

        }




    }
}






