namespace A6
{
    partial class FormDetailEdit
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Goods = new Label();
            Quantity = new Label();
            comboBox1 = new ComboBox();
            txtGoodsQuantity = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0812721F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.91873F));
            tableLayoutPanel1.Controls.Add(Goods, 0, 0);
            tableLayoutPanel1.Controls.Add(Quantity, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(txtGoodsQuantity, 1, 1);
            tableLayoutPanel1.Location = new Point(84, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.52941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.47059F));
            tableLayoutPanel1.Size = new Size(566, 139);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Goods
            // 
            Goods.Anchor = AnchorStyles.Right;
            Goods.AutoSize = true;
            Goods.Location = new Point(59, 21);
            Goods.Name = "Goods";
            Goods.Size = new Size(46, 24);
            Goods.TabIndex = 0;
            Goods.Text = "货物";
            // 
            // Quantity
            // 
            Quantity.Anchor = AnchorStyles.Right;
            Quantity.AutoSize = true;
            Quantity.Location = new Point(59, 91);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(46, 24);
            Quantity.TabIndex = 1;
            Quantity.Text = "数量";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 32);
            comboBox1.TabIndex = 2;
            // 
            // txtGoodsQuantity
            // 
            txtGoodsQuantity.Anchor = AnchorStyles.Left;
            txtGoodsQuantity.Location = new Point(111, 88);
            txtGoodsQuantity.Name = "txtGoodsQuantity";
            txtGoodsQuantity.Size = new Size(312, 30);
            txtGoodsQuantity.TabIndex = 3;
            // 
            // FormDetailEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormDetailEdit";
            Text = "FormDetailEdit";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Goods;
        private Label Quantity;
        private ComboBox comboBox1;
        private TextBox txtGoodsQuantity;
    }
}