--DONE (DRE_CASE_ID extra rows not counted)

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table LEADRS_CORE_DEV_DUI.dre.DRE_CASES_AO_OBS
NOCHECK CONSTRAINT FK_DRE_CASES_AO_OBS_DRE_CASES_DreCaseId

insert into LEADRS_CORE_DEV_DUI.dre.DRE_CASES_AO_OBS
(	[DreCaseId],
	[AttitudeApologetic],
	[AttitudeCocky],
	[AttitudeCombative],
	[AttitudeCooperative],
	[AttitudeIndifferent],
	[AttitudeUnCooperative],
	[BAC],
	[BalanceFallingDown],
	[BalanceNeededSupport],
	[BalanceNormal],
	[BalanceSwaying],
	[BalanceUnsteady],
	[ClothingDisorderly],
	[ClothingOrderly],
	[ClothingSoiled],
	[ClothingStained],
	[ClothingTorn],
	[Comments],
	[DrugCategoryCannabis],
	[DrugCategoryCNSDepressant],
	[DrugCategoryCNSStimulants],
	[DrugCategoryHallucinogents],
	[DrugCategoryInhalants],
	[DrugCategoryNarcoticAbalgestic],
	[DrugCategoryPCP],
	[DrugReasonSuspected],
	[DrugSuspected],
	[DrugWhySuspected],
	[EyesDilated],
	[EyesDroopyEyeLids],
	[EyesNormal],
	[EyesRed],
	[EyesWatering],
	[InstrumentIntoxilyzer],
	[InstrumentNA],
	[InstrumentNumber],
	[InstrumentOther],
	[InstrumentPBT],
	[InstrumentPBTDate],
	[InstrumentPending],
	[InstrumentRefused],
	[InstrumentWarrant],
	[SpeechIncoherent],
	[SpeechNormal],
	[SpeechSlowMumbled],
	[SpeechSlurred],
	[SpeechThickTongued],
	[TypeAlcoholDrug],
	[UnusualActions],
	[WalkingFalling],
	[WalkingHeavyFooted],
	[WalkingNormal],
	[WalkingStaggering],
	[WalkingSwaying],
	[AdditionalBreathPerformed],
	[BreathInstrumentNumber],
	[BreathRefused],
	[BreathResults]
)
select TBL_DRE_CASE_AO_OBS.[DRE_CASE_ID],
	[ATTITUDE_APOLOGETIC],
	[ATTITUDE_COCKY],
	[ATTITUDE_COMBATIVE],
	[ATTITUDE_COOPERATIVE],
	[ATTITUDE_INDIFFERENT],
	[ATTITUDE_UNCOOPERATIVE],
	COALESCE([BAC],0.00),
	[BALANCE_FALLING_DOWN],
	[BALANCE_NEEDED_SUPPORT],
	[BALANCE_NORMAL],
	[BALANCE_SWAYING],
	[BALANCE_UNSTEADY],
	[CLOTHING_DISORDERLY],
	[CLOTHING_ORDERLY],
	[CLOTHING_SOILED],
	[CLOTHING_STAINED],
	[CLOTHING_TORN],
	[COMMENTS],
	COALESCE([DRUG_CATEGORY_CANNABIS],0),
	COALESCE([DRUG_CATEGORY_CNS_DEPRESSANT],0),
	COALESCE([DRUG_CATEGORY_CNS_STIMULANTS],0),
	COALESCE([DRUG_CATEGORY_HALLUCINOGENTS],0),
	COALESCE([DRUG_CATEGORY_INHALANTS],0),
	COALESCE([DRUG_CATEGORY_NARCOTIC_ANALGESIC],0),
	[DRUG_CATEGORY_PCP],
	[DRUG_REASON_SUSPECTED],
	[DRUG_SUSPECTED],
	[DRUG_WHY_SUSPECTED],
	[EYES_DILATED],
	[EYES_DROOPY_EYELIDS],
	[EYES_NORMAL],
	[EYES_RED],
	[EYES_WATERING],
	COALESCE(TBL_DRE_CASE_AO_OBS.[INS_INTOX],0),
	COALESCE(TBL_DRE_CASE_AO_OBS.[INS_NA],0),
	[INS_NUMBER],
	COALESCE(TBL_DRE_CASE_AO_OBS.[INS_OTH],0),
	COALESCE(TBL_DRE_CASE_AO_OBS.[INS_PBT],0),
	[INS_PBT_DATE],
	COALESCE(TBL_DRE_CASE_AO_OBS.[INS_PEND],0),
	COALESCE(TBL_DRE_CASE_AO_OBS.[INS_REF],0),
	COALESCE(TBL_DRE_CASE_AO_OBS.[INS_WARRANT],0),
	[SPEECH_INCOHERENT],
	[SPEECH_NORMAL],
	[SPEECH_SLOW_MUMBLED],
	[SPEECH_SLURRED],
	[SPEECH_THICK_TONGUED],
	[TYPE_ALCOHOL_DRUGS],
	[UNUSUAL_ACTIONS],
	[WALKING_FALLING],
	[WALKING_HEAVY_FOOTED],
	[WALKING_NORMAL],
	[WALKING_STAGGERING],
	[WALKING_SWAYING],
	TBL_DRE_CASE.[ADD_BREATH_PERFORMED],
	TBL_DRE_CASE.[BREATH_INSTRUMENT_NUM],
	TBL_DRE_CASE.[BREATH_REFUSED],
	TBL_DRE_CASE.[BREATH_RESULTS]
from LEADRS_TX_STAGING.dbo.TBL_DRE_CASE_AO_OBS,
	LEADRS_TX_STAGING.dbo.TBL_DRE_CASE
where TBL_DRE_CASE_AO_OBS.DRE_CASE_ID = TBL_DRE_CASE.DRE_CASE_ID

Alter Table LEADRS_CORE_DEV_DUI.dre.DRE_CASES_AO_OBS
CHECK CONSTRAINT FK_DRE_CASES_AO_OBS_DRE_CASES_DreCaseId';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)



