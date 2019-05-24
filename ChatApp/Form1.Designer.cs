namespace ChatApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.edtServerPort = new System.Windows.Forms.TextBox();
            this.edtServerIP = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClientStart = new System.Windows.Forms.Button();
            this.edtClientIP = new System.Windows.Forms.TextBox();
            this.edtClientPort = new System.Windows.Forms.TextBox();
            this.redtHistory = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.edtToSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnServerStart);
            this.groupBox1.Controls.Add(this.edtServerPort);
            this.groupBox1.Controls.Add(this.edtServerIP);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "5000 ->";
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(702, 65);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(86, 26);
            this.btnServerStart.TabIndex = 2;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click_1);
            // 
            // edtServerPort
            // 
            this.edtServerPort.Location = new System.Drawing.Point(449, 65);
            this.edtServerPort.Name = "edtServerPort";
            this.edtServerPort.Size = new System.Drawing.Size(247, 26);
            this.edtServerPort.TabIndex = 0;
            // 
            // edtServerIP
            // 
            this.edtServerIP.Location = new System.Drawing.Point(3, 65);
            this.edtServerIP.Name = "edtServerIP";
            this.edtServerIP.Size = new System.Drawing.Size(440, 26);
            this.edtServerIP.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClientStart);
            this.groupBox2.Controls.Add(this.edtClientIP);
            this.groupBox2.Controls.Add(this.edtClientPort);
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // btnClientStart
            // 
            this.btnClientStart.Location = new System.Drawing.Point(702, 65);
            this.btnClientStart.Name = "btnClientStart";
            this.btnClientStart.Size = new System.Drawing.Size(86, 26);
            this.btnClientStart.TabIndex = 3;
            this.btnClientStart.Text = "Connect";
            this.btnClientStart.UseVisualStyleBackColor = true;
            this.btnClientStart.Click += new System.EventHandler(this.btnClientStart_Click_1);
            // 
            // edtClientIP
            // 
            this.edtClientIP.Location = new System.Drawing.Point(3, 65);
            this.edtClientIP.Name = "edtClientIP";
            this.edtClientIP.Size = new System.Drawing.Size(440, 26);
            this.edtClientIP.TabIndex = 1;
            // 
            // edtClientPort
            // 
            this.edtClientPort.Location = new System.Drawing.Point(449, 65);
            this.edtClientPort.Name = "edtClientPort";
            this.edtClientPort.Size = new System.Drawing.Size(247, 26);
            this.edtClientPort.TabIndex = 0;
            // 
            // redtHistory
            // 
            this.redtHistory.Location = new System.Drawing.Point(3, 357);
            this.redtHistory.Name = "redtHistory";
            this.redtHistory.Size = new System.Drawing.Size(741, 96);
            this.redtHistory.TabIndex = 1;
            this.redtHistory.Text = "";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork_1);
            // 
            // edtToSend
            // 
            this.edtToSend.Location = new System.Drawing.Point(3, 506);
            this.edtToSend.Name = "edtToSend";
            this.edtToSend.Size = new System.Drawing.Size(440, 26);
            this.edtToSend.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(702, 506);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 26);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.edtToSend);
            this.Controls.Add(this.redtHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtServerPort;
        private System.Windows.Forms.TextBox edtServerIP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edtClientIP;
        private System.Windows.Forms.TextBox edtClientPort;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.Button btnClientStart;
        private System.Windows.Forms.RichTextBox redtHistory;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox edtToSend;
        private System.Windows.Forms.Button btnSend;
    }
}

