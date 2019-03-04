using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSortWF.Shared_Classes
{
    public abstract class FileSort
    {
        public List<Models.FileModel> Files { get; set; }
        public String DestinationPath { get; set; }
        public String DirectoryPath { get; set; }
        public abstract void SortFiles(Types type);
        public List<Models.FileModel> GetFiles(Types type, bool allDirectories)
        {
            List<String> extensions = Extensions.GetExtensions(type);
            IEnumerable<string> fileArray = allDirectories ? Directory.EnumerateFiles(DirectoryPath, ".", SearchOption.AllDirectories).Where(e => extensions.Any(x => e.EndsWith(x, StringComparison.OrdinalIgnoreCase))) :
            Directory.EnumerateFiles(DirectoryPath, ".").Where(e => extensions.Any(x => e.EndsWith(x, StringComparison.OrdinalIgnoreCase)));
            List<Models.FileModel> files = new List<Models.FileModel>();
            foreach (var file in fileArray)
                files.Add(new Models.FileModel
                {
                    FileName = Path.GetFileName(file),
                    FilePath = file
                });

            return files;
        }
    }
}
