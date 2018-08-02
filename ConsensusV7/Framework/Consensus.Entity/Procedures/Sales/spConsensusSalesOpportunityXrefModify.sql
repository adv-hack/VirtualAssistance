if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusSalesOpportunityXrefModify')
  exec ('create procedure dbo.spConsensusSalesOpportunityXrefModify as select 1 as temp')
go
alter procedure dbo.spConsensusSalesOpportunityXrefModify(@PA_OPPXREF_ID varchar(11) = null output, @PA_OPPXREF_PROLE_ID varchar(11) = null output, @PA_OPPXREF_OPP_ID varchar(11) = null output, @PA_OPPXREF_PRINCIPAL tinyint = null output, @PA_OPPXREF_RELATION varchar(10) = null output, @PA_OPPXREF_NOTE varchar(250) = null output, @PA_OPPXREF_START datetime = null output, @PA_OPPXREF_END datetime = null output, @PA_OPPXREF_END_ORG tinyint = null output, @PA_OPPXREF_DIST_ORG tinyint = null output, @PA_OPPXREF_SALESMAN varchar(1) = null output, @PA_OPPXREF_ORG_NAME nvarchar(240) = null output, @PA_OPPXREF_PN_NAME varchar(150) = null output, @PA_OPPXREF_ORG_ID varchar(11) = null output, @PA_OPPXREF_ORG_PHONE varchar(25) = null output, @PA_OPPXREF_PN_PHONE varchar(25) = null output, @PA_OPPXREF_REL_1 tinyint = null output, @PA_OPPXREF_REL_2 tinyint = null output, @PA_OPPXREF_REL_3 tinyint = null output, @PA_OPPXREF_REL_4 tinyint = null output, @PA_OPPXREF_REL_5 tinyint = null output, @PA_OPPXREF_REL_6 tinyint = null output, @PA_OPPXREF_VALUE decimal(19, 2) = null output, @PA_OPPXREF_SHARE decimal(19, 2) = null output, @_AUDIT_USER_ID varchar(3) = null) as 
begin
  update dbo.Opportunity_Xref set
    OPPXREF_MOD_DATE = getDate(),
    OPPXREF_MOD_BY = @_AUDIT_USER_ID,
    OPPXREF_PROLE_ID = @PA_OPPXREF_PROLE_ID,
    OPPXREF_OPP_ID = @PA_OPPXREF_OPP_ID,
    OPPXREF_PRINCIPAL = @PA_OPPXREF_PRINCIPAL,
    OPPXREF_RELATION = @PA_OPPXREF_RELATION,
    OPPXREF_NOTE = @PA_OPPXREF_NOTE,
    OPPXREF_START = @PA_OPPXREF_START,
    OPPXREF_END = @PA_OPPXREF_END,
    OPPXREF_END_ORG = @PA_OPPXREF_END_ORG,
    OPPXREF_DIST_ORG = @PA_OPPXREF_DIST_ORG,
    OPPXREF_SALESMAN = @PA_OPPXREF_SALESMAN,
    OPPXREF_ORG_NAME = @PA_OPPXREF_ORG_NAME,
    OPPXREF_PN_NAME = @PA_OPPXREF_PN_NAME,
    OPPXREF_ORG_ID = @PA_OPPXREF_ORG_ID,
    OPPXREF_ORG_PHONE = @PA_OPPXREF_ORG_PHONE,
    OPPXREF_PN_PHONE = @PA_OPPXREF_PN_PHONE,
    OPPXREF_REL_1 = @PA_OPPXREF_REL_1,
    OPPXREF_REL_2 = @PA_OPPXREF_REL_2,
    OPPXREF_REL_3 = @PA_OPPXREF_REL_3,
    OPPXREF_REL_4 = @PA_OPPXREF_REL_4,
    OPPXREF_REL_5 = @PA_OPPXREF_REL_5,
    OPPXREF_REL_6 = @PA_OPPXREF_REL_6,
    OPPXREF_VALUE = @PA_OPPXREF_VALUE,
    OPPXREF_SHARE = @PA_OPPXREF_SHARE
  where OPPXREF_ID = @PA_OPPXREF_ID;
end
go
