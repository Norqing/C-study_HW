namespace A6
{
    partial class FormEdit
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
            GropdOrder = new GroupBox();
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            OrderiD = new DataGridViewTextBoxColumn();
            Goods = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            TelBox = new TextBox();
            CNBox = new TextBox();
            GropdOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GropdOrder
            // 
            GropdOrder.Controls.Add(dataGridView1);
            GropdOrder.Controls.Add(tableLayoutPanel1);
            GropdOrder.Location = new Point(21, 21);
            GropdOrder.Name = "GropdOrder";
            GropdOrder.Size = new Size(952, 628);
            GropdOrder.TabIndex = 0;
            GropdOrder.TabStop = false;
            GropdOrder.Text = "订单信息";
            GropdOrder.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, OrderiD, Goods, Quantity, Price, Sum });
            dataGridView1.Location = new Point(6, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(952, 320);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Number
            // 
            Number.HeaderText = "序号";
            Number.MinimumWidth = 8;
            Number.Name = "Number";
            Number.Width = 150;
            // 
            // OrderiD
            // 
            OrderiD.HeaderText = "订单号";
            OrderiD.MinimumWidth = 8;
            OrderiD.Name = "OrderiD";
            OrderiD.Width = 150;
            // 
            // Goods
            // 
            Goods.HeaderText = "货物名称";
            Goods.MinimumWidth = 8;
            Goods.Name = "Goods";
            Goods.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "数量";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "单价";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Sum
            // 
            Sum.HeaderText = "总价";
            Sum.MinimumWidth = 8;
            Sum.Name = "Sum";
            Sum.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 816F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(TelBox, 1, 1);
            tableLayoutPanel1.Controls.Add(CNBox, 1, 2);
            tableLayoutPanel1.Location = new Point(0, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.9411774F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.0588226F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.Size = new Size(952, 262);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 61);
            label1.TabIndex = 0;
            label1.Text = "订单号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(130, 55);
            label2.TabIndex = 1;
            label2.Text = "下单电话";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 116);
            label3.Name = "label3";
            label3.Size = new Size(130, 64);
            label3.TabIndex = 2;
            label3.Text = "用户名称";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 180);
            label4.Name = "label4";
            label4.Size = new Size(130, 82);
            label4.TabIndex = 3;
            label4.Text = "下单时间";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(139, 209);
            label5.Name = "label5";
            label5.Size = new Size(84, 24);
            label5.TabIndex = 4;
            label5.Text = "2024.5.1";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(139, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(483, 30);
            textBox1.TabIndex = 7;
            // 
            // TelBox
            // 
            TelBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TelBox.Location = new Point(139, 64);
            TelBox.Name = "TelBox";
            TelBox.Size = new Size(483, 30);
            TelBox.TabIndex = 8;
            // 
            // CNBox
            // 
            CNBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CNBox.Location = new Point(139, 119);
            CNBox.Name = "CNBox";
            CNBox.Size = new Size(483, 30);
            CNBox.TabIndex = 9;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 650);
            Controls.Add(GropdOrder);
            Name = "FormEdit";
            Text = "FormEdit";
            GropdOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GropdOrder;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn OrderiD;
        private DataGridViewTextBoxColumn Goods;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Sum;
        private TextBox TelBox;
        private TextBox CNBox;
    }
}