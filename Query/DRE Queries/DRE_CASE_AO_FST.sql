--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASE_AO_FST
NOCHECK CONSTRAINT FK_DRE_CASE_AO_FST_DRE_CASES_DreCaseId

insert into {DB1Name}.dre.DRE_CASE_AO_FST
(DreCaseId,
	HGNCluesLeft,
	HGNCluesRight,
	HGNCluesTotal,
	HGNDistinctMaxDevLeft,
	HGNDistinctMaxDevRight,
	HGNLackOfPursuitLeft,
	HGNLackOfPursuitRight,
	HGNOnsetPrior45Left,
	HGNOnsetPrior45Right,
	IsHGNVerticalNyst,
	OneLegClues,
	OneLegHopps,
	OneLegPutFootDown,
	OneLegSways,
	OneLegUsesArms,
	WalkTurnCannotBalance,
	WalkTurnClues,
	WalkTurnImproperTurn,
	WalkTurnMissHeelToe,
	WalkTurnRaisesArms,
	WalkTurnStartSoon,
	WalkTurnStepOffLine,
	WalkTurnStopWalking,
	WalkTurnWrongNumberSteps
)
select DRE_CASE_ID,
	HGN_CLUES_LEFT,
	HGN_CLUES_RIGHT,
	HGN_CLUES_TOTAL,
	HGN_DISTINCT_MAX_DEV_L,
	HGN_DISTINCT_MAX_DEV_R,
	HGN_LACK_OF_PURSUIT_L,
	HGN_LACK_OF_PURSUIT_R,
	HGN_ONSET_PRIOR_45_L,
	HGN_ONSET_PRIOR_45_R,
	IS_HGN_VERTICAL_NYST,
	OLS_CLUES_TOTAL,
	OLS_HOPPS,
	OLS_PUT_FOOT_DOWN,
	OLS_SWAYS,
	OLS_USES_ARMS,
	WT_CANNOT_BALANCE,
	WT_CLUES_TOTAL,
	WT_IMPROPER_TURN,
	WT_MISS_HEEL_TOE,
	WT_RAISES_ARMS,
	WT_STARTS_SOON,
	WT_STEP_OFF_LINE,
	WT_STOPS_WALKING,
	WT_WRONG_NUMBER_STEPS
from {DB2Name}.dbo.TBL_DRE_CASE_AO_FST;
Alter Table {DB1Name}.dre.DRE_CASE_AO_FST
CHECK CONSTRAINT FK_DRE_CASE_AO_FST_DRE_CASES_DreCaseId';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)


EXECUTE (@SQL_SCRIPT)



