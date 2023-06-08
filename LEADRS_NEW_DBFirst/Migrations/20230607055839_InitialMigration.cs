using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LEADRS_NEW_DBFirst.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessLog");

            migrationBuilder.DropTable(
                name: "ActiveSessions");

            migrationBuilder.DropTable(
                name: "AdditionalOffenses",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "AggregatedCounter",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "AuditChanges");

            migrationBuilder.DropTable(
                name: "AuthType");

            migrationBuilder.DropTable(
                name: "CaseOutcomes");

            migrationBuilder.DropTable(
                name: "CaseVehiclePassengers",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "CaseViolations",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "ClerkSupplement");

            migrationBuilder.DropTable(
                name: "ConditionReasonForStops",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Counter",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "DefendantAdditionalInfos",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantAddresses",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantEmContacts",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantInterviewQuestions",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantObservations",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantOccupationAddress",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantPhones",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantStatements",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DistrictAttorneyCounties");

            migrationBuilder.DropTable(
                name: "DRE_CASE_AO_FST",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_AO_INTERVIEWS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_HGN",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_IMAGES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_INDICATORS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_INTOX_SALIVA_SCREEN",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_INTOX_URINE_SCREEN",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_NOTES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_OLS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_Case_OtherObservation",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_PIC",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_RB",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_TOXICOLOGY_DRUG",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_Case_Video",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_WT",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES_AO_OBS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES_DARK_ROOM",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES_FTN",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES_OBS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES_OFFENSES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES_OTHER_OFFICER",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES_VITAL_SIGNS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_DEFENDANTS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DUI_CASE_NOTE_TYPES",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DUI_CASE_NOTES",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "EvidenceDocuments",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "EvidenceRecordings",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FieldSobrietyTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FST_FingerToNoseTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FST_HandCoordination",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FST_HGNTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FST_OneLegStandTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FST_OtherTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FST_PalmPatTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "FST_WalkAndTurnTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Hash",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "JobParameter",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "JobQueue",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "JudgeCounties");

            migrationBuilder.DropTable(
                name: "JudgeCourtType");

            migrationBuilder.DropTable(
                name: "List",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "LoginHistory");

            migrationBuilder.DropTable(
                name: "LU_AccidentType");

            migrationBuilder.DropTable(
                name: "LU_AddressType");

            migrationBuilder.DropTable(
                name: "LU_AlcoholType");

            migrationBuilder.DropTable(
                name: "LU_BodyOfWaterType");

            migrationBuilder.DropTable(
                name: "LU_BWIMotorType");

            migrationBuilder.DropTable(
                name: "LU_BWIVesselType");

            migrationBuilder.DropTable(
                name: "LU_County");

            migrationBuilder.DropTable(
                name: "LU_DisabilityBias");

            migrationBuilder.DropTable(
                name: "LU_DPSDrugList");

            migrationBuilder.DropTable(
                name: "LU_EducationLevels");

            migrationBuilder.DropTable(
                name: "LU_Ethnicity");

            migrationBuilder.DropTable(
                name: "LU_EyeColor");

            migrationBuilder.DropTable(
                name: "LU_FootwearType");

            migrationBuilder.DropTable(
                name: "LU_GenderBias");

            migrationBuilder.DropTable(
                name: "LU_GenderIdentityBias");

            migrationBuilder.DropTable(
                name: "LU_HairColor");

            migrationBuilder.DropTable(
                name: "LU_InjuryType");

            migrationBuilder.DropTable(
                name: "LU_IntegrationVendors");

            migrationBuilder.DropTable(
                name: "LU_InterviewQuestions");

            migrationBuilder.DropTable(
                name: "LU_IntoxVerifyTemp");

            migrationBuilder.DropTable(
                name: "LU_LightCondition");

            migrationBuilder.DropTable(
                name: "LU_MoreLessIntoxicated");

            migrationBuilder.DropTable(
                name: "LU_NCICBoatShape");

            migrationBuilder.DropTable(
                name: "LU_NCICColor");

            migrationBuilder.DropTable(
                name: "LU_NCICInstructions");

            migrationBuilder.DropTable(
                name: "LU_NCICLabels");

            migrationBuilder.DropTable(
                name: "LU_NCICMakes");

            migrationBuilder.DropTable(
                name: "LU_NCICTransportModes");

            migrationBuilder.DropTable(
                name: "LU_NCICTransportTypes");

            migrationBuilder.DropTable(
                name: "LU_NCICVehicleModels");

            migrationBuilder.DropTable(
                name: "LU_NCICVehicleStyle");

            migrationBuilder.DropTable(
                name: "LU_Offenses");

            migrationBuilder.DropTable(
                name: "LU_OffenseTypeLocation");

            migrationBuilder.DropTable(
                name: "LU_OperatorOccupation");

            migrationBuilder.DropTable(
                name: "LU_PhoneType");

            migrationBuilder.DropTable(
                name: "LU_Race");

            migrationBuilder.DropTable(
                name: "LU_RaceBias");

            migrationBuilder.DropTable(
                name: "LU_RadarTypes");

            migrationBuilder.DropTable(
                name: "LU_RelationshipType");

            migrationBuilder.DropTable(
                name: "LU_ReligionBias");

            migrationBuilder.DropTable(
                name: "LU_RoadConditions");

            migrationBuilder.DropTable(
                name: "LU_RoadSurfaces");

            migrationBuilder.DropTable(
                name: "LU_Sex");

            migrationBuilder.DropTable(
                name: "LU_SexualOrBias");

            migrationBuilder.DropTable(
                name: "LU_SkinComplexions");

            migrationBuilder.DropTable(
                name: "LU_SpecimenStorage");

            migrationBuilder.DropTable(
                name: "LU_SpecimenSubmitMethod");

            migrationBuilder.DropTable(
                name: "LU_States");

            migrationBuilder.DropTable(
                name: "LU_Status");

            migrationBuilder.DropTable(
                name: "LU_Surfaces");

            migrationBuilder.DropTable(
                name: "LU_TechnicianType");

            migrationBuilder.DropTable(
                name: "LU_UnknownBias");

            migrationBuilder.DropTable(
                name: "LU_WaterSurfaces");

            migrationBuilder.DropTable(
                name: "LU_WaveHeights");

            migrationBuilder.DropTable(
                name: "LU_WaveTypes");

            migrationBuilder.DropTable(
                name: "LU_WeatherTypes");

            migrationBuilder.DropTable(
                name: "LuCourtTypeOrganization");

            migrationBuilder.DropTable(
                name: "Officer");

            migrationBuilder.DropTable(
                name: "OrganizationCourtTypes");

            migrationBuilder.DropTable(
                name: "OrganizationEULADoc");

            migrationBuilder.DropTable(
                name: "OrganizationIPRestriction");

            migrationBuilder.DropTable(
                name: "OrganizationSearchWarrantGroup");

            migrationBuilder.DropTable(
                name: "OrganizationSignedEULA");

            migrationBuilder.DropTable(
                name: "OrganizationTransferSettings");

            migrationBuilder.DropTable(
                name: "OtherOfficers",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "PasswordHistory");

            migrationBuilder.DropTable(
                name: "PriorDepartments");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "RoleType");

            migrationBuilder.DropTable(
                name: "Schema",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "SearchWarrantGroup");

            migrationBuilder.DropTable(
                name: "SecurityQuestion");

            migrationBuilder.DropTable(
                name: "Server",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "Set",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "SigningRequestReportActions",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "SigningTemplateReportActions",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "SigningTemplateSigners",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "SpecimenBloodTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "SpecimenBreathTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "SpecimenUrineTests",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "State",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "StepOfficerShiftCases",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "StepOfficerShiftZones",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "SystemModeControls",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OFFICER_RESUME");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Accidents",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_ActivityTypes",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_BodyWaters",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Case_Outcome_Dismissals",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Case_Outcome_Pleas",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Case_Outcome_Trials",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Dismissals",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DPS_DRUG_LIST",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DPS_Drugs",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_FIRST_INDICATORS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_FirstIndicators",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_Major_Indicators",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_MAJOR_INDICATORS ",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_Major_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_Notified",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_REACTION_TO_LIGHT",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_Reaction_To_Lights",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_Requested",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_Roles",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_SECOND_INDICATORS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_HGN_Estimaed_Angle",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Mark43_Lookup",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Instructions",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Labels",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Operation_Occupations",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Outcomes",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Plea",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Specimen_Storage",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_SpecimenSubmittedMethod",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Step_Dar_Event_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Tox_screen_Result",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Tox_Spec_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_User_Security_Questions",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Water_Surfaces",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Wave_Height",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Wave_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Wind_Speed",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TransferType");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserEULADoc");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "UserSignedEULA");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "UserToRoles");

            migrationBuilder.DropTable(
                name: "Vehicle_Watercraft",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Vehicle_Watercraft_Owner",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "VendorSystem");

            migrationBuilder.DropTable(
                name: "Witnesses",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "CaseOffenses",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Violations",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Conditions",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Reason_For_Stop",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DefendantInterviews",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Interview_Questions",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_AlcoholTypes",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_PhoneType",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DRE_CASE_INTOXILYZER_REPORT",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASE_NOTE_TYPES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DreCaseToxSpec",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_AO_TYPES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "Documents",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "PhysicalEvidences",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Foot_Wear_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Judges");

            migrationBuilder.DropTable(
                name: "LU_CourtType");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SigningRequestReport",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "SigningRequestSigners",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "SigningTemplateReports",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "TBL_OPT_SigningActions",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Employed_PWD",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_INTOX_VerifyTemp",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "SpecimenReports",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_More_Less_Intoxicated",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Job",
                schema: "HangFire");

            migrationBuilder.DropTable(
                name: "OfficerStepShifts",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "StepZones",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "SystemPages",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "RolesToPermissions");

            migrationBuilder.DropTable(
                name: "TBL_OPT_BWI_Motors",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_BWI_Vessels",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "CaseVehicles",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_AddressGroup",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Counties",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Offenses",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Injury",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Light_Conditions",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Radar_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Road_Conditions",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Road_Surface",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Surfaces",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Weathers",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Defendants",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "DRE_CASE_PAGES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "DRE_CASES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_TOX_SPEC_TYPE",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DocumentFileTypes",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DocumentTypes",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "SigningRequests",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "TBL_OPT_SignerTypes",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "ReportForms",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "StepShifts",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Colors",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Transport_Make",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Transport_Type",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Vehcile_Style_Types",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Vehicle_Body_Style",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Vehicle_Model",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "CaseHeaders",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Educations",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Ethnicity",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Eye_Colors",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Genders",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Hair_Colors",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Races",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Skin_Complexion",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_States",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Zones",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_CASE_STATUS",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_NOTIFIED",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_REQUESTED",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_ROLES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "TBL_OPT_DRE_TYPES",
                schema: "DRE");

            migrationBuilder.DropTable(
                name: "SigningTemplates",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "TBL_OPT_SigningStatus",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "ReportGroups",
                schema: "Form");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Step_Grant_Type",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "OrganizationLocation");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Status",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_System_Mode",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_NCIC_Transport_Mode",
                schema: "DUI");

            migrationBuilder.DropTable(
                name: "TBL_OPT_Offense_Types",
                schema: "DUI");
        }
    }
}
