
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
            this.tor_logo = new System.Windows.Forms.PictureBox();
            this.au_path = new System.Windows.Forms.Button();
            this.error_pfad = new System.Windows.Forms.Label();
            this.error_tor_path = new System.Windows.Forms.Label();
            this.tor_path = new System.Windows.Forms.Button();
            this.DownloadBar = new System.Windows.Forms.ProgressBar();
            this.status = new System.Windows.Forms.Label();
            this.start_install = new System.Windows.Forms.Button();
            this.error_install = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.start_game = new System.Windows.Forms.Button();
            this.tddc_logo = new System.Windows.Forms.PictureBox();
            this.tddc_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tor_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tddc_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tor_logo
            // 
            this.tor_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tor_logo.Image = ((System.Drawing.Image)(resources.GetObject("tor_logo.Image")));
            this.tor_logo.Location = new System.Drawing.Point(16, 18);
            this.tor_logo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tor_logo.Name = "tor_logo";
            this.tor_logo.Size = new System.Drawing.Size(370, 91);
            this.tor_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tor_logo.TabIndex = 0;
            this.tor_logo.TabStop = false;
            this.tor_logo.Click += new System.EventHandler(this.tor_logo_Click);
            // 
            // au_path
            // 
            this.au_path.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.au_path.Location = new System.Drawing.Point(16, 153);
            this.au_path.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.au_path.Name = "au_path";
            this.au_path.Size = new System.Drawing.Size(280, 41);
            this.au_path.TabIndex = 2;
            this.au_path.Text = "Pfad zu Among Us auswaehlen";
            this.au_path.UseVisualStyleBackColor = true;
            this.au_path.Click += new System.EventHandler(this.au_path_Click);
            // 
            // error_pfad
            // 
            this.error_pfad.AutoSize = true;
            this.error_pfad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_pfad.ForeColor = System.Drawing.Color.Red;
            this.error_pfad.Location = new System.Drawing.Point(304, 164);
            this.error_pfad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.error_pfad.Name = "error_pfad";
            this.error_pfad.Size = new System.Drawing.Size(79, 19);
            this.error_pfad.TabIndex = 3;
            this.error_pfad.Text = "{{ERROR}}";
            this.error_pfad.Visible = false;
            // 
            // error_tor_path
            // 
            this.error_tor_path.AutoSize = true;
            this.error_tor_path.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_tor_path.ForeColor = System.Drawing.Color.Red;
            this.error_tor_path.Location = new System.Drawing.Point(304, 214);
            this.error_tor_path.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.error_tor_path.Name = "error_tor_path";
            this.error_tor_path.Size = new System.Drawing.Size(79, 19);
            this.error_tor_path.TabIndex = 5;
            this.error_tor_path.Text = "{{ERROR}}";
            this.error_tor_path.Visible = false;
            // 
            // tor_path
            // 
            this.tor_path.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tor_path.Location = new System.Drawing.Point(16, 203);
            this.tor_path.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tor_path.Name = "tor_path";
            this.tor_path.Size = new System.Drawing.Size(280, 41);
            this.tor_path.TabIndex = 4;
            this.tor_path.Text = "Wo soll TOR Installiert werden?";
            this.tor_path.UseVisualStyleBackColor = true;
            this.tor_path.Click += new System.EventHandler(this.tor_path_Click);
            // 
            // DownloadBar
            // 
            this.DownloadBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.DownloadBar.Location = new System.Drawing.Point(16, 462);
            this.DownloadBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(606, 34);
            this.DownloadBar.TabIndex = 10;
            this.DownloadBar.Visible = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.Transparent;
            this.status.Location = new System.Drawing.Point(16, 428);
            this.status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(83, 19);
            this.status.TabIndex = 11;
            this.status.Text = "{{STATUS}}";
            this.status.Visible = false;
            // 
            // start_install
            // 
            this.start_install.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_install.Location = new System.Drawing.Point(15, 281);
            this.start_install.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.start_install.Name = "start_install";
            this.start_install.Size = new System.Drawing.Size(280, 41);
            this.start_install.TabIndex = 12;
            this.start_install.Text = "Installation Starten";
            this.start_install.UseVisualStyleBackColor = true;
            this.start_install.Click += new System.EventHandler(this.start_install_Click);
            // 
            // error_install
            // 
            this.error_install.AutoSize = true;
            this.error_install.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error_install.ForeColor = System.Drawing.Color.Red;
            this.error_install.Location = new System.Drawing.Point(15, 327);
            this.error_install.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.error_install.Name = "error_install";
            this.error_install.Size = new System.Drawing.Size(79, 19);
            this.error_install.TabIndex = 13;
            this.error_install.Text = "{{ERROR}}";
            this.error_install.Visible = false;
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(591, 13);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(35, 40);
            this.close_btn.TabIndex = 14;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.MovePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MovePanel.Location = new System.Drawing.Point(-10, -5);
            this.MovePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(653, 34);
            this.MovePanel.TabIndex = 15;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            this.MovePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseUp);
            // 
            // start_game
            // 
            this.start_game.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_game.Location = new System.Drawing.Point(164, 370);
            this.start_game.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.start_game.Name = "start_game";
            this.start_game.Size = new System.Drawing.Size(280, 41);
            this.start_game.TabIndex = 16;
            this.start_game.Text = "Spiel starten";
            this.start_game.UseVisualStyleBackColor = true;
            this.start_game.Visible = false;
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // tddc_logo
            // 
            this.tddc_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tddc_logo.Image = ((System.Drawing.Image)(resources.GetObject("tddc_logo.Image")));
            this.tddc_logo.Location = new System.Drawing.Point(29, 59);
            this.tddc_logo.Name = "tddc_logo";
            this.tddc_logo.Size = new System.Drawing.Size(50, 50);
            this.tddc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tddc_logo.TabIndex = 17;
            this.tddc_logo.TabStop = false;
            this.tddc_logo.Click += new System.EventHandler(this.tddc_logo_Click);
            // 
            // tddc_text
            // 
            this.tddc_text.AutoSize = true;
            this.tddc_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tddc_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tddc_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            this.tddc_text.Location = new System.Drawing.Point(80, 90);
            this.tddc_text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tddc_text.Name = "tddc_text";
            this.tddc_text.Size = new System.Drawing.Size(125, 19);
            this.tddc_text.TabIndex = 18;
            this.tddc_text.Text = "Installer by TDDC";
            this.tddc_text.Click += new System.EventHandler(this.tddc_text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(638, 513);
            this.Controls.Add(this.tddc_text);
            this.Controls.Add(this.tddc_logo);
            this.Controls.Add(this.start_game);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.error_install);
            this.Controls.Add(this.start_install);
            this.Controls.Add(this.status);
            this.Controls.Add(this.DownloadBar);
            this.Controls.Add(this.error_tor_path);
            this.Controls.Add(this.tor_path);
            this.Controls.Add(this.error_pfad);
            this.Controls.Add(this.au_path);
            this.Controls.Add(this.tor_logo);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tor Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.tor_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tddc_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tor_logo;
        private System.Windows.Forms.Button au_path;
        private System.Windows.Forms.Label error_pfad;
        private System.Windows.Forms.Label error_tor_path;
        private System.Windows.Forms.Button tor_path;
        private System.Windows.Forms.ProgressBar DownloadBar;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button start_install;
        private System.Windows.Forms.Label error_install;
        private Button close_btn;
        private Panel MovePanel;
        private Button start_game;
        private PictureBox tddc_logo;
        private Label tddc_text;
    }
}

