namespace TCP_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_btn_connect = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_btn_diconnect = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richtbx_log = new System.Windows.Forms.RichTextBox();
            this.richtbx_send = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propertyGrid1);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接信息";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 42);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(212, 356);
            this.propertyGrid1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_btn_connect,
            this.toolStrip_btn_diconnect});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(212, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_btn_connect
            // 
            this.toolStrip_btn_connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btn_connect.Image")));
            this.toolStrip_btn_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btn_connect.Name = "toolStrip_btn_connect";
            this.toolStrip_btn_connect.Size = new System.Drawing.Size(36, 22);
            this.toolStrip_btn_connect.Text = "连接";
            this.toolStrip_btn_connect.Click += new System.EventHandler(this.toolStrip_btn_connect_Click);
            // 
            // toolStrip_btn_diconnect
            // 
            this.toolStrip_btn_diconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_btn_diconnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btn_diconnect.Image")));
            this.toolStrip_btn_diconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btn_diconnect.Name = "toolStrip_btn_diconnect";
            this.toolStrip_btn_diconnect.Size = new System.Drawing.Size(36, 22);
            this.toolStrip_btn_diconnect.Text = "断开";
            this.toolStrip_btn_diconnect.Click += new System.EventHandler(this.toolStrip_btn_diconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richtbx_log);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(218, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richtbx_send);
            this.groupBox3.Controls.Add(this.btn_send);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(218, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输入区";
            // 
            // richtbx_log
            // 
            this.richtbx_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtbx_log.Location = new System.Drawing.Point(3, 17);
            this.richtbx_log.Name = "richtbx_log";
            this.richtbx_log.Size = new System.Drawing.Size(549, 281);
            this.richtbx_log.TabIndex = 0;
            this.richtbx_log.Text = "";
            // 
            // richtbx_send
            // 
            this.richtbx_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtbx_send.Location = new System.Drawing.Point(3, 17);
            this.richtbx_send.Name = "richtbx_send";
            this.richtbx_send.Size = new System.Drawing.Size(485, 80);
            this.richtbx_send.TabIndex = 0;
            this.richtbx_send.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_send.Location = new System.Drawing.Point(488, 17);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(64, 80);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripButton toolStrip_btn_connect;
        private System.Windows.Forms.ToolStripButton toolStrip_btn_diconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richtbx_log;
        private System.Windows.Forms.RichTextBox richtbx_send;
        private System.Windows.Forms.Button btn_send;
    }
}

