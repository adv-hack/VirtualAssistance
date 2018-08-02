using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PersonRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPersonRepository : SqlServerRepository<PersonRecord, String>, IPersonRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Person"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PersonRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PN_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Person"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PersonRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PersonRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PersonRecord record)
        {
            record.Id = dataRecord["PN_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PN_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PN_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PN_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PN_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PN_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PN_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PN_RCV_FROM"].ConvertTo<String>();
            record.Title = dataRecord["PN_TITLE"].ConvertTo<String>();
            record.FirstName = dataRecord["PN_FIRST_NAME"].ConvertTo<String>();
            record.SecName = dataRecord["PN_SEC_NAME"].ConvertTo<String>();
            record.Initials = dataRecord["PN_INITIALS"].ConvertTo<String>();
            record.Surname = dataRecord["PN_SURNAME"].ConvertTo<String>();
            record.SnameSuffix = dataRecord["PN_SNAME_SUFFIX"].ConvertTo<String>();
            record.Honours = dataRecord["PN_HONOURS"].ConvertTo<String>();
            record.Salutation = dataRecord["PN_SALUTATION"].ConvertTo<String>();
            record.Donotmail = dataRecord["PN_DONOTMAIL"].ConvertTo<Byte?>();
            record.OurPerson = dataRecord["PN_OUR_PERSON"].ConvertTo<Byte?>();
            record.Gender = dataRecord["PN_GENDER"].ConvertTo<String>();
            record.Notes = dataRecord["PN_NOTES"].ConvertTo<String>();
            record.Signature = dataRecord["PN_SIGNATURE"].ConvertTo<String>();
            record.NiNumber = dataRecord["PN_NI_NUMBER"].ConvertTo<String>();
            record.EthnicGroup = dataRecord["PN_ETHNIC_GROUP"].ConvertTo<String>();
            record.Diary = dataRecord["PN_DIARY"].ConvertTo<Byte?>();
            record.Language = dataRecord["PN_LANGUAGE"].ConvertTo<String>();
            record.Warmth = dataRecord["PN_WARMTH"].ConvertTo<String>();
            record.SoundexKey = dataRecord["PN_SOUNDEX_KEY"].ConvertTo<String>();
            record.Userchar1 = dataRecord["PN_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["PN_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["PN_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["PN_USERCHAR_4"].ConvertTo<String>();
            record.Usernum1 = dataRecord["PN_USERNUM_1"].ConvertTo<Decimal?>();
            record.Usernum2 = dataRecord["PN_USERNUM_2"].ConvertTo<Decimal?>();
            record.Node = dataRecord["PN_NODE"].ConvertTo<String>();
            record.Aka = dataRecord["PN_AKA"].ConvertTo<String>();
            record.SecretaryPhone = dataRecord["PN_SECRETARY_PHONE"].ConvertTo<String>();
            record.PrefComm = dataRecord["PN_PREF_COMM"].ConvertTo<String>();
            record.Donotmail2 = dataRecord["PN_DONOTMAIL2"].ConvertTo<Byte?>();
            record.Donotmail3 = dataRecord["PN_DONOTMAIL3"].ConvertTo<Byte?>();
            record.DesigLetters = dataRecord["PN_DESIG_LETTERS"].ConvertTo<String>();
            record.SignifPartner = dataRecord["PN_SIGNIF_PARTNER"].ConvertTo<String>();
            record.DietRequire = dataRecord["PN_DIET_REQUIRE"].ConvertTo<String>();
            record.AlumniGrade = dataRecord["PN_ALUMNI_GRADE"].ConvertTo<String>();
            record.AlumniOffice = dataRecord["PN_ALUMNI_OFFICE"].ConvertTo<String>();
            record.Target = dataRecord["PN_TARGET"].ConvertTo<String>();
            record.PromoId = dataRecord["PN_PROMO_ID"].ConvertTo<String>();
            record.DateOfBirth = dataRecord["PN_DATE_OF_BIRTH"].ConvertTo<DateTime?>();
            record.Religion = dataRecord["PN_RELIGION"].ConvertTo<String>();
            record.SpecialNeeds = dataRecord["PN_SPECIAL_NEEDS"].ConvertTo<String>();
            record.Userdate1 = dataRecord["PN_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userdate2 = dataRecord["PN_USERDATE_2"].ConvertTo<DateTime?>();
            record.Attractive = dataRecord["PN_ATTRACTIVE"].ConvertTo<String>();
            record.Potential = dataRecord["PN_POTENTIAL"].ConvertTo<String>();
            record.HomePhone = dataRecord["PN_HOME_PHONE"].ConvertTo<String>();
            record.HomeFax = dataRecord["PN_HOME_FAX"].ConvertTo<String>();
            record.HomeOther = dataRecord["PN_HOME_OTHER"].ConvertTo<String>();
            record.HomeAddId = dataRecord["PN_HOME_ADD_ID"].ConvertTo<String>();
            record.Shortname = dataRecord["PN_SHORTNAME"].ConvertTo<String>();
            record.Flag1 = dataRecord["PN_FLAG_1"].ConvertTo<Byte?>();
            record.Flag2 = dataRecord["PN_FLAG_2"].ConvertTo<Byte?>();
            record.Flag3 = dataRecord["PN_FLAG_3"].ConvertTo<Byte?>();
            record.Userchar5 = dataRecord["PN_USERCHAR_5"].ConvertTo<String>();
            record.Userchar6 = dataRecord["PN_USERCHAR_6"].ConvertTo<String>();
            record.Userchar7 = dataRecord["PN_USERCHAR_7"].ConvertTo<String>();
            record.Userchar8 = dataRecord["PN_USERCHAR_8"].ConvertTo<String>();
            record.Userchar9 = dataRecord["PN_USERCHAR_9"].ConvertTo<String>();
            record.HomeEmail = dataRecord["PN_HOME_EMAIL"].ConvertTo<String>();
            record.PicFile = dataRecord["PN_PIC_FILE"].ConvertTo<String>();
            record.Userint1 = dataRecord["PN_USERINT_1"].ConvertTo<Byte?>();
            record.Userint2 = dataRecord["PN_USERINT_2"].ConvertTo<Byte?>();
            record.Userint3 = dataRecord["PN_USERINT_3"].ConvertTo<Byte?>();
            record.Userint4 = dataRecord["PN_USERINT_4"].ConvertTo<Byte?>();
            record.Userint5 = dataRecord["PN_USERINT_5"].ConvertTo<Byte?>();
            record.Userint6 = dataRecord["PN_USERINT_6"].ConvertTo<Byte?>();
            record.Usernum3 = dataRecord["PN_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["PN_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["PN_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["PN_USERNUM_6"].ConvertTo<Decimal?>();
            record.Userdate3 = dataRecord["PN_USERDATE_3"].ConvertTo<DateTime?>();
            record.Userdate4 = dataRecord["PN_USERDATE_4"].ConvertTo<DateTime?>();
            record.Userdate5 = dataRecord["PN_USERDATE_5"].ConvertTo<DateTime?>();
            record.Userdate6 = dataRecord["PN_USERDATE_6"].ConvertTo<DateTime?>();
            record.SpecialTerms = dataRecord["PN_SPECIAL_TERMS"].ConvertTo<String>();
            record.PartnerSysRef = dataRecord["PN_PARTNER_SYS_REF"].ConvertTo<String>();
            record.Ethnicity = dataRecord["PN_ETHNICITY"].ConvertTo<String>();
            record.HomePhoneStd = dataRecord["PN_HOME_PHONE_STD"].ConvertTo<String>();
            record.Mobile = dataRecord["PN_MOBILE"].ConvertTo<String>();
            record.DataProt = dataRecord["PN_DATA_PROT"].ConvertTo<String>();
            record.EmergencyContact = dataRecord["PN_EMERGENCY_CONTACT"].ConvertTo<String>();
            record.AccomPref = dataRecord["PN_ACCOM_PREF"].ConvertTo<String>();
            record.Disability = dataRecord["PN_DISABILITY"].ConvertTo<Byte>();
            record.DisabilityNotes = dataRecord["PN_DISABILITY_NOTES"].ConvertTo<String>();
            record.Nationality = dataRecord["PN_NATIONALITY"].ConvertTo<String>();
            record.PorModDate = dataRecord["PN_POR_MOD_DATE"].ConvertTo<DateTime?>();
            record.SyType = dataRecord["PN_SY_TYPE"].ConvertTo<Byte>();
            record.MedicalDet = dataRecord["PN_MEDICAL_DET"].ConvertTo<String>();
            record.DoNotSpare1 = dataRecord["PN_DO_NOT_SPARE1"].ConvertTo<Byte?>();
            record.DoNotSpare2 = dataRecord["PN_DO_NOT_SPARE2"].ConvertTo<Byte?>();
            record.DoNotSpare3 = dataRecord["PN_DO_NOT_SPARE3"].ConvertTo<Byte?>();
            record.DoNotSpare4 = dataRecord["PN_DO_NOT_SPARE4"].ConvertTo<Byte?>();
            record.GdprConsentDate = dataRecord["PN_GDPR_CONSENT_DATE"].ConvertTo<DateTime?>();
            record.RetainUntilDate = dataRecord["PN_RETAIN_UNTIL_DATE"].ConvertTo<DateTime?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PersonRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PersonRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PN_ID", record.Id);
            this.MapParameterIn(command, "@PA_PN_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PN_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_PN_FIRST_NAME", record.FirstName);
            this.MapParameterIn(command, "@PA_PN_SEC_NAME", record.SecName);
            this.MapParameterIn(command, "@PA_PN_INITIALS", record.Initials);
            this.MapParameterIn(command, "@PA_PN_SURNAME", record.Surname);
            this.MapParameterIn(command, "@PA_PN_SNAME_SUFFIX", record.SnameSuffix);
            this.MapParameterIn(command, "@PA_PN_HONOURS", record.Honours);
            this.MapParameterIn(command, "@PA_PN_SALUTATION", record.Salutation);
            this.MapParameterIn(command, "@PA_PN_DONOTMAIL", record.Donotmail);
            this.MapParameterIn(command, "@PA_PN_OUR_PERSON", record.OurPerson);
            this.MapParameterIn(command, "@PA_PN_GENDER", record.Gender);
            this.MapParameterIn(command, "@PA_PN_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_PN_SIGNATURE", record.Signature);
            this.MapParameterIn(command, "@PA_PN_NI_NUMBER", record.NiNumber);
            this.MapParameterIn(command, "@PA_PN_ETHNIC_GROUP", record.EthnicGroup);
            this.MapParameterIn(command, "@PA_PN_DIARY", record.Diary);
            this.MapParameterIn(command, "@PA_PN_LANGUAGE", record.Language);
            this.MapParameterIn(command, "@PA_PN_WARMTH", record.Warmth);
            this.MapParameterIn(command, "@PA_PN_SOUNDEX_KEY", record.SoundexKey);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_PN_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_PN_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_PN_NODE", record.Node);
            this.MapParameterIn(command, "@PA_PN_AKA", record.Aka);
            this.MapParameterIn(command, "@PA_PN_SECRETARY_PHONE", record.SecretaryPhone);
            this.MapParameterIn(command, "@PA_PN_PREF_COMM", record.PrefComm);
            this.MapParameterIn(command, "@PA_PN_DONOTMAIL2", record.Donotmail2);
            this.MapParameterIn(command, "@PA_PN_DONOTMAIL3", record.Donotmail3);
            this.MapParameterIn(command, "@PA_PN_DESIG_LETTERS", record.DesigLetters);
            this.MapParameterIn(command, "@PA_PN_SIGNIF_PARTNER", record.SignifPartner);
            this.MapParameterIn(command, "@PA_PN_DIET_REQUIRE", record.DietRequire);
            this.MapParameterIn(command, "@PA_PN_ALUMNI_GRADE", record.AlumniGrade);
            this.MapParameterIn(command, "@PA_PN_ALUMNI_OFFICE", record.AlumniOffice);
            this.MapParameterIn(command, "@PA_PN_TARGET", record.Target);
            this.MapParameterIn(command, "@PA_PN_PROMO_ID", record.PromoId);
            this.MapParameterIn(command, "@PA_PN_DATE_OF_BIRTH", record.DateOfBirth == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateOfBirth);
            this.MapParameterIn(command, "@PA_PN_RELIGION", record.Religion);
            this.MapParameterIn(command, "@PA_PN_SPECIAL_NEEDS", record.SpecialNeeds);
            this.MapParameterIn(command, "@PA_PN_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_PN_USERDATE_2", record.Userdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate2);
            this.MapParameterIn(command, "@PA_PN_ATTRACTIVE", record.Attractive);
            this.MapParameterIn(command, "@PA_PN_POTENTIAL", record.Potential);
            this.MapParameterIn(command, "@PA_PN_HOME_PHONE", record.HomePhone);
            this.MapParameterIn(command, "@PA_PN_HOME_FAX", record.HomeFax);
            this.MapParameterIn(command, "@PA_PN_HOME_OTHER", record.HomeOther);
            this.MapParameterIn(command, "@PA_PN_HOME_ADD_ID", record.HomeAddId);
            this.MapParameterIn(command, "@PA_PN_SHORTNAME", record.Shortname);
            this.MapParameterIn(command, "@PA_PN_FLAG_1", record.Flag1);
            this.MapParameterIn(command, "@PA_PN_FLAG_2", record.Flag2);
            this.MapParameterIn(command, "@PA_PN_FLAG_3", record.Flag3);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_7", record.Userchar7);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_8", record.Userchar8);
            this.MapParameterIn(command, "@PA_PN_USERCHAR_9", record.Userchar9);
            this.MapParameterIn(command, "@PA_PN_HOME_EMAIL", record.HomeEmail);
            this.MapParameterIn(command, "@PA_PN_PIC_FILE", record.PicFile);
            this.MapParameterIn(command, "@PA_PN_USERINT_1", record.Userint1);
            this.MapParameterIn(command, "@PA_PN_USERINT_2", record.Userint2);
            this.MapParameterIn(command, "@PA_PN_USERINT_3", record.Userint3);
            this.MapParameterIn(command, "@PA_PN_USERINT_4", record.Userint4);
            this.MapParameterIn(command, "@PA_PN_USERINT_5", record.Userint5);
            this.MapParameterIn(command, "@PA_PN_USERINT_6", record.Userint6);
            this.MapParameterIn(command, "@PA_PN_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_PN_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_PN_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_PN_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_PN_USERDATE_3", record.Userdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate3);
            this.MapParameterIn(command, "@PA_PN_USERDATE_4", record.Userdate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate4);
            this.MapParameterIn(command, "@PA_PN_USERDATE_5", record.Userdate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate5);
            this.MapParameterIn(command, "@PA_PN_USERDATE_6", record.Userdate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate6);
            this.MapParameterIn(command, "@PA_PN_SPECIAL_TERMS", record.SpecialTerms);
            this.MapParameterIn(command, "@PA_PN_PARTNER_SYS_REF", record.PartnerSysRef);
            this.MapParameterIn(command, "@PA_PN_ETHNICITY", record.Ethnicity);
            this.MapParameterIn(command, "@PA_PN_HOME_PHONE_STD", record.HomePhoneStd);
            this.MapParameterIn(command, "@PA_PN_MOBILE", record.Mobile);
            this.MapParameterIn(command, "@PA_PN_DATA_PROT", record.DataProt);
            this.MapParameterIn(command, "@PA_PN_EMERGENCY_CONTACT", record.EmergencyContact);
            this.MapParameterIn(command, "@PA_PN_ACCOM_PREF", record.AccomPref);
            this.MapParameterIn(command, "@PA_PN_DISABILITY", record.Disability);
            this.MapParameterIn(command, "@PA_PN_DISABILITY_NOTES", record.DisabilityNotes);
            this.MapParameterIn(command, "@PA_PN_NATIONALITY", record.Nationality);
            this.MapParameterIn(command, "@PA_PN_POR_MOD_DATE", record.PorModDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.PorModDate);
            this.MapParameterIn(command, "@PA_PN_SY_TYPE", record.SyType);
            this.MapParameterIn(command, "@PA_PN_MEDICAL_DET", record.MedicalDet);
            this.MapParameterIn(command, "@PA_PN_DO_NOT_SPARE1", record.DoNotSpare1);
            this.MapParameterIn(command, "@PA_PN_DO_NOT_SPARE2", record.DoNotSpare2);
            this.MapParameterIn(command, "@PA_PN_DO_NOT_SPARE3", record.DoNotSpare3);
            this.MapParameterIn(command, "@PA_PN_DO_NOT_SPARE4", record.DoNotSpare4);
            this.MapParameterIn(command, "@PA_PN_GDPR_CONSENT_DATE", record.GdprConsentDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.GdprConsentDate);
            this.MapParameterIn(command, "@PA_PN_RETAIN_UNTIL_DATE", record.RetainUntilDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RetainUntilDate);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PersonRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PersonRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PN_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PN_LOCK", record.Lock);
            record.Title = this.MapParameterOut(command, "@PA_PN_TITLE", record.Title);
            record.FirstName = this.MapParameterOut(command, "@PA_PN_FIRST_NAME", record.FirstName);
            record.SecName = this.MapParameterOut(command, "@PA_PN_SEC_NAME", record.SecName);
            record.Initials = this.MapParameterOut(command, "@PA_PN_INITIALS", record.Initials);
            record.Surname = this.MapParameterOut(command, "@PA_PN_SURNAME", record.Surname);
            record.SnameSuffix = this.MapParameterOut(command, "@PA_PN_SNAME_SUFFIX", record.SnameSuffix);
            record.Honours = this.MapParameterOut(command, "@PA_PN_HONOURS", record.Honours);
            record.Salutation = this.MapParameterOut(command, "@PA_PN_SALUTATION", record.Salutation);
            record.Donotmail = this.MapParameterOut(command, "@PA_PN_DONOTMAIL", record.Donotmail);
            record.OurPerson = this.MapParameterOut(command, "@PA_PN_OUR_PERSON", record.OurPerson);
            record.Gender = this.MapParameterOut(command, "@PA_PN_GENDER", record.Gender);
            record.Notes = this.MapParameterOut(command, "@PA_PN_NOTES", record.Notes);
            record.Signature = this.MapParameterOut(command, "@PA_PN_SIGNATURE", record.Signature);
            record.NiNumber = this.MapParameterOut(command, "@PA_PN_NI_NUMBER", record.NiNumber);
            record.EthnicGroup = this.MapParameterOut(command, "@PA_PN_ETHNIC_GROUP", record.EthnicGroup);
            record.Diary = this.MapParameterOut(command, "@PA_PN_DIARY", record.Diary);
            record.Language = this.MapParameterOut(command, "@PA_PN_LANGUAGE", record.Language);
            record.Warmth = this.MapParameterOut(command, "@PA_PN_WARMTH", record.Warmth);
            record.SoundexKey = this.MapParameterOut(command, "@PA_PN_SOUNDEX_KEY", record.SoundexKey);
            record.Userchar1 = this.MapParameterOut(command, "@PA_PN_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_PN_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_PN_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_PN_USERCHAR_4", record.Userchar4);
            record.Usernum1 = this.MapParameterOut(command, "@PA_PN_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_PN_USERNUM_2", record.Usernum2);
            record.Node = this.MapParameterOut(command, "@PA_PN_NODE", record.Node);
            record.Aka = this.MapParameterOut(command, "@PA_PN_AKA", record.Aka);
            record.SecretaryPhone = this.MapParameterOut(command, "@PA_PN_SECRETARY_PHONE", record.SecretaryPhone);
            record.PrefComm = this.MapParameterOut(command, "@PA_PN_PREF_COMM", record.PrefComm);
            record.Donotmail2 = this.MapParameterOut(command, "@PA_PN_DONOTMAIL2", record.Donotmail2);
            record.Donotmail3 = this.MapParameterOut(command, "@PA_PN_DONOTMAIL3", record.Donotmail3);
            record.DesigLetters = this.MapParameterOut(command, "@PA_PN_DESIG_LETTERS", record.DesigLetters);
            record.SignifPartner = this.MapParameterOut(command, "@PA_PN_SIGNIF_PARTNER", record.SignifPartner);
            record.DietRequire = this.MapParameterOut(command, "@PA_PN_DIET_REQUIRE", record.DietRequire);
            record.AlumniGrade = this.MapParameterOut(command, "@PA_PN_ALUMNI_GRADE", record.AlumniGrade);
            record.AlumniOffice = this.MapParameterOut(command, "@PA_PN_ALUMNI_OFFICE", record.AlumniOffice);
            record.Target = this.MapParameterOut(command, "@PA_PN_TARGET", record.Target);
            record.PromoId = this.MapParameterOut(command, "@PA_PN_PROMO_ID", record.PromoId);
            record.DateOfBirth = this.MapParameterOut(command, "@PA_PN_DATE_OF_BIRTH", record.DateOfBirth);
            record.Religion = this.MapParameterOut(command, "@PA_PN_RELIGION", record.Religion);
            record.SpecialNeeds = this.MapParameterOut(command, "@PA_PN_SPECIAL_NEEDS", record.SpecialNeeds);
            record.Userdate1 = this.MapParameterOut(command, "@PA_PN_USERDATE_1", record.Userdate1);
            record.Userdate2 = this.MapParameterOut(command, "@PA_PN_USERDATE_2", record.Userdate2);
            record.Attractive = this.MapParameterOut(command, "@PA_PN_ATTRACTIVE", record.Attractive);
            record.Potential = this.MapParameterOut(command, "@PA_PN_POTENTIAL", record.Potential);
            record.HomePhone = this.MapParameterOut(command, "@PA_PN_HOME_PHONE", record.HomePhone);
            record.HomeFax = this.MapParameterOut(command, "@PA_PN_HOME_FAX", record.HomeFax);
            record.HomeOther = this.MapParameterOut(command, "@PA_PN_HOME_OTHER", record.HomeOther);
            record.HomeAddId = this.MapParameterOut(command, "@PA_PN_HOME_ADD_ID", record.HomeAddId);
            record.Shortname = this.MapParameterOut(command, "@PA_PN_SHORTNAME", record.Shortname);
            record.Flag1 = this.MapParameterOut(command, "@PA_PN_FLAG_1", record.Flag1);
            record.Flag2 = this.MapParameterOut(command, "@PA_PN_FLAG_2", record.Flag2);
            record.Flag3 = this.MapParameterOut(command, "@PA_PN_FLAG_3", record.Flag3);
            record.Userchar5 = this.MapParameterOut(command, "@PA_PN_USERCHAR_5", record.Userchar5);
            record.Userchar6 = this.MapParameterOut(command, "@PA_PN_USERCHAR_6", record.Userchar6);
            record.Userchar7 = this.MapParameterOut(command, "@PA_PN_USERCHAR_7", record.Userchar7);
            record.Userchar8 = this.MapParameterOut(command, "@PA_PN_USERCHAR_8", record.Userchar8);
            record.Userchar9 = this.MapParameterOut(command, "@PA_PN_USERCHAR_9", record.Userchar9);
            record.HomeEmail = this.MapParameterOut(command, "@PA_PN_HOME_EMAIL", record.HomeEmail);
            record.PicFile = this.MapParameterOut(command, "@PA_PN_PIC_FILE", record.PicFile);
            record.Userint1 = this.MapParameterOut(command, "@PA_PN_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_PN_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_PN_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_PN_USERINT_4", record.Userint4);
            record.Userint5 = this.MapParameterOut(command, "@PA_PN_USERINT_5", record.Userint5);
            record.Userint6 = this.MapParameterOut(command, "@PA_PN_USERINT_6", record.Userint6);
            record.Usernum3 = this.MapParameterOut(command, "@PA_PN_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_PN_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_PN_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_PN_USERNUM_6", record.Usernum6);
            record.Userdate3 = this.MapParameterOut(command, "@PA_PN_USERDATE_3", record.Userdate3);
            record.Userdate4 = this.MapParameterOut(command, "@PA_PN_USERDATE_4", record.Userdate4);
            record.Userdate5 = this.MapParameterOut(command, "@PA_PN_USERDATE_5", record.Userdate5);
            record.Userdate6 = this.MapParameterOut(command, "@PA_PN_USERDATE_6", record.Userdate6);
            record.SpecialTerms = this.MapParameterOut(command, "@PA_PN_SPECIAL_TERMS", record.SpecialTerms);
            record.PartnerSysRef = this.MapParameterOut(command, "@PA_PN_PARTNER_SYS_REF", record.PartnerSysRef);
            record.Ethnicity = this.MapParameterOut(command, "@PA_PN_ETHNICITY", record.Ethnicity);
            record.HomePhoneStd = this.MapParameterOut(command, "@PA_PN_HOME_PHONE_STD", record.HomePhoneStd);
            record.Mobile = this.MapParameterOut(command, "@PA_PN_MOBILE", record.Mobile);
            record.DataProt = this.MapParameterOut(command, "@PA_PN_DATA_PROT", record.DataProt);
            record.EmergencyContact = this.MapParameterOut(command, "@PA_PN_EMERGENCY_CONTACT", record.EmergencyContact);
            record.AccomPref = this.MapParameterOut(command, "@PA_PN_ACCOM_PREF", record.AccomPref);
            record.Disability = this.MapParameterOut(command, "@PA_PN_DISABILITY", record.Disability);
            record.DisabilityNotes = this.MapParameterOut(command, "@PA_PN_DISABILITY_NOTES", record.DisabilityNotes);
            record.Nationality = this.MapParameterOut(command, "@PA_PN_NATIONALITY", record.Nationality);
            record.PorModDate = this.MapParameterOut(command, "@PA_PN_POR_MOD_DATE", record.PorModDate);
            record.SyType = this.MapParameterOut(command, "@PA_PN_SY_TYPE", record.SyType);
            record.MedicalDet = this.MapParameterOut(command, "@PA_PN_MEDICAL_DET", record.MedicalDet);
            record.DoNotSpare1 = this.MapParameterOut(command, "@PA_PN_DO_NOT_SPARE1", record.DoNotSpare1);
            record.DoNotSpare2 = this.MapParameterOut(command, "@PA_PN_DO_NOT_SPARE2", record.DoNotSpare2);
            record.DoNotSpare3 = this.MapParameterOut(command, "@PA_PN_DO_NOT_SPARE3", record.DoNotSpare3);
            record.DoNotSpare4 = this.MapParameterOut(command, "@PA_PN_DO_NOT_SPARE4", record.DoNotSpare4);
            record.GdprConsentDate = this.MapParameterOut(command, "@PA_PN_GDPR_CONSENT_DATE", record.GdprConsentDate);
            record.RetainUntilDate = this.MapParameterOut(command, "@PA_PN_RETAIN_UNTIL_DATE", record.RetainUntilDate);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PersonRecord" /> instances from the data store.
        /// </summary>
        /// <param name="promoId">
        ///     The value which identifies the <see cref='PersonModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PersonRecord" /> instances that match the specified <paramref name='promoId' />.
        /// </returns>
        public IEnumerable<PersonRecord> FetchAllByPromoId(String promoId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PromoId");
            this.MapParameterIn(command, "@PA_PN_PROMO_ID", promoId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPersonRepository.TableName
        {
            get { return this.TableName; }
        }

        void IPersonRepository.Create(Consensus.Contact.PersonRecord record)
        {
            this.Create(record);
        }

        void IPersonRepository.Modify(Consensus.Contact.PersonRecord record)
        {
            this.Modify(record);
        }

        Consensus.Contact.PersonRecord IPersonRepository.AnonymisePerson(System.String personId)
        {
            return this.AnonymisePerson(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.PersonRecord" /> instances from the data store.
        /// </summary>
        /// <param name="promoId">
        ///     The value which identifies the <see cref="!:PersonModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.PersonRecord" /> instances that match the specified <paramref name="promoId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.PersonRecord> IPersonRepository.FetchAllByPromoId(System.String promoId)
        {
            return this.FetchAllByPromoId(promoId);
        }

        #endregion
    }
}
