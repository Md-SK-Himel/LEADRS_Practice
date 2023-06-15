--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '

insert into {DB1Name}.dre.DRE_DEFENDANTS
(	DreCaseId,
	Age,
	DOB,
	EthnicityId,
	FirstName,
	LastName,
	MiddleName,
	RaceId,
	SexId,
	ArrestingOfficerAgency,
	ArrestingOfficerId,
	ArrestingOfficerName,
	ArrestingOfficerTypeId
)
select DRE_CASE_ID,
	DEF_AGE,
	DEF_DOB,
	Def_Ethnicity_ID,
	DEF_FNAME,
	DEF_LNAME,
	DEF_MNAME,
	DEF_RACE_ID,
	DEF_GENDER_ID,
	ARR_OFF_AGENCY,
	ARR_OFF_ID,
	ARR_OFF_NAME,
	ARR_OFF_TYPE_ID
from {DB2Name}.dbo.TBL_DRE_CASE
WHERE [DRE_CASE_ID] NOT IN (
    SELECT [DreCaseId]
    FROM {DB1Name}.dre.DRE_DEFENDANTS
	WHERE DRE_DEFENDANTS.DreCaseId = TBL_DRE_CASE.DRE_CASE_ID
)';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)


