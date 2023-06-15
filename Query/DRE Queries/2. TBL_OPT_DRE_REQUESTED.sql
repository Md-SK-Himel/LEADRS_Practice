--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
SET IDENTITY_INSERT {DB1Name}.dre.TBL_OPT_DRE_REQUESTED ON

insert into {DB1Name}.dre.TBL_OPT_DRE_REQUESTED
(	[DreRequestedId],
	[Description],
	[Active]
)
select [DRE_REQUESTED_ID],
	[DRE_REQUESTED_DESC],
	[ACTIVE]
from {DB2Name}.dbo.TBL_OPT_DRE_REQUESTED
WHERE [DRE_REQUESTED_ID] NOT IN (
    SELECT [DreRequestedId]
    FROM {DB1Name}.dre.TBL_OPT_DRE_REQUESTED
)
SET IDENTITY_INSERT {DB1Name}.dre.TBL_OPT_DRE_REQUESTED OFF ';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)

