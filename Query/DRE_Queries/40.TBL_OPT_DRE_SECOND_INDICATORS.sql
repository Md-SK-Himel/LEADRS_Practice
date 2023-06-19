DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
insert into {DB1Name}.dre.TBL_OPT_DRE_SECOND_INDICATORS
(	[IndType],
	[IndTypeFullName],
	[CnsDep],
	[CnsSti],
	[Hall],
	[DissAne],
	[NarAna],
	[Inha],
	[Cann]
)
select [IND_TYPE],
	[IND_TYPE_FULL_NAME],
	CAST([CNS_DEP] AS nvarchar(max)),
	CAST([CNS_STI] AS nvarchar(max)),
	CAST([HALL] AS nvarchar(max)),
	CAST([DISS_ANE] AS nvarchar(max)),
	CAST([NAR_ANA] AS nvarchar(max)),
	CAST([INHA] AS nvarchar(max)),
	CAST([CANN] AS nvarchar(max))
from {DB2Name}.dbo.TBL_DRE_CASE_INDICATORS_SECOND';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)


