using System;
using HtmlAgilityPack;

namespace LyricsUnloader.Content {
    public static class SongParsing {

        public static string SongLyrics;
        public static void Link(string link, string name) {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            HtmlWeb web = new HtmlWeb();  
            HtmlDocument document = web.Load(link);

            HtmlNode title = document.DocumentNode.SelectSingleNode("//head/title");
            HtmlNode[] songText = document.DocumentNode.SelectNodes("//div[@id='lyrics-root']/div[@data-lyrics-container='true']").ToArray();

            StreamWriter Lyrics = new StreamWriter(name + ".txt");

            Console.WriteLine("\n-----\n" + title.InnerHtml + "\n-----\n");
            Lyrics.WriteLine(title.InnerHtml + "\n");

            foreach (HtmlNode item in songText) {
                
                item.InnerHtml = item.InnerHtml.Replace("<br>", "\n");
                item.InnerHtml = item.InnerHtml.Replace("&#x27;", "'");

                string[] trashCleaner = item.InnerHtml.ToString().Split("\n");

                for (int i = 0; i < trashCleaner.Length; i++) {
                    if(!trashCleaner[i].Contains("<")) {
                        
                        Lyrics.WriteLine(trashCleaner[i]);
                        SongLyrics += trashCleaner[i] + "\n";
                    }
                }
            }
            Lyrics.Close();
        }
    }
}
