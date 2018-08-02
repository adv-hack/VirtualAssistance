IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusDepartments'))
BEGIN
	exec ('create view [dbo].[vConsensusDepartments] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusDepartments

AS

Select DEPT_ID, DEPT_NAME, DEPT_ORG_ID, uri = 'contact/organisationdepartment/' + convert(varchar, DEPT_ID) From dbo.Department
GO