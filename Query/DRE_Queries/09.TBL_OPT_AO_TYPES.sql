--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
SET IDENTITY_INSERT {DB1Name}.dre.TBL_OPT_AO_TYPES ON

insert into {DB1Name}.dre.TBL_OPT_AO_TYPES
(	[ArrestingOfficerTypeId],
	[OfficerType],
	[Active]
)
VALUES
	(1, N''Same as Evaluator'', 1),
	(2, N''N/A'', 1),
	(3, N''Other DRE'', 1),
	(4, N''Other'', 1)

SET IDENTITY_INSERT {DB1Name}.dre.TBL_OPT_AO_TYPES OFF ';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)

EXECUTE (@SQL_SCRIPT)