if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSecurityLicenseRemoveById')
  exec ('create procedure dbo.spConsensusSecurityLicenseRemoveById as select 1 as temp')
go
alter procedure dbo.spConsensusSecurityLicenseRemoveById(@PA_LIC_ID uniqueidentifier = null output) as 
begin
  delete 
  from dbo.License
  where LIC_ID = @PA_LIC_ID
end
go
