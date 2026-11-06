CREATE TABLE [dbo].[Patiënten] (
   [Rijkregisternummer] CHAR(11) NOT NULL PRIMARY KEY,
	[Naam] VARCHAR(50) NULL,
	[Voornaam] VARCHAR(50) NULL,
	[Afdelingen] INTEGER[]	NULL
 );