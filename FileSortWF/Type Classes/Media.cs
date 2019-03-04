using FileSortWF.Shared_Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WMPLib;

namespace FileSortWF.TypeClasses
{

    public class Media : Shared_Classes.FileSort
    {
        public Media(String DirectoryPath, String DestinationPath)
        {
            this.DirectoryPath = DirectoryPath;
            this.DestinationPath = DestinationPath;
            Files = GetFiles(Types.media, true);

            SortFiles(Types.media);
        }

        public override void SortFiles(Types type)
        {
            Regex nameRegex = new Regex(@"[^\w]");
            Parallel.ForEach(Files, (currentFile) =>
            {
                string regexedName = Regex.Replace(currentFile.FileName, nameRegex.ToString(), " ");
                string[] nameSplit = regexedName.ToLower().Split(' ');
                List<String> validWords = new List<String>();
                foreach (string word in nameSplit)
                {
                    if (File.ReadAllText(ConfigurationManager.AppSettings["dictionaryPath"]).Contains(word) && !String.IsNullOrEmpty(word))
                    {
                        validWords.Add(word);
                    }
                    else if (validWords.Count > 0) { break; }
                }
                string mediaName = string.Join(" ", validWords);

                var player = new WindowsMediaPlayer();
                var clip = player.newMedia(currentFile.FilePath);
                Types mediaType = TimeSpan.FromSeconds(clip.duration).Minutes > 90 ? mediaType = Types.movies : mediaType = Types.series;

                /*  not used
              JObject mediaObject = GetMediaObject(mediaName);
              Types mediaType;
              if (mediaObject["Response"].Value<bool>() == true)
              {
                  Enum.TryParse(mediaObject["Type"].Value<string>(), out mediaType);
              }
              */

                DirectoryInfo parentFolder = Directory.CreateDirectory(this.DestinationPath + @"\" + mediaType + @"\" + mediaName);
                if (mediaType == Types.movies)
                {
                    try
                    {
                        Directory.Move(currentFile.FilePath, parentFolder.FullName + @"\" + currentFile.FileName);
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (mediaType == Types.series)
                {
                    String seriesSeason = GetSeason(currentFile.FileName);
                    if (String.IsNullOrWhiteSpace(seriesSeason))
                    {
                        try
                        {
                            Directory.Move(currentFile.FilePath, parentFolder.FullName + @"\" + currentFile.FileName);
                        }
                        catch (Exception e)
                        {
                        }
                    }
                    else
                    {
                        try
                        {
                            DirectoryInfo seasonFolder = Directory.CreateDirectory(parentFolder.FullName + @"\Season " + seriesSeason);
                            Directory.Move(currentFile.FilePath, seasonFolder.FullName + @"\" + currentFile.FileName);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            });
          
        }


        public string GetSeason(String seriesFileSName)
        {
            Regex seriesRegex = new Regex(@"[Ss]{1}[0-9]{2}[Ee]{1}[0-9]{2}");
            String seriesSeason = Regex.Match(seriesFileSName, seriesRegex.ToString()).Value;
            Regex seasonRegex = new Regex(@"(?<=[Ss]{1})[\d]{2}");
            String season = "";
            if (!String.IsNullOrWhiteSpace(seriesSeason))
            {
                season = Regex.Match(seriesSeason, seasonRegex.ToString()).Value;
            }
            return season;
        }
        public JObject GetMediaObject(string media = "")
        {
            JObject JsonData = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.omdbapi.com/?apikey=" + ConfigurationManager.AppSettings["omdbAPIkey"] + "&t=" + media);

                request.Method = WebRequestMethods.Http.Get;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    String data = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    JsonData = (JObject)JsonConvert.DeserializeObject(data);
                }
            }
            catch (WebException ex)
            {
            }
            return JsonData;
        }
    }
}
