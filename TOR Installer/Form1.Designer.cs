
namespace TOR_Installer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.error_pfad = new System.Windows.Forms.Label();
            this.error_tor_path = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DownloadBar = new System.Windows.Forms.ProgressBar();
            this.status = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.error_install = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.MovePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Moorley Hoosten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(14, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pfad zu Among Us auswaehlen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error_pfad
            // 
            this.error_pfad.AutoSize = true;
            this.error_pfad.Font = new System.Drawing.Font("Moorley Hoosten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_pfad.ForeColor = System.Drawing.Color.Red;
            this.error_pfad.Location = new System.Drawing.Point(266, 125);
            this.error_pfad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_pfad.Name = "error_pfad";
            this.error_pfad.Size = new System.Drawing.Size(76, 20);
            this.error_pfad.TabIndex = 3;
            this.error_pfad.Text = "{{ERROR}}";
            this.error_pfad.Visible = false;
            // 
            // error_tor_path
            // 
            this.error_tor_path.AutoSize = true;
            this.error_tor_path.Font = new System.Drawing.Font("Moorley Hoosten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_tor_path.ForeColor = System.Drawing.Color.Red;
            this.error_tor_path.Location = new System.Drawing.Point(266, 164);
            this.error_tor_path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_tor_path.Name = "error_tor_path";
            this.error_tor_path.Size = new System.Drawing.Size(76, 20);
            this.error_tor_path.TabIndex = 5;
            this.error_tor_path.Text = "{{ERROR}}";
            this.error_tor_path.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Moorley Hoosten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(14, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Wo soll TOR Installiert werden?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DownloadBar
            // 
            this.DownloadBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.DownloadBar.Location = new System.Drawing.Point(14, 365);
            this.DownloadBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(530, 27);
            this.DownloadBar.TabIndex = 10;
            this.DownloadBar.Visible = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Moorley Hoosten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.Transparent;
            this.status.Location = new System.Drawing.Point(14, 338);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(83, 20);
            this.status.TabIndex = 11;
            this.status.Text = "{{STATUS}}";
            this.status.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Moorley Hoosten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(13, 222);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Installation Starten";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // error_install
            // 
            this.error_install.AutoSize = true;
            this.error_install.Font = new System.Drawing.Font("Moorley Hoosten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_install.ForeColor = System.Drawing.Color.Red;
            this.error_install.Location = new System.Drawing.Point(13, 258);
            this.error_install.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_install.Name = "error_install";
            this.error_install.Size = new System.Drawing.Size(76, 20);
            this.error_install.TabIndex = 13;
            this.error_install.Text = "{{ERROR}}";
            this.error_install.Visible = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(515, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 40);
            this.button4.TabIndex = 14;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MovePanel.Location = new System.Drawing.Point(-9, -4);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(571, 56);
            this.MovePanel.TabIndex = 15;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            this.MovePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(558, 405);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.error_install);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.DownloadBar);
            this.Controls.Add(this.error_tor_path);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.error_pfad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tor Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label error_pfad;
        private System.Windows.Forms.Label error_tor_path;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar DownloadBar;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label error_install;
        private Button button4;
        private Panel MovePanel;
    }
}

