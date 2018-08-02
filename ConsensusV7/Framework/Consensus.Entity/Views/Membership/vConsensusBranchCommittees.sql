IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusBranchCommittees'))
BEGIN
	exec ('create view [dbo].[vConsensusBranchCommittees] as select 1 TEMP')
END
GO
ALTER VIEW [dbo].[vConsensusBranchCommittees]
AS
	select 
	COM_ID,
	COM_NAME,
	COM_STATUS,
	COM_TYPE,
	COM_CATEGORY,
	COM_GROUP,
	COM_BR_ID,
	uri = 'Membership/Committee/' + convert(varchar, COM_ID)
	FROM Committee 

GO
