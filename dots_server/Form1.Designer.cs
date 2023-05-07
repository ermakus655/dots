namespace dots_server
{
    partial class server
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverIp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.Label();
            this.portNum = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverIp
            // 
            this.serverIp.AutoSize = true;
            this.serverIp.BackColor = System.Drawing.Color.Transparent;
            this.serverIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverIp.Location = new System.Drawing.Point(30, 28);
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(48, 32);
            this.serverIp.TabIndex = 0;
            this.serverIp.Text = "IP:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(110, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 38);
            this.textBox1.TabIndex = 1;
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.BackColor = System.Drawing.Color.Transparent;
            this.ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerPort.Location = new System.Drawing.Point(30, 109);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(74, 32);
            this.ServerPort.TabIndex = 2;
            this.ServerPort.Text = "Port:";
            // 
            // portNum
            // 
            this.portNum.Enabled = false;
            this.portNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portNum.Location = new System.Drawing.Point(110, 109);
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(250, 38);
            this.portNum.TabIndex = 3;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(110, 232);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(201, 63);
            this.start.TabIndex = 4;
            this.start.Text = "launch server";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(344, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "launch server";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dots_server.Properties.Resources.explosion;
            this.ClientSize = new System.Drawing.Size(412, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.portNum);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.serverIp);
            this.Name = "server";
            this.Text = "server";
            this.Load += new System.EventHandler(this.server_Load);
            this.Leave += new System.EventHandler(this.server_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverIp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.TextBox portNum;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button1;
    }
}

