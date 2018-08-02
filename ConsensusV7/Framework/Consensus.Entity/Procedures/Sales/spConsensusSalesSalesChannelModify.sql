if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesSalesChannelModify')
  exec ('create procedure dbo.spConsensusSalesSalesChannelModify as select 1 as temp')
go
alter procedure dbo.spConsensusSalesSalesChannelModify(@PA_SCHN_ID varchar(11) = null output, @PA_SCHN_LOCK varchar(10) = null output, @PA_SCHN_NUMBER tinyint = null output, @PA_SCHN_NAME varchar(80) = null output, @PA_SCHN_REF varchar(25) = null output, @PA_SCHN_PL_ID varchar(11) = null output, @PA_SCHN_STATE tinyint = null output, @PA_SCHN_CUTOFF_TIME datetime = null output, @PA_SCHN_TIMEOUT integer = null output, @PA_SCHN_NO_BOOK tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Sales_Channel set
    SCHN_MOD_DATE = getDate(),
    SCHN_MOD_BY = @_AUDIT_USER_ID,
    SCHN_LOCK = @PA_SCHN_LOCK,
    SCHN_NUMBER = @PA_SCHN_NUMBER,
    SCHN_NAME = @PA_SCHN_NAME,
    SCHN_REF = @PA_SCHN_REF,
    SCHN_PL_ID = @PA_SCHN_PL_ID,
    SCHN_STATE = @PA_SCHN_STATE,
    SCHN_CUTOFF_TIME = @PA_SCHN_CUTOFF_TIME,
    SCHN_TIMEOUT = @PA_SCHN_TIMEOUT,
    SCHN_NO_BOOK = @PA_SCHN_NO_BOOK
  where SCHN_ID = @PA_SCHN_ID;
end
go
