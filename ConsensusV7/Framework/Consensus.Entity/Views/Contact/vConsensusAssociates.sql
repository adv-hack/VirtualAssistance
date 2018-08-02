if not exists (select object_id from sys.objects where name = 'vConsensusAssociates' and type = 'v')
  exec ('create view dbo.vConsensusAssociates as select 1 as temp')
go

alter view dbo.vConsensusAssociates as 
  select
    ASSO_RECORD_TYPE     = case when ASSO_TYPE between 2 and 6 or ASSO_TYPE between 100 and 199 then 'PERSON' 
                                when ASSO_TYPE in (0, 1, 7, 8) or ASSO_TYPE between 200 and 299 then 'ORGANISATION' end,
    ASSO_ID              = Associates.ASSO_ID,
    ASSO_START_DATE      = Associates.ASSO_START_DATE,
    ASSO_END_DATE        = Associates.ASSO_END_DATE,
    ASSO_TYPE_NAME       = isNull(nullIf(Associates.ASSO_TYPE_NAME, ''), Code.CODE_VALUE1),
    ASSO_ASSOCIATE_ID    = case when ASSO_TYPE between 2 and 6 or ASSO_TYPE between 100 and 199 then ParentPersonRole.PROLE_PERSON_ID
								when ASSO_TYPE in (0, 1, 7, 8) or ASSO_TYPE between 200 and 299 then ParentOrganisation.ORG_ID end,
	ASSO_ASSOCIATE_NAME  = case when ASSO_TYPE between 2 and 6 or ASSO_TYPE between 100 and 199 then ParentPersonRole.PROLE_PN_NAME
								when ASSO_TYPE in (0, 1, 7, 8) or ASSO_TYPE between 200 and 299 then ParentOrganisation.ORG_NAME end,
    ASSO_PERSON_ID       = Person_Role.PROLE_PERSON_ID,
	ASSO_PERSON_NAME     = Person_Role.PROLE_PN_NAME,
	ASSO_ORG_ID          = Organisation.ORG_ID,
	ASSO_ORG_NAME        = Organisation.ORG_NAME,
	ASSO_PROLE_ID,
	ASSO_PARENT_ID       = Associates.ASSO_ASSOCIATE_ID,
	uri                  = 'contact/associate/' + convert(varchar, ASSO_ID)
  from dbo.Associates
  left join dbo.Code on Code.CODE_TYPE = 'ASSOT' and CODE_VALUE3 = ASSO_TYPE
  left join dbo.Person_Role on Person_Role.PROLE_ID = Associates.ASSO_PROLE_ID
  left join dbo.Organisation on Organisation.ORG_ID = Associates.ASSO_ORG_ID
  left join dbo.Person_Role as ParentPersonRole on ParentPersonRole.PROLE_ID = Associates.ASSO_ASSOCIATE_ID
  left join dbo.Organisation as ParentOrganisation on ParentOrganisation.ORG_ID = Associates.ASSO_ASSOCIATE_ID

go