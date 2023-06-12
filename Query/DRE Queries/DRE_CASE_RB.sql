--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASE_RB
NOCHECK CONSTRAINT [FK_DRE_CASE_RB_DRE_CASES_DreCaseId]

insert into {DB1Name}.dre.DRE_CASE_RB
(	[DreCaseId],
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
select COALESCE([DRE_CASE_ID],0),
	[ALMOST_FELL],
	[BODY_TREMORS],
	[CIRC_SWAY],
	[CIRC_SWAY_DESC],
	[EYELID_TREMORS],
	[FR_TO_BK_SWAY],
	[FR_TO_BK_SWAY_DESC],
	[INTERNAL_CLOCK],
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
from {DB2Name}.dbo.TBL_DRE_CASE_RB;
Alter Table {DB1Name}.dre.DRE_CASE_RB
CHECK CONSTRAINT [FK_DRE_CASE_RB_DRE_CASES_DreCaseId]';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)



