--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
set IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_PIC ON

Alter Table {DB1Name}.dre.DRE_CASE_PIC
NOCHECK CONSTRAINT [FK_DRE_CASE_PIC_DRE_CASES_DreCaseId]
insert into {DB1Name}.dre.DRE_CASE_PIC
(	DreCasePictureId,
	[DreCaseId],
	[Section],
	[Sequence],
	[ImageData]
)
select DRE_CASE_PIC_ID,
	[DRE_CASE_ID],
	[SECTION],
	[SEQUENCE],
	[IMAGE_DATA]
from {DB2Name}.dbo.TBL_DRE_CASE_PIC;
Alter Table {DB1Name}.dre.DRE_CASE_PIC
CHECK CONSTRAINT [FK_DRE_CASE_PIC_DRE_CASES_DreCaseId]
set IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_PIC OFF';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)

