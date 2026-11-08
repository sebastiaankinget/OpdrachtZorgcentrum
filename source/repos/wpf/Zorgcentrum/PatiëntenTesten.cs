using System;

using Zorgcentrum.domein;
using ApplicationServices;
using Zorgcentrum;

using Xunit;
using Example;

/*namespace Zorgcentrum.domein.testen
{
    public class PatiëntenTesten
    {
        [Fact]
        public static void Should_ThrowException_When_ObjectIsNull()
        {
            // Provide required constructor arguments for Patiënten
            var patiënt = new Patiënten(
                rijkregisternummer: "12345678901",
                naam: "TestNaam",
                voornaam: "TestVoornaam",
                afdelingen: new string[] { "Afdeling1" }
            );

            ArgumentNullException argumentNullException = Assert.Throws<ArgumentNullException>(() => patiënt.Equals(null));
        }
    }
}*/