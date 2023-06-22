

-- Specify the folder path
DECLARE @folderPath NVARCHAR(255) = 'C:\Users\BS358\Documents\LEADRS_Practice\Query\DRE_Queries'

-- Create a temporary table to store the file contents
CREATE TABLE #TempScript (Id INT IDENTITY, Script NVARCHAR(MAX))
-- Create a table to store the file paths
CREATE TABLE #FileList (Id INT IDENTITY, FilePath NVARCHAR(255))

----------------------------- X ----------------------------------

-- Use xp_cmdshell to retrieve the list of .sql files in the folder
INSERT INTO #FileList
EXEC ('xp_cmdshell ' + '''DIR /B /S "'+ @folderPath+ '\*.sql"''')

-- Remove non-related output from the result set
DELETE FROM #FileList WHERE FilePath IS NULL

----------------------------- X ----------------------------------

-- Iterate over the file paths and read the file contents into the temporary table
DECLARE @filePath NVARCHAR(255)

DECLARE filePathCursor CURSOR FOR
SELECT FilePath FROM #FileList
ORDER BY Id

OPEN filePathCursor
FETCH NEXT FROM filePathCursor INTO  @filePath

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Use xp_cmdshell to read the file into the temporary table
    INSERT INTO #TempScript
    EXEC ('SELECT * FROM OPENROWSET(BULK ''' + @filePath + ''', SINGLE_CLOB) AS x')

    FETCH NEXT FROM filePathCursor INTO @filePath
END

CLOSE filePathCursor
DEALLOCATE filePathCursor

------------------------------ X ------------------------------------

-- Iterate over and execute each Query of the temporary table
DECLARE @sqlScript NVARCHAR(MAX)

DECLARE filePathCursor CURSOR FOR
SELECT Script FROM #TempScript
ORDER BY Id

OPEN filePathCursor
FETCH NEXT FROM filePathCursor INTO @sqlScript

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Execute the SQL script stored in the variable
	EXEC sp_executesql @sqlScript

    FETCH NEXT FROM filePathCursor INTO @sqlScript
END

CLOSE filePathCursor
DEALLOCATE filePathCursor

----------------------------- X ---------------------------------

---- Concatenate the scripts from the temporary table
--SELECT @sqlScript = COALESCE(@sqlScript + CHAR(13) + CHAR(10), '') + Script
--FROM #TempScript

-- Drop the temporary tables
DROP TABLE #TempScript
DROP TABLE #FileList


--SELECT * FROM #TempScript ORDER BY Id


