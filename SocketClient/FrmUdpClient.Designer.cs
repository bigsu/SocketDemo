﻿namespace SocketClient
{
    partial class FrmUdpClient
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
            this.components = new System.ComponentModel.Container();
            this.axUdpClient1 = new NetWorkHelper.AxUdpClient(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // axUdpClient1
            // 
            this.axUdpClient1.IsAxAgreement = true;
            this.axUdpClient1.LocalPort = 9999;
            this.axUdpClient1.RemoteIp = "0.0.0.0";
            this.axUdpClient1.RemotePort = 8888;
            this.axUdpClient1.ReceiveTextMsg += new NetWorkHelper.AxUdpClient.ReceiveTextMsgEventHandler(this.axUdpClient1_ReceiveTextMsg);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 715);
            this.panel1.TabIndex = 0;
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 715);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NetWorkHelper.AxUdpClient axUdpClient1;
        private System.Windows.Forms.Panel panel1;
    }
}

