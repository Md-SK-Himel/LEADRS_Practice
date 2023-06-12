--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASES_FTN
NOCHECK CONSTRAINT [FK_DRE_CASES_FTN_DRE_CASES_DreCaseId]

insert into {DB1Name}.dre.DRE_CASES_FTN
(	AlmostFell,
	BodyTremors,
	EyelidTremors,
	FtnBalanceGiven,
	FtnNotes,
	HandDown1,
	HandDown2,
	HandDown3,
	HandDown4,
	HandDown5,
	HandDown6,
	LegTremors,
	MovedFinger1,
	MovedFinger2,
	MovedFinger3,
	MovedFinger4,
	MovedFinger5,
	MovedFinger6,
	MuscleTensions,
	MuscleToneFlaccid,
	MuscleToneRigid,
	OpenedEyes,
	OpenedEyes1,
	OpenedEyes2,
	OpenedEyes3,
	OpenedEyes4,
	OpenedEyes5,
	OpenedEyes6,
	Other,
	OtherComments,
	Sounds,
	StartedUseWrongHand1,
	StartedUseWrongHand2,
	StartedUseWrongHand3,
	StartedUseWrongHand4,
	StartedUseWrongHand5,
	StartedUseWrongHand6,
	Swaying,
	UnableToPerform,
	UnableToStandStill,
	UnderstoodInstructions,
	UsedArms,
	UsedPad1,
	UsedPad2,
	UsedPad3,
	UsedPad4,
	UsedPad5,
	UsedPad6,
	UsedWrongHand1,
	UsedWrongHand2,
	UsedWrongHand3,
	UsedWrongHand4,
	UsedWrongHand5,
	UsedWrongHand6,
	DreCaseId
)
select ALMOST_FELL,
	BODY_TREMORS,
	EYELID_TREMORS,
	FTN_BALANCE_GIVEN,
	FTN_NOTES,
	HAND_DOWN_1,
	HAND_DOWN_2,
	HAND_DOWN_3,
	HAND_DOWN_4,
	HAND_DOWN_5,
	HAND_DOWN_6,
	LEG_TREMORS,
	MOVED_FINGER_1,
	MOVED_FINGER_2,
	MOVED_FINGER_3,
	MOVED_FINGER_4,
	MOVED_FINGER_5,
	MOVED_FINGER_6,
	MUSCLE_TENSIONS,
	MUSCLE_TONE_FLACCID,
	MUSCLE_TONE_RIGID,
	OPENED_EYES,
	OPENED_EYES_1,
	OPENED_EYES_2,
	OPENED_EYES_3,
	OPENED_EYES_4,
	OPENED_EYES_5,
	OPENED_EYES_6,
	OTHER,
	OTHER_COMMENTS,
	SOUNDS,
	STARTED_USE_WRONG_HAND_1,
	STARTED_USE_WRONG_HAND_2,
	STARTED_USE_WRONG_HAND_3,
	STARTED_USE_WRONG_HAND_4,
	STARTED_USE_WRONG_HAND_5,
	STARTED_USE_WRONG_HAND_6,
	SWAYING,
	UNABLE_TO_PERFORM,
	UNABLE_TO_STAND_STILL,
	UNDERSTOOD_INSTRUCTIONS,
	USED_ARMS,
	USED_PAD_1,
	USED_PAD_2,
	USED_PAD_3,
	USED_PAD_4,
	USED_PAD_5,
	USED_PAD_6,
	USED_WRONG_HAND_1,
	USED_WRONG_HAND_2,
	USED_WRONG_HAND_3,
	USED_WRONG_HAND_4,
	USED_WRONG_HAND_5,
	USED_WRONG_HAND_6,
	DRE_CASE_ID
from {DB2Name}.dbo.TBL_DRE_CASE_FTN

Alter Table {DB1Name}.dre.DRE_CASES_FTN
CHECK CONSTRAINT [FK_DRE_CASES_FTN_DRE_CASES_DreCaseId]';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)

