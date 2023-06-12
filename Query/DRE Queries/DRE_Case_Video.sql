--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
Alter Table {DB1Name}.dre.DRE_Case_Video
NOCHECK CONSTRAINT [FK_DRE_Case_Video_DRE_CASES_DreCaseId]
insert into {DB1Name}.dre.DRE_Case_Video
(	[DreCaseId],
	[VideoS3Url],
	[ArchiveId],
	[ApiKey],
	[Status]
)
select [DRE_CASE_ID],
	[VIDEO_S3_URL],
	[ARCHIVE_ID],
	[API_KEY],0
from {DB2Name}.dbo.TBL_DRE_CASE_VIDEOS
Alter Table {DB1Name}.dre.DRE_Case_Video
CHECK CONSTRAINT [FK_DRE_Case_Video_DRE_CASES_DreCaseId]';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)


