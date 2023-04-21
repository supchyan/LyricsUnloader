using System;

namespace SuperMegaGiagachadApp.Content {
    public class Gigachad {

        public static string url;
        public static string name;
        public virtual void CoolFunction() {
            
            if (url == null) {
                url = Console.ReadLine();
            }

            if (name == null) {
                name = Console.ReadLine();
            }

            bool validLink = false;
            while (!validLink) {
                try {
                    SongParsing.Link(url, name);
                    Console.WriteLine("Data has been unloaded.\n~");
                    validLink = true;
                }
                catch (Exception) {
                    Console.Write("\nCurrent URL is not valid. Try another one: ");
                    url = Console.ReadLine();
                }
            }

        }
    }
}
