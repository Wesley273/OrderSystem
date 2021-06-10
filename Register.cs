using System;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Register : Form
    {
        BasicInfo.Customer customer = new BasicInfo.Customer();
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("账号不能为空！");
            }
            else
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("用户名错误，请规范填写2-8位");
            }
            else
            if (textBox3.Text.Trim() == "" || textBox3.Text.Length < 6 || textBox3.Text.Length > 12)
            {
                MessageBox.Show("密码错误，请规范填写6-12位！");
            }
            else
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("密码错误，请规范填写6-12位!");
            }
            else
            if (textBox3.Text.Trim() != textBox4.Text.Trim())
            {
                MessageBox.Show("两次输入密码必须一致!");
            }
            else
            {
                try
                {
                    customer.AccountNumber = textBox1.Text.Trim();
                    customer.Name = textBox2.Text.Trim();
                    customer.Password = textBox3.Text.Trim();
                    customer.State = 0;
                    customer.Register();
                    if (MessageBox.Show("注册成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Login loginPage = new Login();
                        loginPage.Show();
                        Hide();
                    };

                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
            }
        }


        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
