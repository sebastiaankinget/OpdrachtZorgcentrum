using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorgcentrum.domein;

namespace ApplicationServices
{
    internal class applicationAfspraak
    {
        public static void RunAfspraken()
        {
            string filePath = "C:\\Users\\Sebas\\source\\repos\\wpf\\Zorgcentrum\\Afspraken.csv";
            int i = 0;

            List<Afspraken> afspraken = LoadCsvAfspraken(filePath);

            foreach (var afspraak in afspraken)
            {



                Console.WriteLine($"{afspraak.Afspraakid} - {afspraak.Type} - {afspraak.Datuumtijdstart} - " +
                        $"{afspraak.DuurMin} - {afspraak.RijksregisterNrPatiënt} - {afspraak.RijksregisterNrArts} - {afspraak.AfdelingCode} - {afspraak.Extra1} - {afspraak.Extra2}");





            }


            static List<Afspraken> LoadCsvAfspraken(string path)
            {
                var result = new List<Afspraken>();

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


                        // Map to class with validation
                        if (values.Length < 8)
                        {
                            result.Add(new Afspraken(
                             int.Parse(values[0]), // Afspraakid
                             values[1], // Type
                             DateTime.Parse(values[2]), // Datuumtijdstart
                             int.Parse(values[3]), // DuurMin
                             values[4], // RijksregisterNrPatiënt
                             values[5], // RijksregisterNrArts
                             values[6],// AfdelingCode
                                null,
                           null
                              ));


                        }
                        else if (values.Length < 9)
                        {
                            result.Add(new Afspraken(
                             int.Parse(values[0]), // Afspraakid
                             values[1], // Type
                             DateTime.Parse(values[2]), // Datuumtijdstart
                             int.Parse(values[3]), // DuurMin
                             values[4], // RijksregisterNrPatiënt
                             values[5], // RijksregisterNrArts
                             values[6],// AfdelingCode
                             values[7],// Extra1
                           null
                              ));

                        }

                        else
                        {
                            result.Add(new Afspraken(
                                    int.Parse(values[0]), // Afspraakid
                                    values[1], // Type
                                    DateTime.Parse(values[2]), // Datuumtijdstart
                                    int.Parse(values[3]), // DuurMin
                                    values[4], // RijksregisterNrPatiënt
                                    values[5], // RijksregisterNrArts
                                    values[6], // AfdelingCode
                                    values[7], // Extra1
                                    values[8] // Extra2




                                ));
                        }
                    }
                }

                return result;
            }
        }


    }
}
