using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KMusicPlayer
{
    internal class FileController
    {
        private string original_fn;
        private string working_folder;
        public List<string> files;
        public FileController(string a_fn)
        {
            this.original_fn = a_fn;
            this.working_folder = Path.GetDirectoryName(a_fn);
            this.files = GetMusicFiles(this.working_folder);
        }
        public List<string> GetMusicFiles(string path)
        {
            //search_patern shall include "*.mp3", "*.ogg", "*.wav", "*.flac", "*.m4a", "*.wma"
            string[] searchPatterns = new string[] { "*.mp3", "*.ogg", "*.wav", "*.flac", "*.m4a", "*.wma" };
            List<string> file_names = new();

            foreach (string pattern in searchPatterns)
            {
                file_names.AddRange(System.IO.Directory.GetFiles(path, pattern));
            }
            return file_names;
        }

    }
}
