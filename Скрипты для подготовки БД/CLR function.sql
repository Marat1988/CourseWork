ALTER DATABASE Hostel SET TRUSTWORTHY ON;
GO

USE Hostel;
GO
EXEC sp_configure'clr enabled', 1;
GO
RECONFIGURE
GO

CREATE ASSEMBLY MyDownloadFilePortal
FROM 'C:\Export\DownloadFilePortal.dll'
WITH PERMISSION_SET = UNSAFE
GO

CREATE FUNCTION [dbo].[CLR_DownloadFilePortal](@UrlPortal [NVARCHAR](MAX), @IndexDocumentFormat [INT], @SaveРath [nvarchar](50))
RETURNS [BIT] WITH EXECUTE AS CALLER
AS
EXTERNAL NAME [MyDownloadFilePortal].[DownloadFilePortal.DownloadFile].[ExportReportToFormat]
GO
