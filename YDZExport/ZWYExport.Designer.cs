namespace YDZExport
{
    partial class ZWYExport
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
            this.configuration_list = new System.Windows.Forms.GroupBox();
            this.product_list = new System.Windows.Forms.GroupBox();
            this.check_produce = new System.Windows.Forms.CheckedListBox();
            this.product_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // configuration_list
            // 
            this.configuration_list.Location = new System.Drawing.Point(199, 12);
            this.configuration_list.Name = "configuration_list";
            this.configuration_list.Size = new System.Drawing.Size(415, 323);
            this.configuration_list.TabIndex = 13;
            this.configuration_list.TabStop = false;
            this.configuration_list.Text = "选项配置";
            // 
            // product_list
            // 
            this.product_list.Controls.Add(this.check_produce);
            this.product_list.Location = new System.Drawing.Point(12, 12);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(181, 387);
            this.product_list.TabIndex = 12;
            this.product_list.TabStop = false;
            this.product_list.Text = "可选列表";
            // 
            // check_produce
            // 
            this.check_produce.FormattingEnabled = true;
            this.check_produce.Items.AddRange(new object[] {
            "云星空",
            "易代账",
            "账益达",
            "云账房",
            "云代账",
            "芸豆",
            "大帐房",
            "慧算账",
            "柠檬云",
            "金财代账",
            "微宝",
            "亿企赢"});
            this.check_produce.Location = new System.Drawing.Point(6, 20);
            this.check_produce.Name = "check_produce";
            this.check_produce.Size = new System.Drawing.Size(169, 356);
            this.check_produce.TabIndex = 0;
            this.check_produce.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // ZWYExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 407);
            this.Controls.Add(this.configuration_list);
            this.Controls.Add(this.product_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZWYExport";
            this.Text = "Form1";
            this.product_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox configuration_list;
        private System.Windows.Forms.GroupBox product_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox check_produce;
    }
}