using FileSortWF.Shared_Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSortWF.TypeClasses
{
    public class Default : Shared_Classes.FileSort
    {
        public Default(String DirectoryPath, String DestinationPath, Types type)
        {
            this.DirectoryPath = DirectoryPath;
            this.DestinationPath = DestinationPath;
            Files = GetFiles(type, false);
            SortFiles(type);
        }
        public override void SortFiles(Types type)
        {
            DirectoryInfo parentFolder = null;
            if (Files.Count > 0)
            {
                parentFolder = Directory.CreateDirectory(this.DestinationPath + @"\" + type);
            }
            Parallel.ForEach(Files, (currentFile) => {
                Directory.Move(currentFile.FilePath, parentFolder.FullName + @"\" + currentFile.FileName);
            });
          
        }
    }
}
