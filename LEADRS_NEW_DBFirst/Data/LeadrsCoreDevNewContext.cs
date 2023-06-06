using System;
using System.Collections.Generic;
using LEADRS_NEW_DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Data;

public partial class LeadrsCoreDevNewContext : DbContext
{
    public LeadrsCoreDevNewContext()
    {
    }

    public LeadrsCoreDevNewContext(DbContextOptions<LeadrsCoreDevNewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessLog> AccessLogs { get; set; }

    public virtual DbSet<ActiveSession> ActiveSessions { get; set; }

    public virtual DbSet<AdditionalOffense> AdditionalOffenses { get; set; }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }

    public virtual DbSet<AuditChange> AuditChanges { get; set; }

    public virtual DbSet<AuthType> AuthTypes { get; set; }

    public virtual DbSet<AvGetCboNcicTransportMake> AvGetCboNcicTransportMakes { get; set; }

    public virtual DbSet<AvGetCboNcicVehicleModel> AvGetCboNcicVehicleModels { get; set; }

    public virtual DbSet<CaseHeader> CaseHeaders { get; set; }

    public virtual DbSet<CaseOffense> CaseOffenses { get; set; }

    public virtual DbSet<CaseOutcome> CaseOutcomes { get; set; }

    public virtual DbSet<CaseVehicle> CaseVehicles { get; set; }

    public virtual DbSet<CaseVehiclePassenger> CaseVehiclePassengers { get; set; }

    public virtual DbSet<CaseViolation> CaseViolations { get; set; }

    public virtual DbSet<ClerkSupplement> ClerkSupplements { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<ConditionReasonForStop> ConditionReasonForStops { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<Defendant> Defendants { get; set; }

    public virtual DbSet<DefendantAdditionalInfo> DefendantAdditionalInfos { get; set; }

    public virtual DbSet<DefendantAddress> DefendantAddresses { get; set; }

    public virtual DbSet<DefendantEmContact> DefendantEmContacts { get; set; }

    public virtual DbSet<DefendantInterview> DefendantInterviews { get; set; }

    public virtual DbSet<DefendantInterviewQuestion> DefendantInterviewQuestions { get; set; }

    public virtual DbSet<DefendantObservation> DefendantObservations { get; set; }

    public virtual DbSet<DefendantOccupationAddress> DefendantOccupationAddresses { get; set; }

    public virtual DbSet<DefendantPhone> DefendantPhones { get; set; }

    public virtual DbSet<DefendantStatement> DefendantStatements { get; set; }

    public virtual DbSet<DistrictAttorneyCounty> DistrictAttorneyCounties { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DreCase> DreCases { get; set; }

    public virtual DbSet<DreCaseAoFst> DreCaseAoFsts { get; set; }

    public virtual DbSet<DreCaseAoInterview> DreCaseAoInterviews { get; set; }

    public virtual DbSet<DreCaseHgn> DreCaseHgns { get; set; }

    public virtual DbSet<DreCaseImage> DreCaseImages { get; set; }

    public virtual DbSet<DreCaseIndicator> DreCaseIndicators { get; set; }

    public virtual DbSet<DreCaseIntoxSalivaScreen> DreCaseIntoxSalivaScreens { get; set; }

    public virtual DbSet<DreCaseIntoxUrineScreen> DreCaseIntoxUrineScreens { get; set; }

    public virtual DbSet<DreCaseIntoxilyzerReport> DreCaseIntoxilyzerReports { get; set; }

    public virtual DbSet<DreCaseNote> DreCaseNotes { get; set; }

    public virtual DbSet<DreCaseNoteType> DreCaseNoteTypes { get; set; }

    public virtual DbSet<DreCaseOls> DreCaseOls { get; set; }

    public virtual DbSet<DreCaseOtherObservation> DreCaseOtherObservations { get; set; }

    public virtual DbSet<DreCasePage> DreCasePages { get; set; }

    public virtual DbSet<DreCasePic> DreCasePics { get; set; }

    public virtual DbSet<DreCaseRb> DreCaseRbs { get; set; }

    public virtual DbSet<DreCaseToxSpec> DreCaseToxSpecs { get; set; }

    public virtual DbSet<DreCaseToxicologyDrug> DreCaseToxicologyDrugs { get; set; }

    public virtual DbSet<DreCaseVideo> DreCaseVideos { get; set; }

    public virtual DbSet<DreCaseWt> DreCaseWts { get; set; }

    public virtual DbSet<DreCasesAoObs> DreCasesAoObs { get; set; }

    public virtual DbSet<DreCasesDarkRoom> DreCasesDarkRooms { get; set; }

    public virtual DbSet<DreCasesFtn> DreCasesFtns { get; set; }

    public virtual DbSet<DreCasesObs> DreCasesObs { get; set; }

    public virtual DbSet<DreCasesOffense> DreCasesOffenses { get; set; }

    public virtual DbSet<DreCasesOtherOfficer> DreCasesOtherOfficers { get; set; }

    public virtual DbSet<DreCasesVitalSign> DreCasesVitalSigns { get; set; }

    public virtual DbSet<DreDefendant> DreDefendants { get; set; }

    public virtual DbSet<DuiCaseNote> DuiCaseNotes { get; set; }

    public virtual DbSet<DuiCaseNoteType> DuiCaseNoteTypes { get; set; }

    public virtual DbSet<EvidenceDocument> EvidenceDocuments { get; set; }

    public virtual DbSet<EvidenceRecording> EvidenceRecordings { get; set; }

    public virtual DbSet<FieldSobrietyTest> FieldSobrietyTests { get; set; }

    public virtual DbSet<FstFingerToNoseTest> FstFingerToNoseTests { get; set; }

    public virtual DbSet<FstHandCoordination> FstHandCoordinations { get; set; }

    public virtual DbSet<FstHgntest> FstHgntests { get; set; }

    public virtual DbSet<FstOneLegStandTest> FstOneLegStandTests { get; set; }

    public virtual DbSet<FstOtherTest> FstOtherTests { get; set; }

    public virtual DbSet<FstPalmPatTest> FstPalmPatTests { get; set; }

    public virtual DbSet<FstWalkAndTurnTest> FstWalkAndTurnTests { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobParameter> JobParameters { get; set; }

    public virtual DbSet<JobQueue> JobQueues { get; set; }

    public virtual DbSet<Judge> Judges { get; set; }

    public virtual DbSet<JudgeCounty> JudgeCounties { get; set; }

    public virtual DbSet<JudgeCourtType> JudgeCourtTypes { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<LoginHistory> LoginHistories { get; set; }

    public virtual DbSet<LuAccidentType> LuAccidentTypes { get; set; }

    public virtual DbSet<LuAddressType> LuAddressTypes { get; set; }

    public virtual DbSet<LuAlcoholType> LuAlcoholTypes { get; set; }

    public virtual DbSet<LuBodyOfWaterType> LuBodyOfWaterTypes { get; set; }

    public virtual DbSet<LuBwimotorType> LuBwimotorTypes { get; set; }

    public virtual DbSet<LuBwivesselType> LuBwivesselTypes { get; set; }

    public virtual DbSet<LuCounty> LuCounties { get; set; }

    public virtual DbSet<LuCourtType> LuCourtTypes { get; set; }

    public virtual DbSet<LuDisabilityBias> LuDisabilityBiases { get; set; }

    public virtual DbSet<LuDpsdrugList> LuDpsdrugLists { get; set; }

    public virtual DbSet<LuEducationLevel> LuEducationLevels { get; set; }

    public virtual DbSet<LuEthnicity> LuEthnicities { get; set; }

    public virtual DbSet<LuEyeColor> LuEyeColors { get; set; }

    public virtual DbSet<LuFootwearType> LuFootwearTypes { get; set; }

    public virtual DbSet<LuGenderBias> LuGenderBiases { get; set; }

    public virtual DbSet<LuGenderIdentityBias> LuGenderIdentityBiases { get; set; }

    public virtual DbSet<LuHairColor> LuHairColors { get; set; }

    public virtual DbSet<LuInjuryType> LuInjuryTypes { get; set; }

    public virtual DbSet<LuIntegrationVendor> LuIntegrationVendors { get; set; }

    public virtual DbSet<LuInterviewQuestion> LuInterviewQuestions { get; set; }

    public virtual DbSet<LuIntoxVerifyTemp> LuIntoxVerifyTemps { get; set; }

    public virtual DbSet<LuLightCondition> LuLightConditions { get; set; }

    public virtual DbSet<LuMoreLessIntoxicated> LuMoreLessIntoxicateds { get; set; }

    public virtual DbSet<LuNcicboatShape> LuNcicboatShapes { get; set; }

    public virtual DbSet<LuNciccolor> LuNciccolors { get; set; }

    public virtual DbSet<LuNcicinstruction> LuNcicinstructions { get; set; }

    public virtual DbSet<LuNciclabel> LuNciclabels { get; set; }

    public virtual DbSet<LuNcicmake> LuNcicmakes { get; set; }

    public virtual DbSet<LuNcictransportMode> LuNcictransportModes { get; set; }

    public virtual DbSet<LuNcictransportType> LuNcictransportTypes { get; set; }

    public virtual DbSet<LuNcicvehicleModel> LuNcicvehicleModels { get; set; }

    public virtual DbSet<LuNcicvehicleStyle> LuNcicvehicleStyles { get; set; }

    public virtual DbSet<LuOffense> LuOffenses { get; set; }

    public virtual DbSet<LuOffenseTypeLocation> LuOffenseTypeLocations { get; set; }

    public virtual DbSet<LuOperatorOccupation> LuOperatorOccupations { get; set; }

    public virtual DbSet<LuPhoneType> LuPhoneTypes { get; set; }

    public virtual DbSet<LuRace> LuRaces { get; set; }

    public virtual DbSet<LuRaceBias> LuRaceBiases { get; set; }

    public virtual DbSet<LuRadarType> LuRadarTypes { get; set; }

    public virtual DbSet<LuRelationshipType> LuRelationshipTypes { get; set; }

    public virtual DbSet<LuReligionBias> LuReligionBiases { get; set; }

    public virtual DbSet<LuRoadCondition> LuRoadConditions { get; set; }

    public virtual DbSet<LuRoadSurface> LuRoadSurfaces { get; set; }

    public virtual DbSet<LuSex> LuSexes { get; set; }

    public virtual DbSet<LuSexualOrBias> LuSexualOrBiases { get; set; }

    public virtual DbSet<LuSkinComplexion> LuSkinComplexions { get; set; }

    public virtual DbSet<LuSpecimenStorage> LuSpecimenStorages { get; set; }

    public virtual DbSet<LuSpecimenSubmitMethod> LuSpecimenSubmitMethods { get; set; }

    public virtual DbSet<LuState> LuStates { get; set; }

    public virtual DbSet<LuStatus> LuStatuses { get; set; }

    public virtual DbSet<LuSurface> LuSurfaces { get; set; }

    public virtual DbSet<LuTechnicianType> LuTechnicianTypes { get; set; }

    public virtual DbSet<LuUnknownBias> LuUnknownBiases { get; set; }

    public virtual DbSet<LuWaterSurface> LuWaterSurfaces { get; set; }

    public virtual DbSet<LuWaveHeight> LuWaveHeights { get; set; }

    public virtual DbSet<LuWaveType> LuWaveTypes { get; set; }

    public virtual DbSet<LuWeatherType> LuWeatherTypes { get; set; }

    public virtual DbSet<Officer> Officers { get; set; }

    public virtual DbSet<OfficerStepShift> OfficerStepShifts { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<OrganizationEuladoc> OrganizationEuladocs { get; set; }

    public virtual DbSet<OrganizationIprestriction> OrganizationIprestrictions { get; set; }

    public virtual DbSet<OrganizationLocation> OrganizationLocations { get; set; }

    public virtual DbSet<OrganizationSearchWarrantGroup> OrganizationSearchWarrantGroups { get; set; }

    public virtual DbSet<OrganizationSignedEula> OrganizationSignedEulas { get; set; }

    public virtual DbSet<OrganizationTransferSetting> OrganizationTransferSettings { get; set; }

    public virtual DbSet<OtherOfficer> OtherOfficers { get; set; }

    public virtual DbSet<PasswordHistory> PasswordHistories { get; set; }

    public virtual DbSet<PhysicalEvidence> PhysicalEvidences { get; set; }

    public virtual DbSet<PriorDepartment> PriorDepartments { get; set; }

    public virtual DbSet<ReportForm> ReportForms { get; set; }

    public virtual DbSet<ReportGroup> ReportGroups { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleClaim> RoleClaims { get; set; }

    public virtual DbSet<RoleType> RoleTypes { get; set; }

    public virtual DbSet<RolesToPermission> RolesToPermissions { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<SearchWarrantGroup> SearchWarrantGroups { get; set; }

    public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Set> Sets { get; set; }

    public virtual DbSet<SigningRequest> SigningRequests { get; set; }

    public virtual DbSet<SigningRequestReport> SigningRequestReports { get; set; }

    public virtual DbSet<SigningRequestReportAction> SigningRequestReportActions { get; set; }

    public virtual DbSet<SigningRequestSigner> SigningRequestSigners { get; set; }

    public virtual DbSet<SigningTemplate> SigningTemplates { get; set; }

    public virtual DbSet<SigningTemplateReport> SigningTemplateReports { get; set; }

    public virtual DbSet<SigningTemplateReportAction> SigningTemplateReportActions { get; set; }

    public virtual DbSet<SigningTemplateSigner> SigningTemplateSigners { get; set; }

    public virtual DbSet<SpecimenBloodTest> SpecimenBloodTests { get; set; }

    public virtual DbSet<SpecimenBreathTest> SpecimenBreathTests { get; set; }

    public virtual DbSet<SpecimenReport> SpecimenReports { get; set; }

    public virtual DbSet<SpecimenUrineTest> SpecimenUrineTests { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<StepOfficerShiftCase> StepOfficerShiftCases { get; set; }

    public virtual DbSet<StepOfficerShiftZone> StepOfficerShiftZones { get; set; }

    public virtual DbSet<StepShift> StepShifts { get; set; }

    public virtual DbSet<StepZone> StepZones { get; set; }

    public virtual DbSet<SystemModeControl> SystemModeControls { get; set; }

    public virtual DbSet<SystemPage> SystemPages { get; set; }

    public virtual DbSet<TblOfficerResume> TblOfficerResumes { get; set; }

    public virtual DbSet<TblOptAccident> TblOptAccidents { get; set; }

    public virtual DbSet<TblOptActivityType> TblOptActivityTypes { get; set; }

    public virtual DbSet<TblOptAddressGroup> TblOptAddressGroups { get; set; }

    public virtual DbSet<TblOptAlcoholType> TblOptAlcoholTypes { get; set; }

    public virtual DbSet<TblOptAoType> TblOptAoTypes { get; set; }

    public virtual DbSet<TblOptBodyWater> TblOptBodyWaters { get; set; }

    public virtual DbSet<TblOptBwiMotor> TblOptBwiMotors { get; set; }

    public virtual DbSet<TblOptBwiVessel> TblOptBwiVessels { get; set; }

    public virtual DbSet<TblOptCaseOutcomeDismissal> TblOptCaseOutcomeDismissals { get; set; }

    public virtual DbSet<TblOptCaseOutcomePlea> TblOptCaseOutcomePleas { get; set; }

    public virtual DbSet<TblOptCaseOutcomeTrial> TblOptCaseOutcomeTrials { get; set; }

    public virtual DbSet<TblOptCounty> TblOptCounties { get; set; }

    public virtual DbSet<TblOptDismissal> TblOptDismissals { get; set; }

    public virtual DbSet<TblOptDocumentFileType> TblOptDocumentFileTypes { get; set; }

    public virtual DbSet<TblOptDocumentType> TblOptDocumentTypes { get; set; }

    public virtual DbSet<TblOptDpsDrug> TblOptDpsDrugs { get; set; }

    public virtual DbSet<TblOptDpsDrugList> TblOptDpsDrugLists { get; set; }

    public virtual DbSet<TblOptDreCaseStatus> TblOptDreCaseStatuses { get; set; }

    public virtual DbSet<TblOptDreFirstIndicator> TblOptDreFirstIndicators { get; set; }

    public virtual DbSet<TblOptDreFirstIndicator1> TblOptDreFirstIndicators1 { get; set; }

    public virtual DbSet<TblOptDreMajorIndicator> TblOptDreMajorIndicators { get; set; }

    public virtual DbSet<TblOptDreMajorIndicator1> TblOptDreMajorIndicators1 { get; set; }

    public virtual DbSet<TblOptDreMajorType> TblOptDreMajorTypes { get; set; }

    public virtual DbSet<TblOptDreNotified> TblOptDreNotifieds { get; set; }

    public virtual DbSet<TblOptDreNotified1> TblOptDreNotifieds1 { get; set; }

    public virtual DbSet<TblOptDreReactionToLight> TblOptDreReactionToLights { get; set; }

    public virtual DbSet<TblOptDreReactionToLight1> TblOptDreReactionToLights1 { get; set; }

    public virtual DbSet<TblOptDreRequested> TblOptDreRequesteds { get; set; }

    public virtual DbSet<TblOptDreRequested1> TblOptDreRequesteds1 { get; set; }

    public virtual DbSet<TblOptDreRole> TblOptDreRoles { get; set; }

    public virtual DbSet<TblOptDreRole1> TblOptDreRoles1 { get; set; }

    public virtual DbSet<TblOptDreSecondIndicator> TblOptDreSecondIndicators { get; set; }

    public virtual DbSet<TblOptDreType> TblOptDreTypes { get; set; }

    public virtual DbSet<TblOptDreType1> TblOptDreTypes1 { get; set; }

    public virtual DbSet<TblOptEducation> TblOptEducations { get; set; }

    public virtual DbSet<TblOptEmployedPwd> TblOptEmployedPwds { get; set; }

    public virtual DbSet<TblOptEthnicity> TblOptEthnicities { get; set; }

    public virtual DbSet<TblOptEyeColor> TblOptEyeColors { get; set; }

    public virtual DbSet<TblOptFootWearType> TblOptFootWearTypes { get; set; }

    public virtual DbSet<TblOptGender> TblOptGenders { get; set; }

    public virtual DbSet<TblOptHairColor> TblOptHairColors { get; set; }

    public virtual DbSet<TblOptHgnEstimaedAngle> TblOptHgnEstimaedAngles { get; set; }

    public virtual DbSet<TblOptInjury> TblOptInjuries { get; set; }

    public virtual DbSet<TblOptInterviewQuestion> TblOptInterviewQuestions { get; set; }

    public virtual DbSet<TblOptIntoxVerifyTemp> TblOptIntoxVerifyTemps { get; set; }

    public virtual DbSet<TblOptLightCondition> TblOptLightConditions { get; set; }

    public virtual DbSet<TblOptMark43Lookup> TblOptMark43Lookups { get; set; }

    public virtual DbSet<TblOptMoreLessIntoxicated> TblOptMoreLessIntoxicateds { get; set; }

    public virtual DbSet<TblOptNcicColor> TblOptNcicColors { get; set; }

    public virtual DbSet<TblOptNcicInstruction> TblOptNcicInstructions { get; set; }

    public virtual DbSet<TblOptNcicLabel> TblOptNcicLabels { get; set; }

    public virtual DbSet<TblOptNcicTransportMake> TblOptNcicTransportMakes { get; set; }

    public virtual DbSet<TblOptNcicTransportMode> TblOptNcicTransportModes { get; set; }

    public virtual DbSet<TblOptNcicTransportType> TblOptNcicTransportTypes { get; set; }

    public virtual DbSet<TblOptNcicVehcileStyleType> TblOptNcicVehcileStyleTypes { get; set; }

    public virtual DbSet<TblOptNcicVehicleBodyStyle> TblOptNcicVehicleBodyStyles { get; set; }

    public virtual DbSet<TblOptNcicVehicleModel> TblOptNcicVehicleModels { get; set; }

    public virtual DbSet<TblOptOffense> TblOptOffenses { get; set; }

    public virtual DbSet<TblOptOffenseType> TblOptOffenseTypes { get; set; }

    public virtual DbSet<TblOptOperationOccupation> TblOptOperationOccupations { get; set; }

    public virtual DbSet<TblOptOutcome> TblOptOutcomes { get; set; }

    public virtual DbSet<TblOptPhoneType> TblOptPhoneTypes { get; set; }

    public virtual DbSet<TblOptPlea> TblOptPleas { get; set; }

    public virtual DbSet<TblOptRace> TblOptRaces { get; set; }

    public virtual DbSet<TblOptRadarType> TblOptRadarTypes { get; set; }

    public virtual DbSet<TblOptReasonForStop> TblOptReasonForStops { get; set; }

    public virtual DbSet<TblOptRoadCondition> TblOptRoadConditions { get; set; }

    public virtual DbSet<TblOptRoadSurface> TblOptRoadSurfaces { get; set; }

    public virtual DbSet<TblOptSignerType> TblOptSignerTypes { get; set; }

    public virtual DbSet<TblOptSigningAction> TblOptSigningActions { get; set; }

    public virtual DbSet<TblOptSigningStatus> TblOptSigningStatuses { get; set; }

    public virtual DbSet<TblOptSkinComplexion> TblOptSkinComplexions { get; set; }

    public virtual DbSet<TblOptSpecimenStorage> TblOptSpecimenStorages { get; set; }

    public virtual DbSet<TblOptSpecimenSubmittedMethod> TblOptSpecimenSubmittedMethods { get; set; }

    public virtual DbSet<TblOptState> TblOptStates { get; set; }

    public virtual DbSet<TblOptStatus> TblOptStatuses { get; set; }

    public virtual DbSet<TblOptStepDarEventType> TblOptStepDarEventTypes { get; set; }

    public virtual DbSet<TblOptStepGrantType> TblOptStepGrantTypes { get; set; }

    public virtual DbSet<TblOptSurface> TblOptSurfaces { get; set; }

    public virtual DbSet<TblOptSystemMode> TblOptSystemModes { get; set; }

    public virtual DbSet<TblOptToxScreenResult> TblOptToxScreenResults { get; set; }

    public virtual DbSet<TblOptToxSpecType> TblOptToxSpecTypes { get; set; }

    public virtual DbSet<TblOptToxSpecType1> TblOptToxSpecTypes1 { get; set; }

    public virtual DbSet<TblOptUserSecurityQuestion> TblOptUserSecurityQuestions { get; set; }

    public virtual DbSet<TblOptViolation> TblOptViolations { get; set; }

    public virtual DbSet<TblOptWaterSurface> TblOptWaterSurfaces { get; set; }

    public virtual DbSet<TblOptWaveHeight> TblOptWaveHeights { get; set; }

    public virtual DbSet<TblOptWaveType> TblOptWaveTypes { get; set; }

    public virtual DbSet<TblOptWeather> TblOptWeathers { get; set; }

    public virtual DbSet<TblOptWindSpeed> TblOptWindSpeeds { get; set; }

    public virtual DbSet<TblOptZone> TblOptZones { get; set; }

    public virtual DbSet<TransferType> TransferTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserEuladoc> UserEuladocs { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UserSignedEula> UserSignedEulas { get; set; }

    public virtual DbSet<UserToRole> UserToRoles { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    public virtual DbSet<VehicleWatercraft> VehicleWatercrafts { get; set; }

    public virtual DbSet<VehicleWatercraftOwner> VehicleWatercraftOwners { get; set; }

    public virtual DbSet<VendorSystem> VendorSystems { get; set; }

    public virtual DbSet<Witness> Witnesses { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LEADRS_CORE_DEV_NEW;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<AuditChange>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("pk_AuditChanges");
        });

        modelBuilder.Entity<AvGetCboNcicTransportMake>(entity =>
        {
            entity.ToView("AV_GET_CBO_NCIC_TRANSPORT_MAKE");
        });

        modelBuilder.Entity<AvGetCboNcicVehicleModel>(entity =>
        {
            entity.ToView("AV_GET_CBO_NCIC_VEHICLE_MODEL");
        });

        modelBuilder.Entity<CaseHeader>(entity =>
        {
            entity.Property(e => e.IsTrainingPurpose).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.PaidTxDot).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<CaseOffense>(entity =>
        {
            entity.Property(e => e.ChkOffAddressOfficerGeo).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ChkUpdateArrestInfo).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<CaseOutcome>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.DateCreated).HasDefaultValueSql("('2023-02-27T14:09:32.0688878+05:30')");
            entity.Property(e => e.Submitted).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<CaseVehicle>(entity =>
        {
            entity.Property(e => e.VehicleCommercial).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.VehicleHazMat).HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.State).WithMany(p => p.CaseVehicles).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.VehicleColor).WithMany(p => p.CaseVehicles).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.VehicleMake).WithMany(p => p.CaseVehicles).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.VehicleModel).WithMany(p => p.CaseVehicles).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.VehicleStyle).WithMany(p => p.CaseVehicles).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.VehicleType).WithMany(p => p.CaseVehicles).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ClerkSupplement>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.Submitted).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.Property(e => e.ParksAndWildLifeStop).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ResistanceNone).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<ConditionReasonForStop>(entity =>
        {
            entity.Property(e => e.Checked).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasIndex(e => e.Key, "CX_HangFire_Counter").IsClustered();
        });

        modelBuilder.Entity<DefendantInterview>(entity =>
        {
            entity.Property(e => e.AskOnVideo).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.DoNotAskQuestion).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.DoNotAskQuestionForLanguage).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.RefuseToAnswer).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<DefendantStatement>(entity =>
        {
            entity.Property(e => e.DefendantRefusedStatement).HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.DidEmsresponse).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<DistrictAttorneyCounty>(entity =>
        {
            entity.HasKey(e => e.DacountyId).HasName("pk_DistrictAttorneyCounties");
        });

        modelBuilder.Entity<DreCase>(entity =>
        {
            entity.HasIndex(e => e.UniqueId, "IX_DRE_CASES_UniqueId")
                .IsUnique()
                .HasFilter("([UniqueId] IS NOT NULL)");

            entity.HasOne(d => d.DreRole).WithMany(p => p.DreCases).OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.DreType).WithMany(p => p.DreCases).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Status).WithMany(p => p.DreCases).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseAoFst>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseAoFst).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseAoInterview>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseAoInterview).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseHgn>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithMany(p => p.DreCaseHgns).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseImage>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithMany(p => p.DreCaseImages).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseIndicator>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseIndicator).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseIntoxSalivaScreen>(entity =>
        {
            entity.HasOne(d => d.DreCaseIntoxilyzerReport).WithMany(p => p.DreCaseIntoxSalivaScreens).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseIntoxUrineScreen>(entity =>
        {
            entity.HasOne(d => d.DreCaseIntoxilyzerReport).WithMany(p => p.DreCaseIntoxUrineScreens).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseIntoxilyzerReport>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseIntoxilyzerReport).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseNote>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithMany(p => p.DreCaseNotes).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.DreCaseNoteType).WithMany(p => p.DreCaseNotes).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseNoteType>(entity =>
        {
            entity.HasOne(d => d.DreCasePage).WithMany(p => p.DreCaseNoteTypes).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseOls>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseOl).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseOtherObservation>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseOtherObservation).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCasePic>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithMany(p => p.DreCasePics).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseRb>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseRb).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseVideo>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithMany(p => p.DreCaseVideos).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCaseWt>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCaseWt).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCasesAoObs>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCasesAoOb).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCasesDarkRoom>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCasesDarkRoom).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCasesFtn>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCasesFtn).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCasesObs>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCasesOb).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCasesOffense>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCasesOffense).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreCasesOtherOfficer>(entity =>
        {
            entity.Property(e => e.IsOwner).HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.DreCase).WithMany(p => p.DreCasesOtherOfficers).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.DreRole).WithMany(p => p.DreCasesOtherOfficers).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<DreCasesVitalSign>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreCasesVitalSign).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DreDefendant>(entity =>
        {
            entity.HasOne(d => d.DreCase).WithOne(p => p.DreDefendant).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DuiCaseNote>(entity =>
        {
            entity.HasOne(d => d.DuiCase).WithMany(p => p.DuiCaseNotes).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DuiCaseNoteType>(entity =>
        {
            entity.HasOne(d => d.DuiCasePage).WithMany(p => p.DuiCaseNoteTypes).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<EvidenceRecording>(entity =>
        {
            entity.Property(e => e.HasVideoTape).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<FstOneLegStandTest>(entity =>
        {
            entity.HasOne(d => d.FootWear).WithMany(p => p.FstOneLegStandTests).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");
        });

        modelBuilder.Entity<JobParameter>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameters).HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobQueue>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<JudgeCounty>(entity =>
        {
            entity.HasKey(e => e.JudgeCountyId).HasName("pk_JudgeCounties");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LoginHistory>(entity =>
        {
            entity.HasKey(e => e.AuditLoginId).HasName("pk_LoginHistory");
        });

        modelBuilder.Entity<OfficerStepShift>(entity =>
        {
            entity.HasOne(d => d.StepGrantType).WithMany(p => p.OfficerStepShifts).OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.StepShift).WithMany(p => p.OfficerStepShifts).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.Property(e => e.IsTest).HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasMany(d => d.CourtTypes).WithMany(p => p.Organizations)
                .UsingEntity<Dictionary<string, object>>(
                    "OrganizationCourtType",
                    r => r.HasOne<LuCourtType>().WithMany().HasForeignKey("CourtTypeId"),
                    l => l.HasOne<Organization>().WithMany().HasForeignKey("OrganizationId"),
                    j =>
                    {
                        j.HasKey("OrganizationId", "CourtTypeId");
                        j.ToTable("OrganizationCourtTypes");
                        j.HasIndex(new[] { "CourtTypeId" }, "IX_OrganizationCourtTypes_CourtTypeId");
                    });
        });

        modelBuilder.Entity<OrganizationIprestriction>(entity =>
        {
            entity.Property(e => e.WebsiteOrApi).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<OrganizationLocation>(entity =>
        {
            entity.Property(e => e.OrganizationLocationState).IsFixedLength();
        });

        modelBuilder.Entity<OrganizationTransferSetting>(entity =>
        {
            entity.HasKey(e => e.OrganizationTransferSettingsId).HasName("pk_OrganizationTransferSettingsId");
        });

        modelBuilder.Entity<OtherOfficer>(entity =>
        {
            entity.Property(e => e.Supplement).HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Case).WithMany(p => p.OtherOfficers).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<PasswordHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_PasswordHistory");
        });

        modelBuilder.Entity<PriorDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_PriorDepartments");
        });

        modelBuilder.Entity<ReportForm>(entity =>
        {
            entity.HasOne(d => d.ReportGroup).WithMany(p => p.ReportForms).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");
        });

        modelBuilder.Entity<RoleType>(entity =>
        {
            entity.Property(e => e.RoleTypeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<SecurityQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("pk_SecurityQuestion");
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<SpecimenBloodTest>(entity =>
        {
            entity.HasOne(d => d.Employed).WithMany(p => p.SpecimenBloodTests).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.MoreLessIntox).WithMany(p => p.SpecimenBloodTests).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<SpecimenBreathTest>(entity =>
        {
            entity.HasOne(d => d.MoreLessIntox).WithMany(p => p.SpecimenBreathTests).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.VerifyTemp).WithMany(p => p.SpecimenBreathTests).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<SpecimenUrineTest>(entity =>
        {
            entity.HasOne(d => d.MoreLessIntox).WithMany(p => p.SpecimenUrineTests).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Job).WithMany(p => p.States).HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<StepShift>(entity =>
        {
            entity.HasOne(d => d.StepGrantType).WithMany(p => p.StepShifts).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<StepZone>(entity =>
        {
            entity.HasOne(d => d.StepGrantType).WithMany(p => p.StepZones).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<SystemModeControl>(entity =>
        {
            entity.HasOne(d => d.Mode).WithMany(p => p.SystemModeControls).OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Page).WithMany(p => p.SystemModeControls).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<TblOfficerResume>(entity =>
        {
            entity.HasKey(e => e.OfficerResumeId).HasName("OFFICER_RESUME_ID");
        });

        modelBuilder.Entity<TblOptDreRole>(entity =>
        {
            entity.Property(e => e.IsOfficerRole).HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<TblOptSystemMode>(entity =>
        {
            entity.HasOne(d => d.NcicTransportMode).WithMany(p => p.TblOptSystemModes).OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.OffenseType).WithMany(p => p.TblOptSystemModes).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.HasOne(d => d.Organization).WithMany(p => p.Users).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("pk_UserSettings");

            entity.Property(e => e.EmailNotification).HasDefaultValueSql("(CONVERT([bit],(1)))");
            entity.Property(e => e.Notification).HasDefaultValueSql("(CONVERT([bit],(1)))");
        });

        modelBuilder.Entity<VehicleWatercraft>(entity =>
        {
            entity.HasOne(d => d.Motor).WithMany(p => p.VehicleWatercrafts).OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Vessel).WithMany(p => p.VehicleWatercrafts).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<VendorSystem>(entity =>
        {
            entity.HasKey(e => e.VendorId).HasName("pk_VendorId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
