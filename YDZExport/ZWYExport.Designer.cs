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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZWYExport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbQYH = new System.Windows.Forms.Label();
            this.txtEntNo = new System.Windows.Forms.TextBox();
            this.txtYZM = new System.Windows.Forms.TextBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.picVerify = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerify)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picVerify);
            this.groupBox1.Controls.Add(this.txtPWD);
            this.groupBox1.Controls.Add(this.txtYZM);
            this.groupBox1.Controls.Add(this.txtEntNo);
            this.groupBox1.Controls.Add(this.lbQYH);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 316);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入系统的登录用户信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(95, 140);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 26);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lbQYH
            // 
            this.lbQYH.AutoSize = true;
            this.lbQYH.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbQYH.Location = new System.Drawing.Point(24, 100);
            this.lbQYH.Name = "lbQYH";
            this.lbQYH.Size = new System.Drawing.Size(65, 20);
            this.lbQYH.TabIndex = 4;
            this.lbQYH.Text = "企业号：";
            this.lbQYH.Visible = false;
            this.lbQYH.Click += new System.EventHandler(this.lbQYH_Click);
            // 
            // txtEntNo
            // 
            this.txtEntNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEntNo.Location = new System.Drawing.Point(95, 100);
            this.txtEntNo.Name = "txtEntNo";
            this.txtEntNo.Size = new System.Drawing.Size(209, 26);
            this.txtEntNo.TabIndex = 5;
            this.txtEntNo.Visible = false;
            this.txtEntNo.TextChanged += new System.EventHandler(this.txtEntNo_TextChanged);
            // 
            // txtYZM
            // 
            this.txtYZM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYZM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYZM.Location = new System.Drawing.Point(95, 227);
            this.txtYZM.Name = "txtYZM";
            this.txtYZM.Size = new System.Drawing.Size(99, 26);
            this.txtYZM.TabIndex = 6;
            this.txtYZM.Visible = false;
            this.txtYZM.TextChanged += new System.EventHandler(this.txtYZM_TextChanged);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(0, 350);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(352, 10);
            this.pBar.TabIndex = 12;
            // 
            // picVerify
            // 
            this.picVerify.Image = ((System.Drawing.Image)(resources.GetObject("picVerify.Image")));
            this.picVerify.Location = new System.Drawing.Point(200, 227);
            this.picVerify.Name = "picVerify";
            this.picVerify.Size = new System.Drawing.Size(100, 40);
            this.picVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVerify.TabIndex = 7;
            this.picVerify.TabStop = false;
            this.picVerify.Visible = false;
            this.picVerify.Click += new System.EventHandler(this.picVerify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "账号：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "验证码：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPWD
            // 
            this.txtPWD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPWD.Location = new System.Drawing.Point(95, 182);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(209, 26);
            this.txtPWD.TabIndex = 3;
            this.txtPWD.TextChanged += new System.EventHandler(this.txtPWD_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(28, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(276, 33);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "云星空",
            "易代账",
            "账益达",
            "云账房",
            "云代账",
            "芸豆",
            "大账房"});
            this.comboBox1.Location = new System.Drawing.Point(95, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "可选列表:";
            // 
            // ZWYExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZWYExport";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVerify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picVerify;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtYZM;
        private System.Windows.Forms.TextBox txtEntNo;
        private System.Windows.Forms.Label lbQYH;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
    }
}