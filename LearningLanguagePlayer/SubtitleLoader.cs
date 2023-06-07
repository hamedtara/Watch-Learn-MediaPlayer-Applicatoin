using System.IO;
using System.Text;
using System.Collections.Generic;
using SubtitlesParser;
using SubtitlesParser.Classes;

namespace LearningLanguagePlayer
{
    public class SubtitleLoader
    {
        public List<SubtitleItem> LoadSubtitles(string subtitleFilePath)
        {
            List<SubtitleItem> subtitles = new List<SubtitleItem>();

            if (File.Exists(subtitleFilePath))
            {
                var parser = new SubtitlesParser.Classes.Parsers.SrtParser();
                using (var stream = File.OpenRead(subtitleFilePath))
                {
                    subtitles = parser.ParseStream(stream, Encoding.UTF8);
                }
            }

            return subtitles;
        }
    }
}
