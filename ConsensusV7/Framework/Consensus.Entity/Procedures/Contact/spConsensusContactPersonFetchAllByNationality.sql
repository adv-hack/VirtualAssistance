if not exists (select object_id from sys.objects where type = 'P' and name = 'spConsensusContactPersonFetchAllByNationality')
  exec ('create procedure dbo.spConsensusContactPersonFetchAllByNationality as select 1 as temp')
go
alter procedure dbo.spConsensusContactPersonFetchAllByNationality(@PA_PN_NATIONALITY varchar(40) = null output) as 
begin
  select 
    PN_ID,
    PN_LOCK,
    PN_ADD_DATE,
    PN_ADD_BY,
    PN_MOD_DATE,
    PN_MOD_BY,
    PN_RCV_DATE,
    PN_RCV_FROM,
    PN_TITLE,
    PN_FIRST_NAME,
    PN_SEC_NAME,
    PN_INITIALS,
    PN_SURNAME,
    PN_SNAME_SUFFIX,
    PN_HONOURS,
    PN_SALUTATION,
    PN_DONOTMAIL,
    PN_OUR_PERSON,
    PN_GENDER,
    PN_NOTES,
    PN_SIGNATURE,
    PN_NI_NUMBER,
    PN_ETHNIC_GROUP,
    PN_DIARY,
    PN_LANGUAGE,
    PN_WARMTH,
    PN_SOUNDEX_KEY,
    PN_USERCHAR_1,
    PN_USERCHAR_2,
    PN_USERCHAR_3,
    PN_USERCHAR_4,
    PN_USERNUM_1,
    PN_USERNUM_2,
    PN_NODE,
    PN_AKA,
    PN_SECRETARY_PHONE,
    PN_PREF_COMM,
    PN_DONOTMAIL2,
    PN_DONOTMAIL3,
    PN_DESIG_LETTERS,
    PN_SIGNIF_PARTNER,
    PN_DIET_REQUIRE,
    PN_ALUMNI_GRADE,
    PN_ALUMNI_OFFICE,
    PN_TARGET,
    PN_PROMO_ID,
    PN_DATE_OF_BIRTH,
    PN_RELIGION,
    PN_SPECIAL_NEEDS,
    PN_USERDATE_1,
    PN_USERDATE_2,
    PN_ATTRACTIVE,
    PN_POTENTIAL,
    PN_HOME_PHONE,
    PN_HOME_FAX,
    PN_HOME_OTHER,
    PN_HOME_ADD_ID,
    PN_SHORTNAME,
    PN_FLAG_1,
    PN_FLAG_2,
    PN_FLAG_3,
    PN_USERCHAR_5,
    PN_USERCHAR_6,
    PN_USERCHAR_7,
    PN_USERCHAR_8,
    PN_USERCHAR_9,
    PN_HOME_EMAIL,
    PN_PIC_FILE,
    PN_USERINT_1,
    PN_USERINT_2,
    PN_USERINT_3,
    PN_USERINT_4,
    PN_USERINT_5,
    PN_USERINT_6,
    PN_USERNUM_3,
    PN_USERNUM_4,
    PN_USERNUM_5,
    PN_USERNUM_6,
    PN_USERDATE_3,
    PN_USERDATE_4,
    PN_USERDATE_5,
    PN_USERDATE_6,
    PN_SPECIAL_TERMS,
    PN_PARTNER_SYS_REF,
    PN_ETHNICITY,
    PN_HOME_PHONE_STD,
    PN_MOBILE,
    PN_DATA_PROT,
    PN_EMERGENCY_CONTACT,
    PN_ACCOM_PREF,
    PN_DISABILITY,
    PN_DISABILITY_NOTES,
    PN_NATIONALITY,
    PN_POR_MOD_DATE,
    PN_SY_TYPE,
    PN_MEDICAL_DET,
    PN_DO_NOT_SPARE1,
    PN_DO_NOT_SPARE2,
    PN_DO_NOT_SPARE3,
    PN_DO_NOT_SPARE4,
    PN_GDPR_CONSENT_DATE,
    PN_RETAIN_UNTIL_DATE
  from dbo.Person
  where PN_NATIONALITY = @PA_PN_NATIONALITY
end
go
