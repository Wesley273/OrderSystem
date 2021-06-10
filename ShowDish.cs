using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace OrderSystem
{
    public partial class ShowDish : Form
    {
        public string result;
        public string name;
        public string calorie;
        public string description;
        public ShowDish()
        {
            InitializeComponent();
            ShowDetails();
        }
        // 菜品识别
        private void Dish()
        {
            string token = "24.ea9ed2960ab93a1c2b84f53f20bac36e.2592000.1609772933.282335-23104315";
            string host = "https://aip.baidubce.com/rest/2.0/image-classify/v2/dish?access_token=" + token;
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.KeepAlive = true;
            // 图片的base64编码
            string base64 = GetFileBase64(MenuManager.path);
            string body = "image=" + HttpUtility.UrlEncode(base64) + "&top_num=" + 3 + "&baike_num=" + "1";
            byte[] buffer = encoding.GetBytes(body);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            result = reader.ReadToEnd();
            //这里将传回的JSON字符串转为字典，便于查找
            var jObject = JObject.Parse(result);
            //显示输出
            name = nameLabel.Text = (string)jObject["result"][0]["name"];
            calorie = calorieLabel.Text = (string)jObject["result"][0]["calorie"]+"大卡/100g";
            description = descriptionTextBox.Text = (string)jObject["result"][0]["baike_info"]["description"];
        }

        private string GetFileBase64(string fileName)
        {
            FileStream filestream = new FileStream(fileName, FileMode.Open);
            byte[] arr = new byte[filestream.Length];
            filestream.Read(arr, 0, (int)filestream.Length);
            string baser64 = Convert.ToBase64String(arr);
            filestream.Close();
            return baser64;
        }
        private void ShowDetails()
        {
            Stream stream = new FileStream(MenuManager.path, FileMode.Open, FileAccess.Read, FileShare.Read);
            Image image = new Bitmap(stream);
            //关闭IO，防止占用文件
            stream.Close();
            stream.Dispose();
            pictureBox1.Image = image;
            Thread myThread = new Thread(new ThreadStart(Dish));
            //这样写可以实现线程间访问而不报错
            CheckForIllegalCrossThreadCalls = false;
            myThread.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowDish_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MerchantPage.menuManagerPage.nameTextBox.Text = nameLabel.Text;
            MerchantPage.menuManagerPage.descriptionTextBox.Text = descriptionTextBox.Text + "★卡路里含量：" + calorieLabel.Text;
            this.Hide();
        }
    }
}
