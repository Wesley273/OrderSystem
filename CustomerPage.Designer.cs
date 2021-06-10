namespace OrderSystem
{
    partial class CustomerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addOrderButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveOrderButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.customerName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labellx = new System.Windows.Forms.Label();
            this.labeldj = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.chooseTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(782, 827);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.addOrderButton,
            this.toolStripSeparator3,
            this.saveOrderButton,
            this.toolStripSeparator11,
            this.cancelButton,
            this.toolStripSeparator8});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1278, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripLabel1.Font = new System.Drawing.Font("等线", 9F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 24);
            this.toolStripLabel1.Text = "查询类别";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "凉菜",
            "炒菜",
            "烧菜",
            "汤/饮品"});
            this.toolStripComboBox1.BackColor = System.Drawing.Color.White;
            this.toolStripComboBox1.Font = new System.Drawing.Font("等线", 9F);
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "全部",
            "凉菜",
            "烧菜",
            "汤/饮品",
            "炒菜"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(136, 29);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.Color.White;
            this.addOrderButton.Font = new System.Drawing.Font("等线", 9F);
            this.addOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("addOrderButton.Image")));
            this.addOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(105, 24);
            this.addOrderButton.Text = "新建订单";
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.BackColor = System.Drawing.Color.White;
            this.saveOrderButton.Font = new System.Drawing.Font("等线", 9F);
            this.saveOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("saveOrderButton.Image")));
            this.saveOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(105, 24);
            this.saveOrderButton.Text = "保存订单";
            this.saveOrderButton.ToolTipText = "保存";
            this.saveOrderButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 29);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.Font = new System.Drawing.Font("等线", 9F);
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 24);
            this.cancelButton.Text = "取消";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 29);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.BackColor = System.Drawing.Color.Transparent;
            this.customerName.Font = new System.Drawing.Font("等线", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.customerName.Location = new System.Drawing.Point(816, 54);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(156, 29);
            this.customerName.TabIndex = 2;
            this.customerName.Text = "Your Name";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTime.Location = new System.Drawing.Point(818, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(98, 18);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "当前时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 9F);
            this.label2.Location = new System.Drawing.Point(817, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "当前已选菜品：";
            // 
            // detailTextBox
            // 
            this.detailTextBox.Font = new System.Drawing.Font("等线", 9F);
            this.detailTextBox.Location = new System.Drawing.Point(821, 645);
            this.detailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailTextBox.Size = new System.Drawing.Size(387, 179);
            this.detailTextBox.TabIndex = 18;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("等线", 9F);
            this.labelname.Location = new System.Drawing.Point(817, 170);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(99, 19);
            this.labelname.TabIndex = 4;
            this.labelname.Text = "菜品名称：";
            // 
            // labellx
            // 
            this.labellx.AutoSize = true;
            this.labellx.Font = new System.Drawing.Font("等线", 9F);
            this.labellx.Location = new System.Drawing.Point(817, 215);
            this.labellx.Name = "labellx";
            this.labellx.Size = new System.Drawing.Size(99, 19);
            this.labellx.TabIndex = 5;
            this.labellx.Text = "菜品类型：";
            // 
            // labeldj
            // 
            this.labeldj.AutoSize = true;
            this.labeldj.Font = new System.Drawing.Font("等线", 9F);
            this.labeldj.Location = new System.Drawing.Point(1052, 170);
            this.labeldj.Name = "labeldj";
            this.labeldj.Size = new System.Drawing.Size(99, 19);
            this.labeldj.TabIndex = 6;
            this.labeldj.Text = "菜品单价：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("等线", 9F);
            this.nameTextBox.Location = new System.Drawing.Point(905, 170);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(128, 19);
            this.nameTextBox.TabIndex = 7;
            // 
            // typeTextBox
            // 
            this.typeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeTextBox.Font = new System.Drawing.Font("等线", 9F);
            this.typeTextBox.Location = new System.Drawing.Point(904, 215);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(128, 19);
            this.typeTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("等线", 9F);
            this.priceTextBox.Location = new System.Drawing.Point(1138, 170);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(128, 19);
            this.priceTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Font = new System.Drawing.Font("等线", 9F);
            this.addButton.Location = new System.Drawing.Point(1111, 491);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 38);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "添加菜品";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 9F);
            this.label3.Location = new System.Drawing.Point(817, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "当前菜品总价：";
            // 
            // costTextBox
            // 
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTextBox.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costTextBox.Location = new System.Drawing.Point(947, 552);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(128, 19);
            this.costTextBox.TabIndex = 14;
            // 
            // chooseTable
            // 
            this.chooseTable.Font = new System.Drawing.Font("等线", 9F);
            this.chooseTable.FormattingEnabled = true;
            this.chooseTable.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.chooseTable.Location = new System.Drawing.Point(981, 108);
            this.chooseTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chooseTable.Name = "chooseTable";
            this.chooseTable.Size = new System.Drawing.Size(83, 27);
            this.chooseTable.TabIndex = 15;
            this.chooseTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 9F);
            this.label4.Location = new System.Drawing.Point(817, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "请选择您的桌号：";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AcceptsReturn = true;
            this.descriptionTextBox.Font = new System.Drawing.Font("等线", 10F);
            this.descriptionTextBox.Location = new System.Drawing.Point(821, 295);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.Size = new System.Drawing.Size(387, 155);
            this.descriptionTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线", 9F);
            this.label5.Location = new System.Drawing.Point(817, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "简介";
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 853);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.chooseTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labeldj);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.labellx);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerPage_FormClosing);
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton addOrderButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.ToolStripButton saveOrderButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labellx;
        private System.Windows.Forms.Label labeldj;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.ComboBox chooseTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label5;
    }
}