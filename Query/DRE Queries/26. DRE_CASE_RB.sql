--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
SET IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_RB ON

insert into {DB1Name}.dre.DRE_CASE_RB
(	[DreCaseRBId],
	[DreCaseId],
	[AlmostFell],
	[BodyTremors],
	[CIRCSway],
	[CIRCSwayDesc],
	[EyelidTremos],
	[FrontToBackSway],
	[FrontToBackSwayDesc],
	[InternalClock],
	[LegTremos],
	[MuscleToneFlaccid],
	[MuscleToneRigid],
	[NoSway],
	[OpenedEyes],
	[OtherText],
	[RombergBalanceGiven],
	[RombergOther],
	[SideToSideSway],
	[SideToSideSwayDesc],
	[Statement],
	[UnableToPerform],
	[UnableToStandStill],
	[UnserstoodInstructions],
	[UsedArms]
)
select [DRE_CASE_RB_ID],
	TBL_DRE_CASE_RB.[DRE_CASE_ID],
	[ALMOST_FELL],
	[BODY_TREMORS],
	[CIRC_SWAY],
	[CIRC_SWAY_DESC],
	[EYELID_TREMORS],
	[FR_TO_BK_SWAY],
	[FR_TO_BK_SWAY_DESC],
	TBL_DRE_CASE_RB.[INTERNAL_CLOCK],
	[LEG_TREMORS],
	[MUSCLE_TONE_FLACCID],
	[MUSCLE_TONE_RIGID],
	[NO_SWAY],
	[OPENED_EYES],
	[TXT_OTHER],
	[ROMBERG_BALANCE_GIVEN],
	[RB_OTHER],
	[SD_TO_SD_SWAY],
	[SD_TO_SD_SWAY_DESC],
	[STATEMENTS],
	[UNABLE_TO_PERFORM],
	[UNABLE_TO_STAND_STILL],
	[UNDERSTOOD_INSTRUCTIONS],
	[USED_ARMS]
from {DB2Name}.dbo.TBL_DRE_CASE_RB
	,{DB2Name}.dbo.TBL_DRE_CASE
WHERE TBL_DRE_CASE_RB.DRE_CASE_ID = TBL_DRE_CASE.DRE_CASE_ID
	AND [DRE_CASE_RB_ID] NOT IN (
    SELECT [DreCaseRBId]
    FROM {DB1Name}.dre.DRE_CASE_RB
	WHERE DRE_CASE_RB.DreCaseId = TBL_DRE_CASE.DRE_CASE_ID
)
SET IDENTITY_INSERT {DB1Name}.dre.DRE_CASE_RB OFF';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)



