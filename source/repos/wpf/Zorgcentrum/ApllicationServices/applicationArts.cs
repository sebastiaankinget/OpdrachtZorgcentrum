using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorgcentrum.domein;
namespace ApllicationServices
{
    internal class applicationArts
    {
        public static void RunArtsen()
        {
            string filePath = "C:\\Users\\Sebas\\source\\repos\\wpf\\Zorgcentrum\\Artsen.csv";
            int i = 0;

            List<Artsen> artsen = LoadCsvArtsen(filePath);

            List<Artsen> artsenmetfoutRIZIV = new List<Artsen>();
            foreach (var persoon in artsen)
            {

                if (persoon.RIZIV.Replace(".", "").Replace("-", "").Length != 11)
                {


                    artsenmetfoutRIZIV.Add(persoon);

                }


                Console.Write($"{persoon.Rijkregisternummer} - {persoon.Naam} - {persoon.Voornaam} - " +
                        $"{persoon.RIZIV} - {persoon.Specialisatie} - ");
                foreach (var afdeling in persoon.Afdelingen)
                {
                    Console.Write(afdeling);

                }

                Console.WriteLine();


            }




            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Artsen met een ongeldige RIZIV:");
            foreach (var arts in artsenmetfoutRIZIV)
            {
                Console.WriteLine($"{arts.Rijkregisternummer} - {arts.Naam} - {arts.Voornaam} - " +
                    $"{arts.RIZIV} - {arts.Specialisatie} -   {arts.Afdelingen}");
            }
            static List<Artsen> LoadCsvArtsen(string path)
            {
                var result = new List<Artsen>();

                if (!File.Exists(path))
                    throw new FileNotFoundException("CSV file not found.", path);

                using (var reader = new StreamReader(path))
                {
                    bool isHeader = true;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            continue; // Skip empty lines

                        // Skip header row
                        if (isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        // Split by comma (basic CSV parsing)
                        var values = line.Split(';');

                        if (values.Length < 3)
                            throw new FormatException("CSV row does not have enough columns.");

                        // Map to class with validation


                        result.Add(new Artsen(
                            values[0], // rijkregisternummer
                            values[1], // naam
                            values[2],
                             values[3],
                              values[4],
                            values[5].Split('|').ToArray()
                        ));
                    }
                }

                return result;
            }

        }
    }
}
    

