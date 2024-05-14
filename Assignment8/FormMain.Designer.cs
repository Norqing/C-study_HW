namespace A6
{ 
    partial class FormMain
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
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            OrderiD = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerPhone = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            OrderPrice = new DataGridViewTextBoxColumn();
            Goods = new DataGridViewTextBoxColumn();
            OrderQuantity = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            OrderAdd_B = new Button();
            OrderDelete_B = new Button();
            OrderFlesh = new Button();
            OrderDetail_B = new Button();
            cbxField = new ComboBox();
            txtKeyword = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Ordersearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderiD, CustomerName, CustomerPhone, OrderTime, OrderPrice, Goods, OrderQuantity });
            dataGridView1.Location = new Point(29, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(1090, 317);
            dataGridView1.TabIndex = 0;
            // 
            // OrderiD
            // 
            OrderiD.HeaderText = "订单号";
            OrderiD.MinimumWidth = 8;
            OrderiD.Name = "OrderiD";
            OrderiD.Width = 150;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "客户名";
            CustomerName.MinimumWidth = 8;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 150;
            // 
            // CustomerPhone
            // 
            CustomerPhone.HeaderText = "客户电话";
            CustomerPhone.MinimumWidth = 8;
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.Width = 150;
            // 
            // OrderTime
            // 
            OrderTime.HeaderText = "订单创建时间";
            OrderTime.MinimumWidth = 8;
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 150;
            // 
            // OrderPrice
            // 
            OrderPrice.HeaderText = "订单金额";
            OrderPrice.MinimumWidth = 8;
            OrderPrice.Name = "OrderPrice";
            OrderPrice.Width = 150;
            // 
            // Goods
            // 
            Goods.HeaderText = "货物名称";
            Goods.MinimumWidth = 8;
            Goods.Name = "Goods";
            Goods.Width = 150;
            // 
            // OrderQuantity
            // 
            OrderQuantity.HeaderText = "数量";
            OrderQuantity.MinimumWidth = 8;
            OrderQuantity.Name = "OrderQuantity";
            OrderQuantity.Width = 150;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 678);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1173, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // OrderAdd_B
            // 
            OrderAdd_B.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderAdd_B.ForeColor = Color.Black;
            OrderAdd_B.Location = new Point(3, 3);
            OrderAdd_B.Name = "OrderAdd_B";
            OrderAdd_B.Size = new Size(248, 57);
            OrderAdd_B.TabIndex = 3;
            OrderAdd_B.Text = "订单添加";
            OrderAdd_B.UseVisualStyleBackColor = true;
            OrderAdd_B.Click += button1_Click;
            // 
            // OrderDelete_B
            // 
            OrderDelete_B.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderDelete_B.ForeColor = Color.Black;
            OrderDelete_B.Location = new Point(3, 66);
            OrderDelete_B.Name = "OrderDelete_B";
            OrderDelete_B.Size = new Size(248, 61);
            OrderDelete_B.TabIndex = 5;
            OrderDelete_B.Text = "订单删除";
            OrderDelete_B.UseVisualStyleBackColor = true;
            // 
            // OrderFlesh
            // 
            OrderFlesh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderFlesh.ForeColor = Color.Black;
            OrderFlesh.Location = new Point(257, 66);
            OrderFlesh.Name = "OrderFlesh";
            OrderFlesh.Size = new Size(249, 61);
            OrderFlesh.TabIndex = 6;
            OrderFlesh.Text = "刷新";
            OrderFlesh.UseVisualStyleBackColor = true;
            // 
            // OrderDetail_B
            // 
            OrderDetail_B.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderDetail_B.ForeColor = Color.Black;
            OrderDetail_B.Location = new Point(257, 3);
            OrderDetail_B.Name = "OrderDetail_B";
            OrderDetail_B.Size = new Size(249, 57);
            OrderDetail_B.TabIndex = 4;
            OrderDetail_B.Text = "订单修改";
            OrderDetail_B.UseVisualStyleBackColor = true;
            // 
            // cbxField
            // 
            cbxField.FormattingEnabled = true;
            cbxField.Items.AddRange(new object[] { "全部订单", "ID", "客户名", "客户电话", "货物名", "价格大于", "订单金额" });
            cbxField.Location = new Point(3, 3);
            cbxField.Name = "cbxField";
            cbxField.Size = new Size(174, 32);
            cbxField.TabIndex = 7;
            // 
            // txtKeyword
            // 
            txtKeyword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKeyword.Location = new Point(183, 3);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(252, 30);
            txtKeyword.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(OrderDelete_B, 0, 1);
            tableLayoutPanel1.Controls.Add(OrderFlesh, 1, 1);
            tableLayoutPanel1.Controls.Add(OrderDetail_B, 1, 0);
            tableLayoutPanel1.Controls.Add(OrderAdd_B, 0, 0);
            tableLayoutPanel1.Location = new Point(610, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3333321F));
            tableLayoutPanel1.Size = new Size(509, 130);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.09589F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.90411F));
            tableLayoutPanel2.Controls.Add(cbxField, 0, 0);
            tableLayoutPanel2.Controls.Add(txtKeyword, 1, 0);
            tableLayoutPanel2.Location = new Point(61, 89);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(438, 41);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // Ordersearch
            // 
            Ordersearch.ForeColor = Color.Black;
            Ordersearch.Location = new Point(196, 166);
            Ordersearch.Name = "Ordersearch";
            Ordersearch.Size = new Size(112, 34);
            Ordersearch.TabIndex = 11;
            Ordersearch.Text = "查询";
            Ordersearch.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 700);
            Controls.Add(Ordersearch);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            ForeColor = Color.Aqua;
            Name = "FormMain";
            Text = "订单展示";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private StatusStrip statusStrip1;
        private Button OrderAdd_B;
        private Button OrderDelete_B;
        private Button OrderFlesh;
        private Button OrderDetail_B;
        private ComboBox cbxField;
        private TextBox txtKeyword;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn OrderiD;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerPhone;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn OrderPrice;
        private DataGridViewTextBoxColumn Goods;
        private DataGridViewTextBoxColumn OrderQuantity;
        private Button Ordersearch;
    }
}