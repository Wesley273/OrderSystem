using System;
using System.Data;
using System.Windows.Forms;

namespace OrderSystem
{

    public partial class Login : Form
    {
        private BasicInfo.Customer customer = new BasicInfo.Customer();
        public Login()
        {
            InitializeComponent();

        }
        public void GetLoginState()
        {
            customer.AccountNumber = textBox1.Text.Trim();
            DataSet dataSet = customer.Login();
            customer.State = 1;
            customer.Name = dataSet.Tables[0].Rows[0][1].ToString().Trim();
            customer.ChangeInfo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                label3.Text = "账号不能为空";
                textBox1.Focus();
                return;
            }
            else
            if (textBox2.Text.Trim() == "")
            {
                label3.Text = "密码不能为空";
                textBox1.Focus();
                return;
            }
            else
            if (radioButton2.Checked)
            {
                try
                {
                    DataSet dataSet = null;
                    customer.AccountNumber = textBox1.Text.Trim();
                    customer.Password = textBox2.Text.Trim();
                    dataSet = customer.Login();
                    if (dataSet == null || dataSet.Tables.Count == 0 || (dataSet.Tables.Count == 1 && dataSet.Tables[0].Rows.Count == 0))
                    {
                        MessageBox.Show("用户名错误！");
                        return;
                    }
                    else
                    if (dataSet.Tables[0].Rows[0][2].ToString().Trim() != textBox2.Text.Trim())
                    { MessageBox.Show("密码错误"); }
                    else
                    {
                        MessageBox.Show("登录成功！");
                        GetLoginState();
                        CustomerPage customerPage = new CustomerPage(Convert.ToString(textBox1.Text));
                        customerPage.Show();
                        this.Hide();
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            if (radioButton1.Checked)
            {
                if (textBox1.Text.Trim() == "merchant" && textBox2.Text.Trim() == "123456")
                {
                    MessageBox.Show("登录成功");
                    MerchantPage merchantPage = new MerchantPage();
                    merchantPage.Show();
                    this.Hide();
                }
                else { MessageBox.Show("账号或密码错误！请重新输入！"); return; }
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
