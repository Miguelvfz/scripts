DECLARE @Name VARCHAR(MAX)

DECLARE database_cursor CURSOR FOR
select name from sys.databases where name not in ('master','tempdb','model','msdb','ReportServer','ReportServerTempDB')

OPEN database_cursor

	FETCH NEXT FROM database_cursor INTO @Name

	WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT @NAME
		DECLARE @SQL NVARCHAR(100) = N'alter database ['+@NAME+'] set single_user with rollback immediate'
		EXECUTE sp_executesql @SQL
		
		DECLARE @SQL_DROP NVARCHAR(100) = N'drop database ['+@NAME+']'
		
		EXECUTE sp_executesql @SQL_DROP
							  
		FETCH NEXT FROM database_cursor INTO @Name
	END

CLOSE database_cursor
DEALLOCATE database_cursor