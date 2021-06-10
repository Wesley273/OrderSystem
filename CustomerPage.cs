using System;
using System.Data;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class CustomerPage : Form
    {
        BasicInfo.Customer customer = new BasicInfo.Customer();
        BasicInfo.Menu menu = new BasicInfo.Menu();
        BasicInfo.Order order = new BasicInfo.Order();
        private DataSet dataSet;
        public double totalCost = 0;//消费总价

        public CustomerPage(string account)
        {
            InitializeComponent();
            order.Customer = account;
            customer.AccountNumber = account;
            DataSet dataSet = customer.Login();
            customerName.Text = dataSet.Tables[0].Rows[0][1].ToString().Trim() + "欢迎光临！";
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = menu.ShowMenu().Tables[0].DefaultView;//展示菜品信息
            dataGridView1.ReadOnly = true;
            this.SetdataGridView1HeadText();
            LoadEnable();
        }

        public void LoadEnable()
        {
            cancelButton.Enabled = false;
            saveOrderButton.Enabled = false;
            dataSet = order.SearchOrders("This Unsettled");
            if (dataSet == null || dataSet.Tables.Count == 0 || (dataSet.Tables.Count == 1 && dataSet.Tables[0].Rows.Count == 0))
            {
                //这时意味着该用户无未结账的账单
                chooseTable.Enabled = false;
                addOrderButton.Enabled = true;
                addButton.Enabled = false;
                customer.State = 1;
            }
            else
            {
                //这时意味着该用户有未结账的账单
                customer.State = 0;
                chooseTable.Text = dataSet.Tables[0].Rows[0][0].ToString().Trim();
                detailTextBox.Text = dataSet.Tables[0].Rows[0][2].ToString().Trim();
                costTextBox.Text = dataSet.Tables[0].Rows[0][3].ToString().Trim();
                chooseTable.Enabled = false;
                addOrderButton.Enabled = false;
                addButton.Enabled = true;
            }
            if (costTextBox.Text.Trim() != "")
            {
                totalCost = Convert.ToDouble(costTextBox.Text.Trim());
            }
            else
            {
                totalCost = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }
        private void SetdataGridView1HeadText()
        {
            dataGridView1.Columns[0].HeaderText = "菜品编号";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].HeaderText = "菜品名称";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].HeaderText = "菜品规格";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].HeaderText = "菜品类型";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].HeaderText = "菜品价格";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].Visible = false;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请选择您的桌号后开始点餐");
            chooseTable.Enabled = true;
            addOrderButton.Enabled = false;
            saveOrderButton.Enabled = true;
            cancelButton.Enabled = true;
            addButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (customer.State == 1)
            {
                addOrderButton.Enabled = true;
                addButton.Enabled = false;
            }
            else
            {
                try
                {
                    detailTextBox.Text = dataSet.Tables[0].Rows[0][2].ToString().Trim();
                    costTextBox.Text = dataSet.Tables[0].Rows[0][3].ToString().Trim();
                }
                catch { }
            }
            saveOrderButton.Enabled = false;
            cancelButton.Enabled = false;
            chooseTable.Enabled = false;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameTextBox.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品全称
            typeTextBox.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品类型
            priceTextBox.Text = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品价格
            descriptionTextBox.Text = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品简介
        }

        private void tlBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            saveOrderButton.Enabled = true;
            cancelButton.Enabled = true;
            detailTextBox.Text += nameTextBox.Text.Trim() + "*1;  ";
            totalCost += Convert.ToDouble(priceTextBox.Text.Trim());
            costTextBox.Text = totalCost.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (chooseTable.Text == "") { MessageBox.Show("桌号不能为空！请选择桌号！"); return; }
            //若无未结账订单
            if (customer.State == 1)
            {
                try
                {
                    order.SerialNumber = Convert.ToInt32(chooseTable.SelectedItem);
                    order.Details = detailTextBox.Text.Trim();
                    order.TotalCost = float.Parse(costTextBox.Text);
                    order.Time = DateTime.Now.ToString().Trim();
                    order.NewOrder();
                    //更新状态及dataSet
                    dataSet = order.SearchOrders("This Unsettled");
                    customer.State = 0;
                    MessageBox.Show("新增订单成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //设置按键
                    cancelButton.Enabled = false;
                    saveOrderButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //若有未结账订单
            else
            {
                //更新订单信息
                order.SerialNumber = Convert.ToInt32(chooseTable.SelectedItem);
                order.Details = detailTextBox.Text.Trim();
                order.TotalCost = float.Parse(costTextBox.Text);
                order.Update();
                dataSet = order.SearchOrders("This Unsettled");
                MessageBox.Show("菜品添加成功！");
                //设置按键
                cancelButton.Enabled = false;
                saveOrderButton.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.SerialNumber = int.Parse(chooseTable.Text.Trim());
            DataSet dataSet = order.SearchOrders("Repeat SerialNumber");
            if (dataSet == null || dataSet.Tables.Count == 0 || (dataSet.Tables.Count == 1 && dataSet.Tables[0].Rows.Count == 0))
            {
                chooseTable.Enabled = false;
            }
            else { if (customer.State == 1) MessageBox.Show("当前桌已满，请重新选择！"); }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text.Trim() == "全部")
            {
                dataGridView1.DataSource = menu.ShowMenu().Tables[0].DefaultView;
                SetdataGridView1HeadText();
                return;
            }
            else
            {
                menu.Type = toolStripComboBox1.Text;
                DataSet dataSet = menu.SearchByType();
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                SetdataGridView1HeadText();
            }
        }

        private void CustomerPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
