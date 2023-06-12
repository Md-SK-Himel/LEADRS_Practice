--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
set IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_INTOX_SALIVA_SCREEN ON
Alter Table {DB1Name}.dre.DRE_CASE_INTOX_SALIVA_SCREEN
NOCHECK CONSTRAINT [FK_DRE_CASE_INTOX_SALIVA_SCREEN_DRE_CASE_INTOXILYZER_REPORT_DreCaseIntoxilyzerReportId]

insert into {DB1Name}.dre.DRE_CASE_INTOX_SALIVA_SCREEN
([DreSalivaToxResultId],
	DreCaseIntoxilyzerReportId,
	ToxScreenResultId,
	Comment
)
select DRE_SALIVA_TOX_RESULT_ID,
	DRE_INTOX_ID,
	TOX_SCREEN_RESULT_ID,
	COMMENT
from {DB2Name}.dbo.TBL_DRE_CASE_INTOX_SALIVA_SCREEN
Alter Table {DB1Name}.dre.DRE_CASE_INTOX_SALIVA_SCREEN
CHECK CONSTRAINT [FK_DRE_CASE_INTOX_SALIVA_SCREEN_DRE_CASE_INTOXILYZER_REPORT_DreCaseIntoxilyzerReportId]

set IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_INTOX_SALIVA_SCREEN OFF';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)


EXECUTE (@SQL_SCRIPT)

