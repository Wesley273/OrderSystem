using System;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class MerchantPage : Form
    {
        public static MenuManager menuManagerPage = new MenuManager();
        public static OrderManager orderManagerPage = new OrderManager();
        public MerchantPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuManagerPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderManagerPage.Show();
        }

        private void MerchantPage_Load(object sender, EventArgs e)
        {

        }

        private void MerchantPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }
    }
}
