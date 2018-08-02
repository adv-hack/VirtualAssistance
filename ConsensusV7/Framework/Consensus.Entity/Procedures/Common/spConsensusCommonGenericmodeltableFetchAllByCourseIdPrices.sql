if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusCommonGenericmodeltableFetchAllByCourseIdPrices')
  exec ('create procedure dbo.spConsensusCommonGenericmodeltableFetchAllByCourseIdPrices as select 1 as temp')
go
alter procedure dbo.spConsensusCommonGenericmodeltableFetchAllByCourseIdPrices(@PA_COURSE_ID varchar(11) = null output,@PA_DEL_COUNT tinyint = 1 output) as 
begin
	declare @TodaysDate datetime

	set @TodaysDate = getdate()

	select distinct 
    SXREF_PRS_ID GMT_ID,
    SXREF_PL_ID GMT_ID1,
    '' GMT_ID2,
    SXREF_ID GMT_ID3,
    SXREF_ACT_ID GMT_ID4,
    SXREF_COURSE_ID GMT_ID5,
    SXREF_VATCD GMT_DESC1,
    PL_NAME GMT_DESC2,
    '' GMT_DESC3,
    '' GMT_DESC4,
    '' GMT_DESC5,
    '' GMT_LONGDESC,
    null GMT_DATE1,
    null GMT_DATE2,
    null GMT_DATE3,
    1 GMT_INT1,
    0 GMT_INT2,
    0 GMT_INT3,
    SXREF_PRICE GMT_MONEY1,
    0 GMT_MONEY2,
    0 GMT_MONEY3	
	from dbo.Session_Xref
	join dbo.Course ON COURSE_ID=SXREF_COURSE_ID
	join dbo.Activity ON ACT_ID=SXREF_ACT_ID
	join dbo.Price_List ON PL_ID=SXREF_PL_ID
	join (select Max(isnull(SXREF_QTY_MAX,0)) MAX_SXREF_QTY_MAX, SXREF_ACT_ID MAX_ACT_ID 
		from dbo.SESSION_XREF
		where SXREF_COURSE_ID = @PA_COURSE_ID
		group by SXREF_ACT_ID
	)z ON z.MAX_ACT_ID=SXREF_ACT_ID
	where SXREF_COURSE_ID=@PA_COURSE_ID
	and (PL_STATUS=1 or ACT_TYPE='D-Accom')
	and (case when sxref_valid_date = 0 then @TodaysDate 
	else course_start_date end 
	between coalesce(SXREF_VALID_FROM,case when sxref_valid_date =  1 then course_start_date else @TodaysDate end,@TodaysDate) 
	and coalesce(SXREF_VALID_UNTIL,case when sxref_valid_date =  1 then course_start_date else @TodaysDate end,@TodaysDate))
	and (isnull(SXREF_START_DAY,0) = 0 or dateadd(d,(-1) * SXREF_START_DAY,cast(floor(cast(COURSE_START_DATE as float)) as datetime)) <=@TodaysDate)
	and (isnull(SXREF_END_DAY,0) = 0 or dateadd(d,(-1) * SXREF_END_DAY,cast(floor(cast(COURSE_START_DATE as float))+0.9999999 as datetime)) >=@TodaysDate )
	and ((@PA_DEL_COUNT between isnull(SXREF_QTY_MIN,0) and isnull(SXREF_QTY_MAX,0)) 
	or (isnull(SXREF_QTY_MIN,0) = 0 and isnull(SXREF_QTY_MAX,0)=0) 
	or (@PA_DEL_COUNT>isnull(SXREF_QTY_MAX,0) and isnull(SXREF_QTY_MAX,0) = MAX_SXREF_QTY_MAX))
	union all
	select distinct
    SXREF_PRS_ID GMT_ID,
    SXREF_PL_ID GMT_ID1,
    EP_PROD_ID GMT_ID2,
    SXREF_ID GMT_ID3,
    '' GMT_ID4,
    SXREF_COURSE_ID GMT_ID5,
    SXREF_VATCD GMT_DESC1,
    PL_NAME GMT_DESC2,
    '' GMT_DESC3,
    '' GMT_DESC4,
    '' GMT_DESC5,
    '' GMT_LONGDESC,
    null GMT_DATE1,
    null GMT_DATE2,
    null GMT_DATE3,
    0 GMT_INT1,
    0 GMT_INT2,
    0 GMT_INT3,
    SXREF_PRICE GMT_MONEY1,
    0 GMT_MONEY2,
    0 GMT_MONEY3	
	FROM dbo.Session_Xref  
	join dbo.event_product on ep_id =  sxref_ep_id 
	join dbo.Course ON COURSE_ID=SXREF_COURSE_ID
	join dbo.Price_List ON PL_ID=SXREF_PL_ID
	join (select Max(isnull(SXREF_QTY_MAX,0)) MAX_SXREF_QTY_MAX, sxref_ep_id MAX_sxref_ep_id 
		from dbo.SESSION_XREF
		where SXREF_COURSE_ID = @PA_COURSE_ID
		group by sxref_ep_id
	)z ON z.MAX_sxref_ep_id=ep_id	
	where SXREF_COURSE_ID=@PA_COURSE_ID
	and PL_STATUS=1
	and (case when sxref_valid_date = 0 then @TodaysDate 
	else course_start_date end 
	between coalesce(SXREF_VALID_FROM,case when sxref_valid_date =  1 then course_start_date else @TodaysDate end,@TodaysDate) 
	and coalesce(SXREF_VALID_UNTIL,case when sxref_valid_date =  1 then course_start_date else @TodaysDate end,@TodaysDate))
	and (isnull(SXREF_START_DAY,0) = 0 or dateadd(d,(-1) * SXREF_START_DAY,cast(floor(cast(COURSE_START_DATE as float)) as datetime)) <=@TodaysDate)
	and (isnull(SXREF_END_DAY,0) = 0 or dateadd(d,(-1) * SXREF_END_DAY,cast(floor(cast(COURSE_START_DATE as float))+0.9999999 as datetime)) >=@TodaysDate )
	and ((@PA_DEL_COUNT between isnull(SXREF_QTY_MIN,0) and isnull(SXREF_QTY_MAX,0)) 
	or (isnull(SXREF_QTY_MIN,0) = 0 and isnull(SXREF_QTY_MAX,0)=0) 
	or (@PA_DEL_COUNT>isnull(SXREF_QTY_MAX,0) and isnull(SXREF_QTY_MAX,0) = MAX_SXREF_QTY_MAX))
end
go
