using Zorgcentrum;


using System;
using Zorgcentrum.domein;


Console.WriteLine("Welkom wil je runnen");
int keuze = int.Parse(Console.ReadLine());
Console.WriteLine(keuze);
switch(keuze) { 
case 1:
    Patiënten.RunPatiënten();
    break;
    case 2:
        Artsen.RunArtsen();
        break;
    case 3:
        Afspraken.RunAfspraken();
        break;

}