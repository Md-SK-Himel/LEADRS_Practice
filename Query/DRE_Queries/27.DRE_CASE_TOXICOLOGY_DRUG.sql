--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
set IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_TOXICOLOGY_DRUG ON

insert into {DB1Name}.dre.DRE_CASE_TOXICOLOGY_DRUG
(	[DreCaseToxDrugId],
	[DreCaseId],
	[DreCaseToxSpecId],
	[DpsDrugListId],
	[DrugResult],
	[DrugMeasurement]
)
select [TBL_DRE_CASE_TOXICOLOGY_DRUG_ID],
	TBL_DRE_CASE_TOXICOLOGY_DRUG.[DRE_CASE_ID],
	[CASE_TOX_SPEC_ID],
	[DPS_DRUG_LIST_ID],
	[DRUG_RESULT],
	[DRUG_MEASUREMENT]
from {DB2Name}.dbo.TBL_DRE_CASE_TOXICOLOGY_DRUG
	,LEADRS_TX_STAGING.dbo.TBL_DRE_CASE
WHERE TBL_DRE_CASE_TOXICOLOGY_DRUG.DRE_CASE_ID = TBL_DRE_CASE.DRE_CASE_ID
	AND
	[TBL_DRE_CASE_TOXICOLOGY_DRUG_ID] NOT IN (
    SELECT [DreCaseToxDrugId]
    FROM {DB1Name}.dre.DRE_CASE_TOXICOLOGY_DRUG
	WHERE DRE_CASE_TOXICOLOGY_DRUG.DreCaseId = TBL_DRE_CASE.DRE_CASE_ID
)

set IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_TOXICOLOGY_DRUG OFF';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)
