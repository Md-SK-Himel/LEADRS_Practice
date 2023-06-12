--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DreCaseToxSpec
NOCHECK CONSTRAINT [FK_DreCaseToxSpec_DRE_CASES_DreCaseId]
Alter Table {DB1Name}.dre.DreCaseToxSpec
NOCHECK CONSTRAINT [FK_DreCaseToxSpec_TBL_OPT_TOX_SPEC_TYPE_ToxSpecTypeId]

insert into {DB1Name}.dre.DreCaseToxSpec
(	[DreCaseId],
	[ToxSpecTypeId],
	[BacResult],
	[HospSerResult],
	[WholeBloodResult],
	[Active],
	[DtCreated],
	[DtUpdated],
	[NoAlcohol]
)
select [DRE_CASE_ID],
	[TOX_SPECIMEN_TYPE_ID],
	[BAC_RESULT],
	[HOSP_SER_RESULT],
	[WHOLE_BLOOD_RESULT],
	[ACTIVE],
	[DT_CREATED],
	[DT_UPDATED],
	[NO_ALCOHOL]
from {DB2Name}.dbo.TBL_DRE_CASE_TOXICOLOGY_SPEC
Alter Table {DB1Name}.dre.DreCaseToxSpec
CHECK CONSTRAINT [FK_DreCaseToxSpec_DRE_CASES_DreCaseId]
Alter Table {DB1Name}.dre.DreCaseToxSpec
CHECK CONSTRAINT [FK_DreCaseToxSpec_TBL_OPT_TOX_SPEC_TYPE_ToxSpecTypeId]';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)


