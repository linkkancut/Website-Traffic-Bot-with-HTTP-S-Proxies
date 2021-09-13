
namespace traffic_bot
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loaded = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.websitetrafic = new System.Windows.Forms.TextBox();
            this.proxy = new System.Windows.Forms.Timer(this.components);
            this.offline = new System.Windows.Forms.Label();
            this.online = new System.Windows.Forms.Label();
            this.latest = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.imported = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 139);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 139);
            this.panel2.TabIndex = 1;
            // 
            // loaded
            // 
            this.loaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.loaded.Dock = System.Windows.Forms.DockStyle.Top;
            this.loaded.Location = new System.Drawing.Point(1, 0);
            this.loaded.Name = "loaded";
            this.loaded.Size = new System.Drawing.Size(360, 1);
            this.loaded.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 1);
            this.panel4.TabIndex = 3;
            // 
            // start
            // 
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.start.Location = new System.Drawing.Point(12, 81);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(123, 24);
            this.start.TabIndex = 4;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.stop.Location = new System.Drawing.Point(141, 81);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(123, 24);
            this.stop.TabIndex = 5;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // websitetrafic
            // 
            this.websitetrafic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.websitetrafic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.websitetrafic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.websitetrafic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.websitetrafic.Location = new System.Drawing.Point(12, 111);
            this.websitetrafic.Multiline = true;
            this.websitetrafic.Name = "websitetrafic";
            this.websitetrafic.Size = new System.Drawing.Size(338, 18);
            this.websitetrafic.TabIndex = 6;
            this.websitetrafic.Text = "https://www.website.com/";
            this.websitetrafic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // proxy
            // 
            this.proxy.Interval = 200;
            this.proxy.Tick += new System.EventHandler(this.proxy_Tick);
            // 
            // offline
            // 
            this.offline.AutoSize = true;
            this.offline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.offline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.offline.Location = new System.Drawing.Point(9, 39);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(108, 15);
            this.offline.TabIndex = 7;
            this.offline.Text = "Offline Proxies: n/a";
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.online.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.online.Location = new System.Drawing.Point(9, 23);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(107, 15);
            this.online.TabIndex = 8;
            this.online.Text = "Online Proxies: n/a";
            // 
            // latest
            // 
            this.latest.AutoSize = true;
            this.latest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.latest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.latest.Location = new System.Drawing.Point(9, 8);
            this.latest.Name = "latest";
            this.latest.Size = new System.Drawing.Size(124, 15);
            this.latest.TabIndex = 9;
            this.latest.Text = "Latest Proxy Used: n/a";
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.close.Location = new System.Drawing.Point(270, 81);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(80, 24);
            this.close.TabIndex = 10;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // imported
            // 
            this.imported.AutoSize = true;
            this.imported.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imported.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.imported.Location = new System.Drawing.Point(9, 54);
            this.imported.Name = "imported";
            this.imported.Size = new System.Drawing.Size(121, 15);
            this.imported.TabIndex = 11;
            this.imported.Text = "Imported Proxies: n/a";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(362, 139);
            this.Controls.Add(this.imported);
            this.Controls.Add(this.close);
            this.Controls.Add(this.latest);
            this.Controls.Add(this.online);
            this.Controls.Add(this.offline);
            this.Controls.Add(this.websitetrafic);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.loaded);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traffic Bot";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel loaded;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox websitetrafic;
        private System.Windows.Forms.Timer proxy;
        private System.Windows.Forms.Label offline;
        private System.Windows.Forms.Label online;
        private System.Windows.Forms.Label latest;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label imported;
    }
}

