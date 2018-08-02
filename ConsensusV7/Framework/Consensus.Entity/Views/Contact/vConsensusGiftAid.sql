IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'dbo.vConsensusGiftAid'))
BEGIN
	exec ('create view [dbo].[vConsensusGiftAid] as select 1 TEMP')
END
GO

ALTER VIEW [dbo].vConsensusGiftAid

AS
select GIF_ID,GIF_PN_ID,GIF_TYPE,GIF_COMMUNICATION,GIF_START_DATE,GIF_END_DATE,GIF_ACTIVE, uri = 'contact/giftaid/' + convert(varchar, GIF_ID)
from dbo.GiftAid