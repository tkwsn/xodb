--  
-- Script to Update dbo.X_DictionaryCountry in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryCountry Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryCountry Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryCountry Table'
END
GO


--  
-- Script to Update dbo.X_Contact in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Contact Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Contact Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Contact Table'
END
GO


--  
-- Script to Update dbo.X_Company in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Company Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Company Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Company Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryCountryState in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryCountryState Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryCountryState Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryCountryState Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryLocationType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryLocationType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryLocationType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryLocationType Table'
END
GO


--  
-- Script to Update dbo.X_Location in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Location Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Location Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Location Table'
END
GO


--  
-- Script to Update dbo.X_Address in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Address Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [AddressName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [City] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [Email] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [Fax] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [Mobile] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [Phone] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [Postcode] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [State] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Address]
      ALTER COLUMN [Street] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Address Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Address Table'
END
GO


--  
-- Script to Update dbo.X_AssayGroup in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_AssayGroup Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_AssayGroup Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_AssayGroup Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryAssayMethod in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryAssayMethod Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryAssayMethod Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryAssayMethod Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryAssayType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryAssayType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryAssayType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryAssayType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryUnit in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryUnit Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryUnit Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryUnit Table'
END
GO


--  
-- Script to Update dbo.X_Parameter in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Parameter Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Parameter Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Parameter Table'
END
GO


--  
-- Script to Update dbo.X_AssayGroupTest in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_AssayGroupTest Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_AssayGroupTest Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_AssayGroupTest Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySampleCategory in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySampleCategory Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySampleCategory Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySampleCategory Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySampleState in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySampleState Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySampleState Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySampleState Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySampleType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySampleType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySampleType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySampleType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDataStatus in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDataStatus Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDataStatus Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDataStatus Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryGeodeticDatum in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryGeodeticDatum Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryGeodeticDatum Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryGeodeticDatum Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryGeophysicalLogType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryGeophysicalLogType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryGeophysicalLogType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryGeophysicalLogType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryHeightDatum in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryHeightDatum Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryHeightDatum Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryHeightDatum Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryHolePurpose in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryHolePurpose Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryHolePurpose Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryHolePurpose Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryHoleStatus in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryHoleStatus Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryHoleStatus Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryHoleStatus Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryHoleType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryHoleType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryHoleType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryHoleType Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySurveyAccuracy in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySurveyAccuracy Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySurveyAccuracy Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySurveyAccuracy Table'
END
GO


--  
-- Script to Update dbo.X_Tenement in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Tenement Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Tenement Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Tenement Table'
END
GO


--  
-- Script to Update dbo.X_Project in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Project Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Project Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Project Table'
END
GO


--  
-- Script to Update dbo.X_Header in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Header Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Header Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Header Table'
END
GO


--  
-- Script to Update dbo.X_AssayGroupTestSample in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_AssayGroupTestSample Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_AssayGroupTestSample Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_AssayGroupTestSample Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryAssayStandard in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryAssayStandard Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryAssayStandard Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryAssayStandard Table'
END
GO


--  
-- Script to Update dbo.X_AssayGroupStandardTestResult in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_AssayGroupStandardTestResult Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_AssayGroupStandardTestResult Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_AssayGroupStandardTestResult Table'
END
GO


--  
-- Script to Update dbo.X_AssayGroupTestResult in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_AssayGroupTestResult Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_AssayGroupTestResult Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_AssayGroupTestResult Table'
END
GO


--  
-- Script to Update dbo.X_AssayGroupTestResultComment in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_AssayGroupTestResultComment Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_AssayGroupTestResultComment Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_AssayGroupTestResultComment Table'
END
GO


--  
-- Script to Update dbo.X_AssayGroupTestResultDuplicate in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_AssayGroupTestResultDuplicate Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_AssayGroupTestResultDuplicate Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_AssayGroupTestResultDuplicate Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDimension in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDimension Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDimension Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDimension Table'
END
GO


--  
-- Script to Update dbo.X_BlockModel in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_BlockModel Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_BlockModel Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_BlockModel Table'
END
GO


--  
-- Script to Update dbo.X_BlockModelBlock in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_BlockModelBlock Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_BlockModelBlock Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_BlockModelBlock Table'
END
GO


--  
-- Script to Update dbo.X_BlockModelBlockData in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_BlockModelBlockData Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_BlockModelBlockData Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_BlockModelBlockData Table'
END
GO


--  
-- Script to Update dbo.X_BlockModelMetadata in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_BlockModelMetadata Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_BlockModelMetadata Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_BlockModelMetadata Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDrillCasingType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDrillCasingType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDrillCasingType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDrillCasingType Table'
END
GO


--  
-- Script to Update dbo.X_Casing in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Casing Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Casing Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Casing Table'
END
GO


--  
-- Script to Update dbo.X_Cementing in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Cementing Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Cementing Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Cementing Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryAlteration in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryAlteration Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryAlteration Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryAlteration Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryBedSpacing in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryBedSpacing Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryBedSpacing Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryBedSpacing Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDefectCompleteness in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDefectCompleteness Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDefectCompleteness Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDefectCompleteness Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDefectContinuity in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDefectContinuity Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDefectContinuity Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDefectContinuity Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDefectType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDefectType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDefectType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDefectType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDipOrientationMethod in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDipOrientationMethod Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDipOrientationMethod Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDipOrientationMethod Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryEstimatedStrength in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryEstimatedStrength Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryEstimatedStrength Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryEstimatedStrength Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryInfillMode in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryInfillMode Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryInfillMode Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryInfillMode Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryInfillType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryInfillType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryInfillType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryInfillType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMoistureSensitivity in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMoistureSensitivity Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMoistureSensitivity Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMoistureSensitivity Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryPlasticity in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryPlasticity Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryPlasticity Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryPlasticity Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryRockMassUnitType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryRockMassUnitType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryRockMassUnitType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryRockMassUnitType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryShape in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryShape Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryShape Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryShape Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySurfaceRoughness in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySurfaceRoughness Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySurfaceRoughness Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySurfaceRoughness Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryWeathering in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryWeathering Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryWeathering Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryWeathering Table'
END
GO


--  
-- Script to Update dbo.X_Defect in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Defect Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Defect Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Defect Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDrillBitType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDrillBitType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDrillBitType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDrillBitType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDrillFluid in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDrillFluid Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDrillFluid Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDrillFluid Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDrillRigType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDrillRigType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDrillRigType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDrillRigType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDrillSize in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDrillSize Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDrillSize Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDrillSize Table'
END
GO


--  
-- Script to Update dbo.X_Drilling in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Drilling Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Drilling Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Drilling Table'
END
GO


--  
-- Script to Update dbo.X_Geology in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Geology Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Geology Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Geology Table'
END
GO


--  
-- Script to Update dbo.X_Geophysics in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Geophysics Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Geophysics Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Geophysics Table'
END
GO


--  
-- Script to Update dbo.X_GeophysicsMetadata in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_GeophysicsMetadata Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_GeophysicsMetadata Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_GeophysicsMetadata Table'
END
GO


--  
-- Script to Update dbo.X_GeophyicsData in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_GeophyicsData Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_GeophyicsData Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_GeophyicsData Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryAdjective in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryAdjective Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryAdjective Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryAdjective Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryBasalContact in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryBasalContact Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryBasalContact Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryBasalContact Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryColour in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryColour Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryColour Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryColour Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryCoreState in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryCoreState Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryCoreState Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryCoreState Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDefectSpacing in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDefectSpacing Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDefectSpacing Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDefectSpacing Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDomain in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDomain Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDomain Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDomain Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryGasDetected in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryGasDetected Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryGasDetected Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryGasDetected Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryHorizon in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryHorizon Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryHorizon Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryHorizon Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryHue in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryHue Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryHue Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryHue Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryIntervalStatus in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryIntervalStatus Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryIntervalStatus Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryIntervalStatus Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryLithologyInterrelation in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryLithologyInterrelation Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryLithologyInterrelation Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryLithologyInterrelation Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryLithologyQualifier in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryLithologyQualifier Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryLithologyQualifier Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryLithologyQualifier Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryLithologyType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryLithologyType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryLithologyType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryLithologyType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMechanicalState in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMechanicalState Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMechanicalState Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMechanicalState Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMineralAndFossilAbundance in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMineralAndFossilAbundance Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMineralAndFossilAbundance Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMineralAndFossilAbundance Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMineralAndFossilAssociation in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMineralAndFossilAssociation Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMineralAndFossilAssociation Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMineralAndFossilAssociation Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMineralAndFossilType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMineralAndFossilType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMineralAndFossilType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMineralAndFossilType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryPly in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryPly Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryPly Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryPly Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySeam in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySeam Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySeam Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySeam Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySedimentaryFeature in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySedimentaryFeature Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySedimentaryFeature Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySedimentaryFeature Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryShade in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryShade Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryShade Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryShade Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryStratigraphy in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryStratigraphy Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryStratigraphy Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryStratigraphy Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryTexture in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryTexture Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryTexture Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryTexture Table'
END
GO


--  
-- Script to Update dbo.X_Lithology in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Lithology Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Lithology Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Lithology Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMineralAbundance in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMineralAbundance Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMineralAbundance Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMineralAbundance Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMineralForm in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMineralForm Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMineralForm Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMineralForm Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMineralStyle in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMineralStyle Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMineralStyle Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMineralStyle Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryMineralType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryMineralType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryMineralType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryMineralType Table'
END
GO


--  
-- Script to Update dbo.X_Mineralogy in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Mineralogy Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Mineralogy Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Mineralogy Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryFailureMode in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryFailureMode Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryFailureMode Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryFailureMode Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryPointLoadTestType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryPointLoadTestType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryPointLoadTestType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryPointLoadTestType Table'
END
GO


--  
-- Script to Update dbo.X_PointLoad in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_PointLoad Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_PointLoad Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_PointLoad Table'
END
GO


--  
-- Script to Update dbo.X_Recovery in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Recovery Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Recovery Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Recovery Table'
END
GO


--  
-- Script to Update dbo.X_Composite in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Composite Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Composite Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Composite Table'
END
GO


--  
-- Script to Update dbo.X_CompositeData in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_CompositeData Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_CompositeData Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_CompositeData Table'
END
GO


--  
-- Script to Update dbo.X_Dictionary in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Dictionary Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   IF EXISTS (SELECT name FROM sysobjects WHERE name = N'PK_Dictionary')
      ALTER TABLE [dbo].[X_Dictionary] DROP CONSTRAINT [PK_Dictionary]
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Dictionary]
      ALTER COLUMN [CategoryID] [nvarchar] (15) COLLATE Latin1_General_CI_AS NOT NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Dictionary]
      ALTER COLUMN [CodeID] [nvarchar] (16) COLLATE Latin1_General_CI_AS NOT NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Dictionary]
      ALTER COLUMN [Description] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_Dictionary] ADD CONSTRAINT [PK_Dictionary] PRIMARY KEY CLUSTERED ([CategoryID], [CodeID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Dictionary Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Dictionary Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryAssayTest in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryAssayTest Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryAssayTest Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryAssayTest Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryCommodity in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryCommodity Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryCommodity Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryCommodity Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDesurveyAlgorithmType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDesurveyAlgorithmType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDesurveyAlgorithmType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDesurveyAlgorithmType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryDomainAlias in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryDomainAlias Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryDomainAlias Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryDomainAlias Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryFlowTestType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryFlowTestType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryFlowTestType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryFlowTestType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryGroup in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryGroup Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryGroup Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryGroup Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryLeaseApplicationType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryLeaseApplicationType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryLeaseApplicationType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryLeaseApplicationType Table'
END
GO


--  
-- Script to Create dbo.X_DictionaryModelStatus in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_DictionaryModelStatus Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO

CREATE TABLE [dbo].[X_DictionaryModelStatus] (
   [ModelStatusID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_X_DictionaryModelStatus_ModelStatusID] DEFAULT (newid()),
   [StandardModelStatusName] [nvarchar] (16) COLLATE Latin1_General_CI_AS NOT NULL,
   [CustomModelStatusName] [nvarchar] (16) COLLATE Latin1_General_CI_AS NOT NULL,
   [Description] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL
)
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_DictionaryModelStatus] ADD CONSTRAINT [PK_X_DictionaryModelStatus] PRIMARY KEY CLUSTERED ([ModelStatusID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryModelStatus Table Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_DictionaryModelStatus Table'
END
GO


--  
-- Script to Create dbo.X_DictionaryModel in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_DictionaryModel Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO

CREATE TABLE [dbo].[X_DictionaryModel] (
   [ModelID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_X_DictionaryModel_ModelID] DEFAULT (newid()),
   [StandardModelName] [nvarchar] (60) COLLATE Latin1_General_CI_AS NOT NULL,
   [CustomModelName] [nvarchar] (60) COLLATE Latin1_General_CI_AS NULL,
   [CompanyID] [uniqueidentifier] NULL,
   [OriginalManufacturerName] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL,
   [StatusID] [uniqueidentifier] NULL,
   [Description] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL
)
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_DictionaryModel] ADD CONSTRAINT [PK_X_DictionaryModel] PRIMARY KEY CLUSTERED ([ModelID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryModel Table Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_DictionaryModel Table'
END
GO


--  
-- Script to Create dbo.X_DictionaryModelRelation in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_DictionaryModelRelation Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO

CREATE TABLE [dbo].[X_DictionaryModelRelation] (
   [ModelRelationID] [uniqueidentifier] NOT NULL,
   [OriginalModelID] [uniqueidentifier] NULL,
   [RelatedModelID] [uniqueidentifier] NULL,
   [RelationTypeID] [uniqueidentifier] NULL,
   [Related] [date] NULL CONSTRAINT [DF_X_DictionaryModelRelation_Related] DEFAULT (getdate())
)
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_DictionaryModelRelation] ADD CONSTRAINT [PK_X_DictionaryModelRelation] PRIMARY KEY CLUSTERED ([ModelRelationID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryModelRelation Table Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_DictionaryModelRelation Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryPlyAlias in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryPlyAlias Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryPlyAlias Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryPlyAlias Table'
END
GO


--  
-- Script to Create dbo.X_DictionaryPosition in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_DictionaryPosition Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO

CREATE TABLE [dbo].[X_DictionaryPosition] (
   [PositionID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_X_DictionaryPosition_PositionID] DEFAULT (newid()),
   [StandardPositionName] [nvarchar] (16) COLLATE Latin1_General_CI_AS NOT NULL,
   [CoalPositionName] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL,
   [GoldPositionName] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL,
   [CustomPositionName] [nvarchar] (16) COLLATE Latin1_General_CI_AS NULL,
   [Description] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL
)
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   ALTER TABLE [dbo].[X_DictionaryPosition] ADD CONSTRAINT [PK_X_Position] PRIMARY KEY CLUSTERED ([PositionID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryPosition Table Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_DictionaryPosition Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryProfession in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryProfession Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryProfession Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryProfession Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryProvinceType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryProvinceType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryProvinceType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryProvinceType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryProvinceGroup in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryProvinceGroup Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryProvinceGroup Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryProvinceGroup Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryRelationType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryRelationType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryRelationType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryRelationType Table'
END
GO


--  
-- Script to Update dbo.X_DictionarySeamAlias in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionarySeamAlias Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionarySeamAlias Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionarySeamAlias Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryUsageAuditType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryUsageAuditType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryUsageAuditType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryUsageAuditType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryWorkType in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryWorkType Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryWorkType Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryWorkType Table'
END
GO


--  
-- Script to Update dbo.X_DictionaryWorkTypeRelation in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DictionaryWorkTypeRelation Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryWorkTypeRelation Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DictionaryWorkTypeRelation Table'
END
GO


--  
-- Script to Update dbo.X_DrillCompanyContract in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_DrillCompanyContract Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DrillCompanyContract Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_DrillCompanyContract Table'
END
GO


--  
-- Script to Update dbo.X_Experience in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Experience Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Experience Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Experience Table'
END
GO


--  
-- Script to Update dbo.X_FileData in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_FileData Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_FileData Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_FileData Table'
END
GO


--  
-- Script to Update dbo.X_Lease in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Lease Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Lease Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Lease Table'
END
GO


--  
-- Script to Update dbo.X_LeaseApplication in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_LeaseApplication Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_LeaseApplication Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_LeaseApplication Table'
END
GO


--  
-- Script to Update dbo.X_LocationAlias in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_LocationAlias Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_LocationAlias Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_LocationAlias Table'
END
GO


--  
-- Script to Update dbo.X_MetaData in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_MetaData Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_MetaData Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_MetaData Table'
END
GO


--  
-- Script to Update dbo.X_MetaDataRelation in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_MetaDataRelation Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_MetaDataRelation Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_MetaDataRelation Table'
END
GO


--  
-- Script to Update dbo.X_PrivateData in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_PrivateData Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_PrivateData Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_PrivateData Table'
END
GO


--  
-- Script to Update dbo.X_ProjectPlan in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_ProjectPlan Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_ProjectPlan Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_ProjectPlan Table'
END
GO


--  
-- Script to Update dbo.X_ProjectPlanTask in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_ProjectPlanTask Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_ProjectPlanTask Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_ProjectPlanTask Table'
END
GO


--  
-- Script to Update dbo.X_ProjectPlanTaskResponse in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_ProjectPlanTaskResponse Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_ProjectPlanTaskResponse Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_ProjectPlanTaskResponse Table'
END
GO


--  
-- Script to Update dbo.X_ProjectPlanTaskWorker in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_ProjectPlanTaskWorker Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_ProjectPlanTaskWorker Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_ProjectPlanTaskWorker Table'
END
GO


--  
-- Script to Update dbo.X_Prospectus in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Prospectus Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Prospectus Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Prospectus Table'
END
GO


--  
-- Script to Update dbo.X_ProspectusProject in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_ProspectusProject Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_ProspectusProject Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_ProspectusProject Table'
END
GO


--  
-- Script to Update dbo.X_Province in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Province Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Province Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Province Table'
END
GO


--  
-- Script to Update dbo.X_SecurityBlacklist in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_SecurityBlacklist Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_SecurityBlacklist Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_SecurityBlacklist Table'
END
GO


--  
-- Script to Update dbo.X_SecurityWhitelist in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_SecurityWhitelist Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_SecurityWhitelist Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_SecurityWhitelist Table'
END
GO


--  
-- Script to Update dbo.X_Survey in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_Survey Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_Survey Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_Survey Table'
END
GO


--  
-- Script to Update dbo.X_UsageAudit in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_UsageAudit Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_UsageAudit Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_UsageAudit Table'
END
GO


--  
-- Script to Update dbo.X_UserData in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_UserData Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_UserData Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_UserData Table'
END
GO


--  
-- Script to Update dbo.X_WaterFlow in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Updating dbo.X_WaterFlow Table'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_WaterFlow Table Updated Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Update dbo.X_WaterFlow Table'
END
GO


--  
-- Script to Create dbo.X_TRG_BlockModel_NoUpdate in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_TRG_BlockModel_NoUpdate Trigger'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


exec('-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
CREATE TRIGGER [dbo].[X_TRG_BlockModel_NoUpdate]
ON dbo.X_BlockModel
FOR UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON
	declare @isSame as int = 0
	select @isSame=Count(*) from deleted d where d.Approved is not null
	IF @isSame = 1
	BEGIN
		PRINT ''Can''''t Update''
		raiserror(''Updates or deletions to the block model are not allowed after they have been approved'', 16, 1)
		return
	END
END
')
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_TRG_BlockModel_NoUpdate Trigger Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_TRG_BlockModel_NoUpdate Trigger'
END
GO


--  
-- Script to Create dbo.X_TRG_BlockModelBlock_NoUpdate in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_TRG_BlockModelBlock_NoUpdate Trigger'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


exec('-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
CREATE TRIGGER [dbo].[X_TRG_BlockModelBlock_NoUpdate]
ON [dbo].[X_BlockModelBlock]
FOR INSERT,UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON
	declare @isSame as int = 0
	select @isSame=Count(*) from deleted d inner join X_BlockModel b on d.BlockModelID=b.BlockModelId AND b.Approved is not null
	IF @isSame = 1
	BEGIN
		PRINT ''Can''''t Update''
		raiserror(''Updates or deletions to the block model are not allowed after they have been approved'', 16, 1)
		return
	END
END
')
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_TRG_BlockModelBlock_NoUpdate Trigger Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_TRG_BlockModelBlock_NoUpdate Trigger'
END
GO


--  
-- Script to Create dbo.X_TRG_BlockModelMetaData_NoUpdate in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_TRG_BlockModelMetaData_NoUpdate Trigger'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


exec('-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
CREATE TRIGGER [dbo].[X_TRG_BlockModelMetaData_NoUpdate]
ON dbo.X_BlockModelMetadata
FOR INSERT,UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON
	declare @isSame as int = 0
	select @isSame=Count(*) from deleted d inner join X_BlockModel b on d.BlockModelID=b.BlockModelId AND b.Approved is not null
	IF @isSame = 1
	BEGIN
		PRINT ''Can''''t Update''
		raiserror(''Updates or deletions to the block model are not allowed after they have been approved'', 16, 1)
		return
	END
END
')
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_TRG_BlockModelMetaData_NoUpdate Trigger Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_TRG_BlockModelMetaData_NoUpdate Trigger'
END
GO


--  
-- Script to Create dbo.X_TRG_Company_NoUpdateCompanyName in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_TRG_Company_NoUpdateCompanyName Trigger'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


exec('-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
CREATE TRIGGER [dbo].[X_TRG_Company_NoUpdateCompanyName]
ON [dbo].[X_Company]
FOR UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON
	declare @isSame as int = 0
	select @isSame=Count(*) from inserted i inner join deleted d on i.CompanyID=d.CompanyID and i.CompanyName=d.CompanyName
	IF @isSame <> 1
	BEGIN
		PRINT ''Can''''t Update''
		raiserror(''Updates or deletions of the company & company name are not allowed'', 16, 1)
		return
	END
END
')
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_TRG_Company_NoUpdateCompanyName Trigger Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_TRG_Company_NoUpdateCompanyName Trigger'
END
GO


--  
-- Script to Create dbo.X_TRG_PrivateData_UniqueID in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_TRG_PrivateData_UniqueID Trigger'
GO

SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, QUOTED_IDENTIFIER, CONCAT_NULL_YIELDS_NULL ON
GO

SET NUMERIC_ROUNDABORT OFF
GO


exec('-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
CREATE TRIGGER [dbo].[X_TRG_PrivateData_UniqueID]
ON dbo.X_PrivateData
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON
	declare @isnull as int
	select @isnull = count(*) FROM INSERTED I where (I.UniqueID is null)  
	IF @isnull <> 1
	BEGIN
		declare @count as int
		select @count=count(*) from (SELECT TOP 2 T.UniqueID FROM dbo.x_PrivateData T INNER JOIN INSERTED I  ON I.UniqueID is not null and T.UniqueID = I.UniqueID) selection
		IF @count > 1
		BEGIN
			PRINT ''Duplicate''
			raiserror(''Can''''t submit answer to same question twice'', 16, 1)
			return
		END
	END
END
')
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_TRG_PrivateData_UniqueID Trigger Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_TRG_PrivateData_UniqueID Trigger'
END
GO


--  
-- Script to Create dbo.X_DictionaryModel in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_DictionaryModel Table'
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   IF EXISTS (SELECT name FROM sysobjects WHERE name = N'FK_X_DictionaryModel_X_Company')
      ALTER TABLE [dbo].[X_DictionaryModel] DROP CONSTRAINT [FK_X_DictionaryModel_X_Company]
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   IF NOT EXISTS (SELECT name FROM sysobjects WHERE name = N'FK_X_DictionaryModel_X_Company')
      ALTER TABLE [dbo].[X_DictionaryModel] ADD CONSTRAINT [FK_X_DictionaryModel_X_Company] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[X_Company] ([CompanyID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   IF EXISTS (SELECT name FROM sysobjects WHERE name = N'FK_X_DictionaryModel_X_DictionaryModelStatus')
      ALTER TABLE [dbo].[X_DictionaryModel] DROP CONSTRAINT [FK_X_DictionaryModel_X_DictionaryModelStatus]
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   IF NOT EXISTS (SELECT name FROM sysobjects WHERE name = N'FK_X_DictionaryModel_X_DictionaryModelStatus')
      ALTER TABLE [dbo].[X_DictionaryModel] ADD CONSTRAINT [FK_X_DictionaryModel_X_DictionaryModelStatus] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[X_DictionaryModelStatus] ([ModelStatusID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryModel Table Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_DictionaryModel Table'
END
GO


--  
-- Script to Create dbo.X_DictionaryModelRelation in au-bne-lt-017.XODB 
-- Generated Wednesday, December 12, 2012, at 10:16 AM 
--  
-- Please backup au-bne-lt-017.XODB before executing this script
--  
-- ** Script Begin **
BEGIN TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO

PRINT 'Creating dbo.X_DictionaryModelRelation Table'
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   IF EXISTS (SELECT name FROM sysobjects WHERE name = N'FK_X_DictionaryModelRelation_X_DictionaryRelationType')
      ALTER TABLE [dbo].[X_DictionaryModelRelation] DROP CONSTRAINT [FK_X_DictionaryModelRelation_X_DictionaryRelationType]
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
   IF NOT EXISTS (SELECT name FROM sysobjects WHERE name = N'FK_X_DictionaryModelRelation_X_DictionaryRelationType')
      ALTER TABLE [dbo].[X_DictionaryModelRelation] ADD CONSTRAINT [FK_X_DictionaryModelRelation_X_DictionaryRelationType] FOREIGN KEY ([RelationTypeID]) REFERENCES [dbo].[X_DictionaryRelationType] ([RelationTypeID])
GO

IF @@ERROR <> 0
   IF @@TRANCOUNT = 1 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT = 1
BEGIN
   PRINT 'dbo.X_DictionaryModelRelation Table Added Successfully'
   COMMIT TRANSACTION
END ELSE
BEGIN
   PRINT 'Failed To Add dbo.X_DictionaryModelRelation Table'
END
GO

UPDATE X_PrivateData set Value='3' where UniqueID='XODBSchemaVersion'
GO