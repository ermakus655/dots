namespace dots
{
    partial class Form1
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
            this.start = new System.Windows.Forms.Button();
            this.serPort = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.Label();
            this.serIP = new System.Windows.Forms.TextBox();
            this.serverIp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Label();
            this.teamCol = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.Label();
            this.picTurn = new System.Windows.Forms.PictureBox();
            this.picTeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(92, 320);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(201, 84);
            this.start.TabIndex = 9;
            this.start.Text = "connect to server";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // serPort
            // 
            this.serPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serPort.Location = new System.Drawing.Point(92, 253);
            this.serPort.Name = "serPort";
            this.serPort.Size = new System.Drawing.Size(230, 38);
            this.serPort.TabIndex = 8;
            this.serPort.Text = "8010";
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.BackColor = System.Drawing.Color.Transparent;
            this.ServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerPort.Location = new System.Drawing.Point(12, 253);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(74, 32);
            this.ServerPort.TabIndex = 7;
            this.ServerPort.Text = "Port:";
            // 
            // serIP
            // 
            this.serIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serIP.Location = new System.Drawing.Point(92, 172);
            this.serIP.Name = "serIP";
            this.serIP.Size = new System.Drawing.Size(230, 38);
            this.serIP.TabIndex = 6;
            this.serIP.Text = "192.168.113.7";
            // 
            // serverIp
            // 
            this.serverIp.AutoSize = true;
            this.serverIp.BackColor = System.Drawing.Color.Transparent;
            this.serverIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverIp.Location = new System.Drawing.Point(12, 172);
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(48, 32);
            this.serverIp.TabIndex = 5;
            this.serverIp.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 852);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "your team:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 1259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "your team:";
            // 
            // userPort
            // 
            this.userPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPort.Location = new System.Drawing.Point(151, 24);
            this.userPort.Name = "userPort";
            this.userPort.Size = new System.Drawing.Size(201, 38);
            this.userPort.TabIndex = 12;
            this.userPort.Text = "8080";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "your port:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(92, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.BackColor = System.Drawing.Color.Transparent;
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color.Location = new System.Drawing.Point(12, 898);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(0, 32);
            this.color.TabIndex = 15;
            this.color.Visible = false;
            // 
            // teamCol
            // 
            this.teamCol.AutoSize = true;
            this.teamCol.BackColor = System.Drawing.Color.Transparent;
            this.teamCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamCol.Location = new System.Drawing.Point(18, 898);
            this.teamCol.Name = "teamCol";
            this.teamCol.Size = new System.Drawing.Size(0, 32);
            this.teamCol.TabIndex = 16;
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.BackColor = System.Drawing.Color.Transparent;
            this.turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.turn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.turn.Location = new System.Drawing.Point(56, 596);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(63, 32);
            this.turn.TabIndex = 17;
            this.turn.Text = "turn";
            // 
            // picTurn
            // 
            this.picTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picTurn.Location = new System.Drawing.Point(24, 642);
            this.picTurn.Name = "picTurn";
            this.picTurn.Size = new System.Drawing.Size(135, 50);
            this.picTurn.TabIndex = 18;
            this.picTurn.TabStop = false;
            // 
            // picTeam
            // 
            this.picTeam.BackColor = System.Drawing.Color.Blue;
            this.picTeam.Location = new System.Drawing.Point(18, 908);
            this.picTeam.Name = "picTeam";
            this.picTeam.Size = new System.Drawing.Size(135, 50);
            this.picTeam.TabIndex = 19;
            this.picTeam.TabStop = false;
            this.picTeam.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.picTeam);
            this.Controls.Add(this.picTurn);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.teamCol);
            this.Controls.Add(this.color);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.serPort);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.serIP);
            this.Controls.Add(this.serverIp);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dots";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox serPort;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.TextBox serIP;
        private System.Windows.Forms.Label serverIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label teamCol;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.PictureBox picTurn;
        private System.Windows.Forms.PictureBox picTeam;
    }
}

