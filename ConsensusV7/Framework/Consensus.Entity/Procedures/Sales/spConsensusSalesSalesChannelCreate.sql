if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesSalesChannelCreate')
  exec ('create procedure dbo.spConsensusSalesSalesChannelCreate as select 1 as temp')
go
alter procedure dbo.spConsensusSalesSalesChannelCreate(@PA_SCHN_ID varchar(11) = null output, @PA_SCHN_LOCK varchar(10) = null output, @PA_SCHN_NUMBER tinyint = null output, @PA_SCHN_NAME varchar(80) = null output, @PA_SCHN_REF varchar(25) = null output, @PA_SCHN_PL_ID varchar(11) = null output, @PA_SCHN_STATE tinyint = null output, @PA_SCHN_CUTOFF_TIME datetime = null output, @PA_SCHN_TIMEOUT integer = null output, @PA_SCHN_NO_BOOK tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Sales_Channel(
    SCHN_ADD_DATE,
    SCHN_ADD_BY,
    SCHN_MOD_DATE,
    SCHN_MOD_BY,
    SCHN_RCV_DATE,
    SCHN_RCV_FROM,
    SCHN_LOCK,
    SCHN_NUMBER,
    SCHN_NAME,
    SCHN_REF,
    SCHN_PL_ID,
    SCHN_STATE,
    SCHN_CUTOFF_TIME,
    SCHN_TIMEOUT,
    SCHN_NO_BOOK
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_SCHN_LOCK,
    @PA_SCHN_NUMBER,
    @PA_SCHN_NAME,
    @PA_SCHN_REF,
    @PA_SCHN_PL_ID,
    @PA_SCHN_STATE,
    @PA_SCHN_CUTOFF_TIME,
    @PA_SCHN_TIMEOUT,
    @PA_SCHN_NO_BOOK
  );
    set @PA_SCHN_ID = @@identity;
end
go
