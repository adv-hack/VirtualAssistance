if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactCommunicationsFetchAll')
  exec ('create procedure dbo.spConsensusContactCommunicationsFetchAll as select 1 as temp')
go
alter procedure dbo.spConsensusContactCommunicationsFetchAll as 
begin
  select 
    COMM_ID,
    COMM_ADD_DATE,
    COMM_ADD_BY,
    COMM_MOD_DATE,
    COMM_MOD_BY,
    COMM_DEVICE_CODE,
    COMM_DIALLING_CODE,
    COMM_STD_CODE,
    COMM_EXTENSION,
    COMM_EX_DIRECTORY,
    COMM_NOTES,
    COMM_VALID_FROM,
    COMM_ACTIVE,
    COMM_DEFAULT,
    COMM_PREFERRED,
    COMM_DEVICE_VALUE,
    COMM_DEVICE_FULL_VALUE,
    COMM_ADD_ID
  from dbo.Communications
end
go
