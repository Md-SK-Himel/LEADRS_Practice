--DONE (DRE_CASE_ID extra rows not counted)

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
Alter Table {DB1Name}.dre.DRE_CASE_HGN
NOCHECK CONSTRAINT [FK_DRE_CASE_HGN_DRE_CASES_DreCaseId]
insert into {DB1Name}.dre.DRE_CASE_HGN
(	CluesLeft,
    CluesRight,
    CluesTotal,
    ContactDescription,
    Contacts,
    DistinctMaxDevL,
    DistinctMaxDevR,
    EqualPupilSize,
    EqualTracking,
    FollowStimulus,
    HeadInjuries,
    HeadInjuriesComments,
    HgnEstimatedAngleId,
    HgnUnderstood,
    IsVerticalNyst,
    LackOfPursuitL,
    LackOfPursuitR,
    LEstimatedAngleId,
    OnsetPrior45L,
    OnsetPrior45R,
    OtherComments,
    PupilSizeComments,
    REstimatedAngleId,
    RestingNystagmus,
    StimulusComments,
    VerticalNyst,
    DreCaseId,
    ConvergencePresent
)
select CLUES_LEFT,
    CLUES_RIGHT,
    CLUES_TOTAL,
    CONTACT_DESCRIPTION,
    CONTACTS,
    DISTINCT_MAX_DEV_L,
    DISTINCT_MAX_DEV_R,
    EQUAL_PUPIL_SIZE,
    EQUAL_TRACKING,
    FOLLOW_STIMULUS,
    HEAD_INJURIES,
    HEAD_INJURIES_COMMENTS,
    HGN_ESTIMATED_ANGLE_ID_L5,
    HGN_UNDERSTOOD,
    IS_VERTICAL_NYST,
    LACK_OF_PURSUIT_L,
    LACK_OF_PURSUIT_R,
    L_ESTIMATED_ANGLE_ID,
    ONSET_PRIOR_45_L,
    ONSET_PRIOR_45_R,
    OTHER_COMMENTS,
    PUPIL_SIZE_COMMENTS,
    R_ESTIMATED_ANGLE_ID,
    RESTING_NYSTAGMUS,
    STIMULUS_COMMENTS,
    VERTICAL_NYST,
    TBL_DRE_CASE_HGN.DRE_CASE_ID,
	CONVERGENCE_PRESENT
from {DB2Name}.dbo.TBL_DRE_CASE_HGN,
	{DB2Name}.dbo.TBL_DRE_CASE
where TBL_DRE_CASE_HGN.DRE_CASE_ID = TBL_DRE_CASE.DRE_CASE_ID

Alter Table {DB1Name}.dre.DRE_CASE_HGN
CHECK CONSTRAINT [FK_DRE_CASE_HGN_DRE_CASES_DreCaseId]';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)



