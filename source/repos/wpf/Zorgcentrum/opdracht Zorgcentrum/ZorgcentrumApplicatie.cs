using Zorgcentrum;


using System;
using Zorgcentrum.domein;
using Zorgcentrum.Application_Services;


Console.WriteLine("Welkom wil je runnen");
int keuze = int.Parse(Console.ReadLine());
Console.WriteLine(keuze);
switch(keuze) { 
case 1:
    PatiëntenApplicationService.RunPatiënten();
    break;

    case 2:
        ArtsenApplicationService.RunArtsen();
        break;
    case 3:
        AfsprakenApplicationService.RunAfspraken();
        break;
    case 4:

        PatiëntenApplicationService.Should_ThrowException_When_ObjectIsNull();
        break;

}