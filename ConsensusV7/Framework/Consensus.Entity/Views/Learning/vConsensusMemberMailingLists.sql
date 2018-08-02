if not exists (select object_id from sys.objects where name = 'vConsensusMemberMailingLists' and type = 'v')
  exec ('create view dbo.vConsensusMemberMailingLists as select 1 as temp')
go

alter view dbo.vConsensusMemberMailingLists as 

SELECT DISTINCT LM_PN_ID, LM_ID, LIST_TITLE, LM_ADD_DATE, LIST_STATUS,
uri = 'marketing/mailinglistmember/' + convert(varchar, LM_ID)
FROM List
INNER JOIN List_Member ON LIST_ID = LM_LIST_ID

go


