IF not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusLearningBookingGenerateGrpId')
  EXEC ('create procedure dbo.spConsensusLearningBookingGenerateGrpId as select 1 as temp')
go

ALTER procedure [dbo].[spConsensusLearningBookingGenerateGrpId]
(
@PA_BOOK_ID varchar(11) = null output,
@PA_USER_LOGIN_ID varchar(10)
) 
as 
BEGIN
	declare @Delegates table
	(
	ID int identity(1,1),
	DEL_ID varchar(11),
	DEL_ELEM_TYPE tinyint
	)

	declare 
	@NoElements int,
	@Cancelled int,
	@Substituted int,
	@Confirmed int,	
	@Attended int,
	@Provisional int,
	@Waiting int,
	@Transfer int,
	@Reservation int,
	@LapsedWait int,
	@LapsedRes int,
	@Returned int,
	@Returning int,
	@DEL_BOOK_APPROVED tinyint
	
	insert into @Delegates
	select distinct DEL_ID,1 from dbo.Delegate
	join dbo.Element ON ELEM_DEL_ID=DEL_ID
	where DEL_BOOK_ID=@PA_BOOK_ID and ELEM_MAIN_SESSION=1 and (isnull(ELEM_COURSE_ID,'')<>'' or elem_type=28)

	insert into @Delegates
	select distinct DEL_ID,0 from dbo.Delegate
	join dbo.Element ON ELEM_DEL_ID=DEL_ID
	where DEL_BOOK_ID=@PA_BOOK_ID  and ELEM_MAIN_SESSION=1 and isnull(ELEM_COURSE_ID,'')='' and elem_type!=28

	DECLARE 
	@totalRecords int,
	@I int,
	@DEL_ID varchar(11),
	@TYPE tinyint

	SELECT @I = 1
	SELECT @totalRecords = COUNT(ID) FROM @Delegates

	set @PA_USER_LOGIN_ID =SUBSTRING(@PA_USER_LOGIN_ID,1,3)

--Loop into the delegates and call the stored procedure to calc grp id them
	WHILE (@I <= @totalRecords)
	BEGIN
		SELECT @DEL_ID = DEL_ID,@TYPE = DEL_ELEM_TYPE FROM @Delegates WHERE ID = @I
			
		EXEC dbo.Element_GenerateGroupID 
			@PA_USER_LOGIN_ID = @PA_USER_LOGIN_ID,
			@PA_BOOK_ID = @PA_BOOK_ID,
			@PA_DEL_ID = @DEL_ID,
			@PA_DO_ALL_COURSES = @TYPE
		set @I = @I+1
	END 

	--whilst we are here, we can check wether we need to update the delegate status from the events, and the booking status, and the delegate totals from the element (as these are not done when creating the booking here, due to ordering
	select @totalRecords = COUNT(ID) FROM @Delegates
	delete from @Delegates

	insert into @Delegates
	select distinct DEL_ID,DEL_BOOK_APPROVED from dbo.Delegate
	join dbo.Element ON ELEM_DEL_ID=DEL_ID
	where DEL_BOOK_ID=@PA_BOOK_ID and ELEM_MAIN_SESSION=1 and ELEM_STATUS<>DEL_BOOK_APPROVED

	SELECT @I = 1 + @totalRecords
	SELECT @totalRecords = @totalRecords + COUNT(ID) FROM @Delegates

	WHILE (@I <= @totalRecords)
	BEGIN
		SELECT @DEL_ID = DEL_ID,@DEL_BOOK_APPROVED = DEL_ELEM_TYPE FROM @Delegates WHERE ID = @I

		if @DEL_BOOK_APPROVED <> 99
		begin

			select	@Cancelled=sum(case when elem_status = 2 then 1 else 0 end),
				@Substituted = sum(case when elem_status = 9 then 1 else 0 end),
				@Confirmed =  sum(case when elem_status = 1 then 1 else 0 end),
				@Attended =  sum(case when elem_attended = 1 then 1 else 0 end),
				@Provisional = sum(case when elem_status = 0 then 1 else 0 end),
				@Waiting  = sum(case when elem_status = 10 then 1 else 0 end),
				@Transfer  = sum(case when elem_status = 7 then 1 else 0 end),
				@Reservation = sum(case when elem_status = 11 then 1 else 0 end),
				@LapsedWait = sum(case when elem_status = 12 then 1 else 0 end),
				@LapsedRes = sum(case when elem_status = 13 then 1 else 0 end),
				@Returned = sum(case when elem_status = 6 then 1 else 0 end),
				@Returning = sum(case when elem_status = 5 then 1 else 0 end) 
			from dbo.ELEMENT where ELEM_DEL_ID = @DEL_ID and (ELEM_MAIN_SESSION=1 or ELEM_MANDATORY=1) and ELEM_TYPE <> 3

			Select @NoElements = Count(ELEM_ID) from dbo.Element where ELEM_DEL_ID = @DEL_ID and (ELEM_MAIN_SESSION=1 or ELEM_MANDATORY=1) and ELEM_TYPE <> 3

			if @Cancelled + @Transfer + @Substituted + @LapsedWait + @LapsedRes + @Returned = @NoElements 
			begin
				select @DEL_BOOK_APPROVED = 2
			end
			else
			begin
				if (@Reservation + @LapsedRes + @Transfer) = @NoElements
				begin
					select @DEL_BOOK_APPROVED = 11
				end
				else
				begin
					if @Waiting = @NoElements
					begin
						select @DEL_BOOK_APPROVED = 10
					end
					else
					begin
							if
								(@Confirmed + @Cancelled + @Transfer + @Substituted + @LapsedWait + @LapsedRes + @Returned + @Returning = @NoElements) or
								(@Attended + @Confirmed + @Cancelled + @Transfer + @Substituted + @LapsedWait + @LapsedRes + @Returned + @Returning = @NoElements) or
								(@Attended  + @Cancelled + @Transfer + @Substituted + @LapsedWait + @LapsedRes + @Returned + @Returning = @NoElements)
							begin
								select @DEL_BOOK_APPROVED = 1
							end
							else
							begin
								select @DEL_BOOK_APPROVED = 0
							end
					end
				end
			end
		end

		if (@NoElements > 0)
		begin
			exec dbo.spInsertUpdateDelegate
				@PA_USER_LOGIN_ID = @PA_USER_LOGIN_ID,
				@PA_DEL_ID = @DEL_ID,
				@PA_DEL_BOOK_APPROVED = @DEL_BOOK_APPROVED
		end

		set @I = @I+1
	END

	select * from dbo.Booking where BOOK_ID=@PA_BOOK_ID
END
GO