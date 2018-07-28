namespace UdpDemo
{
    partial class FrmClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtlocalIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "本地IP";
            // 
            // txtlocalIP
            // 
            this.txtlocalIP.Location = new System.Drawing.Point(93, 31);
            this.txtlocalIP.Name = "txtlocalIP";
            this.txtlocalIP.Size = new System.Drawing.Size(100, 21);
            this.txtlocalIP.TabIndex = 1;
            this.txtlocalIP.Text = "192.168.1.110";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(281, 31);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "33333";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(39, 73);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(546, 84);
            this.txtMsg.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(510, 175);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(39, 232);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(558, 175);
            this.txtReceive.TabIndex = 6;
            this.txtReceive.Text = "";
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 436);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtlocalIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlocalIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtReceive;
    }
}

