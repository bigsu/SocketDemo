namespace SocketClient
{
    partial class FrmTcpClient
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
            this.iTcpClient1 = new NetWorkHelper.TCP.ITcpClient(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // iTcpClient1
            // 
            this.iTcpClient1.IsReconnection = true;
            this.iTcpClient1.IsStart = false;
            this.iTcpClient1.ReConnectionTime = 3000;
            this.iTcpClient1.ServerIp = "192.168.1.110";
            this.iTcpClient1.ServerPort = 5000;
            this.iTcpClient1.OnRecevice += new System.EventHandler<NetWorkHelper.ICommond.TcpClientReceviceEventArgs>(this.iTcpClient1_OnRecevice);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // FrmTcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTcpClient";
            this.Text = "FrmTcpClient";
            this.Load += new System.EventHandler(this.FrmTcpClient_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private NetWorkHelper.TCP.ITcpClient iTcpClient1;
        private System.Windows.Forms.Panel panel1;
    }
}