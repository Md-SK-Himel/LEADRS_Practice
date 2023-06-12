--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASE_INDICATORS
NOCHECK CONSTRAINT [FK_DRE_CASE_INDICATORS_DRE_CASES_DreCaseId]

insert into {DB1Name}.dre.DRE_CASE_INDICATORS
(BpInd,
	BtInd,
	Cann,
	CnsDep,
	CnsSti,
	DissAne,
	HallBody,
	HgnInd,
	Inha,
	LocInd,
	MstInd,
	NarAna,
	OpAlcohol,
	OpCannabis,
	OpCnsDepressant,
	OpCnsStimulant,
	OpDissAnesthetic,
	OpHallucinogen,
	OpInhalant,
	OpMedical,
	OpNarcoticAnalgesic,
	OpNotImpaired,
	PrInd,
	PsInd,
	RtlInd,
	VgnInd,
	DreCaseId
)
select BP_IND,
	BT_IND,
	CANN,
	CNS_DEP,
	CNS_STI,
	DISS_ANE,
	HALL_BODY,
	HGN_IND,
	INHA,
	LOC_IND,
	MST_IND,
	NAR_ANA,
	OP_ALCOHOL,
	OP_CANNABIS,
	OP_CNS_DEPRESSANT,
	OP_CNS_STIMULANT,
	OP_DISS_ANESTHETIC,
	OP_HALLUCINOGEN,
	OP_INHALANT,
	OP_MEDICAL,
	OP_NARCOTIC_ANALGESIC,
	OP_NOT_IMPAIRED,
	PR_IND,
	PS_IND,
	RTL_IND,
	VGN_IND,
	DRE_CASE_ID
from {DB2Name}.dbo.TBL_DRE_CASE_INDICATORS ORDER BY DRE_CASE_IND_ID
Alter Table {DB1Name}.dre.DRE_CASE_INDICATORS
CHECK CONSTRAINT [FK_DRE_CASE_INDICATORS_DRE_CASES_DreCaseId]';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)


EXECUTE (@SQL_SCRIPT)




