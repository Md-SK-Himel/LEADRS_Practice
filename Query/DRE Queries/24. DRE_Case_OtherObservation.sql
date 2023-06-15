--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '

insert into {DB1Name}.dre.DRE_Case_OtherObservation
(	DreCaseId,
	EvalCompletionTime,
	InjComments,
	InjLaText,
	InjRaText,
	MtComments,
	MtFlaccid,
	MtNormal,
	MtRigid,
	PulseRate3,
	PulseSite3,
	PulseTime3,
	SubDrugs,
	SubDrugsQty,
	SubDrugsTime,
	SubDrugsWhere,
	SubOtherComments,
	SubRefusedEval,
	SubStopPartEval
)
select DRE_CASE_ID,
	EVAL_COMPLETION_TIME,
	INJ_COMMENTS,
	INJ_LA_TEXT,
	INJ_RA_TEXT,
	MT_COMMENTS,
	MT_FLACCID,
	MT_NORMAL,
	MT_RIGID,
	PULSE_RATE_3,
	PULSE_SITE_3,
	PULSE_TIME_3,
	SUB_DRUGS,
	SUB_DRUGS_QTY,
	SUB_DRUGS_TIME,
	SUB_DRUGS_WHERE,
	SUB_OTHER_COMMENTS,
	SUB_REFUSED_EVAL,
	SUB_STOP_PART_EVAL
from {DB2Name}.dbo.TBL_DRE_CASE
WHERE [DRE_CASE_ID] NOT IN (
    SELECT [DreCaseId]
    FROM {DB1Name}.dre.DRE_Case_OtherObservation
	WHERE DRE_Case_OtherObservation.DreCaseId = TBL_DRE_CASE.DRE_CASE_ID
) ';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)


EXECUTE (@SQL_SCRIPT)


