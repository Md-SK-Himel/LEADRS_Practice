--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASES_OFFENSES
NOCHECK CONSTRAINT [FK_DRE_CASES_OFFENSES_DRE_CASES_DreCaseId]

insert into {DB1Name}.dre.DRE_CASES_OFFENSES
(	DreCaseId,
	CrashId,
	Assault,
	AssaultCharged,
	Charged,
	DWI,
	InjuryId,
	NoChargeComment,
	OffenseId,
	Other,
	OtherCharged,
	Possession,
	PossessionCharged,
	PublicIntox,
	RecklessDriving,
	Theft,
	TheftCharged
)
select [DRE_CASE_ID],
	[ACCIDENT_ID],
	[ASSAULT],
	[ASSAULT_CHARGE],
	[CHARGED],
	[DWI],
	[INJURIES_ID],
	[NO_CHARGE_COMMENT],
	[OFFENSE_ID],
	[OTHER],
	[OTHER_CHARGE],
	[POSSESSION],
	[POSSESSION_CHARGE],
	[PUBLIC_INTOX],
	[RECKLESS_DRIVING],
	[THEFT],
	[THEFT_CHARGE]
from {DB2Name}.dbo.TBL_DRE_CASE_OFFENSE

Alter Table {DB1Name}.dre.DRE_CASES_OFFENSES
CHECK CONSTRAINT [FK_DRE_CASES_OFFENSES_DRE_CASES_DreCaseId]';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)


