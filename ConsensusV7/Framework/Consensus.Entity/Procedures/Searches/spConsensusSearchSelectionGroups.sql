if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSearchSelectionGroups')
  exec ('create procedure dbo.spConsensusSearchSelectionGroups as select 1 as temp')
go

alter procedure dbo.spConsensusSearchSelectionGroups
( 
	@PA_PARENT_ID varchar(25) = null,
	@PA_TYPE int = null
) 
as
begin
	if @PA_TYPE = 1 --Event
	BEGIN
		select CSG_ID as ID, CSG_NAME as Name ,CSG_DESCRIPTION as 'Description', CSG_MIN as 'Minimum', CSG_MAX as 'Maximum' ,CSG_ORDER as 'Order',
		uri = 'learning/courseselectgroups/' + CAST(CSG_ID as varchar(25))
		from dbo.CourseSelectGroups
		where CSG_COURSE_ID = @PA_PARENT_ID
		order by CSG_ORDER
	END
	else --Product
		BEGIN
		select PSG_ID as ID, PSG_NAME as Name ,PSG_DESCRIPTION as 'Description', PSG_MIN as 'Minimum', PSG_MAX as 'Maximum' ,PSG_ORDER as 'Order',
		uri = 'learning/prodselectgroup/' + CAST(PSG_ID as varchar(25))
		from dbo.ProdSelectGroups
		where PSG_PROD_ID= @PA_PARENT_ID
		order by PSG_ORDER
	END
end
