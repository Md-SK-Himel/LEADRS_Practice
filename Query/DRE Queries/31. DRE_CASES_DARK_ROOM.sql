--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
SET IDENTITY_INSERT {DB1Name}.dre.DRE_CASES_DARK_ROOM ON

insert into {DB1Name}.dre.DRE_CASES_DARK_ROOM
(	[DreCaseDarkRoomId],
	DreCaseId,
	LightL,
	LightR,
	DarkL,
	DarkR,
	DirectL,
	DirectR,
	ReboundY,
	ReboundN,
	HippusObserveD,
	LightReaction,
	NasalAreaClear,
	NasalAreaRed,
	NasalAreableeding,
	NasalAreadeviated,
	NasalAreawhite,
	NasalAreaother,
	NasalAreaothertxt,
	OralCavityclear,
	OralCavityRaised,
	OralCavityMarijuana,
	OralCavityDry,
	OralCavityRotten,
	OralCavityGreen,
	OralCavityMissing,
	OralCavityOther,
	OralCavityOtherText,
	ReactionToLightId,
	ReboundStartL,
	ReboundEndL,
	ReboundStartR,
	ReboundEndR,
	UvLight
)
select [DRE_DARK_ROOM_ID],
	TBL_DRE_CASE_DARK_ROOM.[DRE_CASE_ID],
	[LIGHT_L],
	[LIGHT_R],
	[DARK_L],
	[DARK_R],
	[DIRECT_L],
	[DIRECT_R],
	[REBOUND_Y],
	[REBOUND_N],
	[HIPPUS_OBSERVED],
	[LIGHT_REACTION],
	[NA_CLEAR],
	[NA_RED],
	[NA_BLEEDING],
	[NA_DEVIATED],
	[NA_WHITE],
	[NA_OTHER],
	[NA_OTHER_TXT],
	[OC_CLEAR],
	[OC_RAISED],
	[OC_MARIJUANA],
	[OC_DRY],
	[OC_ROTTEN],
	[OC_GREEN],
	[OC_MISSING],
	[OC_OTHER],
	[OC_OTHER_TXT],
	TBL_DRE_CASE_DARK_ROOM.[REACTION_TO_LIGHT_ID],
	[REBOUND_START_L],
	[REBOUND_END_L],
	[REBOUND_START_R],
	[REBOUND_END_R],
	[UV_LIGHT]
from {DB2Name}.dbo.TBL_DRE_CASE_DARK_ROOM,
	{DB2Name}.dbo.TBL_DRE_CASE
WHERE TBL_DRE_CASE_DARK_ROOM.DRE_CASE_ID = TBL_DRE_CASE.DRE_CASE_ID
	AND
	[DRE_DARK_ROOM_ID] NOT IN (
    SELECT [DreCaseDarkRoomId]
    FROM {DB1Name}.dre.DRE_CASES_DARK_ROOM
	WHERE DRE_CASES_DARK_ROOM.DreCaseId = TBL_DRE_CASE.DRE_CASE_ID
)

SET IDENTITY_INSERT {DB1Name}.dre.DRE_CASES_DARK_ROOM OFF ';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)

