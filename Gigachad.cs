using System;
using SuperMegaGiagachadApp.Content;

namespace SuperMegaGiagachadApp {
    public class Gigachad {
        public static void Main(string[] args) {
                        
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine(@"  _                _                        _                 _           ");
            Console.WriteLine(@" | |              (_)                      | |               | |          ");
            Console.WriteLine(@" | |    _   _ _ __ _  ___ ___   _   _ _ __ | | ___   __ _  __| | ___ _ __ ");
            Console.WriteLine(@" | |   | | | | '__| |/ __/ __| | | | | '_ \| |/ _ \ / _` |/ _` |/ _ \ '__|");
            Console.WriteLine(@" | |___| |_| | |  | | (__\__ \ | |_| | | | | | (_) | (_| | (_| |  __/ |   ");
            Console.WriteLine(@" |______\__, |_|  |_|\___|___/  \__,_|_| |_|_|\___/ \__,_|\__,_|\___|_|   ");
            Console.WriteLine(@"         __/ |                                                            ");
            Console.WriteLine(@"        |___/      ver 1.0    author: supchyan_                           ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nPaste the link from 'genius.com' to get the song lyrics: ");
            string? url = Console.ReadLine();
            Console.Write("\nFile name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("\nFile name has been saved.");
            bool validLink = false;
            while (!validLink) {
                try {
                    SongParsing.Link(url, name);
                    Console.WriteLine("\nData has been unloaded.");
                    validLink = true;
                }
                catch (Exception) {
                    Console.Write("\nCurrent URL is not valid. Try another one: ");
                    url = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
