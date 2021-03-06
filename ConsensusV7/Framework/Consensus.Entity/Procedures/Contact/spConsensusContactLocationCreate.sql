if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactLocationCreate')
  exec ('create procedure dbo.spConsensusContactLocationCreate as select 1 as temp')
go
alter procedure dbo.spConsensusContactLocationCreate(@PA_LOC_ID varchar(11) = null output, @PA_LOC_ORG_ID varchar(11) = null output, @PA_LOC_ADD_ID varchar(11) = null output, @PA_LOC_JOIN_INSTRUCS varchar(11) = null output, @PA_LOC_REF varchar(20) = null output, @PA_LOC_NAME nvarchar(80) = null output, @PA_LOC_CERT_NAME varchar(40) = null output, @PA_LOC_EXTERNAL tinyint = null output, @PA_LOC_CONTACT_NAME varchar(45) = null output, @PA_LOC_COST_PER_DAY float = null output, @PA_LOC_DEL_PER_DAY float = null output, @PA_LOC_MAX_PLACES float = null output, @PA_LOC_SIZE varchar(20) = null output, @PA_LOC_MAP_ID varchar(11) = null output, @PA_LOC_BEDROOM tinyint = null output, @PA_LOC_ROOM_TYPE varchar(25) = null output, @PA_LOC_ROOM_GRADE varchar(25) = null output, @PA_LOC_DIRECTION varchar(11) = null output, @PA_LOC_HTML varchar(11) = null output, @PA_LOC_URL varchar(1000) = null output, @PA_LOC_MAP_FILE varchar(11) = null output, @PA_LOC_OUR_LOCATION tinyint = null output, @PA_LOC_TRAIN_PROVIDER tinyint = null output, @PA_LOC_TRAIN_LOCATION tinyint = null output, @PA_LOC_HOTEL tinyint = null output, @PA_LOC_ANALYSIS_1 varchar(20) = null output, @PA_LOC_ANALYSIS_2 varchar(20) = null output, @PA_LOC_DIRECTIONS varchar(max) = null output, @PA_LOC_NOTES varchar(max) = null output, @PA_LOC_MAP_NAME varchar(80) = null output, @PA_LOC_SELCO_SP_ID varchar(11) = null output, @PA_loc_prole_id varchar(11) = null output, @PA_loc_phone varchar(25) = null output, @PA_loc_fax varchar(25) = null output, @PA_loc_phone_std varchar(10) = null output, @PA_loc_fax_std varchar(10) = null output, @PA_loc_email varchar(100) = null output, @PA_loc_nearest_1 varchar(250) = null output, @PA_loc_nearest_2 varchar(250) = null output, @PA_loc_nearest_3 varchar(250) = null output, @PA_loc_nearest_4 varchar(250) = null output, @PA_loc_nearest_5 varchar(250) = null output, @PA_loc_nearest_6 varchar(250) = null output, @PA_LOC_MAP_IMAGE_PATH varchar(255) = null output, @PA_LOC_DETAILS_PATH varchar(255) = null output, @PA_LOC_REGION varchar(40) = null output, @PA_LOC_DEL_DAY_RATE decimal(19, 2) = null output, @PA_LOC_COST_CODE varchar(40) = null output, @PA_LOC_REV_CODE varchar(40) = null output, @PA_LOC_WEB tinyint = null output, @PA_LOC_VENUE_TYPE varchar(40) = null output, @PA_LOC_LINKED_LOC_ID varchar(11) = null output, @PA_LOC_TITLE varchar(100) = null output, @PA_LOC_DESCRIPTION varchar(max) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  exec spNextID 44, @PA_LOC_ID output
  
  insert into dbo.Location(
    LOC_ID,
    LOC_ADD_DATE,
    LOC_ADD_BY,
    LOC_MOD_DATE,
    LOC_MOD_BY,
    LOC_RCV_DATE,
    LOC_RCV_FROM,
    LOC_ORG_ID,
    LOC_ADD_ID,
    LOC_JOIN_INSTRUCS,
    LOC_REF,
    LOC_NAME,
    LOC_CERT_NAME,
    LOC_EXTERNAL,
    LOC_CONTACT_NAME,
    LOC_COST_PER_DAY,
    LOC_DEL_PER_DAY,
    LOC_MAX_PLACES,
    LOC_SIZE,
    LOC_MAP_ID,
    LOC_BEDROOM,
    LOC_ROOM_TYPE,
    LOC_ROOM_GRADE,
    LOC_DIRECTION,
    LOC_HTML,
    LOC_URL,
    LOC_MAP_FILE,
    LOC_OUR_LOCATION,
    LOC_TRAIN_PROVIDER,
    LOC_TRAIN_LOCATION,
    LOC_HOTEL,
    LOC_ANALYSIS_1,
    LOC_ANALYSIS_2,
    LOC_DIRECTIONS,
    LOC_NOTES,
    LOC_MAP_NAME,
    LOC_SELCO_SP_ID,
    loc_prole_id,
    loc_phone,
    loc_fax,
    loc_phone_std,
    loc_fax_std,
    loc_email,
    loc_nearest_1,
    loc_nearest_2,
    loc_nearest_3,
    loc_nearest_4,
    loc_nearest_5,
    loc_nearest_6,
    LOC_MAP_IMAGE_PATH,
    LOC_DETAILS_PATH,
    LOC_REGION,
    LOC_DEL_DAY_RATE,
    LOC_COST_CODE,
    LOC_REV_CODE,
    LOC_WEB,
    LOC_VENUE_TYPE,
    LOC_LINKED_LOC_ID,
    LOC_TITLE,
    LOC_DESCRIPTION
  ) values (
    @PA_LOC_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    @_AUDIT_USER_ID,
    getDate(),
    '',
    @PA_LOC_ORG_ID,
    @PA_LOC_ADD_ID,
    @PA_LOC_JOIN_INSTRUCS,
    @PA_LOC_REF,
    @PA_LOC_NAME,
    @PA_LOC_CERT_NAME,
    @PA_LOC_EXTERNAL,
    @PA_LOC_CONTACT_NAME,
    @PA_LOC_COST_PER_DAY,
    @PA_LOC_DEL_PER_DAY,
    @PA_LOC_MAX_PLACES,
    @PA_LOC_SIZE,
    @PA_LOC_MAP_ID,
    @PA_LOC_BEDROOM,
    @PA_LOC_ROOM_TYPE,
    @PA_LOC_ROOM_GRADE,
    @PA_LOC_DIRECTION,
    @PA_LOC_HTML,
    @PA_LOC_URL,
    @PA_LOC_MAP_FILE,
    @PA_LOC_OUR_LOCATION,
    @PA_LOC_TRAIN_PROVIDER,
    @PA_LOC_TRAIN_LOCATION,
    @PA_LOC_HOTEL,
    @PA_LOC_ANALYSIS_1,
    @PA_LOC_ANALYSIS_2,
    @PA_LOC_DIRECTIONS,
    @PA_LOC_NOTES,
    @PA_LOC_MAP_NAME,
    @PA_LOC_SELCO_SP_ID,
    @PA_loc_prole_id,
    @PA_loc_phone,
    @PA_loc_fax,
    @PA_loc_phone_std,
    @PA_loc_fax_std,
    @PA_loc_email,
    @PA_loc_nearest_1,
    @PA_loc_nearest_2,
    @PA_loc_nearest_3,
    @PA_loc_nearest_4,
    @PA_loc_nearest_5,
    @PA_loc_nearest_6,
    @PA_LOC_MAP_IMAGE_PATH,
    @PA_LOC_DETAILS_PATH,
    @PA_LOC_REGION,
    @PA_LOC_DEL_DAY_RATE,
    @PA_LOC_COST_CODE,
    @PA_LOC_REV_CODE,
    @PA_LOC_WEB,
    @PA_LOC_VENUE_TYPE,
    @PA_LOC_LINKED_LOC_ID,
    @PA_LOC_TITLE,
    @PA_LOC_DESCRIPTION
  );
end
go
