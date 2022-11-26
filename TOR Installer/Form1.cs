using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;
using System.Diagnostics;

namespace TOR_Installer
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;

        String url = "https://api.github.com/repos/TheOtherRolesAU/TheOtherRoles/releases/latest";
        String serverregionsUrl = "https://gist.githubusercontent.com/j0nas500/2260e600cab2ff3ebbad1446fff7d2b6/raw/a40e873da4da8a992810f1d784f20a55edd331a9/at.duikbo.regioninstall.cfg";

        String amongPath1 = $@"C:\Program Files (x86)\Steam\steamapps\common\Among Us";
        String amongPath2 = $@"C:\Program Files\Steam\steamapps\common\Among Us";

        bool acceptedpath = true;
        String path = string.Empty;
        bool acceptedclonepath = false;
        String clonePath = string.Empty;

        bool error = false;

        public static HttpClient client = new();

        public Form1()
        {
            InitializeComponent();
            checkAmong();
            close_btn.FlatAppearance.BorderSize = 0;
            this.Controls.SetChildIndex(close_btn, 0);
            close_btn.Refresh();
        }

        void install_error(string error_text)
        {
            error_install.Visible = true;
            error_install.Text = error_text;
            error_install.ForeColor = System.Drawing.Color.Red;
            error_install.Refresh();
            start_install.Visible = true;
            start_install.Refresh();
            status.Visible = false;
            status.Refresh();
            DownloadBar.Visible = false;
            DownloadBar.Refresh();
            error = true;
        }

        void checkAmong()
        {
            if (Directory.Exists(amongPath1 + "\\Among Us_Data"))
            {
                acceptedpath = true;
                path = amongPath1;
                error_pfad.Visible = true;
                error_pfad.Text = "Pfad gesetzt.";
                error_pfad.ForeColor = Color.FromArgb(0, 219, 88);
                error_pfad.Refresh();
            }
            else if (Directory.Exists(amongPath2 + "\\Among Us_Data"))
            {
                acceptedpath = true;
                path = amongPath2;
                error_pfad.Visible = true;
                error_pfad.Text = "Pfad gesetzt.";
                error_pfad.ForeColor = Color.FromArgb(0, 219, 88);
                error_pfad.Refresh();
            }
        }

        private void au_path_Click(object sender, EventArgs e)
        {
            error_pfad.Visible = false;
            error_pfad.Refresh();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    if (Directory.Exists(path + "\\Among Us_Data"))
                    {
                        acceptedpath = true;
                        error_pfad.Visible = true;
                        error_pfad.Text = "Pfad gesetzt.";
                        error_pfad.ForeColor = Color.FromArgb(0, 219, 88);
                        error_pfad.Refresh();
                    }
                    else
                    {
                        error_pfad.Visible = true;
                        error_pfad.Text = "Dieser Ordner beinhaltet nicht Among Us!";
                        error_pfad.ForeColor = System.Drawing.Color.Red;
                        error_pfad.Refresh();
                    }
                }
                else
                {
                    error_pfad.Visible = true;
                    error_pfad.Text = "Mit diesem Ordner ist ein Fehler aufgetreten!";
                    error_pfad.ForeColor = System.Drawing.Color.Red;
                    error_pfad.Refresh();
                }
            }
        }

        private void tor_path_Click(object sender, EventArgs e)
        {
            error_tor_path.Visible = false;
            error_tor_path.Refresh();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    clonePath = fbd.SelectedPath;
                    if (!Directory.EnumerateFileSystemEntries(clonePath).Any())
                    {
                        acceptedclonepath = true;
                        error_tor_path.Visible = true;
                        error_tor_path.Text = "Pfad gesetzt.";
                        error_tor_path.ForeColor = Color.FromArgb(0, 219, 88);
                        error_tor_path.Refresh();
                    }
                    else
                    {
                        error_tor_path.Visible = true;
                        error_tor_path.Text = "Dieser Ordner ist nicht leer!";
                        error_tor_path.ForeColor = System.Drawing.Color.Red;
                        error_tor_path.Refresh();
                    }
                }
                else
                {
                    error_tor_path.Visible = true;
                    error_tor_path.Text = "Mit diesem Ordner ist ein Fehler aufgetreten!";
                    error_tor_path.ForeColor = System.Drawing.Color.Red;
                    error_tor_path.Refresh();
                }
            }
        }

        private void start_install_Click(object sender, EventArgs e)
        {
            error_install.Visible = false;
            error_install.Refresh();
            if (acceptedpath == true && acceptedclonepath == true)
            {
                start_install.Visible = false;
                startInstall();
            }
            else
            {
                error_install.Visible = true;
                error_install.Text = "Beide Pfade müssen gesetzt sein!";
                error_install.ForeColor = System.Drawing.Color.Red;
                error_install.Refresh();
            }
        }

        public async Task startInstall()
        {
            DownloadBar.Visible = true;
            DownloadBar.Refresh();
            status.Visible = true;
            status.Text = "Kopiere Among Us Dateien...";
            status.ForeColor = System.Drawing.Color.White;
            status.Refresh();
            await CloneVanillaAmongUs();
            if (error == true) return;
            status.Text = "The Other Roles wird heruntergeladen...";
            status.ForeColor = System.Drawing.Color.White;
            status.Refresh();
            await Handlezip();
        }

        public async Task CloneVanillaAmongUs()
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    File.Copy($@"{file}", $@"{clonePath}" + $"\\{file.Substring(path.Length + 1)}", true);
                }
                string[] folders = Directory.GetDirectories(path);
                foreach (string folder in folders)
                {
                    Console.WriteLine($"Ordner {folder.Substring(path.Length + 1)} kopiert");
                    CopyDirectory(folder, $@"{clonePath}" + $"\\{folder.Substring(path.Length + 1)}");
                }

                if (Directory.Exists(clonePath + "\\BepInEx")) Directory.Delete(clonePath + "\\BepInEx", true);
                if (Directory.Exists(clonePath + "\\mono")) Directory.Delete(clonePath + "\\mono", true);
                if (Directory.Exists(clonePath + "\\dotnet")) Directory.Delete(clonePath + "\\dotnet", true);
            }
            catch (Exception e)
            {
                error = true;
                install_error("Es ist ein Fehler beim kopieren aufgetreten!");
            }
        }

        public static void CopyDirectory(string originalPath, string newPath)
        {
            var dir = new DirectoryInfo(originalPath);
            DirectoryInfo[] dirs = dir.GetDirectories();

            Directory.CreateDirectory(newPath);

            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(newPath, file.Name);
                file.CopyTo(targetFilePath);
            }

            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(newPath, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir);
            }
        }

        public async Task Handlezip()
        {
            try
            {
                client.DefaultRequestHeaders.Add("User-Agent", "TOR Downloader");
                Json assets = await client.GetFromJsonAsync<Json>(url);
                Assets linktozip = assets.Assets.Find(link => link.Browser_download_url.EndsWith("zip"));
                client.Dispose();
                //Touversion = assets.Name;

                using (WebClient ws = new WebClient())
                {
                    ws.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadBar_DownloadProgressChanged);
                    ws.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedTor);
                    ws.DownloadFileAsync(
                        new System.Uri(linktozip.Browser_download_url),
                        clonePath + "\\tor.zip"
                    );
                }
            }
            catch (Exception e)
            {
                error = true;
                install_error("Es ist ein Fehler beim Downloaden aufgetreten!");
            }
        }

        void DownloadBar_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Value = e.ProgressPercentage;
        }

        void CompletedTor(object sender, AsyncCompletedEventArgs e)
        {
            if (error == true)
            {
                status.Visible = false;
                DownloadBar.Visible = false;
                status.Refresh();
                DownloadBar.Refresh();
                return;
            }
            try
            {
                status.Text = "The Other Roles wird entpackt...";
                status.ForeColor = System.Drawing.Color.White;
                status.Refresh();

                string zippath = $@"{clonePath}" + "\\tor.zip";
                var zip = new FileInfo(zippath);
                ZipFile.ExtractToDirectory(zippath, clonePath, true);
                zip.Delete();
                HandleCustomRegions();
            }
            catch (Exception r)
            {
                error = true;
                install_error("Es ist ein Fehler beim Entpacken aufgetreten!");
            }
        }

        void HandleCustomRegions()
        {
            if (error == true)
            {
                status.Visible = false;
                DownloadBar.Visible = false;
                status.Refresh();
                DownloadBar.Refresh();
                return;
            }
            status.Text = "Regionen werden geändert...";
            status.Refresh();

            using (WebClient ws = new WebClient())
            {
                ws.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadBar_DownloadProgressChanged);
                ws.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                ws.DownloadFileAsync(
                    new System.Uri(serverregionsUrl),
                    clonePath + "\\at.duikbo.regioninstall.cfg"
                );
            }
        }

        void Completed(object sender, AsyncCompletedEventArgs e)
        {
            var region = new FileInfo(clonePath + "\\at.duikbo.regioninstall.cfg");
            region.MoveTo(clonePath + "\\BepInEx\\config\\at.duikbo.regioninstall.cfg", true);
            status.Text = "TheOtherRoles in " + clonePath + " installiert!";
            status.ForeColor = Color.FromArgb(0, 219, 88);
            status.Refresh();
            start_game.Visible = true;
            start_game.Refresh();
        }

        private void start_game_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($@"{clonePath}" + "\\Among Us.exe");
            Close();
        }

        private void tor_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Teejay39/TOR-Installer",
                UseShellExecute = true
            });
        }

        private void tddc_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://tddc.eu/",
                UseShellExecute = true
            });
        }

        private void tddc_text_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://tddc.eu/",
                UseShellExecute = true
            });
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //moveable window

        private void MovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void MovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void MovePanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
