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

namespace TOR_Installer
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;

        String url = "https://api.github.com/repos/TheOtherRolesAU/TheOtherRoles/releases/latest";
        String serverregionsUrl = "https://gist.githubusercontent.com/j0nas500/2260e600cab2ff3ebbad1446fff7d2b6/raw/a40e873da4da8a992810f1d784f20a55edd331a9/at.duikbo.regioninstall.cfg";

        bool acceptedpath = true;
        String path = string.Empty;
        bool acceptedclonepath = false;
        String clonePath = string.Empty;

        public static HttpClient client = new();

        public Form1()
        {
            InitializeComponent();
            error_pfad.Visible = false;
            error_tor_path.Visible = false;
            error_install.Visible = false;
            status.Visible = false;
            DownloadBar.Visible = false;
            button4.FlatAppearance.BorderSize = 0;
            this.Controls.SetChildIndex(MovePanel, 15);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            error_pfad.Visible = false;
            error_pfad.Refresh();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    if (Directory.Exists(path + "\\Among Us_Data")) acceptedpath = true;
                    else
                    {
                        error_pfad.Visible = true;
                        error_pfad.Text = "Dieser Ordner beinhaltet nicht Among Us!";
                        error_pfad.Refresh();
                    }
                }
                else
                {
                    error_pfad.Visible = true;
                    error_pfad.Text = "Mit diesem Ordner ist ein Fehler aufgetreten!";
                    error_pfad.Refresh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            error_tor_path.Visible = false;
            error_tor_path.Refresh();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    clonePath = fbd.SelectedPath;
                    if (!Directory.EnumerateFileSystemEntries(clonePath).Any()) acceptedclonepath = true;
                    else
                    {
                        error_tor_path.Visible = true;
                        error_tor_path.Text = "Dieser Ordner ist nicht leer!";
                        error_tor_path.Refresh();
                    }
                }
                else
                {
                    error_tor_path.Visible = true;
                    error_tor_path.Text = "Mit diesem Ordner ist ein Fehler aufgetreten!";
                    error_tor_path.Refresh();
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            error_install.Visible = false;
            error_install.Refresh();
            if (acceptedpath == true && acceptedclonepath == true)
            {
                startInstall();
            }
            else
            {
                error_install.Visible = true;
                error_install.Text = "Beide Pfade müssen gesetzt sein!";
                error_install.Refresh();
            }
        }

        public async Task startInstall()
        {
            DownloadBar.Visible = true;
            DownloadBar.Refresh();
            status.Visible = true;
            status.Text = "Kopiere Among Us Dateien...";
            status.Refresh();
            await CloneVanillaAmongUs();
            status.Text = "The Other Roles wird heruntergeladen...";
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
                error_install.Visible = true;
                error_install.Text = "Es ist ein Fehler beim kopieren aufgetreten!";
                error_install.Refresh();
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
                error_install.Visible = true;
                error_install.Text = "Es ist ein Fehler beim Downloaden aufgetreten!";
                error_install.Refresh();
            }
        }

        void DownloadBar_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadBar.Value = e.ProgressPercentage;
        }

        void CompletedTor(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                status.Text = "The Other Roles wird entpackt...";
                status.Refresh();

                string zippath = $@"{clonePath}" + "\\tor.zip";
                var zip = new FileInfo(zippath);
                ZipFile.ExtractToDirectory(zippath, clonePath, true);
                zip.Delete();
                HandleCustomRegions();
            }
            catch (Exception r)
            {
                error_install.Visible = true;
                error_install.Text = "Es ist ein Fehler beim Entpacken aufgetreten!";
                error_install.Refresh();
            }
        }

        void HandleCustomRegions()
        {
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
            status.ForeColor = System.Drawing.Color.Green;
            status.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
