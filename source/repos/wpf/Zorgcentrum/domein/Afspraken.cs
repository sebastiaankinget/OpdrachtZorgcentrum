using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Zorgcentrum.domein;
namespace Zorgcentrum.domein
{
    public class Afspraken
    {
        private int _afspraakid;

        public int Afspraakid
        {
            get => _afspraakid; init
            {
                _afspraakid = value;
            }
        }


        private string _type;
        public string Type
        {
            get => _type;
            init
            {
                _type = value;
            }
        }
        private int _duurMin;

        public int DuurMin
        {
            get => _duurMin; init
            {
                _duurMin = value;
            }
        }

        private string _rijksregisterNrPatiënt;

        public string RijksregisterNrPatiënt
        {
            get => _rijksregisterNrPatiënt; init
            {
                _rijksregisterNrPatiënt = value;
            }
        }
        private string _rijksregisterNrArts;

        public string RijksregisterNrArts
        {
            get => _rijksregisterNrArts; init
            {
                _rijksregisterNrArts = value;
            }
        }
        private string _afdelingCode;

        public string AfdelingCode
        {
            get => _afdelingCode; init
            {
                _afdelingCode = value;
            }
        }
        private string _extra1;
        public string Extra1
        {
            get => _extra1; init
            {
                _extra1 = value;
            }
        }
        private string _extra2;
        public string Extra2
        {
            get => _extra2; init
            {
                _extra2 = value;
            }
        }


        private DateTime _datuumtijdstart;

        public DateTime Datuumtijdstart
        {

            get => _datuumtijdstart;
            init
            {
                _datuumtijdstart = value;
            }
        }


        public Afspraken(int afspraakid, string type, DateTime datuumtijdstart, int duurMin, string rijksregisterNrPatiënt, string rijksregisterNrArts,
            string afdelingCode, string extra1, string extra2)
        {
            Afspraakid = afspraakid;
            Type = type;
            Datuumtijdstart = datuumtijdstart;
            DuurMin = duurMin;
            RijksregisterNrPatiënt = rijksregisterNrPatiënt;
            RijksregisterNrArts = rijksregisterNrArts;
            AfdelingCode = afdelingCode;
            Extra1 = extra1;

            Extra2 = extra2;
        }



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
