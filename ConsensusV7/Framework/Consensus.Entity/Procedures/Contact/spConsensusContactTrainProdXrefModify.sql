if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactTrainProdXrefModify')
  exec ('create procedure dbo.spConsensusContactTrainProdXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusContactTrainProdXrefModify(@PA_TPXREF_ID varchar(11) = null output, @PA_TPXREF_TRAIN_ID varchar(11) = null output, @PA_TPXREF_LOC_ID varchar(11) = null output, @PA_TPXREF_PROD_ID varchar(11) = null output, @PA_TPXREF_START_DATE datetime = null output, @PA_TPXREF_END_DATE datetime = null output, @PA_TPXREF_STATUS varchar(40) = null output, @PA_TPXREF_GRADE varchar(40) = null output, @PA_TPXREF_NOTES varchar(255) = null output, @PA_TPXREF_COST decimal(12, 2) = null output, @PA_TPXREF_USERCHAR_1 varchar(100) = null output, @PA_TPXREF_USERCHAR_2 varchar(100) = null output, @PA_TPXREF_USERCHAR_3 varchar(100) = null output, @PA_TPXREF_USERCHAR_4 varchar(100) = null output, @PA_TPXREF_USERCHAR_5 varchar(100) = null output, @PA_TPXREF_USERCHAR_6 varchar(100) = null output, @PA_TPXREF_USERINT_1 tinyint = null output, @PA_TPXREF_USERINT_2 tinyint = null output, @PA_TPXREF_USERINT_3 tinyint = null output, @PA_TPXREF_USERINT_4 tinyint = null output, @PA_TPXREF_USERINT_5 tinyint = null output, @PA_TPXREF_USERINT_6 tinyint = null output, @PA_TPXREF_USERNUM_1 decimal(16, 2) = null output, @PA_TPXREF_USERNUM_2 decimal(16, 2) = null output, @PA_TPXREF_USERNUM_3 decimal(16, 2) = null output, @PA_TPXREF_USERNUM_4 decimal(16, 2) = null output, @PA_TPXREF_USERNUM_5 decimal(16, 2) = null output, @PA_TPXREF_USERNUM_6 decimal(16, 2) = null output, @PA_TPXREF_USERDATE_1 datetime = null output, @PA_TPXREF_USERDATE_2 datetime = null output, @PA_TPXREF_USERDATE_3 datetime = null output, @PA_TPXREF_USERDATE_4 datetime = null output, @PA_TPXREF_USERDATE_5 datetime = null output, @PA_TPXREF_USERDATE_6 datetime = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.TRAIN_PROD_XREF set
    TPXREF_MOD_DATE = getDate(),
    TPXREF_MOD_BY = @_AUDIT_USER_ID,
    TPXREF_TRAIN_ID = @PA_TPXREF_TRAIN_ID,
    TPXREF_LOC_ID = @PA_TPXREF_LOC_ID,
    TPXREF_PROD_ID = @PA_TPXREF_PROD_ID,
    TPXREF_START_DATE = @PA_TPXREF_START_DATE,
    TPXREF_END_DATE = @PA_TPXREF_END_DATE,
    TPXREF_STATUS = @PA_TPXREF_STATUS,
    TPXREF_GRADE = @PA_TPXREF_GRADE,
    TPXREF_NOTES = @PA_TPXREF_NOTES,
    TPXREF_COST = @PA_TPXREF_COST,
    TPXREF_USERCHAR_1 = @PA_TPXREF_USERCHAR_1,
    TPXREF_USERCHAR_2 = @PA_TPXREF_USERCHAR_2,
    TPXREF_USERCHAR_3 = @PA_TPXREF_USERCHAR_3,
    TPXREF_USERCHAR_4 = @PA_TPXREF_USERCHAR_4,
    TPXREF_USERCHAR_5 = @PA_TPXREF_USERCHAR_5,
    TPXREF_USERCHAR_6 = @PA_TPXREF_USERCHAR_6,
    TPXREF_USERINT_1 = @PA_TPXREF_USERINT_1,
    TPXREF_USERINT_2 = @PA_TPXREF_USERINT_2,
    TPXREF_USERINT_3 = @PA_TPXREF_USERINT_3,
    TPXREF_USERINT_4 = @PA_TPXREF_USERINT_4,
    TPXREF_USERINT_5 = @PA_TPXREF_USERINT_5,
    TPXREF_USERINT_6 = @PA_TPXREF_USERINT_6,
    TPXREF_USERNUM_1 = @PA_TPXREF_USERNUM_1,
    TPXREF_USERNUM_2 = @PA_TPXREF_USERNUM_2,
    TPXREF_USERNUM_3 = @PA_TPXREF_USERNUM_3,
    TPXREF_USERNUM_4 = @PA_TPXREF_USERNUM_4,
    TPXREF_USERNUM_5 = @PA_TPXREF_USERNUM_5,
    TPXREF_USERNUM_6 = @PA_TPXREF_USERNUM_6,
    TPXREF_USERDATE_1 = @PA_TPXREF_USERDATE_1,
    TPXREF_USERDATE_2 = @PA_TPXREF_USERDATE_2,
    TPXREF_USERDATE_3 = @PA_TPXREF_USERDATE_3,
    TPXREF_USERDATE_4 = @PA_TPXREF_USERDATE_4,
    TPXREF_USERDATE_5 = @PA_TPXREF_USERDATE_5,
    TPXREF_USERDATE_6 = @PA_TPXREF_USERDATE_6
  where TPXREF_ID = @PA_TPXREF_ID;
end
go
