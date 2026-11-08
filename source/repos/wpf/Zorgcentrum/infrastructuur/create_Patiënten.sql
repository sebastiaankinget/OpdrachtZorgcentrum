CREATE TABLE [dbo].[Patiënten] (
   [Rijkregisternummer] CHAR(11) NOT NULL PRIMARY KEY,
	[Naam] VARCHAR(50) NULL,
	[Voornaam] VARCHAR(50) NULL,

 );

 CREATE TABLE [dbo].[AfdelingenVoorPatiënt] (
	[id] INT NOT NULL PRIMARY KEY,
   [RijkregisternummerPatiënt] CHAR(11) NOT NULL,
   [AfdelingId] INT NOT NULL);

   