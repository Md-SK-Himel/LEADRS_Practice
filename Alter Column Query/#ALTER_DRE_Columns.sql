begin TRANSACTION

USE [LEADRS_CORE_DEV_NEW]

-- dre.DRE_CASES
--UPDATE LEADRS_CORE_DEV_NEW.DRE.DRE_CASES SET [UniqueId] = NEWID()
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [DreTypeId] int NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [CrashFatal] bit NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [CrashInjury] bit NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [CrashNone] bit NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [CrashProperty] bit NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [DepartmentId] int NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [DreNumber] nvarchar(max) NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [EvaluatorId] int NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [LocationId] int NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [StatusId] int NULL
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [CaseOwnerDepartmentId] int NULL
-- Lat and Lng
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [OffenseLat] nvarchar(50)
ALTER TABLE DRE.DRE_CASES ALTER COLUMN [OffenseLng] nvarchar(50)



-- dre.DRE_Case_OtherObservation 
ALTER TABLE DRE.DRE_Case_OtherObservation ALTER COLUMN [SubRefusedEval] BIT
ALTER TABLE DRE.DRE_Case_OtherObservation ALTER COLUMN [SubStopPartEval] BIT
ALTER TABLE DRE.DRE_Case_OtherObservation ALTER COLUMN [InjectionSitesId] int NULL



-- dre.DRE_CASES_AO_OBS
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [BAC] decimal(18,2) NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [DrugCategoryCannabis] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [DrugCategoryCNSDepressant] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [DrugCategoryCNSStimulants] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [DrugCategoryHallucinogents] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [DrugCategoryInhalants] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [DrugCategoryNarcoticAbalgestic] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [InstrumentIntoxilyzer] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [InstrumentNA] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [InstrumentOther] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [InstrumentPBT] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [InstrumentPending] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [InstrumentRefused] bit NULL
ALTER TABLE DRE.DRE_CASES_AO_OBS ALTER COLUMN [InstrumentWarrant] bit NULL



-- dre.DRE_CASE_WT
ALTER TABLE DRE.DRE_CASE_WT ALTER COLUMN [SO_LL] int NULL
ALTER TABLE DRE.DRE_CASE_WT ALTER COLUMN [SO_LR] int NULL
ALTER TABLE DRE.DRE_CASE_WT ALTER COLUMN [SO_RL] int NULL
ALTER TABLE DRE.DRE_CASE_WT ALTER COLUMN [SO_RR] int NULL



-- dre.DRE_CASES_OBS
ALTER TABLE DRE.DRE_CASES_OBS ALTER COLUMN [BlindnessComment] nvarchar(500)



-- dre.DRE_CASES_OTHER_OFFICER
ALTER TABLE DRE.DRE_CASES_OTHER_OFFICER ALTER COLUMN [PBT] bit NULL
ALTER TABLE DRE.DRE_CASES_OTHER_OFFICER ALTER COLUMN [OfficerUserId] int
ALTER TABLE DRE.DRE_CASES_OTHER_OFFICER ALTER COLUMN [Accepted] bit NULL
ALTER TABLE DRE.DRE_CASES_OTHER_OFFICER ALTER COLUMN [IsOwner] bit NULL



-- dre.DRE_CASE_PAGES
ALTER TABLE DRE.DRE_CASE_PAGES ALTER COLUMN [Active] bit NULL



-- dre.TBL_OPT_TOX_SPEC_TYPE
ALTER TABLE DRE.TBL_OPT_TOX_SPEC_TYPE ALTER COLUMN [Active] bit NULL



-- dre.DRE_Case_Video
ALTER TABLE DRE.DRE_Case_Video ALTER COLUMN [Status] int NULL



-- dre.TBL_OPT_DRE_SECOND_INDICATORS
--ALTER TABLE DRE.TBL_OPT_DRE_SECOND_INDICATORS ALTER COLUMN  [Cann] bit
--ALTER TABLE DRE.TBL_OPT_DRE_SECOND_INDICATORS ALTER COLUMN  [CnsDep] bit
--ALTER TABLE DRE.TBL_OPT_DRE_SECOND_INDICATORS ALTER COLUMN  [CnsSti] bit
--ALTER TABLE DRE.TBL_OPT_DRE_SECOND_INDICATORS ALTER COLUMN  [DissAne] bit
--ALTER TABLE DRE.TBL_OPT_DRE_SECOND_INDICATORS ALTER COLUMN  [Hall] bit
--ALTER TABLE DRE.TBL_OPT_DRE_SECOND_INDICATORS ALTER COLUMN  [Inha] bit
--ALTER TABLE DRE.TBL_OPT_DRE_SECOND_INDICATORS ALTER COLUMN  [NarAna] bit



-- dre.TBL_OPT_DRE_ROLES
ALTER TABLE DRE.TBL_OPT_DRE_ROLES ALTER COLUMN [IsOfficerRole] bit NULL



--ROLLBACK
COMMIT




