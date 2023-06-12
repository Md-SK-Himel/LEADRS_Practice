--DONE (Extra DRE_CASE_ID rows not counted)

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
insert into {DB1Name}.dre.DRE_CASE_WT
(   ActualSteps1,
    ActualSteps2,
    BodyTremos,
    CannotBalance,
    EyelidsTremos,
    ImproperTurn,
    LegTremos,
    MissHellToe,
    MuscleTensions,
    OtherComments,
    RaisesArms,
    SO_LL,
    SO_LR,
    SO_RL,
    SO_RR,
    Sounds,
    StartsSoon,
    StepOffLine,
    StopsWalking,
    Swaying,
    UnableToPerform,
    UnserstoodInstructions,
    WalkTurnDescribeTurn,
    WalkTurnGiven,
    WrongNumberSteps,
    WTMissesFirstNine,
    WTMissesSecondNine,
    WTNAFirstNine,
    WTNASecondNine,
    WTOther,
    WTRaisesFirstNine,
    WTRaisesSecondNine,
    WTStepCount,
    WTStepCountSecond,
    WTStepsLeftFirstNine,
    WTStepsLeftSecondNine,
    WTStepsRightFirstNine,
    WTStepsRightSecondNine,
    WTStopsFirstNine,
    WTStopsSecondNine,
    WTTakensFirstNine,
    WTTakenSecondNine,
    DreCaseId,
	WalkTurnNoTest,
	OLSStarts
)
select [ACTUAL_STEPS_1],
    [ACTUAL_STEPS_2],
    [BODY_TREMORS],
    [CANNOT_BALANCE],
    [EYELID_TREMORS],
    [IMPROPER_TURN],
    [LEG_TREMORS],
    [MISS_HEEL_TOE],
    TBL_DRE_CASE_WT.[MUSCLE_TENSIONS],
    [OTHER_COMMENTS],
    [RAISES_ARMS],
    COALESCE([SO_LL],0),
    COALESCE([SO_LR],0),
    COALESCE([SO_RL],0),
    COALESCE([SO_RR],0),
    TBL_DRE_CASE_WT.[SOUNDS],
    [STARTS_SOON],
    [STEP_OFF_LINE],
    [STOPS_WALKING],
    [SWAYING],
    TBL_DRE_CASE_WT.[UNABLE_TO_PERFORM],
    TBL_DRE_CASE_WT.[UNDERSTOOD_INSTRUCTIONS],
    TBL_DRE_CASE_WT.[WT_DESCRIBE_TURN],
    [WALK_TURN_GIVEN],
    [WRONG_NUMBER_STEPS],
    [WT_MISSES_FIRST_NINE],
    [WT_MISSES_SECOND_NINE],
    [WT_NA_FIRST_NINE],
    [WT_NA_SECOND_NINE],
    [WT_OTHER],
    [WT_RAISES_FIRST_NINE],
    [WT_RAISES_SECOND_NINE],
    [WT_STEP_COUNT],
    [WT_STEP_COUNT_SECOND],
    [WT_STEPS_LEFT_FIRST_NINE],
    [WT_STEPS_LEFT_SECOND_NINE],
    [WT_STEPS_RIGHT_FIRST_NINE],
    [WT_STEPS_RIGHT_SECOND_NINE],
    [WT_STOPS_FIRST_NINE],
    [WT_STOPS_SECOND_NINE],
    [WT_TAKEN_FIRST_NINE],
    [WT_TAKEN_SECOND_NINE],
    TBL_DRE_CASE_WT.[DRE_CASE_ID],
	TBL_DRE_CASE.[WT_NO_TEST],
	TBL_DRE_CASE_OLS.[OLS_STARTS]
from {DB2Name}.dbo.TBL_DRE_CASE_WT,
	LEADRS_TX_STAGING.dbo.TBL_DRE_CASE,
	LEADRS_TX_STAGING.dbo.TBL_DRE_CASE_OLS
where TBL_DRE_CASE_WT.DRE_CASE_ID = TBL_DRE_CASE.DRE_CASE_ID
	AND TBL_DRE_CASE_WT.DRE_CASE_ID = TBL_DRE_CASE_OLS.DRE_CASE_ID';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)


