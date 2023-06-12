--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASE_OLS
NOCHECK CONSTRAINT [FK_DRE_CASE_OLS_DRE_CASES_DreCaseId]

insert into {DB1Name}.dre.DRE_CASE_OLS
(
	DreCaseId,
	BodyTremos_R,
	BodyTremosL,
	EyeLidTremosL,
	EyeLidTremosR,
	FootWearTypeId,
	LegTremosL,
	LegTremosR,
	MuscleTensions,
	NoCountL,
	NoCountR,
	NOLookDownL,
	NOLookDownR,
	NotSixInchesL,
	NotSixInchesR,
	OLSArmsL,
	OLSArmsR,
	OLSArmTimeL,
	OLSArmTimeR,
	OLSComments,
	OLSFootL,
	OLSFootR,
	OLSHoppingL,
	OLSHoppingR,
	OLSHopTimeL,
	OLSHopTimeR,
	OLSLeftDown,
	OLSLeftDownCount,
	OLSNoates,
	OLSOtherL,
	OLSOtherR,
	OLSRightDown,
	OLSRightDownCount,
	OLSSwaysL,
	OLSSwaysR,
	OLSSwayTimeL,
	OLSSwayTimeR,
	OLSTimeL,
	OLSTImeLeftDown,
	OLSTimeR,
	OLSTImeRightDown,
	OneLegStandGiven,
	OtherL,
	OtherR,
	Sounds,
	UnableToPerform,
	UnderstoodInstruction
)
select [DRE_CASE_ID],
	[BODY_TREMORS_R],
	[BODY_TREMORS_L],
	[EYELID_TREMORS_L],
	[EYELID_TREMORS_R],
	[OLS_FOOTWEAR_ID],
	[LEG_TREMORS_L],
	[LEG_TREMORS_R],
	[MUSCLE_TENSIONS],
	[NO_COUNT_L],
	[NO_COUNT_R],
	[NO_LOOK_DOWN_L],
	[NO_LOOK_DOWN_R],
	[NOT_SIX_INCHES_L],
	[NOT_SIX_INCHES_R],
	[OLS_ARMS_L],
	[OLS_ARMS_R],
	[OLS_ARM_TIME_L],
	[OLS_ARM_TIME_R],
	[OLS_COMMENTS],
	[OLS_FOOT_L],
	[OLS_FOOT_R],
	[OLS_HOPPING_L],
	[OLS_HOPPING_R],
	[OLS_HOP_TIME_L],
	[OLS_HOP_TIME_R],
	[OLS_LEFT_DOWN],
	[OLS_LEFT_DOWN_COUNT],
	[OLS_NOTES],
	[OLS_OTHER_L],
	[OLS_OTHER_R],
	[OLS_RIGHT_DOWN],
	[OLS_RIGHT_DOWN_CONT],
	[OLS_SWAYS_L],
	[OLS_SWAYS_R],
	[OLS_SWY_TIME_L],
	[OLS_SWY_TIME_R],
	[OLS_TIME_L],
	[OLS_TIME_LEFT_DOWN],
	[OLS_TIME_R],
	[OLS_TIME_RIGHT_DOWN],
	[ONE_LEG_STAND_GIVEN],
	[OTHER_L],
	[OTHER_R],
	[SOUNDS],
	[UNABLE_TO_PERFORM],
	[UNDERSTOOD_INSTRUCTIONS]
from {DB2Name}.dbo.TBL_DRE_CASE_OLS

Alter Table {DB1Name}.dre.DRE_CASE_OLS
NOCHECK CONSTRAINT [FK_DRE_CASE_OLS_DRE_CASES_DreCaseId]';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)


EXECUTE (@SQL_SCRIPT)


