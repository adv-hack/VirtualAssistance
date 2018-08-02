if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonAttachmentDataModify')
  exec ('create procedure dbo.spConsensusCommonAttachmentDataModify as select 1 as temp')
go
alter procedure dbo.spConsensusCommonAttachmentDataModify(@PA_ATTD_ID integer = null output, @PA_ATTD_ATT_ID varchar(11) = null output, @PA_ATTD_VERSION_NO float = null output, @PA_ATTD_BINARY varbinary(max) = null output, @PA_ATTD_TEXT varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Attachment_Data set
    ATTD_ATT_ID = @PA_ATTD_ATT_ID,
    ATTD_VERSION_NO = @PA_ATTD_VERSION_NO,
    ATTD_BINARY = @PA_ATTD_BINARY,
    ATTD_TEXT = @PA_ATTD_TEXT
  where ATTD_ID = @PA_ATTD_ID;
end
go
