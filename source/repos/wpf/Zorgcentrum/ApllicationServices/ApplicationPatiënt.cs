using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorgcentrum.domein;

namespace ApllicationServices
{
    internal class ApplicationPatiënt
    {
        public static void RunPatiënten()
        {
            string filePath = "C:\\Users\\Sebas\\source\\repos\\wpf\\Zorgcentrum\\Patiënten.csv";
            int i = 0;

            List<Patiënten> patiënten = LoadCsvPatiënten(filePath);

            foreach (var persoon in patiënten)
            {



                Console.Write($"{persoon.Rijkregisternummer} - {persoon.Naam} - {persoon.Voornaam} - " +
                        $"- ");


                foreach (var afdeling in persoon.Afdelingen)
                {
                    Console.Write(afdeling); Console.Write(" ");

                }
                Console.WriteLine();


            }


            static List<Patiënten> LoadCsvPatiënten(string path)
            {
                var result = new List<Patiënten>();

                if (!File.Exists(path))
                    throw new FileNotFoundException("CSV file not found.", path);

                using (var reader = new StreamReader(path))
                {
                    bool isHeader = true;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();




                        var values = line.Split(';');




                        result.Add(new Patiënten(
                            values[0], // rijkregisternummer
                            values[1], // naam
                            values[2], // voornaam
                            values[3].Split(',').ToArray()   // afdelingen (empty array as placeholder)
                        ));
                    }
                }

                return result;
            }
        }
    }
}
    