USE master
 GO

 ALTER DATABASE XODB
 SET OFFLINE WITH ROLLBACK IMMEDIATE
 ALTER DATABASE XODB
 SET ONLINE
 GO

 USE XODB
 GO