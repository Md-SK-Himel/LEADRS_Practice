using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LEADRS_NEW_DBFirst.Migrations
{
    /// <inheritdoc />
    public partial class ColumnMismatchFiltered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_AO_FST_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_AO_INTERVIEWS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_HGN_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_IMAGES_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_INDICATORS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_INTOXILYZER_REPORT_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_OLS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_Case_OtherObservation_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_PIC_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_RB_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_RB");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_TOXICOLOGY_DRUG_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_Case_Video_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_Case_Video");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_WT_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_WT");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_NOTIFIED_DreNotifiedId",
                schema: "DRE",
                table: "DRE_CASES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_REQUESTED_DreRequestedId",
                schema: "DRE",
                table: "DRE_CASES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_AO_OBS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_DARK_ROOM_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_FTN_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_OBS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_OFFENSES_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_OTHER_OFFICER_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_VITAL_SIGNS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_DEFENDANTS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_DEFENDANTS_TBL_OPT_AO_TYPES_ArrestingOfficerTypeId",
                schema: "DRE",
                table: "DRE_DEFENDANTS");

            migrationBuilder.DropForeignKey(
                name: "FK_DreCaseToxSpec_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.DropForeignKey(
                name: "FK_DreCaseToxSpec_TBL_OPT_TOX_SPEC_TYPE_ToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                schema: "DRE",
                table: "TBL_OPT_TOX_SPEC_TYPE",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                schema: "DRE",
                table: "TBL_OPT_DRE_TYPES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "DRE",
                table: "TBL_OPT_DRE_TYPES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                schema: "DRE",
                table: "TBL_OPT_DRE_ROLES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "DRE",
                table: "TBL_OPT_DRE_REQUESTED",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "DRE",
                table: "TBL_OPT_DRE_REACTION_TO_LIGHT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "DRE",
                table: "TBL_OPT_DRE_NOTIFIED",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ValueToDisplay",
                schema: "DRE",
                table: "TBL_OPT_DRE_MAJOR_INDICATORS ",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                schema: "DRE",
                table: "TBL_OPT_DRE_MAJOR_INDICATORS ",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ColumnName",
                schema: "DRE",
                table: "TBL_OPT_DRE_MAJOR_INDICATORS ",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NarAna",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IndTypeFullName",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IndType",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "INHA",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HALL",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisAne",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnsSti",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnsDep",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CANN",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                schema: "DRE",
                table: "TBL_OPT_DRE_CASE_STATUS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DpsDrugCategory",
                schema: "DRE",
                table: "TBL_OPT_DPS_DRUG_LIST",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DpsDrug",
                schema: "DRE",
                table: "TBL_OPT_DPS_DRUG_LIST",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerType",
                schema: "DRE",
                table: "TBL_OPT_AO_TYPES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WholeBloodResult",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HospSerResult",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BacResult",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DreCaseToxSpecTypeToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArrestingOfficerTypeId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArrestingOfficerName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArrestingOfficerId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArrestingOfficerAgency",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Temperature",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BPSystolic",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BPDiastolic",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RollingLogNumber",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PBT",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "OfficerUserId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerName",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerAgency",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsOwner",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "bit",
                nullable: true,
                defaultValueSql: "(CONVERT([bit],(0)))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValueSql: "(CONVERT([bit],(0)))");

            migrationBuilder.AlterColumn<int>(
                name: "DreRoleId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DreNumber",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Badge",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Accepted",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TheftCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PossessionCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoChargeComment",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssaultCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrackingUnequalDesc",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpeechOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FaceOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinationOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BlindnessComment",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AttitudeOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherComments",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FtnNotes",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReboundStartR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReboundStartL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReboundEndR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReboundEndL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OralCavityOtherText",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NasalAreaothertxt",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LightReaction",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LightR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LightL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DirectR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DirectL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DarkR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DarkL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UnusualActions",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentWarrant",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentRefused",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentPending",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentPBT",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentOther",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "InstrumentNumber",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentNA",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentIntoxilyzer",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DrugWhySuspected",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrugSuspected",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrugReasonSuspected",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryNarcoticAbalgestic",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryInhalants",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryHallucinogents",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryCannabis",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryCNSStimulants",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryCNSDepressant",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathResults",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathInstrumentNumber",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BAC",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UnderCareDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SleepHowLong",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SickInjuredDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RollingLogNumber",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite3",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite2",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite1",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate3",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate2",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate1",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhysicalDefectsDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseZip",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseCity",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseAddress2",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseAddress1",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MirandaGivenBy",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedicationsDrugDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastSleep",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InsulinDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InitialPupilSizeR",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InitialPupilSizeL",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InitialObservationOfSubject",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EvaluationAddress",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EatenWhen",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EatenToday",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrinkingToday",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrinkingTime",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrinkingHowMuch",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DreRoleId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DreRequestedId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DreNotifiedId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DiabeticEpilepticDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CrashProperty",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "CrashNone",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "CrashInjury",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "CrashFatal",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerRank",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerName",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CaseOwnerDepartmentId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerBadge",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerAgency",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgencyCaseNumber",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WalkTurnNoTest",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WalkTurnDescribeTurn",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTTakensFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTTakenSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTStopsSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTStopsFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsRightSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsRightFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsLeftSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsLeftFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTRaisesSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTRaisesFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTNASecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTNAFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTMissesSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WTMissesFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SO_RR",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SO_RL",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SO_LR",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SO_LL",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OtherComments",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSComments",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VideoS3Url",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArchiveId",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApiKey",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrugResult",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Statement",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SideToSideSwayDesc",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherText",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InternalClock",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FrontToBackSwayDesc",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CIRCSwayDesc",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Section",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageData",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "DRE",
                table: "DRE_CASE_PAGES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                schema: "DRE",
                table: "DRE_CASE_PAGES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                schema: "DRE",
                table: "DRE_CASE_PAGES",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "SubStopPartEval",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SubRefusedEval",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubOtherComments",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugsWhere",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugsTime",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugsQty",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugs",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite3",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate3",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MtComments",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InjectionSitesId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "InjRaText",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InjLaText",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InjComments",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTImeRightDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTImeLeftDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwaysR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwaysL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwayTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwayTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSRightDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSOtherR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSOtherL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSNoates",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSLeftDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHoppingR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHoppingL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHopTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHopTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSComments",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmsR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmsL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedById",
                schema: "DRE",
                table: "DRE_CASE_NOTES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                schema: "DRE",
                table: "DRE_CASE_NOTES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                schema: "DRE",
                table: "DRE_CASE_NOTES",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Section",
                schema: "DRE",
                table: "DRE_CASE_NOTE_TYPES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrineWhoObserved",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SalivaWhoObserved",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathSubjectComments",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathSerialNumber",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathResult2",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathResult1",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathRecordNumber",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathOperatorName",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BreathOperatorAgency",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BloodVials",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BloodPhonePwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BloodNamePwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BloodLocationBwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BloodEmployerPwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BloodDescriptionBwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "DRE",
                table: "DRE_CASE_INTOX_URINE_SCREEN",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "DRE",
                table: "DRE_CASE_INTOX_SALIVA_SCREEN",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VgnInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RtlInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PsInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NarAna",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MstInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Inha",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HgnInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HallBody",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DissAne",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnsSti",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnsDep",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cann",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BtInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BpInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StimulusComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PupilSizeComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HeadInjuriesComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactDescription",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CluesTotal",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CluesRight",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CluesLeft",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectVehicleCrashedDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectUsedSteetNameDrugDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectTryConcealOrThrowMaterialDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectSpeechAppearSlurredDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectSeenSmokeDrinkDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectRespondingStopDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectRespondToOfficer",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectOpertingVehicleDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectMentionPrescriptionDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectInhalingSubstanceDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundPrescriptionBottlesDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundMaterialDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundInjectionMaterialDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundDrugResidueDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundBallonPlasticDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectDrivingVehicleDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectComplainedInjuryDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectAttitudeDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectAttitudCompareDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerInterview",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DreCaseToxSpec_DRECaseId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                column: "DRECaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DreCaseToxSpec_DreCaseToxSpecTypeToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                column: "DreCaseToxSpecTypeToxSpecTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_DEFENDANTS_DRECaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASES_VITAL_SIGNS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASES_OTHER_OFFICER_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                column: "DRECaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASES_OFFENSES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASES_OBS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASES_FTN_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASES_DARK_ROOM_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASES_AO_OBS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_WT_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_WT",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_Case_Video_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_Video",
                column: "DRECaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_TOXICOLOGY_DRUG_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                column: "DRECaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_RB_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_RB",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_PIC_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                column: "DRECaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_Case_OtherObservation_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_OLS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_INTOXILYZER_REPORT_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_INDICATORS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_IMAGES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                column: "DRECaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_HGN_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                column: "DRECaseId");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_AO_INTERVIEWS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DRE_CASE_AO_FST_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST",
                column: "DRECaseId",
                unique: true,
                filter: "[DRECaseId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_AO_FST_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_AO_INTERVIEWS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_HGN_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_IMAGES_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_INDICATORS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_INTOXILYZER_REPORT_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_OLS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_Case_OtherObservation_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_PIC_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_RB_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_RB",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_TOXICOLOGY_DRUG_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_Case_Video_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_Video",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_WT_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_WT",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_NOTIFIED_DreNotifiedId",
                schema: "DRE",
                table: "DRE_CASES",
                column: "DreNotifiedId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_DRE_NOTIFIED",
                principalColumn: "DreNotifiedId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_REQUESTED_DreRequestedId",
                schema: "DRE",
                table: "DRE_CASES",
                column: "DreRequestedId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_DRE_REQUESTED",
                principalColumn: "DreRequestedId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_AO_OBS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_DARK_ROOM_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_FTN_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_OBS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_OFFENSES_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_OTHER_OFFICER_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_VITAL_SIGNS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_DEFENDANTS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_DEFENDANTS_TBL_OPT_AO_TYPES_ArrestingOfficerTypeId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                column: "ArrestingOfficerTypeId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_AO_TYPES",
                principalColumn: "ArrestingOfficerTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DreCaseToxSpec_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                column: "DRECaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DreCaseToxSpec_TBL_OPT_TOX_SPEC_TYPE_DreCaseToxSpecTypeToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                column: "DreCaseToxSpecTypeToxSpecTypeId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_TOX_SPEC_TYPE",
                principalColumn: "ToxSpecTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_AO_FST_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_AO_INTERVIEWS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_HGN_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_IMAGES_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_INDICATORS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_INTOXILYZER_REPORT_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_OLS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_Case_OtherObservation_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_PIC_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_RB_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_RB");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_TOXICOLOGY_DRUG_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_Case_Video_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_Video");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASE_WT_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_WT");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_NOTIFIED_DreNotifiedId",
                schema: "DRE",
                table: "DRE_CASES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_REQUESTED_DreRequestedId",
                schema: "DRE",
                table: "DRE_CASES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_AO_OBS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_DARK_ROOM_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_FTN_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_OBS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_OFFENSES_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_OTHER_OFFICER_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_CASES_VITAL_SIGNS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_DEFENDANTS_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS");

            migrationBuilder.DropForeignKey(
                name: "FK_DRE_DEFENDANTS_TBL_OPT_AO_TYPES_ArrestingOfficerTypeId",
                schema: "DRE",
                table: "DRE_DEFENDANTS");

            migrationBuilder.DropForeignKey(
                name: "FK_DreCaseToxSpec_DRE_CASES_DRECaseId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.DropForeignKey(
                name: "FK_DreCaseToxSpec_TBL_OPT_TOX_SPEC_TYPE_DreCaseToxSpecTypeToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.DropIndex(
                name: "IX_DreCaseToxSpec_DRECaseId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.DropIndex(
                name: "IX_DreCaseToxSpec_DreCaseToxSpecTypeToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.DropIndex(
                name: "IX_DRE_DEFENDANTS_DRECaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASES_VITAL_SIGNS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASES_OTHER_OFFICER_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASES_OFFENSES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASES_OBS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASES_FTN_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASES_DARK_ROOM_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASES_AO_OBS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_WT_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_WT");

            migrationBuilder.DropIndex(
                name: "IX_DRE_Case_Video_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_Video");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_TOXICOLOGY_DRUG_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_RB_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_RB");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_PIC_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC");

            migrationBuilder.DropIndex(
                name: "IX_DRE_Case_OtherObservation_DRECaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_OLS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_INTOXILYZER_REPORT_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_INDICATORS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_IMAGES_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_HGN_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_AO_INTERVIEWS_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS");

            migrationBuilder.DropIndex(
                name: "IX_DRE_CASE_AO_FST_DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.DropColumn(
                name: "DreCaseToxSpecTypeToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_WT");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_Case_Video");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_RB");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS");

            migrationBuilder.DropColumn(
                name: "DRECaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                schema: "DRE",
                table: "TBL_OPT_TOX_SPEC_TYPE",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                schema: "DRE",
                table: "TBL_OPT_DRE_TYPES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "DRE",
                table: "TBL_OPT_DRE_TYPES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                schema: "DRE",
                table: "TBL_OPT_DRE_ROLES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "DRE",
                table: "TBL_OPT_DRE_REQUESTED",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "DRE",
                table: "TBL_OPT_DRE_REACTION_TO_LIGHT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "DRE",
                table: "TBL_OPT_DRE_NOTIFIED",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ValueToDisplay",
                schema: "DRE",
                table: "TBL_OPT_DRE_MAJOR_INDICATORS ",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                schema: "DRE",
                table: "TBL_OPT_DRE_MAJOR_INDICATORS ",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "ColumnName",
                schema: "DRE",
                table: "TBL_OPT_DRE_MAJOR_INDICATORS ",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "NarAna",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IndTypeFullName",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IndType",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "INHA",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "HALL",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DisAne",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CnsSti",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CnsDep",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CANN",
                schema: "DRE",
                table: "TBL_OPT_DRE_FIRST_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                schema: "DRE",
                table: "TBL_OPT_DRE_CASE_STATUS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DpsDrugCategory",
                schema: "DRE",
                table: "TBL_OPT_DPS_DRUG_LIST",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DpsDrug",
                schema: "DRE",
                table: "TBL_OPT_DPS_DRUG_LIST",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerType",
                schema: "DRE",
                table: "TBL_OPT_AO_TYPES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "WholeBloodResult",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "HospSerResult",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BacResult",
                schema: "DRE",
                table: "DreCaseToxSpec",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "ArrestingOfficerTypeId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ArrestingOfficerName",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ArrestingOfficerId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ArrestingOfficerAgency",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Temperature",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "BPSystolic",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BPDiastolic",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RollingLogNumber",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<bool>(
                name: "PBT",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerUserId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerName",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerAgency",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "IsOwner",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "bit",
                nullable: false,
                defaultValueSql: "(CONVERT([bit],(0)))",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValueSql: "(CONVERT([bit],(0)))");

            migrationBuilder.AlterColumn<int>(
                name: "DreRoleId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DreNumber",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Badge",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "Accepted",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TheftCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PossessionCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OtherCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "NoChargeComment",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "AssaultCharged",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TrackingUnequalDesc",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SpeechOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FaceOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinationOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BreathOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "BlindnessComment",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AttitudeOther",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "OtherComments",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "FtnNotes",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReboundStartR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ReboundStartL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ReboundEndR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ReboundEndL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "OralCavityOtherText",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NasalAreaothertxt",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LightReaction",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LightR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "LightL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "DirectR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "DirectL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "DarkR",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "DarkL",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "UnusualActions",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentWarrant",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentRefused",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentPending",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentPBT",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentOther",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstrumentNumber",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentNA",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "InstrumentIntoxilyzer",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrugWhySuspected",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "DrugSuspected",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "DrugReasonSuspected",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryNarcoticAbalgestic",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryInhalants",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryHallucinogents",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryCannabis",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryCNSStimulants",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DrugCategoryCNSDepressant",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BreathResults",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "BreathInstrumentNumber",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<decimal>(
                name: "BAC",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UnderCareDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SleepHowLong",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "SickInjuredDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "RollingLogNumber",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite3",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite2",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite1",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate3",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate2",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate1",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PhysicalDefectsDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseZip",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseCity",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseAddress2",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OffenseAddress1",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "MirandaGivenBy",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MedicationsDrugDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastSleep",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "InsulinDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "InitialPupilSizeR",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "InitialPupilSizeL",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "InitialObservationOfSubject",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EvaluationAddress",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "EatenWhen",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "EatenToday",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "DrinkingToday",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "DrinkingTime",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "DrinkingHowMuch",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "DreRoleId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DreRequestedId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DreNotifiedId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DiabeticEpilepticDesc",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<bool>(
                name: "CrashProperty",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CrashNone",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CrashInjury",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CrashFatal",
                schema: "DRE",
                table: "DRE_CASES",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerRank",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerName",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CaseOwnerDepartmentId",
                schema: "DRE",
                table: "DRE_CASES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerBadge",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CaseOwnerAgency",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AgencyCaseNumber",
                schema: "DRE",
                table: "DRE_CASES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "WalkTurnNoTest",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "WalkTurnDescribeTurn",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "WTTakensFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTTakenSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTStopsSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTStopsFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsRightSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsRightFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsLeftSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTStepsLeftFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTRaisesSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTRaisesFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTNASecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTNAFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTMissesSecondNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "WTMissesFirstNine",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "SO_RR",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SO_RL",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SO_LR",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SO_LL",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherComments",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSComments",
                schema: "DRE",
                table: "DRE_CASE_WT",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "VideoS3Url",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ArchiveId",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApiKey",
                schema: "DRE",
                table: "DRE_Case_Video",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrugResult",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Statement",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SideToSideSwayDesc",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "OtherText",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InternalClock",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FrontToBackSwayDesc",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "CIRCSwayDesc",
                schema: "DRE",
                table: "DRE_CASE_RB",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Section",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImageData",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                schema: "DRE",
                table: "DRE_CASE_PAGES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                schema: "DRE",
                table: "DRE_CASE_PAGES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                schema: "DRE",
                table: "DRE_CASE_PAGES",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubStopPartEval",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "SubRefusedEval",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "SubOtherComments",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugsWhere",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugsTime",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugsQty",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SubDrugs",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PulseSite3",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PulseRate3",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "MtComments",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "InjectionSitesId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InjRaText",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "InjLaText",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "InjComments",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTImeRightDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSTImeLeftDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwaysR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwaysL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwayTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OLSSwayTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OLSRightDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSOtherR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSOtherL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSNoates",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OLSLeftDown",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHoppingR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHoppingL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHopTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OLSHopTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OLSComments",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmsR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmsL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmTimeR",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "OLSArmTimeL",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedById",
                schema: "DRE",
                table: "DRE_CASE_NOTES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                schema: "DRE",
                table: "DRE_CASE_NOTES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                schema: "DRE",
                table: "DRE_CASE_NOTES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Section",
                schema: "DRE",
                table: "DRE_CASE_NOTE_TYPES",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "UrineWhoObserved",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "SalivaWhoObserved",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BreathSubjectComments",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "BreathSerialNumber",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BreathResult2",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "BreathResult1",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BreathRecordNumber",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BreathOperatorName",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BreathOperatorAgency",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "BloodVials",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "BloodPhonePwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BloodNamePwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BloodLocationBwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "BloodEmployerPwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BloodDescriptionBwd",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "DRE",
                table: "DRE_CASE_INTOX_URINE_SCREEN",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "DRE",
                table: "DRE_CASE_INTOX_SALIVA_SCREEN",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "VgnInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "RtlInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "PsInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "PrInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "NarAna",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "MstInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "LocInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Inha",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "HgnInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "HallBody",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DissAne",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CnsSti",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CnsDep",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Cann",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BtInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "BpInd",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StimulusComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "PupilSizeComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "OtherComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "HeadInjuriesComments",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "ContactDescription",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "CluesTotal",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "CluesRight",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "CluesLeft",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectVehicleCrashedDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectUsedSteetNameDrugDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectTryConcealOrThrowMaterialDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectSpeechAppearSlurredDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectSeenSmokeDrinkDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectRespondingStopDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectRespondToOfficer",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectOpertingVehicleDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectMentionPrescriptionDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectInhalingSubstanceDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundPrescriptionBottlesDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundMaterialDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundInjectionMaterialDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundDrugResidueDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectFoundBallonPlasticDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectDrivingVehicleDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectComplainedInjuryDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectAttitudeDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectAttitudCompareDesc",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "OfficerInterview",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_AO_FST_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_FST",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_AO_INTERVIEWS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_AO_INTERVIEWS",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_HGN_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_HGN",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_IMAGES_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_IMAGES",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_INDICATORS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_INDICATORS",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_INTOXILYZER_REPORT_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_INTOXILYZER_REPORT",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_OLS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_OLS",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_Case_OtherObservation_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_Case_OtherObservation",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_PIC_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_PIC",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_RB_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_RB",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_TOXICOLOGY_DRUG_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_TOXICOLOGY_DRUG",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_Case_Video_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_Case_Video",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASE_WT_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASE_WT",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_NOTIFIED_DreNotifiedId",
                schema: "DRE",
                table: "DRE_CASES",
                column: "DreNotifiedId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_DRE_NOTIFIED",
                principalColumn: "DreNotifiedId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_TBL_OPT_DRE_REQUESTED_DreRequestedId",
                schema: "DRE",
                table: "DRE_CASES",
                column: "DreRequestedId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_DRE_REQUESTED",
                principalColumn: "DreRequestedId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_AO_OBS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_AO_OBS",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_DARK_ROOM_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_DARK_ROOM",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_FTN_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_FTN",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_OBS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_OBS",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_OFFENSES_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_OFFENSES",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_OTHER_OFFICER_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_OTHER_OFFICER",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_CASES_VITAL_SIGNS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_CASES_VITAL_SIGNS",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_DEFENDANTS_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_DRE_DEFENDANTS_TBL_OPT_AO_TYPES_ArrestingOfficerTypeId",
                schema: "DRE",
                table: "DRE_DEFENDANTS",
                column: "ArrestingOfficerTypeId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_AO_TYPES",
                principalColumn: "ArrestingOfficerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DreCaseToxSpec_DRE_CASES_DreCaseId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                column: "DreCaseId",
                principalSchema: "DRE",
                principalTable: "DRE_CASES",
                principalColumn: "DRECaseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DreCaseToxSpec_TBL_OPT_TOX_SPEC_TYPE_ToxSpecTypeId",
                schema: "DRE",
                table: "DreCaseToxSpec",
                column: "ToxSpecTypeId",
                principalSchema: "DRE",
                principalTable: "TBL_OPT_TOX_SPEC_TYPE",
                principalColumn: "ToxSpecTypeId");
        }
    }
}
