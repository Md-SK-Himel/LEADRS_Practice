--DONE

DECLARE @query NVARCHAR(MAX)
DECLARE @SQL_SCRIPT NVARCHAR(MAX)
DECLARE @DB1_Name NVARCHAR(50)
DECLARE @DB2_Name NVARCHAR(50)


SET @DB1_Name = '[LEADRS_CORE_DEV_DUI]';
SET @DB2_Name = '[LEADRS_TX_STAGING]';

--Foreign Key Check Will be changed.

SET @query = '
Alter Table {DB1Name}.dre.DRE_CASE_INTOXILYZER_REPORT
NOCHECK CONSTRAINT [FK_DRE_CASE_INTOXILYZER_REPORT_DRE_CASES_DreCaseId]

insert into {DB1Name}.dre.DRE_CASE_INTOXILYZER_REPORT
(
	AttemptedBlood,
	AttemptedBreath,
	AttemptedSaliva,
	AttemptedUrine,
	BloodDatetimeSpecimenExtractedBwd,
	BloodDescriptionBwd,
	BloodEmployedIdPwd,
	BloodEmployerPwd,
	BloodLocationBwd,
	BloodMoreLessIntoxId,
	BloodNamePwd,
	BloodNoAlcohol,
	BloodPhonePwd,
	BloodPreservative,
	BloodRotated,
	BloodTaken,
	BloodVials,
	BreathBeginWait,
	BreathDateGiven,
	BreathIntoxOperatorL5,
	BreathMoreLessIntoxIdL5,
	BreathOperatorAgency,
	BreathOperatorName,
	BreathRecordNumber,
	BreathResult1,
	BreathResult1Time,
	BreathResult2,
	BreathResult2Time,
	BreathSerialNumber,
	BreathSubjectComments,
	BreathVerifytempId,
	ProvidedBlood,
	ProvidedBreath,
	ProvidedSaliva,
	ProvidedUrine,
	RefusedBlood,
	RefusedBreath,
	RefusedSaliva,
	RefusedUrine,
	SalivaDreObserved,
	SalivaToxScreenPerformed,
	SalivaWhoObserved,
	UrineDreObserved,
	UrineToxScreenPerformed,
	UrineWhoObserved,
	DreCaseId
)
select [ATTEMPTED_BLOOD],
	[ATTEMPTED_BREATH],
	[ATTEMPTED_SALIVA],
	[ATTEMPTED_URINE],
	[BLOOD_DATETIME_SPECIMEN_EXTRACTED_BWD],
	[BLOOD_DESCRIPTION_BWD],
	[BLOOD_EMPLOYED_ID_PWD],
	[BLOOD_EMPLOYER_PWD],
	[BLOOD_LOCATION_BWD],
	[BLOOD_MORE_LESS_INTOX_ID],
	[BLOOD_NAME_PWD],
	[BLOOD_NO_ALCOHOL],
	[BLOOD_PHONE_PWD],
	[BLOOD_PRESERVATIVE],
	[BLOOD_ROTATED],
	[BLOOD_TAKEN],
	[BLOOD_VIALS],
	[BREATH_BEGIN_WAIT],
	[BREATH_DATE_GIVEN],
	[BREATH_INTOX_OPERATOR_L5],
	[BREATH_MORE_LESS_INTOX_ID_L5],
	[BREATH_OPERATOR_AGENCY],
	[BREATH_OPERATOR_NAME],
	[BREATH_RECORD_NUMBER],
	[BREATH_RESULT_1],
	[BREATH_RESULT_1_TIME],
	[BREATH_RESULT_2],
	[BREATH_RESULT_2_TIME],
	[BREATH_SERIAL_NUMBER],
	[BREATH_SUBJECT_COMMENTS],
	[BREATH_VERIFYTEMP_ID],
	[PROVIDED_BLOOD],
	[PROVIDED_BREATH],
	[PROVIDED_SALIVA],
	[PROVIDED_URINE],
	[REFUSED_BLOOD],
	[REFUSED_BREATH],
	[REFUSED_SALIVA],
	[REFUSED_URINE],
	[SALIVA_DRE_OBSERVED],
	[SALIVA_TOX_SCREEN_PERFORMED],
	[SALIVA_WHO_OBSERVED],
	[URINE_DRE_OBSERVED],
	[URINE_TOX_SCREEN_PERFORMED],
	[URINE_WHO_OBSERVED],
	[DRE_CASE_ID]
from {DB2Name}.dbo.TBL_DRE_CASE_INTOXILYZER_REPORT
Alter Table {DB1Name}.dre.DRE_CASE_INTOXILYZER_REPORT
CHECK CONSTRAINT [FK_DRE_CASE_INTOXILYZER_REPORT_DRE_CASES_DreCaseId]';


SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)
SET @SQL_SCRIPT = REPLACE(@SQL_SCRIPT, '{DB2Name}', @DB2_Name)


EXECUTE (@SQL_SCRIPT)


