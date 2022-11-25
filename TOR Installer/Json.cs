using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOR_Installer
{
    public sealed class Json
    {
        public string Tag_name { get; set; }
        public List<Assets> Assets { get; set; }
    }
    public class Assets
    {
        public string Browser_download_url { get; set; }
    }
}
