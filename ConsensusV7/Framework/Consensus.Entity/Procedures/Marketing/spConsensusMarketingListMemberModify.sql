if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingListMemberModify')
  exec ('create procedure dbo.spConsensusMarketingListMemberModify as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingListMemberModify(@PA_LM_ID varchar(11) = null output, @PA_LM_LOCK varchar(11) = null output, @PA_LM_LIST_ID varchar(11) = null output, @PA_LM_PN_ID varchar(11) = null output, @PA_LM_TITLE varchar(30) = null output, @PA_LM_USERCHAR_1 varchar(100) = null output, @PA_LM_USERCHAR_2 varchar(100) = null output, @PA_LM_USERCHAR_3 varchar(100) = null output, @PA_LM_USERCHAR_4 varchar(100) = null output, @PA_LM_TERMS_READ tinyint = null output, @PA_LM_TABLE_NAME varchar(50) = null output, @PA_LM_RECORD_ID varchar(50) = null output, @PA_LM_DISABLE tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.List_Member set
    LM_MOD_DATE = getDate(),
    LM_MOD_BY = @_AUDIT_USER_ID,
    LM_LOCK = @PA_LM_LOCK,
    LM_LIST_ID = @PA_LM_LIST_ID,
    LM_PN_ID = @PA_LM_PN_ID,
    LM_TITLE = @PA_LM_TITLE,
    LM_USERCHAR_1 = @PA_LM_USERCHAR_1,
    LM_USERCHAR_2 = @PA_LM_USERCHAR_2,
    LM_USERCHAR_3 = @PA_LM_USERCHAR_3,
    LM_USERCHAR_4 = @PA_LM_USERCHAR_4,
    LM_TERMS_READ = @PA_LM_TERMS_READ,
    LM_TABLE_NAME = @PA_LM_TABLE_NAME,
    LM_RECORD_ID = @PA_LM_RECORD_ID,
    LM_DISABLE = @PA_LM_DISABLE
  where LM_ID = @PA_LM_ID;
end
go
