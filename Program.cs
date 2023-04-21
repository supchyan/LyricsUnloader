using System;
using Microsoft.VisualBasic;
using SuperMegaGiagachadApp.Content;

namespace SuperMegaGiagachadApp {
    public class Program : Gigachad {

        static string Answer;
        static bool AnswerIsValid;
        public override void CoolFunction() {

            Console.Write("\n\nPaste the link from 'genius.com' to get the song lyrics: ");
            Gigachad.url = Console.ReadLine();

            Console.Write("\nFile name: ");
            Gigachad.name = Console.ReadLine();
            Console.WriteLine("\nFile name has been saved.");

            base.CoolFunction();

            Console.Write("Show song lyrics in console? Y/n: ");

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
            Console.WriteLine("\nProgram finished it's work. Press any button to close the console...");

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

            Gigachad gigachad = new Program();
            gigachad.CoolFunction();
        }
    }
}