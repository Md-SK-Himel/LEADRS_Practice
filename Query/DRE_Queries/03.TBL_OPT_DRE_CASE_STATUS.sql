----DONE


--DECLARE @query NVARCHAR(MAX)
--DECLARE @SQL_SCRIPT NVARCHAR(MAX)
--DECLARE @DB1_Name NVARCHAR(50)
--DECLARE @DB2_Name NVARCHAR(50)


--SET @DB1_Name = '[LEADRS_CORE_DEV_NEW]';
--SET @DB2_Name = '[LEADRS_TX_STAGING]';


--SET @query = '
--SET IDENTITY_INSERT {DB1Name}.dre.[TBL_OPT_DRE_CASE_STATUS] ON

--INSERT INTO {DB1Name}.dre.[TBL_OPT_DRE_CASE_STATUS]
--(	DRECaseStatusId,
--	StatusName,
--	Active
--)
--VALUES
--	(1, N''Active'', 1),
--	(2, N''Accepted'', 1),
--	(3, N''Submitted'', 1),
--	(4, N''Rejected'', 1)

--SET IDENTITY_INSERT {DB1Name}.dre.[TBL_OPT_DRE_CASE_STATUS] OFF';



--SET @SQL_SCRIPT = REPLACE(@query, '{DB1Name}', @DB1_Name)

--EXECUTE (@SQL_SCRIPT)


