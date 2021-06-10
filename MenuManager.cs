using System;
using System.Data;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class MenuManager : Form
    {
        BasicInfo.Menu menu = new BasicInfo.Menu();
        int controlerState = 0;//控件状态标志
        public static string path;
        public MenuManager()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            numberTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            specificationTextBox.Text = string.Empty;
            typeTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
        }

        private void CancelEnabled()
        {
            groupBox1.Enabled = false;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
        }
        private void LoadEnabled()
        {
            groupBox1.Enabled = false;
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
        }
        private void EditEnabled()
        {
            groupBox1.Enabled = true;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
        }
        private void AddEnabled()
        {
            priceTextBox.Text = "";
            specificationTextBox.Text = "";
            numberTextBox.Text = "";
            nameTextBox.Text = "";
            typeTextBox.Text = "";
            groupBox1.Enabled = true;
            addButton.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
        }
        private void MenuShop_Load(object sender, EventArgs e)
        {
            LoadEnabled();
            dataGridView1.DataSource = menu.ShowMenu().Tables[0].DefaultView;//展示菜品信息
            Console.WriteLine(menu.ShowMenu().Tables[0]);
            SetdataGridView1HeadText();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numberTextBox.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品编号
            nameTextBox.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品全称
            specificationTextBox.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品规格
            typeTextBox.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品类型
            priceTextBox.Text = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品单价
            descriptionTextBox.Text = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();//显示菜品描述
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("删除--菜品数据--失败！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            menu.Number = numberTextBox.Text.Trim();
            menu.Delete();
            MessageBox.Show("删除--库存商品数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = menu.ShowMenu().Tables[0].DefaultView;
            this.SetdataGridView1HeadText();
            this.ClearText();//清空文本框
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (controlerState == 0)
            {
                try
                {
                    //添加数据
                    menu.Number = numberTextBox.Text;
                    menu.Name = nameTextBox.Text;
                    menu.Specification = specificationTextBox.Text;
                    menu.Type = typeTextBox.Text;
                    menu.Price = float.Parse(priceTextBox.Text.Trim());
                    menu.Description = descriptionTextBox.Text;
                    //执行添加操作
                    menu.AddMenu();
                    MessageBox.Show("新增--库存商品数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //修改数据
                menu.Number = numberTextBox.Text;
                menu.Name = nameTextBox.Text;
                menu.Specification = specificationTextBox.Text;
                menu.Type = typeTextBox.Text;
                menu.Price = float.Parse(priceTextBox.Text.Trim());
                menu.Description = descriptionTextBox.Text.Trim();
                //执行修改操作
                menu.UpdateMenu();
                MessageBox.Show("修改--库存商品数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = menu.ShowMenu().Tables[0].DefaultView;
            this.SetdataGridView1HeadText();
            CancelEnabled();//设置各个按钮的可用状态
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelEnabled();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            controlerState = 1;
            EditEnabled();
        }

        private void tlBtnAdd_Click(object sender, EventArgs e)
        {
            AddEnabled();
            controlerState = 0;
        }

        private void choosePictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\Wesley\Desktop";
            openFileDialog1.Filter = "bmp 文件(*.bmp)|*.bmp|gif 文件(*.gif)|*.gif|jpg 文件(*.jpg)|*.jpg|png 文件(*.png)|*.png";
            //设置为3，默认打开对话框中显示的文件是所有文件
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "选择图片";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                ShowDish dish = new ShowDish();
                dish.Show();
            }
        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelsj_Click(object sender, EventArgs e)
        {

        }

        private void tlCmbStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tlCmbStockType.Text.Trim() == "全部")
            {
                dataGridView1.DataSource = menu.ShowMenu().Tables[0].DefaultView;
                this.SetdataGridView1HeadText();
                return;
            }
            else
            {
                menu.Type = tlCmbStockType.Text;
                DataSet dataSet = menu.SearchByType();
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                this.SetdataGridView1HeadText();
            }
        }

        private void MenuManager_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void MenuManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
