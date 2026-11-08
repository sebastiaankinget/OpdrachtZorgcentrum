CREATE TABLE [dbo].[Artsen] (
   [Rijkregisternummer] CHAR(11) NOT NULL PRIMARY KEY,
	[Naam] VARCHAR(50) NULL,
	[Voornaam] VARCHAR(50) NULL,
	[RIZIV] TEKST NULL,
	[Specialisatie] TEKST  NULL
 );
 
CREATE TABLE [dbo].[AfdelingenVoorArts] (
	[id] INT NOT NULL PRIMARY KEY,
   [RijkregisternummerArts] CHAR(11) NOT NULL,
   [AfdelingId] INT NOT NULL);

   