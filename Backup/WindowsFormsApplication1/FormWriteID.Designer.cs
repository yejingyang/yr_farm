namespace WindowsFormsApplication1
{
    partial class FormWriteID
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
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSCID = new System.Windows.Forms.Button();
            this.btnXRID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJYID = new System.Windows.Forms.TextBox();
            this.txtSCID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnJYID = new System.Windows.Forms.Button();
            this.btnOpenCOM = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labInformation = new System.Windows.Forms.Label();
            this.btnReadID = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbxCOMPort.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(211, 39);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(128, 37);
            this.cbxCOMPort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "端口选择：";
            // 
            // btnSCID
            // 
            this.btnSCID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSCID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSCID.Location = new System.Drawing.Point(6, 29);
            this.btnSCID.Name = "btnSCID";
            this.btnSCID.Size = new System.Drawing.Size(128, 42);
            this.btnSCID.TabIndex = 2;
            this.btnSCID.Text = "(1)生成ID";
            this.btnSCID.UseVisualStyleBackColor = false;
            this.btnSCID.Click += new System.EventHandler(this.btnSCID_Click);
            // 
            // btnXRID
            // 
            this.btnXRID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXRID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXRID.Location = new System.Drawing.Point(141, 29);
            this.btnXRID.Name = "btnXRID";
            this.btnXRID.Size = new System.Drawing.Size(128, 42);
            this.btnXRID.TabIndex = 1;
            this.btnXRID.Text = "(2)写入ID";
            this.btnXRID.UseVisualStyleBackColor = false;
            this.btnXRID.Click += new System.EventHandler(this.btnXRID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "生成ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "校验ID：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJYID);
            this.groupBox1.Controls.Add(this.txtSCID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(52, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID显示";
            // 
            // txtJYID
            // 
            this.txtJYID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtJYID.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJYID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtJYID.Location = new System.Drawing.Point(185, 73);
            this.txtJYID.Name = "txtJYID";
            this.txtJYID.Size = new System.Drawing.Size(328, 41);
            this.txtJYID.TabIndex = 9;
            // 
            // txtSCID
            // 
            this.txtSCID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSCID.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSCID.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSCID.Location = new System.Drawing.Point(185, 23);
            this.txtSCID.Name = "txtSCID";
            this.txtSCID.Size = new System.Drawing.Size(328, 41);
            this.txtSCID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文新魏", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(94, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(474, 57);
            this.label6.TabIndex = 10;
            this.label6.Text = "耳标ID号生成系统";
            // 
            // btnJYID
            // 
            this.btnJYID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnJYID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJYID.Location = new System.Drawing.Point(409, 29);
            this.btnJYID.Name = "btnJYID";
            this.btnJYID.Size = new System.Drawing.Size(128, 42);
            this.btnJYID.TabIndex = 11;
            this.btnJYID.Text = "(4)校验ID";
            this.btnJYID.UseVisualStyleBackColor = false;
            this.btnJYID.Click += new System.EventHandler(this.btnJYID_Click);
            // 
            // btnOpenCOM
            // 
            this.btnOpenCOM.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpenCOM.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCOM.Location = new System.Drawing.Point(385, 34);
            this.btnOpenCOM.Name = "btnOpenCOM";
            this.btnOpenCOM.Size = new System.Drawing.Size(128, 42);
            this.btnOpenCOM.TabIndex = 12;
            this.btnOpenCOM.Text = "打开端口";
            this.btnOpenCOM.UseVisualStyleBackColor = false;
            this.btnOpenCOM.Click += new System.EventHandler(this.btnOpenCOM_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnOpenCOM);
            this.groupBox2.Controls.Add(this.cbxCOMPort);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(52, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 97);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通信设置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReadID);
            this.groupBox3.Controls.Add(this.btnSCID);
            this.groupBox3.Controls.Add(this.btnXRID);
            this.groupBox3.Controls.Add(this.btnJYID);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(52, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 93);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ID操作";
            // 
            // labInformation
            // 
            this.labInformation.AutoSize = true;
            this.labInformation.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInformation.ForeColor = System.Drawing.Color.Red;
            this.labInformation.Location = new System.Drawing.Point(266, 429);
            this.labInformation.Name = "labInformation";
            this.labInformation.Size = new System.Drawing.Size(106, 24);
            this.labInformation.TabIndex = 15;
            this.labInformation.Text = "反馈信息";
            // 
            // btnReadID
            // 
            this.btnReadID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReadID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadID.Location = new System.Drawing.Point(275, 29);
            this.btnReadID.Name = "btnReadID";
            this.btnReadID.Size = new System.Drawing.Size(128, 42);
            this.btnReadID.TabIndex = 12;
            this.btnReadID.Text = "(3)读取ID";
            this.btnReadID.UseVisualStyleBackColor = false;
            this.btnReadID.Click += new System.EventHandler(this.btnReadID_Click);
            // 
            // FormWriteID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.DBJ_SCADA_CS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 468);
            this.Controls.Add(this.labInformation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormWriteID";
            this.Text = "耳标ID号生成系统";
            this.Load += new System.EventHandler(this.FormWriteID_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWriteID_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSCID;
        private System.Windows.Forms.Button btnXRID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnJYID;
        private System.Windows.Forms.Button btnOpenCOM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labInformation;
        private System.Windows.Forms.TextBox txtJYID;
        private System.Windows.Forms.TextBox txtSCID;
        private System.Windows.Forms.Button btnReadID;
    }
}