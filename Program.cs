using System;
using Microsoft.VisualBasic;
using LyricsUnloader.Content;

namespace LyricsUnloader {
    public class Program : LyUnloader
    {

        static string Answer;
        static bool AnswerIsValid;
        public override void aFunction() {

            Console.Write("\n\nPaste the link from 'genius.com' to get the song lyrics: ");
            LyUnloader.url = Console.ReadLine();

            Console.Write("\nFile name: ");
            LyUnloader.name = Console.ReadLine();
            Console.WriteLine("\nFile name has been saved.");

            base.aFunction();

            Console.Write("Show the song lyrics in console? Y/n: ");

            while (!AnswerIsValid) {

                Answer = Console.ReadLine();

                if (Answer == "Y")
                {
                    Console.WriteLine("\n" + SongParsing.SongLyrics);
                    AnswerIsValid = true;
                }
                else if (Answer == "n") {
                    AnswerIsValid = true;
                }
                else {
                    Console.Write("Show song lyrics in console? Y/n: ");
                }
                    
            }
            Console.WriteLine("\nProgram has finished. Press any button to close the console...");
            Console.ReadKey();

        }

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

            LyUnloader lyunloader = new Program();
            lyunloader.aFunction();
        }
    }
}