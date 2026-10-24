using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zorgcentrum.domein
{
    public class Persoon
    {
        private string _rijkregisternummer;
        private string _naam;
        private string _voornaam;

        public string Rijkregisternummer
        {
            get => _rijkregisternummer;
            init
            {
               

                _rijkregisternummer = value;
            }
        }

        public string Naam {
            get => _naam;

            init { _naam = value; }
        
        }
        public string Voornaam
        {
            get => _voornaam;

            init { _voornaam = value; }

        }


        public Persoon(string rijkregisternummer , string naam, string voornaam)
        {
            Rijkregisternummer = rijkregisternummer;

            Naam = naam;
           
            Voornaam = voornaam;
        }

  
    }


}
