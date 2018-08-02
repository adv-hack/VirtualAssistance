if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentDataCreate')
  exec ('create procedure dbo.spConsensusCommonAttachmentDataCreate as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentDataCreate(@PA_ATTD_ID integer = null output, @PA_ATTD_ATT_ID varchar(11) = null output, @PA_ATTD_VERSION_NO float = null output, @PA_ATTD_BINARY varbinary(max) = null output, @PA_ATTD_TEXT varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Attachment_Data(
    ATTD_ATT_ID,
    ATTD_VERSION_NO,
    ATTD_BINARY,
    ATTD_TEXT
  ) values (
    @PA_ATTD_ATT_ID,
    @PA_ATTD_VERSION_NO,
    @PA_ATTD_BINARY,
    @PA_ATTD_TEXT
  );
    set @PA_ATTD_ID = @@identity;
end
go
