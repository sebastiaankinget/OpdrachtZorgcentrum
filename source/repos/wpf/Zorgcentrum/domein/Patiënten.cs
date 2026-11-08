using Example;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApplicationServices;
namespace Zorgcentrum.domein
{
    public class Patiënten : Persoon
    {
        private string[] _afdelingen;

        public Array Afdelingen
        {
            get => _afdelingen;

            init { _afdelingen = (string[])value; }

        }



        public Patiënten(string rijkregisternummer, string naam, string voornaam, string[] afdelingen) : base(rijkregisternummer, naam, voornaam)
        {
            Afdelingen = afdelingen;
        }

       

    }
} 
