namespace tcpIpTestClient
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IPaddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.listBox_Info = new System.Windows.Forms.ListBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textBox_IPaddress
            // 
            this.textBox_IPaddress.Location = new System.Drawing.Point(74, 12);
            this.textBox_IPaddress.Name = "textBox_IPaddress";
            this.textBox_IPaddress.Size = new System.Drawing.Size(205, 22);
            this.textBox_IPaddress.TabIndex = 2;
            this.textBox_IPaddress.TextChanged += new System.EventHandler(this.textBox_IPaddress_TextChanged);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(74, 58);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(205, 22);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(12, 127);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(75, 23);
            this.Connect_button.TabIndex = 4;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(204, 127);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 23);
            this.Close_Button.TabIndex = 5;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Click);
            // 
            // listBox_Info
            // 
            this.listBox_Info.FormattingEnabled = true;
            this.listBox_Info.ItemHeight = 12;
            this.listBox_Info.Location = new System.Drawing.Point(12, 168);
            this.listBox_Info.Name = "listBox_Info";
            this.listBox_Info.Size = new System.Drawing.Size(267, 172);
            this.listBox_Info.TabIndex = 6;
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(110, 127);
            this.Send_button.Margin = new System.Windows.Forms.Padding(1);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(75, 23);
            this.Send_button.TabIndex = 7;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 852);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.listBox_Info);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBox_IPaddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_IPaddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.ListBox listBox_Info;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

