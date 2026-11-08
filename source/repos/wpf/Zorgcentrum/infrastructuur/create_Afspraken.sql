CREATE TABLE [dbo].[Patiënten] (
   [AfspraakId] INT NOT NULL PRIMARY KEY,
	[Type] VARCHAR(50) NULL,
	[DatumTijdStart] DATE NULL,
	[Duurmin] INT NULL,
	[RijksregisterNrPatiënt] VARCHAR(50) NULL,
	[RijksregisterNrArts] VARCHAR(50) NULL,
	[AfdelingsCode] VARCHAR(50) NULL,
	[Extra1] VARCHAR(50) NULL,
	[Extra2] INT NULL,
 );