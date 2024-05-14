namespace A6
{
    partial class FormParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrderMainLink = new LinkLabel();
            OrderAdd = new Label();
            seperatorLabel = new Label();
            contentPanel = new Panel();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrderMainLink
            // 
            OrderMainLink.AutoSize = true;
            OrderMainLink.Enabled = false;
            OrderMainLink.Font = new Font("华文宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderMainLink.Location = new Point(3, 9);
            OrderMainLink.Name = "OrderMainLink";
            OrderMainLink.Size = new Size(108, 27);
            OrderMainLink.TabIndex = 0;
            OrderMainLink.TabStop = true;
            OrderMainLink.Text = "订单管理";
            // 
            // OrderAdd
            // 
            OrderAdd.AutoSize = true;
            OrderAdd.Font = new Font("华文宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderAdd.Location = new Point(148, 8);
            OrderAdd.Name = "OrderAdd";
            OrderAdd.Size = new Size(108, 27);
            OrderAdd.TabIndex = 1;
            OrderAdd.Text = "添加订单";
            // 
            // seperatorLabel
            // 
            seperatorLabel.AutoSize = true;
            seperatorLabel.Location = new Point(117, 11);
            seperatorLabel.Name = "seperatorLabel";
            seperatorLabel.Size = new Size(15, 24);
            seperatorLabel.TabIndex = 2;
            seperatorLabel.Text = "|";
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(seperatorLabel);
            contentPanel.Controls.Add(OrderMainLink);
            contentPanel.Controls.Add(OrderAdd);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(4);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(789, 486);
            contentPanel.TabIndex = 1;
            contentPanel.TabStop = true;
            // 
            // FormParent
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 486);
            Controls.Add(contentPanel);
            Name = "FormParent";
            Text = "Form1";
            Load += FormParent_Load;
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel OrderMainLink;
        private Label OrderAdd;
        private Label seperatorLabel;
        private Panel contentPanel;
    }
}