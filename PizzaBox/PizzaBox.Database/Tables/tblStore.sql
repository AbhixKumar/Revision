﻿CREATE TABLE [dbo].[tblStore]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [StoreNumber] VARCHAR(20) NOT NULL, 
    [Address] VARCHAR(100) NOT NULL, 
    [PhoneNumber] VARCHAR(18) NOT NULL
)
