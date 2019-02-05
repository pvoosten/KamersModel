using KamersModel;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace KamersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak spelomgeving aan
            // maak speler
            // plaats speler in spelomgeving
            // begin te spelen
            var spelomgeving = MaakSpelOmgevingAan();
            var speler = MaakSpeler();
            spelomgeving.VoegSpelerToe(speler);
            Speel(spelomgeving);
        }

        private static void Speel(Level spelomgeving)
        {
            string command = "";
            while(command != "stop")
            {
                switch (command)
                {
                    case "toon plaats":
                        // zoek de plaats waar de speler zich
                        // bevindt.
                        // geef de naam van die plaats
                        foreach(var plaats in spelomgeving.Plaatsen)
                        {
                            if(plaats.Speler != null)
                            {
                                Console.WriteLine($"{plaats.Speler} is op plaats {plaats}");
                            }
                        }
                        break;
                    case "schrijf html":
                        SchrijfHtmlBestand(spelomgeving);
                        break;
                    case "help":
                    default:
                        Console.WriteLine("Mogelijke commando's:");
                        Console.WriteLine("schrijf html: schrijft en opent een html-bestand");
                        Console.WriteLine("help: toont deze help");
                        Console.WriteLine("toon plaats: geeft de plaats waar de speler zich bevindt");
                        break;
                }
                command = Console.ReadLine().Trim();
            }
        }

        private static void SchrijfHtmlBestand(Level spelomgeving)
        {
            string htmlInhoud = @"<!doctype html>
<html>
<head><title></title></head>
<body>
voorbeeld schrijven html
</body>
</html>";
            // File.WriteAllText("output.html", htmlInhoud);

            //IDisposable xxx;
            //try
            //{
            //    xxx = ...
            //        // body van using statement
            //}
            //finally
            //{
            //    xxx.Dispose();
            //}

            using (var outputStream = File.OpenWrite("output.html"))
            {
                using(var writer = new StreamWriter(outputStream))
                {
                    writer.WriteLine(htmlInhoud);
                }
            }

            var startInfo = new ProcessStartInfo("output.html");
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);

            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        private static Speler MaakSpeler()
        {
            var speler = new Speler();
            return speler;
        }

        private static Level MaakSpelOmgevingAan()
        {
            var plaats = new Plaats("Cincinatti");
            return new Level(plaats);
        }
    }
}
