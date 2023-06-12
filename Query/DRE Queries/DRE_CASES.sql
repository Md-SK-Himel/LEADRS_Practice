--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASES
NOCHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_REQUESTED_DreRequestedId
Alter Table {DB1Name}.dre.DRE_CASES
NOCHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_ROLES_DreRoleId
Alter Table {DB1Name}.dre.DRE_CASES
NOCHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_NOTIFIED_DreNotifiedId
Alter Table {DB1Name}.dre.DRE_CASES
NOCHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_TYPES_DreTypeId
Alter Table {DB1Name}.dre.DRE_CASES
NOCHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_CASE_STATUS_StatusId

set IDENTITY_INSERT {DB1Name}.dre.DRE_CASES ON

insert into {DB1Name}.dre.DRE_CASES(
	[DRECaseId],
	[DreNotifiedId],
	[DreRequestedId],
	[DreRoleId],
	[DreTypeId],
	[StatusId],
	[ActualTime],
	[AgencyCaseNumber],
	[AssociatedCaseId],
	[CrashFatal],
	[CrashInjury],
	[CrashNone],
	[CrashProperty],
	[DefendantTime],
	[DepartmentId],
	[DiabeticEpileptic],
	[DiabeticEpilepticDesc],
	[DreNumber],
	[DrinkingHowMuch],
	[DrinkingTime],
	[DrinkingToday],
	[EatenToday],
	[EatenWhen],
	[EvaulationDate],
	[EvaluationAddress],
	[EvaluatorId],
	[InitialAngleNystagums],
	[InitialObservationOfSubject],
	[InitialPupilSizeL],
	[InitialPupilSizeR],
	[Insulin],
	[InsulinDesc],
	[LastSleep],
	[LocationId],
	[MedicationsDrug],
	[MedicationsDrugDesc],
	[MirandaDate],
	[MirandaEnglish],
	[MirandaGiven],
	[MirandaGivenBy],
	[MirandaSpanish],
	[MirandaUnderstood],
	[NotifyDate],
	[NotifyTime],
	[OffenseCounty],
	[OffenseAddress1],
	[OffenseAddress2],
	[OffenseCity],
	[OffenseLat],
	[OffenseLng],
	[OffenseState],
	[OffenseZip],
	[PhysicalDefects],
	[PhysicalDefectsDesc],
	[PulseRate1],
	[PulseRate2],
	[PulseRate3],
	[PulseSite1],
	[PulseSite2],
	[PulseSite3],
	[PulseTime1],
	[PulseTime2],
	[PulseTime3],
	[RollingLogNumber],
	[SickInjured],
	[SickInjuredDesc],
	[SleepHowLong],
	[UnderCare],
	[UnderCareDesc],
	[UniqueId]
)
select [DRE_CASE_ID],
	[DRE_NOTIFIED_ID_FK],
	[DRE_REQUESTED_ID_FK],
	[DRE_ROLE_ID],
	COALESCE([DRE_TYPE_ID],0),
	[STATUS_ID],
	[ACTUAL_TIME],
	[AGENCY_CASE_NUMBER],
	[ASSOCIATED_CASE_ID],
	COALESCE([CRASH_FATAL],''false''),
	COALESCE([CRASH_INJURY],''false''),
	COALESCE([CRASH_NONE],''false''),
	COALESCE([CRASH_PROPERTY],''false''),
	[DEF_TIME],
	COALESCE([DEPARTMENT_ID],0),
	[DIABETIC_EPILEPTIC],
	[DIABETIC_EPILEPTIC_DESC],
	COALESCE([DRE_NUMBER],''NULL''),
	[DRINKING_HOW_MUCH],
	[DRINKING_TIME],
	[DRINKING_TODAY],
	[EATEN_TODAY],
	[EATEN_WHEN],
	[EVAL_DATE],
	[EVAL_LOCATION_ADDRESS],
	COALESCE([EVALUATOR_ID],0),
	[INITIAL_ANGLE_NYSTAGMUS_ID],
	[INITIAL_OBSERVATION_OF_SUBJECT],
	[INITIAL_PUPIL_SIZE_L],
	[INITIAL_PUPIL_SIZE_R],
	[INSULIN],
	[INSULIN_DESC],
	[LAST_SLEEP],
	COALESCE([LOCATION_ID],0),
	[MEDS_DRUGS],
	[MEDS_DRUGS_DESC],
	[MIRANDA_DATETIME],
	[MIRANDA_ENGLISH],
	[MIRANDA_GIVEN],
	[MIRANDA_GIVEN_BY],
	[MIRANDA_SPANISH],
	[MIRANDA_UNDERSTOOD],
	[NOTIFY_DATE],
	[NOTIFY_TIME],
	[OFFENSE_COUNTY_ID],
	[OFFENSE_LOCATION],
	[OFFENSE_LOCATION_ADDRESS_2],
	[OFFENSE_LOCATION_CITY],
	CAST([OFFENSE_LOCATION_GEO_LAT] AS float),
	CAST([OFFENSE_LOCATION_GEO_LNG] AS float),
	[OFFENSE_LOCATION_STATE_ID],
	[OFFENSE_LOCATION_ZIP],
	[PHYSICAL_DEFECTS],
	[PHYSICAL_DEFECTS_DESC],
	[PULSE_RATE_1],
	[PULSE_RATE_2],
	[PULSE_RATE_3],
	[PULSE_SITE_1],
	[PULSE_SITE_2],
	[PULSE_SITE_3],
	[PULSE_TIME_1],
	[PULSE_TIME_2],
	[PULSE_TIME_3],
	[ROLLING_LOG_NUMBER],
	[SICK_INJURED],
	[SICK_INJURED_DESC],
	[SLEEP_HOW_LONG],
	[UNDER_CARE],
	[UNDER_CARE_DESC],
	NEWID()
from {DB2Name}.dbo.TBL_DRE_CASE;

set IDENTITY_INSERT {DB1Name}.dre.DRE_CASES OFF

Alter Table {DB1Name}.dre.DRE_CASES
CHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_CASE_STATUS_StatusId
Alter Table {DB1Name}.dre.DRE_CASES
CHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_TYPES_DreTypeId
Alter Table {DB1Name}.dre.DRE_CASES
CHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_NOTIFIED_DreNotifiedId
Alter Table {DB1Name}.dre.DRE_CASES
CHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_REQUESTED_DreRequestedId
Alter Table {DB1Name}.dre.DRE_CASES
CHECK CONSTRAINT FK_DRE_CASES_TBL_OPT_DRE_ROLES_DreRoleId';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)



