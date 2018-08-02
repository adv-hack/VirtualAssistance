if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusMarketingListModify')
  exec ('create procedure dbo.spConsensusMarketingListModify as select 1 as temp')
go
alter procedure dbo.spConsensusMarketingListModify(@PA_LIST_ID varchar(11) = null output, @PA_LIST_LOCK varchar(10) = null output, @PA_LIST_TITLE varchar(100) = null output, @PA_LIST_SUPPLIER_ID varchar(11) = null output, @PA_LIST_PROLE_ID varchar(11) = null output, @PA_LIST_DATE datetime = null output, @PA_LIST_USER_ID varchar(11) = null output, @PA_LIST_ENTRIES float = null output, @PA_LIST_DUPLICATES float = null output, @PA_LIST_NEW_ORG float = null output, @PA_LIST_NEW_PERSON float = null output, @PA_LIST_PRICE float = null output, @PA_LIST_STATUS varchar(30) = null output, @PA_LIST_NOTES varchar(255) = null output, @PA_LIST_NEW_ADDRESSES float = null output, @PA_LIST_LIMIT float = null output, @PA_LIST_UNTIL datetime = null output, @PA_LIST_USERCHAR_1 varchar(100) = null output, @PA_LIST_USERCHAR_2 varchar(100) = null output, @PA_LIST_USERCHAR_3 varchar(100) = null output, @PA_LIST_USERCHAR_4 varchar(100) = null output, @PA_LIST_USERCHAR_5 varchar(100) = null output, @PA_LIST_USERCHAR_6 varchar(100) = null output, @PA_LIST_COURSE_ID varchar(11) = null output, @PA_LIST_PROCESS varchar(20) = null output, @PA_LIST_COUNTRY varchar(30) = null output, @PA_LIST_IMP_STATUS tinyint = null output, @PA_LIST_JOB_LU tinyint = null output, @PA_LIST_LINES integer = null output, @PA_LIST_COUNTRY_LU tinyint = null output, @PA_LIST_INCOMPLETE integer = null output, @PA_LIST_INVALID_IND integer = null output, @PA_LIST_INVALID_CO integer = null output, @PA_LIST_DELIMIT tinyint = null output, @PA_LIST_HEADER tinyint = null output, @PA_LIST_ETT_ID varchar(11) = null output, @PA_LIST_WEB_ENABLED tinyint = null output, @PA_LIST_NOTES_HTML varchar(11) = null output, @PA_LIST_IS_DYNAMIC bit = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.List set
    LIST_MOD_DATE = getDate(),
    LIST_MOD_BY = @_AUDIT_USER_ID,
    LIST_LOCK = @PA_LIST_LOCK,
    LIST_TITLE = @PA_LIST_TITLE,
    LIST_SUPPLIER_ID = @PA_LIST_SUPPLIER_ID,
    LIST_PROLE_ID = @PA_LIST_PROLE_ID,
    LIST_DATE = @PA_LIST_DATE,
    LIST_USER_ID = @PA_LIST_USER_ID,
    LIST_ENTRIES = @PA_LIST_ENTRIES,
    LIST_DUPLICATES = @PA_LIST_DUPLICATES,
    LIST_NEW_ORG = @PA_LIST_NEW_ORG,
    LIST_NEW_PERSON = @PA_LIST_NEW_PERSON,
    LIST_PRICE = @PA_LIST_PRICE,
    LIST_STATUS = @PA_LIST_STATUS,
    LIST_NOTES = @PA_LIST_NOTES,
    LIST_NEW_ADDRESSES = @PA_LIST_NEW_ADDRESSES,
    LIST_LIMIT = @PA_LIST_LIMIT,
    LIST_UNTIL = @PA_LIST_UNTIL,
    LIST_USERCHAR_1 = @PA_LIST_USERCHAR_1,
    LIST_USERCHAR_2 = @PA_LIST_USERCHAR_2,
    LIST_USERCHAR_3 = @PA_LIST_USERCHAR_3,
    LIST_USERCHAR_4 = @PA_LIST_USERCHAR_4,
    LIST_USERCHAR_5 = @PA_LIST_USERCHAR_5,
    LIST_USERCHAR_6 = @PA_LIST_USERCHAR_6,
    LIST_COURSE_ID = @PA_LIST_COURSE_ID,
    LIST_PROCESS = @PA_LIST_PROCESS,
    LIST_COUNTRY = @PA_LIST_COUNTRY,
    LIST_IMP_STATUS = @PA_LIST_IMP_STATUS,
    LIST_JOB_LU = @PA_LIST_JOB_LU,
    LIST_LINES = @PA_LIST_LINES,
    LIST_COUNTRY_LU = @PA_LIST_COUNTRY_LU,
    LIST_INCOMPLETE = @PA_LIST_INCOMPLETE,
    LIST_INVALID_IND = @PA_LIST_INVALID_IND,
    LIST_INVALID_CO = @PA_LIST_INVALID_CO,
    LIST_DELIMIT = @PA_LIST_DELIMIT,
    LIST_HEADER = @PA_LIST_HEADER,
    LIST_ETT_ID = @PA_LIST_ETT_ID,
    LIST_WEB_ENABLED = @PA_LIST_WEB_ENABLED,
    LIST_NOTES_HTML = @PA_LIST_NOTES_HTML,
    LIST_IS_DYNAMIC = @PA_LIST_IS_DYNAMIC
  where LIST_ID = @PA_LIST_ID;
end
go
