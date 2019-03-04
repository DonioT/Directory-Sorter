using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSortWF.Shared_Classes
{
    public enum Types
    {
        documents,
        applications,
        media,
        images,
        series,
        movies,
        compressedfiles,
        music

    }
    public class Extensions
    {
        public static List<String> GetExtensions(Types type)
        {
            List<String> extensionList = null;
            switch (type)
            {
                case (Types.documents):
                    extensionList = new List<String>
                    {
                         "doc" , "docx", "odt", "ppt", "pptx", "txt", "xls", "xlsx", "pdf", "wpd", "wks", "csv"
                    };
                    break;

                case (Types.applications):
                    extensionList = new List<String>
                    {
                         "exe" , "msi", "iso", "msu"
                    };
                    break;
                case (Types.images):
                    extensionList = new List<String>
                    {
                        "jpg", "png", "tff", "gif", "jpeg", "svg", "bmp"
                    };
                    break;
                case (Types.media):
                    extensionList = new List<String>
                    {
                        "flv", "avi", "mov", "mkv", "mp4"
                    };
                    break;
                case (Types.compressedfiles):
                    extensionList = new List<String>
                    {
                        "rar", "zip", "7z"
                    };
                    break;
                case (Types.music):
                    extensionList = new List<String>
                    {
                        "mp3", "wav", "aac", "ogg", "ac3", "flac"
                    };
                    break;
            }
            return extensionList;
        }
    }
}
