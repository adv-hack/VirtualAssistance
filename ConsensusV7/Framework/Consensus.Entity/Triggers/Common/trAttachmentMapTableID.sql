
if not exists (select object_id from sys.objects where name = 'trAttachmentMapTableID' and type = 'TR')
  exec ('create trigger dbo.trAttachmentMapTableID on Attachment for INSERT as select 1 as temp')
go

alter trigger trAttachmentMapTableID 
on Attachment
for INSERT, UPDATE 
as

IF UPDATE (ATT_TABLE_ID) OR UPDATE(ATT_TABLE_URL)
BEGIN
	SET NOCOUNT ON

	-- This mapping table will need to be kept up to date as new modules are
	-- added to the V7 application.
	declare @tMap TABLE (M_TABLE_ID int PRIMARY KEY, M_TABLE_URL varchar(240))
	
	insert into @tMap values(1, 'Contact/Organisation')
	insert into @tMap values(2, 'Contact/Person')
	insert into @tMap values(38, 'Learning/Booking')
	insert into @tMap values(35, 'Learning/Event')
	insert into @tMap values(16, 'Learning/Product') 
	insert into @tMap values(44, 'Contact/Location')
	insert into @tMap values(4,  'Activities/Activity')
	insert into @tMap values(320, 'Activities/Complaint')
	--insert into @tMap values(35, 'WorkPackage')
	--insert into @tMap values(185, 'ServiceAudit/ServiceIncident')
	insert into @tMap values(98, 'Other/Batch') -- (when len(BAT_DI_ID) == 0)
	insert into @tMap values(5002, 'Other/Batch') -- when len(BAT_DI_ID) > 0)
	insert into @tMap values(48, 'Marketing/Campaign')
	insert into @tMap values(85, 'Marketing/PromotionMaster')
	insert into @tMap values(49, 'Marketing/Promotion')
	insert into @tMap values(20, 'Activities/Helpdesk')
	--insert into @tMap values(37, 'Delegate')
	--insert into @tMap values(5000, 'Trainers')
	--insert into @tMap values(90, 'eCustomer')
	--insert into @tMap values(150, 'Installation')
	insert into @tMap values(12001, 'Marketing/SaqQuery')
	insert into @tMap values(270, 'Membership/Membership')
	insert into @tMap values(3, 'Sales/Opportunity')
	insert into @tMap values(252, 'Document/LetterTemplate')
	--insert into @tMap values(1205, 'Information Requirement')
	--insert into @tMap values(8700, 'PD Scheme')
	--insert into @tMap values(27, 'Project/Workpackage/Task (PROJ_ID)')
	--insert into @tMap values(70, 'Issue (IH_ID or IL_ID ?!)')
	--insert into @tMap values(11, 'Survey')
			
	IF UPDATE (ATT_TABLE_ID) AND (NOT UPDATE(ATT_TABLE_URL) OR NOT EXISTS(SELECT *
		FROM Attachment a
		JOIN inserted i on i.ATT_ID = a.ATT_ID
		WHERE (i.ATT_TABLE_ID IS NULL OR (a.ATT_TABLE_ID = i.ATT_TABLE_ID) AND NULLIF(i.ATT_TABLE_URL, '') IS NOT NULL)))
	BEGIN	
		UPDATE Attachment
			SET ATT_TABLE_URL = im.M_TABLE_URL
		FROM Attachment
		JOIN @tMAP as im on im.M_TABLE_ID = Attachment.ATT_TABLE_ID
		JOIN inserted i on i.ATT_ID = Attachment.ATT_ID
		WHERE (Attachment.ATT_TABLE_URL IS NULL OR Attachment.ATT_TABLE_URL != im.M_TABLE_URL)
	END
	ELSE IF UPDATE(ATT_TABLE_URL)
	BEGIN
		UPDATE Attachment
			SET ATT_TABLE_ID = im.M_TABLE_ID
		FROM Attachment
		JOIN @tMAP as im on im.M_TABLE_URL = Attachment.ATT_TABLE_URL
		JOIN inserted i on i.ATT_ID = Attachment.ATT_ID
		WHERE (Attachment.ATT_TABLE_ID IS NULL OR Attachment.ATT_TABLE_ID != im.M_TABLE_ID)

	END
END

GO

ALTER TABLE Attachment ENABLE TRIGGER trAttachmentMapTableID
GO

-- Include this update to ensure that M_TABLE_URL is up to date with the current mapping.
-- This can be removed once APP_TABLE_ID is no longer being written to, or the mapping table has finished changing.
UPDATE Attachment SET ATT_TABLE_ID = ATT_TABLE_ID
