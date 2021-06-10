using System;
using System.Data;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class OrderManager : Form
    {
        BasicInfo.Order order = new BasicInfo.Order();
        public OrderManager()
        {
            InitializeComponent();
        }

        private void orderManagerPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = order.SearchOrders("All").Tables[0].DefaultView;//展示订单信息
            SetdataGridView1HeadText();
        }
        private void SetdataGridView1HeadText()
        {
            dataGridView1.Columns[0].HeaderText = "桌号";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].HeaderText = "顾客帐号";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].HeaderText = "订单详情";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].HeaderText = "订单总价";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].HeaderText = "订单时间";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].HeaderText = "结账状态";
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (ComboBox.Text == string.Empty)
            {
                MessageBox.Show("查询类别不能为空！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboBox.Focus();
                return;
            }
            if (ComboBox.Text.Length == 1 && int.Parse(ComboBox.Text) >= 1 && int.Parse(ComboBox.Text) <= 10)
            {
                order.SerialNumber = int.Parse(ComboBox.Text);
                DataSet dataSet = order.SearchOrders("SerialNumber");
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                this.SetdataGridView1HeadText();
                if (dataSet == null || dataSet.Tables.Count == 0 || (dataSet.Tables.Count == 1 && dataSet.Tables[0].Rows.Count == 0))
                {
                    orderDetailTextBox.Text = "";
                }
                else
                {
                    orderDetailTextBox.Text = dataSet.Tables[0].Rows[0][2].ToString().Trim();
                }
            }
            else
            {
                order.Customer = ComboBox.Text;
                DataSet dataSet = order.SearchOrders("Customer");
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                this.SetdataGridView1HeadText();
                if (dataSet == null || dataSet.Tables.Count == 0 || (dataSet.Tables.Count == 1 && dataSet.Tables[0].Rows.Count == 0))
                {
                    orderDetailTextBox.Text = "";
                }
                else
                {
                    orderDetailTextBox.Text = dataSet.Tables[0].Rows[0][2].ToString().Trim();
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ComboBox.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            orderDetailTextBox.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            totalCostLabel.Text = "本次消费总价为:" + dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ComboBox.Text.Trim() != "")
            {
                order.SerialNumber = int.Parse(ComboBox.Text.Trim());
                order.Customer = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                order.Details = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                order.TotalCost = float.Parse(dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                order.Time = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                order.Settle();
                MessageBox.Show("结账完成！");
                dataGridView1.DataSource = order.SearchOrders("All").Tables[0].DefaultView;
                SetdataGridView1HeadText();
            }
            else
            {
                MessageBox.Show("请选择正确的桌号！");
                return;
            }
        }

        private void ComboBoxzh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderDetailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox.Text.Trim() == "全部")
            {
                dataGridView1.DataSource = order.SearchOrders("All").Tables[0].DefaultView;
                return;
            }
            if (ComboBox.Text.Trim() == "已结账订单")
            {
                dataGridView1.DataSource = order.SearchOrders("Settled").Tables[0].DefaultView;
                return;
            }
            if (ComboBox.Text.Trim() == "未结账订单")
            {
                dataGridView1.DataSource = order.SearchOrders("Unsettled").Tables[0].DefaultView;
                return;
            }
        }

        private void OrderManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
