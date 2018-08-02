if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningBillOfMaterialCreate')
  exec ('create procedure dbo.spConsensusLearningBillOfMaterialCreate as select 1 as temp')
go
alter procedure dbo.spConsensusLearningBillOfMaterialCreate(@PA_BOM_ID varchar(11) = null output, @PA_BOM_LOCK varchar(10) = null output, @PA_BOM_PARENT_ID varchar(11) = null output, @PA_BOM_SYLLABUS_ID varchar(11) = null output, @PA_BOM_LOCATION_ID varchar(11) = null output, @PA_BOM_RESOURCE_ID varchar(11) = null output, @PA_BOM_TYPE varchar(20) = null output, @PA_BOM_REAL tinyint = null output, @PA_BOM_SESSION tinyint = null output, @PA_BOM_ELEMENT tinyint = null output, @PA_BOM_START_DAY float = null output, @PA_BOM_END_DAY float = null output, @PA_BOM_START_TIME datetime = null output, @PA_BOM_END_TIME datetime = null output, @PA_BOM_QUANTITY float = null output, @PA_BOM_MANDATORY tinyint = null output, @PA_BOM_STREAM varchar(20) = null output, @PA_BOM_CHARGEABLE tinyint = null output, @PA_BOM_INVOICE_PRINT tinyint = null output, @PA_BOM_ACT_TYPE varchar(25) = null output, @PA_BOM_SHOW_SALES tinyint = null output, @PA_BOM_ACT_NOTE varchar(max) = null output, @PA_BOM_SUBJECT varchar(80) = null output, @PA_BOM_VAL_TO_REV float = null output, @PA_BOM_MAIN_SESSION tinyint = null output, @PA_BOM_TYPE_SUB varchar(20) = null output, @PA_BOM_ROOM_LAYOUT integer = null output, @PA_BOM_INC_IN_BUDGET tinyint = null output, @PA_BOM_TEACH_HRS decimal(19, 2) = null output, @PA_BOM_STUD_WKS decimal(19, 2) = null output, @PA_BOM_NOTINUSE_START integer = null output, @PA_BOM_NOTINUSE_END integer = null output, @PA_BOM_ACT_SESSION_NAME nvarchar(250) = null output, @PA_BOM_NO_SLOTS integer = null output, @PA_BOM_START_SLOT integer = null output, @PA_BOM_PREDELIV tinyint = null output, @PA_BOM_CODE varchar(5) = null output, @PA_BOM_PROV_PACK varchar(11) = null output, @PA_BOM_CONF_PACK varchar(11) = null output, @PA_BOM_JOINING_PACK varchar(11) = null output, @PA_BOM_POST_PACK varchar(11) = null output, @PA_BOM_PROV_SEND_TO_BOOK tinyint = null output, @PA_BOM_PROV_SEND_TO_DEL tinyint = null output, @PA_BOM_CONF_SEND_TO_BOOK tinyint = null output, @PA_BOM_CONF_SEND_TO_DEL tinyint = null output, @PA_BOM_JOINING_SEND_TO_BOOK tinyint = null output, @PA_BOM_JOINING_SEND_TO_DEL tinyint = null output, @PA_BOM_POST_SEND_TO_BOOK tinyint = null output, @PA_BOM_POST_SEND_TO_DEL tinyint = null output, @PA_BOM_PSG_ID integer = null output, @PA_BOM_ACT_REVENUE_SPLIT float = null output, @PA_BOM_ACT_HOURS_SPLIT float = null output, @PA_BOM_EXP_OCCUPANCY integer = null output, @PA_BOM_SHOW_ATT_LOG tinyint = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  insert into dbo.Bill_Of_Material(
    BOM_ADD_DATE,
    BOM_ADD_BY,
    BOM_MOD_DATE,
    BOM_MOD_BY,
    BOM_RCV_DATE,
    BOM_RCV_FROM,
    BOM_LOCK,
    BOM_PARENT_ID,
    BOM_SYLLABUS_ID,
    BOM_LOCATION_ID,
    BOM_RESOURCE_ID,
    BOM_TYPE,
    BOM_REAL,
    BOM_SESSION,
    BOM_ELEMENT,
    BOM_START_DAY,
    BOM_END_DAY,
    BOM_START_TIME,
    BOM_END_TIME,
    BOM_QUANTITY,
    BOM_MANDATORY,
    BOM_STREAM,
    BOM_CHARGEABLE,
    BOM_INVOICE_PRINT,
    BOM_ACT_TYPE,
    BOM_SHOW_SALES,
    BOM_ACT_NOTE,
    BOM_SUBJECT,
    BOM_VAL_TO_REV,
    BOM_MAIN_SESSION,
    BOM_TYPE_SUB,
    BOM_ROOM_LAYOUT,
    BOM_INC_IN_BUDGET,
    BOM_TEACH_HRS,
    BOM_STUD_WKS,
    BOM_NOTINUSE_START,
    BOM_NOTINUSE_END,
    BOM_ACT_SESSION_NAME,
    BOM_NO_SLOTS,
    BOM_START_SLOT,
    BOM_PREDELIV,
    BOM_CODE,
    BOM_PROV_PACK,
    BOM_CONF_PACK,
    BOM_JOINING_PACK,
    BOM_POST_PACK,
    BOM_PROV_SEND_TO_BOOK,
    BOM_PROV_SEND_TO_DEL,
    BOM_CONF_SEND_TO_BOOK,
    BOM_CONF_SEND_TO_DEL,
    BOM_JOINING_SEND_TO_BOOK,
    BOM_JOINING_SEND_TO_DEL,
    BOM_POST_SEND_TO_BOOK,
    BOM_POST_SEND_TO_DEL,
    BOM_PSG_ID,
    BOM_ACT_REVENUE_SPLIT,
    BOM_ACT_HOURS_SPLIT,
    BOM_EXP_OCCUPANCY,
    BOM_SHOW_ATT_LOG
  ) values (
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_BOM_LOCK,
    @PA_BOM_PARENT_ID,
    @PA_BOM_SYLLABUS_ID,
    @PA_BOM_LOCATION_ID,
    @PA_BOM_RESOURCE_ID,
    @PA_BOM_TYPE,
    @PA_BOM_REAL,
    @PA_BOM_SESSION,
    @PA_BOM_ELEMENT,
    @PA_BOM_START_DAY,
    @PA_BOM_END_DAY,
    @PA_BOM_START_TIME,
    @PA_BOM_END_TIME,
    @PA_BOM_QUANTITY,
    @PA_BOM_MANDATORY,
    @PA_BOM_STREAM,
    @PA_BOM_CHARGEABLE,
    @PA_BOM_INVOICE_PRINT,
    @PA_BOM_ACT_TYPE,
    @PA_BOM_SHOW_SALES,
    @PA_BOM_ACT_NOTE,
    @PA_BOM_SUBJECT,
    @PA_BOM_VAL_TO_REV,
    @PA_BOM_MAIN_SESSION,
    @PA_BOM_TYPE_SUB,
    @PA_BOM_ROOM_LAYOUT,
    @PA_BOM_INC_IN_BUDGET,
    @PA_BOM_TEACH_HRS,
    @PA_BOM_STUD_WKS,
    @PA_BOM_NOTINUSE_START,
    @PA_BOM_NOTINUSE_END,
    @PA_BOM_ACT_SESSION_NAME,
    @PA_BOM_NO_SLOTS,
    @PA_BOM_START_SLOT,
    @PA_BOM_PREDELIV,
    @PA_BOM_CODE,
    @PA_BOM_PROV_PACK,
    @PA_BOM_CONF_PACK,
    @PA_BOM_JOINING_PACK,
    @PA_BOM_POST_PACK,
    @PA_BOM_PROV_SEND_TO_BOOK,
    @PA_BOM_PROV_SEND_TO_DEL,
    @PA_BOM_CONF_SEND_TO_BOOK,
    @PA_BOM_CONF_SEND_TO_DEL,
    @PA_BOM_JOINING_SEND_TO_BOOK,
    @PA_BOM_JOINING_SEND_TO_DEL,
    @PA_BOM_POST_SEND_TO_BOOK,
    @PA_BOM_POST_SEND_TO_DEL,
    @PA_BOM_PSG_ID,
    @PA_BOM_ACT_REVENUE_SPLIT,
    @PA_BOM_ACT_HOURS_SPLIT,
    @PA_BOM_EXP_OCCUPANCY,
    @PA_BOM_SHOW_ATT_LOG
  );
    set @PA_BOM_ID = @@identity;
end
go
