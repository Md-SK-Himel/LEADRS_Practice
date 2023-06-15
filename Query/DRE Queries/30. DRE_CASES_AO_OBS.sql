--DONE


DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';


SET @query = '
SET IDENTITY_INSERT {DB1Name}.dre.DRE_CASES_AO_OBS ON

insert into {DB1Name}.dre.DRE_CASES_AO_OBS
(	[ObservationId],
	[DreCaseId],
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
select [DRE_AO_OBS_ID],
	TBL_DRE_CASE_AO_OBS.[DRE_CASE_ID],
	[ATTITUDE_APOLOGETIC],
	[ATTITUDE_COCKY],
	[ATTITUDE_COMBATIVE],
	[ATTITUDE_COOPERATIVE],
	[ATTITUDE_INDIFFERENT],
	[ATTITUDE_UNCOOPERATIVE],
	[BAC],
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
	[DRUG_CATEGORY_CANNABIS],
	[DRUG_CATEGORY_CNS_DEPRESSANT],
	[DRUG_CATEGORY_CNS_STIMULANTS],
	[DRUG_CATEGORY_HALLUCINOGENTS],
	[DRUG_CATEGORY_INHALANTS],
	[DRUG_CATEGORY_NARCOTIC_ANALGESIC],
	[DRUG_CATEGORY_PCP],
	[DRUG_REASON_SUSPECTED],
	[DRUG_SUSPECTED],
	[DRUG_WHY_SUSPECTED],
	[EYES_DILATED],
	[EYES_DROOPY_EYELIDS],
	[EYES_NORMAL],
	[EYES_RED],
	[EYES_WATERING],
	TBL_DRE_CASE_AO_OBS.[INS_INTOX],
	TBL_DRE_CASE_AO_OBS.[INS_NA],
	[INS_NUMBER],
	TBL_DRE_CASE_AO_OBS.[INS_OTH],
	TBL_DRE_CASE_AO_OBS.[INS_PBT],
	[INS_PBT_DATE],
	TBL_DRE_CASE_AO_OBS.[INS_PEND],
	TBL_DRE_CASE_AO_OBS.[INS_REF],
	TBL_DRE_CASE_AO_OBS.[INS_WARRANT],
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
FROM {DB2Name}.dbo.TBL_DRE_CASE_AO_OBS,
	{DB2Name}.dbo.TBL_DRE_CASE
WHERE TBL_DRE_CASE_AO_OBS.DRE_CASE_ID = TBL_DRE_CASE.DRE_CASE_ID
	AND
	[DRE_AO_OBS_ID] NOT IN (
    SELECT [ObservationId]
    FROM {DB1Name}.dre.DRE_CASES_AO_OBS
	WHERE DRE_CASES_AO_OBS.DreCaseId = TBL_DRE_CASE.DRE_CASE_ID
)
SET IDENTITY_INSERT {DB1Name}.dre.DRE_CASES_AO_OBS OFF';



SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)

EXECUTE (@SQL_SCRIPT)



