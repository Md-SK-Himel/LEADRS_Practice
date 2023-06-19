DECLARE @sqlScript NVARCHAR(MAX)

-- Specify the path to the .sql file
DECLARE @filePath NVARCHAR(255) = 'C:\Users\BS358\Documents\LEADRS_Practice\Query\DRE_Queries\01.TBL_OPT_DRE_ROLES.sql'

-- Create a temporary table to store the file contents
CREATE TABLE #TempScript (Script NVARCHAR(MAX))

-- Use xp_cmdshell to read the file into the temporary table
INSERT INTO #TempScript
EXEC ('SELECT * FROM OPENROWSET(BULK ''' + @filePath + ''', SINGLE_CLOB) AS x')

-- Retrieve the script from the temporary table
SELECT @sqlScript = Script
FROM #TempScript

-- Drop the temporary table
DROP TABLE #TempScript

-- Execute the SQL script stored in the variable
EXEC sp_executesql @sqlScript



