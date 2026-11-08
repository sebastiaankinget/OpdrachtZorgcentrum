using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using Zorgcentrum.domein;
namespace Zorgcentrum.domein
{
    public class Artsen : Persoon
    {
        private string[] _afdelingen;

        public Array Afdelingen
        {
            get => _afdelingen;

            init { _afdelingen = (string[])value; }

        }



        private string _RIZIV;

        public string RIZIV
        {
            get => _RIZIV;
            init
            {


                _RIZIV = value;
            }
        }
        private string _specialisatie;


        public string Specialisatie
        {
            get => _specialisatie;
            init
            {


                _specialisatie = value;
            }
        }

        public Artsen(string rijkregisternummer, string naam, string voornaam, string rIZIV, string specialisatie, string[] afdelingen) : base(rijkregisternummer, naam, voornaam)
        {
            Afdelingen = afdelingen;
            RIZIV = rIZIV;
            Specialisatie = specialisatie;
        }


      
    
   
       

        } } 

