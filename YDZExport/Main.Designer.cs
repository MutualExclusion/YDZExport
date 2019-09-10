namespace YDZExport
{
    partial class Main
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pageLabel = new System.Windows.Forms.Label();
            this.allButton = new System.Windows.Forms.Button();
            this.moreButton = new System.Windows.Forms.Button();
            this.rawDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rawDataTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.向下版愉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向上版块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行业版块ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一地ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.rawDataTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.boardMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加分组ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 添加分组ToolStripMenuItem
            // 
            this.添加分组ToolStripMenuItem.Name = "添加分组ToolStripMenuItem";
            this.添加分组ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加分组ToolStripMenuItem.Text = "添加分组";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(132, 470);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(59, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(63, 470);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "撤销";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 436);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(650, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 499);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "拼接结果";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pageLabel
            // 
            this.pageLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(289, 351);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(23, 12);
            this.pageLabel.TabIndex = 3;
            this.pageLabel.Text = "0/0";
            // 
            // allButton
            // 
            this.allButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.allButton.Location = new System.Drawing.Point(329, 345);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(62, 25);
            this.allButton.TabIndex = 2;
            this.allButton.Text = "显示全部";
            this.allButton.UseVisualStyleBackColor = true;
            // 
            // moreButton
            // 
            this.moreButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.moreButton.Location = new System.Drawing.Point(212, 345);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(61, 25);
            this.moreButton.TabIndex = 1;
            this.moreButton.Text = "显示更多";
            this.moreButton.UseVisualStyleBackColor = true;
            // 
            // rawDataGrid
            // 
            this.rawDataGrid.AllowUserToAddRows = false;
            this.rawDataGrid.AllowUserToDeleteRows = false;
            this.rawDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rawDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.rawDataGrid.Location = new System.Drawing.Point(16, 21);
            this.rawDataGrid.Name = "rawDataGrid";
            this.rawDataGrid.ReadOnly = true;
            this.rawDataGrid.RowTemplate.Height = 23;
            this.rawDataGrid.Size = new System.Drawing.Size(593, 318);
            this.rawDataGrid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pageLabel);
            this.groupBox3.Controls.Add(this.allButton);
            this.groupBox3.Controls.Add(this.moreButton);
            this.groupBox3.Controls.Add(this.rawDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(3, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 379);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "账套列表";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rawDataTab
            // 
            this.rawDataTab.Controls.Add(this.groupBox3);
            this.rawDataTab.Controls.Add(this.groupBox1);
            this.rawDataTab.Location = new System.Drawing.Point(4, 22);
            this.rawDataTab.Name = "rawDataTab";
            this.rawDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.rawDataTab.Size = new System.Drawing.Size(624, 473);
            this.rawDataTab.TabIndex = 0;
            this.rawDataTab.Text = "原始数据";
            this.rawDataTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始数据筛选";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(517, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.rawDataTab);
            this.tabControl.Location = new System.Drawing.Point(12, 28);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(632, 499);
            this.tabControl.TabIndex = 11;
            // 
            // 向下版愉ToolStripMenuItem
            // 
            this.向下版愉ToolStripMenuItem.Name = "向下版愉ToolStripMenuItem";
            this.向下版愉ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.向下版愉ToolStripMenuItem.Text = "向下版块";
            // 
            // 向上版块ToolStripMenuItem
            // 
            this.向上版块ToolStripMenuItem.Name = "向上版块ToolStripMenuItem";
            this.向上版块ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.向上版块ToolStripMenuItem.Text = "向上版块";
            // 
            // 行业版块ToolStripMenuItem
            // 
            this.行业版块ToolStripMenuItem.Name = "行业版块ToolStripMenuItem";
            this.行业版块ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.行业版块ToolStripMenuItem.Text = "行业版块";
            // 
            // 一地ToolStripMenuItem
            // 
            this.一地ToolStripMenuItem.Name = "一地ToolStripMenuItem";
            this.一地ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.一地ToolStripMenuItem.Text = "地区版块";
            // 
            // boardMenuStrip
            // 
            this.boardMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一地ToolStripMenuItem,
            this.行业版块ToolStripMenuItem,
            this.向上版块ToolStripMenuItem,
            this.向下版愉ToolStripMenuItem});
            this.boardMenuStrip.Name = "boardMenuStrip";
            this.boardMenuStrip.Size = new System.Drawing.Size(125, 92);
            // 
            // 设置列ToolStripMenuItem
            // 
            this.设置列ToolStripMenuItem.Name = "设置列ToolStripMenuItem";
            this.设置列ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.设置列ToolStripMenuItem.Text = "新建任务";
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置列ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.显示ToolStripMenuItem.Text = "任务";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.显示ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(78, 24);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(410, 21);
            this.txtFind.TabIndex = 18;
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "代码";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "账套ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "备注";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.rawDataTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.boardMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加分组ToolStripMenuItem;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.DataGridView rawDataGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage rawDataTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem 向下版愉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向上版块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行业版块ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一地ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip boardMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 设置列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}