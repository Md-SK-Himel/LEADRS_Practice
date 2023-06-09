--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
insert into {DB1Name}.dre.TBL_OPT_DRE_FIRST_INDICATORS
(	[IndType],
	[CnsDep],
	[CnsSti],
	[HALL],
	[DisAne],
	[NarAna],
	[INHA],
	[CANN],
	[IndTypeFullName],
	[DisplayName]
)
select [IndType],
	[CNS_DEP],
	[CNS_STI],
	[HALL],
	[DISS_ANE],
	[NAR_ANA],
	[INHA],
	[CANN],
	[IndTypeFullName],
	[DISPLAY_NAME]
from {DB2Name}.dbo.TBL_OPT_DRE_FIRST_INDICATORS';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)


