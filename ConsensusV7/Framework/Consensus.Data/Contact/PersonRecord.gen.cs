using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Person" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PersonRecord : Record<String>, Cloneable<PersonRecord>, IEquatable<PersonRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PN_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PN_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PN_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PN_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PN_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PN_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PN_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PN_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "PN_FIRST_NAME" field.
        /// </summary>
        private String _firstName;

        /// <summary>
        ///     the value of the "PN_SEC_NAME" field.
        /// </summary>
        private String _secName;

        /// <summary>
        ///     the value of the "PN_INITIALS" field.
        /// </summary>
        private String _initials;

        /// <summary>
        ///     the value of the "PN_SURNAME" field.
        /// </summary>
        private String _surname;

        /// <summary>
        ///     the value of the "PN_SNAME_SUFFIX" field.
        /// </summary>
        private String _snameSuffix;

        /// <summary>
        ///     the value of the "PN_HONOURS" field.
        /// </summary>
        private String _honours;

        /// <summary>
        ///     the value of the "PN_SALUTATION" field.
        /// </summary>
        private String _salutation;

        /// <summary>
        ///     the value of the "PN_DONOTMAIL" field.
        /// </summary>
        private Byte? _donotmail;

        /// <summary>
        ///     the value of the "PN_OUR_PERSON" field.
        /// </summary>
        private Byte? _ourPerson;

        /// <summary>
        ///     the value of the "PN_GENDER" field.
        /// </summary>
        private String _gender;

        /// <summary>
        ///     the value of the "PN_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "PN_SIGNATURE" field.
        /// </summary>
        private String _signature;

        /// <summary>
        ///     the value of the "PN_NI_NUMBER" field.
        /// </summary>
        private String _niNumber;

        /// <summary>
        ///     the value of the "PN_ETHNIC_GROUP" field.
        /// </summary>
        private String _ethnicGroup;

        /// <summary>
        ///     the value of the "PN_DIARY" field.
        /// </summary>
        private Byte? _diary;

        /// <summary>
        ///     the value of the "PN_LANGUAGE" field.
        /// </summary>
        private String _language;

        /// <summary>
        ///     the value of the "PN_WARMTH" field.
        /// </summary>
        private String _warmth;

        /// <summary>
        ///     the value of the "PN_SOUNDEX_KEY" field.
        /// </summary>
        private String _soundexKey;

        /// <summary>
        ///     the value of the "PN_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "PN_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "PN_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "PN_USERCHAR_4" field.
        /// </summary>
        private String _userchar4;

        /// <summary>
        ///     the value of the "PN_USERNUM_1" field.
        /// </summary>
        private Decimal? _usernum1;

        /// <summary>
        ///     the value of the "PN_USERNUM_2" field.
        /// </summary>
        private Decimal? _usernum2;

        /// <summary>
        ///     the value of the "PN_NODE" field.
        /// </summary>
        private String _node;

        /// <summary>
        ///     the value of the "PN_AKA" field.
        /// </summary>
        private String _aka;

        /// <summary>
        ///     the value of the "PN_SECRETARY_PHONE" field.
        /// </summary>
        private String _secretaryPhone;

        /// <summary>
        ///     the value of the "PN_PREF_COMM" field.
        /// </summary>
        private String _prefComm;

        /// <summary>
        ///     the value of the "PN_DONOTMAIL2" field.
        /// </summary>
        private Byte? _donotmail2;

        /// <summary>
        ///     the value of the "PN_DONOTMAIL3" field.
        /// </summary>
        private Byte? _donotmail3;

        /// <summary>
        ///     the value of the "PN_DESIG_LETTERS" field.
        /// </summary>
        private String _desigLetters;

        /// <summary>
        ///     the value of the "PN_SIGNIF_PARTNER" field.
        /// </summary>
        private String _signifPartner;

        /// <summary>
        ///     the value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        private String _dietRequire;

        /// <summary>
        ///     the value of the "PN_ALUMNI_GRADE" field.
        /// </summary>
        private String _alumniGrade;

        /// <summary>
        ///     the value of the "PN_ALUMNI_OFFICE" field.
        /// </summary>
        private String _alumniOffice;

        /// <summary>
        ///     the value of the "PN_TARGET" field.
        /// </summary>
        private String _target;

        /// <summary>
        ///     the value of the "PN_PROMO_ID" field.
        /// </summary>
        private String _promoId;

        /// <summary>
        ///     the value of the "PN_DATE_OF_BIRTH" field.
        /// </summary>
        private DateTime? _dateOfBirth;

        /// <summary>
        ///     the value of the "PN_RELIGION" field.
        /// </summary>
        private String _religion;

        /// <summary>
        ///     the value of the "PN_SPECIAL_NEEDS" field.
        /// </summary>
        private String _specialNeeds;

        /// <summary>
        ///     the value of the "PN_USERDATE_1" field.
        /// </summary>
        private DateTime? _userdate1;

        /// <summary>
        ///     the value of the "PN_USERDATE_2" field.
        /// </summary>
        private DateTime? _userdate2;

        /// <summary>
        ///     the value of the "PN_ATTRACTIVE" field.
        /// </summary>
        private String _attractive;

        /// <summary>
        ///     the value of the "PN_POTENTIAL" field.
        /// </summary>
        private String _potential;

        /// <summary>
        ///     the value of the "PN_HOME_PHONE" field.
        /// </summary>
        private String _homePhone;

        /// <summary>
        ///     the value of the "PN_HOME_FAX" field.
        /// </summary>
        private String _homeFax;

        /// <summary>
        ///     the value of the "PN_HOME_OTHER" field.
        /// </summary>
        private String _homeOther;

        /// <summary>
        ///     the value of the "PN_HOME_ADD_ID" field.
        /// </summary>
        private String _homeAddId;

        /// <summary>
        ///     the value of the "PN_SHORTNAME" field.
        /// </summary>
        private String _shortname;

        /// <summary>
        ///     the value of the "PN_FLAG_1" field.
        /// </summary>
        private Byte? _flag1;

        /// <summary>
        ///     the value of the "PN_FLAG_2" field.
        /// </summary>
        private Byte? _flag2;

        /// <summary>
        ///     the value of the "PN_FLAG_3" field.
        /// </summary>
        private Byte? _flag3;

        /// <summary>
        ///     the value of the "PN_USERCHAR_5" field.
        /// </summary>
        private String _userchar5;

        /// <summary>
        ///     the value of the "PN_USERCHAR_6" field.
        /// </summary>
        private String _userchar6;

        /// <summary>
        ///     the value of the "PN_USERCHAR_7" field.
        /// </summary>
        private String _userchar7;

        /// <summary>
        ///     the value of the "PN_USERCHAR_8" field.
        /// </summary>
        private String _userchar8;

        /// <summary>
        ///     the value of the "PN_USERCHAR_9" field.
        /// </summary>
        private String _userchar9;

        /// <summary>
        ///     the value of the "PN_HOME_EMAIL" field.
        /// </summary>
        private String _homeEmail;

        /// <summary>
        ///     the value of the "PN_PIC_FILE" field.
        /// </summary>
        private String _picFile;

        /// <summary>
        ///     the value of the "PN_USERINT_1" field.
        /// </summary>
        private Byte? _userint1;

        /// <summary>
        ///     the value of the "PN_USERINT_2" field.
        /// </summary>
        private Byte? _userint2;

        /// <summary>
        ///     the value of the "PN_USERINT_3" field.
        /// </summary>
        private Byte? _userint3;

        /// <summary>
        ///     the value of the "PN_USERINT_4" field.
        /// </summary>
        private Byte? _userint4;

        /// <summary>
        ///     the value of the "PN_USERINT_5" field.
        /// </summary>
        private Byte? _userint5;

        /// <summary>
        ///     the value of the "PN_USERINT_6" field.
        /// </summary>
        private Byte? _userint6;

        /// <summary>
        ///     the value of the "PN_USERNUM_3" field.
        /// </summary>
        private Decimal? _usernum3;

        /// <summary>
        ///     the value of the "PN_USERNUM_4" field.
        /// </summary>
        private Decimal? _usernum4;

        /// <summary>
        ///     the value of the "PN_USERNUM_5" field.
        /// </summary>
        private Decimal? _usernum5;

        /// <summary>
        ///     the value of the "PN_USERNUM_6" field.
        /// </summary>
        private Decimal? _usernum6;

        /// <summary>
        ///     the value of the "PN_USERDATE_3" field.
        /// </summary>
        private DateTime? _userdate3;

        /// <summary>
        ///     the value of the "PN_USERDATE_4" field.
        /// </summary>
        private DateTime? _userdate4;

        /// <summary>
        ///     the value of the "PN_USERDATE_5" field.
        /// </summary>
        private DateTime? _userdate5;

        /// <summary>
        ///     the value of the "PN_USERDATE_6" field.
        /// </summary>
        private DateTime? _userdate6;

        /// <summary>
        ///     the value of the "PN_SPECIAL_TERMS" field.
        /// </summary>
        private String _specialTerms;

        /// <summary>
        ///     the value of the "PN_PARTNER_SYS_REF" field.
        /// </summary>
        private String _partnerSysRef;

        /// <summary>
        ///     the value of the "PN_ETHNICITY" field.
        /// </summary>
        private String _ethnicity;

        /// <summary>
        ///     the value of the "PN_HOME_PHONE_STD" field.
        /// </summary>
        private String _homePhoneStd;

        /// <summary>
        ///     the value of the "PN_MOBILE" field.
        /// </summary>
        private String _mobile;

        /// <summary>
        ///     the value of the "PN_DATA_PROT" field.
        /// </summary>
        private String _dataProt;

        /// <summary>
        ///     the value of the "PN_EMERGENCY_CONTACT" field.
        /// </summary>
        private String _emergencyContact;

        /// <summary>
        ///     the value of the "PN_ACCOM_PREF" field.
        /// </summary>
        private String _accomPref;

        /// <summary>
        ///     the value of the "PN_DISABILITY" field.
        /// </summary>
        private Byte _disability;

        /// <summary>
        ///     the value of the "PN_DISABILITY_NOTES" field.
        /// </summary>
        private String _disabilityNotes;

        /// <summary>
        ///     the value of the "PN_NATIONALITY" field.
        /// </summary>
        private String _nationality;

        /// <summary>
        ///     the value of the "PN_POR_MOD_DATE" field.
        /// </summary>
        private DateTime? _porModDate;

        /// <summary>
        ///     the value of the "PN_SY_TYPE" field.
        /// </summary>
        private Byte _syType;

        /// <summary>
        ///     the value of the "PN_MEDICAL_DET" field.
        /// </summary>
        private String _medicalDet;

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE1" field.
        /// </summary>
        private Byte? _doNotSpare1;

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE2" field.
        /// </summary>
        private Byte? _doNotSpare2;

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE3" field.
        /// </summary>
        private Byte? _doNotSpare3;

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE4" field.
        /// </summary>
        private Byte? _doNotSpare4;

        /// <summary>
        ///     the value of the "PN_GDPR_CONSENT_DATE" field.
        /// </summary>
        private DateTime? _gdprConsentDate;

        /// <summary>
        ///     the value of the "PN_RETAIN_UNTIL_DATE" field.
        /// </summary>
        private DateTime? _retainUntilDate;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PN_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PN_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PN_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PN_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PN_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PN_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PN_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PN_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "PN_FIRST_NAME" field.
        /// </summary>
        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        ///     the value of the "PN_SEC_NAME" field.
        /// </summary>
        public String SecName
        {
            get { return _secName; }
            set { _secName = value; }
        }

        /// <summary>
        ///     the value of the "PN_INITIALS" field.
        /// </summary>
        public String Initials
        {
            get { return _initials; }
            set { _initials = value; }
        }

        /// <summary>
        ///     the value of the "PN_SURNAME" field.
        /// </summary>
        public String Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        /// <summary>
        ///     the value of the "PN_SNAME_SUFFIX" field.
        /// </summary>
        public String SnameSuffix
        {
            get { return _snameSuffix; }
            set { _snameSuffix = value; }
        }

        /// <summary>
        ///     the value of the "PN_HONOURS" field.
        /// </summary>
        public String Honours
        {
            get { return _honours; }
            set { _honours = value; }
        }

        /// <summary>
        ///     the value of the "PN_SALUTATION" field.
        /// </summary>
        public String Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        /// <summary>
        ///     the value of the "PN_DONOTMAIL" field.
        /// </summary>
        public Byte? Donotmail
        {
            get { return _donotmail; }
            set { _donotmail = value; }
        }

        /// <summary>
        ///     the value of the "PN_OUR_PERSON" field.
        /// </summary>
        public Byte? OurPerson
        {
            get { return _ourPerson; }
            set { _ourPerson = value; }
        }

        /// <summary>
        ///     the value of the "PN_GENDER" field.
        /// </summary>
        public String Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        /// <summary>
        ///     the value of the "PN_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "PN_SIGNATURE" field.
        /// </summary>
        public String Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }

        /// <summary>
        ///     the value of the "PN_NI_NUMBER" field.
        /// </summary>
        public String NiNumber
        {
            get { return _niNumber; }
            set { _niNumber = value; }
        }

        /// <summary>
        ///     the value of the "PN_ETHNIC_GROUP" field.
        /// </summary>
        public String EthnicGroup
        {
            get { return _ethnicGroup; }
            set { _ethnicGroup = value; }
        }

        /// <summary>
        ///     the value of the "PN_DIARY" field.
        /// </summary>
        public Byte? Diary
        {
            get { return _diary; }
            set { _diary = value; }
        }

        /// <summary>
        ///     the value of the "PN_LANGUAGE" field.
        /// </summary>
        public String Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /// <summary>
        ///     the value of the "PN_WARMTH" field.
        /// </summary>
        public String Warmth
        {
            get { return _warmth; }
            set { _warmth = value; }
        }

        /// <summary>
        ///     the value of the "PN_SOUNDEX_KEY" field.
        /// </summary>
        public String SoundexKey
        {
            get { return _soundexKey; }
            set { _soundexKey = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_4" field.
        /// </summary>
        public String Userchar4
        {
            get { return _userchar4; }
            set { _userchar4 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERNUM_1" field.
        /// </summary>
        public Decimal? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERNUM_2" field.
        /// </summary>
        public Decimal? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "PN_NODE" field.
        /// </summary>
        public String Node
        {
            get { return _node; }
            set { _node = value; }
        }

        /// <summary>
        ///     the value of the "PN_AKA" field.
        /// </summary>
        public String Aka
        {
            get { return _aka; }
            set { _aka = value; }
        }

        /// <summary>
        ///     the value of the "PN_SECRETARY_PHONE" field.
        /// </summary>
        public String SecretaryPhone
        {
            get { return _secretaryPhone; }
            set { _secretaryPhone = value; }
        }

        /// <summary>
        ///     the value of the "PN_PREF_COMM" field.
        /// </summary>
        public String PrefComm
        {
            get { return _prefComm; }
            set { _prefComm = value; }
        }

        /// <summary>
        ///     the value of the "PN_DONOTMAIL2" field.
        /// </summary>
        public Byte? Donotmail2
        {
            get { return _donotmail2; }
            set { _donotmail2 = value; }
        }

        /// <summary>
        ///     the value of the "PN_DONOTMAIL3" field.
        /// </summary>
        public Byte? Donotmail3
        {
            get { return _donotmail3; }
            set { _donotmail3 = value; }
        }

        /// <summary>
        ///     the value of the "PN_DESIG_LETTERS" field.
        /// </summary>
        public String DesigLetters
        {
            get { return _desigLetters; }
            set { _desigLetters = value; }
        }

        /// <summary>
        ///     the value of the "PN_SIGNIF_PARTNER" field.
        /// </summary>
        public String SignifPartner
        {
            get { return _signifPartner; }
            set { _signifPartner = value; }
        }

        /// <summary>
        ///     the value of the "PN_DIET_REQUIRE" field.
        /// </summary>
        public String DietRequire
        {
            get { return _dietRequire; }
            set { _dietRequire = value; }
        }

        /// <summary>
        ///     the value of the "PN_ALUMNI_GRADE" field.
        /// </summary>
        public String AlumniGrade
        {
            get { return _alumniGrade; }
            set { _alumniGrade = value; }
        }

        /// <summary>
        ///     the value of the "PN_ALUMNI_OFFICE" field.
        /// </summary>
        public String AlumniOffice
        {
            get { return _alumniOffice; }
            set { _alumniOffice = value; }
        }

        /// <summary>
        ///     the value of the "PN_TARGET" field.
        /// </summary>
        public String Target
        {
            get { return _target; }
            set { _target = value; }
        }

        /// <summary>
        ///     the value of the "PN_PROMO_ID" field.
        /// </summary>
        public String PromoId
        {
            get { return _promoId; }
            set { _promoId = value; }
        }

        /// <summary>
        ///     the value of the "PN_DATE_OF_BIRTH" field.
        /// </summary>
        public DateTime? DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        /// <summary>
        ///     the value of the "PN_RELIGION" field.
        /// </summary>
        public String Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }

        /// <summary>
        ///     the value of the "PN_SPECIAL_NEEDS" field.
        /// </summary>
        public String SpecialNeeds
        {
            get { return _specialNeeds; }
            set { _specialNeeds = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERDATE_1" field.
        /// </summary>
        public DateTime? Userdate1
        {
            get { return _userdate1; }
            set { _userdate1 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERDATE_2" field.
        /// </summary>
        public DateTime? Userdate2
        {
            get { return _userdate2; }
            set { _userdate2 = value; }
        }

        /// <summary>
        ///     the value of the "PN_ATTRACTIVE" field.
        /// </summary>
        public String Attractive
        {
            get { return _attractive; }
            set { _attractive = value; }
        }

        /// <summary>
        ///     the value of the "PN_POTENTIAL" field.
        /// </summary>
        public String Potential
        {
            get { return _potential; }
            set { _potential = value; }
        }

        /// <summary>
        ///     the value of the "PN_HOME_PHONE" field.
        /// </summary>
        public String HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        /// <summary>
        ///     the value of the "PN_HOME_FAX" field.
        /// </summary>
        public String HomeFax
        {
            get { return _homeFax; }
            set { _homeFax = value; }
        }

        /// <summary>
        ///     the value of the "PN_HOME_OTHER" field.
        /// </summary>
        public String HomeOther
        {
            get { return _homeOther; }
            set { _homeOther = value; }
        }

        /// <summary>
        ///     the value of the "PN_HOME_ADD_ID" field.
        /// </summary>
        public String HomeAddId
        {
            get { return _homeAddId; }
            set { _homeAddId = value; }
        }

        /// <summary>
        ///     the value of the "PN_SHORTNAME" field.
        /// </summary>
        public String Shortname
        {
            get { return _shortname; }
            set { _shortname = value; }
        }

        /// <summary>
        ///     the value of the "PN_FLAG_1" field.
        /// </summary>
        public Byte? Flag1
        {
            get { return _flag1; }
            set { _flag1 = value; }
        }

        /// <summary>
        ///     the value of the "PN_FLAG_2" field.
        /// </summary>
        public Byte? Flag2
        {
            get { return _flag2; }
            set { _flag2 = value; }
        }

        /// <summary>
        ///     the value of the "PN_FLAG_3" field.
        /// </summary>
        public Byte? Flag3
        {
            get { return _flag3; }
            set { _flag3 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_5" field.
        /// </summary>
        public String Userchar5
        {
            get { return _userchar5; }
            set { _userchar5 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_6" field.
        /// </summary>
        public String Userchar6
        {
            get { return _userchar6; }
            set { _userchar6 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_7" field.
        /// </summary>
        public String Userchar7
        {
            get { return _userchar7; }
            set { _userchar7 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_8" field.
        /// </summary>
        public String Userchar8
        {
            get { return _userchar8; }
            set { _userchar8 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERCHAR_9" field.
        /// </summary>
        public String Userchar9
        {
            get { return _userchar9; }
            set { _userchar9 = value; }
        }

        /// <summary>
        ///     the value of the "PN_HOME_EMAIL" field.
        /// </summary>
        public String HomeEmail
        {
            get { return _homeEmail; }
            set { _homeEmail = value; }
        }

        /// <summary>
        ///     the value of the "PN_PIC_FILE" field.
        /// </summary>
        public String PicFile
        {
            get { return _picFile; }
            set { _picFile = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERINT_1" field.
        /// </summary>
        public Byte? Userint1
        {
            get { return _userint1; }
            set { _userint1 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERINT_2" field.
        /// </summary>
        public Byte? Userint2
        {
            get { return _userint2; }
            set { _userint2 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERINT_3" field.
        /// </summary>
        public Byte? Userint3
        {
            get { return _userint3; }
            set { _userint3 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERINT_4" field.
        /// </summary>
        public Byte? Userint4
        {
            get { return _userint4; }
            set { _userint4 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERINT_5" field.
        /// </summary>
        public Byte? Userint5
        {
            get { return _userint5; }
            set { _userint5 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERINT_6" field.
        /// </summary>
        public Byte? Userint6
        {
            get { return _userint6; }
            set { _userint6 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERNUM_3" field.
        /// </summary>
        public Decimal? Usernum3
        {
            get { return _usernum3; }
            set { _usernum3 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERNUM_4" field.
        /// </summary>
        public Decimal? Usernum4
        {
            get { return _usernum4; }
            set { _usernum4 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERNUM_5" field.
        /// </summary>
        public Decimal? Usernum5
        {
            get { return _usernum5; }
            set { _usernum5 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERNUM_6" field.
        /// </summary>
        public Decimal? Usernum6
        {
            get { return _usernum6; }
            set { _usernum6 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERDATE_3" field.
        /// </summary>
        public DateTime? Userdate3
        {
            get { return _userdate3; }
            set { _userdate3 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERDATE_4" field.
        /// </summary>
        public DateTime? Userdate4
        {
            get { return _userdate4; }
            set { _userdate4 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERDATE_5" field.
        /// </summary>
        public DateTime? Userdate5
        {
            get { return _userdate5; }
            set { _userdate5 = value; }
        }

        /// <summary>
        ///     the value of the "PN_USERDATE_6" field.
        /// </summary>
        public DateTime? Userdate6
        {
            get { return _userdate6; }
            set { _userdate6 = value; }
        }

        /// <summary>
        ///     the value of the "PN_SPECIAL_TERMS" field.
        /// </summary>
        public String SpecialTerms
        {
            get { return _specialTerms; }
            set { _specialTerms = value; }
        }

        /// <summary>
        ///     the value of the "PN_PARTNER_SYS_REF" field.
        /// </summary>
        public String PartnerSysRef
        {
            get { return _partnerSysRef; }
            set { _partnerSysRef = value; }
        }

        /// <summary>
        ///     the value of the "PN_ETHNICITY" field.
        /// </summary>
        public String Ethnicity
        {
            get { return _ethnicity; }
            set { _ethnicity = value; }
        }

        /// <summary>
        ///     the value of the "PN_HOME_PHONE_STD" field.
        /// </summary>
        public String HomePhoneStd
        {
            get { return _homePhoneStd; }
            set { _homePhoneStd = value; }
        }

        /// <summary>
        ///     the value of the "PN_MOBILE" field.
        /// </summary>
        public String Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        /// <summary>
        ///     the value of the "PN_DATA_PROT" field.
        /// </summary>
        public String DataProt
        {
            get { return _dataProt; }
            set { _dataProt = value; }
        }

        /// <summary>
        ///     the value of the "PN_EMERGENCY_CONTACT" field.
        /// </summary>
        public String EmergencyContact
        {
            get { return _emergencyContact; }
            set { _emergencyContact = value; }
        }

        /// <summary>
        ///     the value of the "PN_ACCOM_PREF" field.
        /// </summary>
        public String AccomPref
        {
            get { return _accomPref; }
            set { _accomPref = value; }
        }

        /// <summary>
        ///     the value of the "PN_DISABILITY" field.
        /// </summary>
        public Byte Disability
        {
            get { return _disability; }
            set { _disability = value; }
        }

        /// <summary>
        ///     the value of the "PN_DISABILITY_NOTES" field.
        /// </summary>
        public String DisabilityNotes
        {
            get { return _disabilityNotes; }
            set { _disabilityNotes = value; }
        }

        /// <summary>
        ///     the value of the "PN_NATIONALITY" field.
        /// </summary>
        public String Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        /// <summary>
        ///     the value of the "PN_POR_MOD_DATE" field.
        /// </summary>
        public DateTime? PorModDate
        {
            get { return _porModDate; }
            set { _porModDate = value; }
        }

        /// <summary>
        ///     the value of the "PN_SY_TYPE" field.
        /// </summary>
        public Byte SyType
        {
            get { return _syType; }
            set { _syType = value; }
        }

        /// <summary>
        ///     the value of the "PN_MEDICAL_DET" field.
        /// </summary>
        public String MedicalDet
        {
            get { return _medicalDet; }
            set { _medicalDet = value; }
        }

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE1" field.
        /// </summary>
        public Byte? DoNotSpare1
        {
            get { return _doNotSpare1; }
            set { _doNotSpare1 = value; }
        }

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE2" field.
        /// </summary>
        public Byte? DoNotSpare2
        {
            get { return _doNotSpare2; }
            set { _doNotSpare2 = value; }
        }

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE3" field.
        /// </summary>
        public Byte? DoNotSpare3
        {
            get { return _doNotSpare3; }
            set { _doNotSpare3 = value; }
        }

        /// <summary>
        ///     the value of the "PN_DO_NOT_SPARE4" field.
        /// </summary>
        public Byte? DoNotSpare4
        {
            get { return _doNotSpare4; }
            set { _doNotSpare4 = value; }
        }

        /// <summary>
        ///     the value of the "PN_GDPR_CONSENT_DATE" field.
        /// </summary>
        public DateTime? GdprConsentDate
        {
            get { return _gdprConsentDate; }
            set { _gdprConsentDate = value; }
        }

        /// <summary>
        ///     the value of the "PN_RETAIN_UNTIL_DATE" field.
        /// </summary>
        public DateTime? RetainUntilDate
        {
            get { return _retainUntilDate; }
            set { _retainUntilDate = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PersonRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PersonRecord" /> object instance.
        /// </returns>
        public PersonRecord Clone()
        {
            PersonRecord record = new PersonRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Title = this.Title;
            record.FirstName = this.FirstName;
            record.SecName = this.SecName;
            record.Initials = this.Initials;
            record.Surname = this.Surname;
            record.SnameSuffix = this.SnameSuffix;
            record.Honours = this.Honours;
            record.Salutation = this.Salutation;
            record.Donotmail = this.Donotmail;
            record.OurPerson = this.OurPerson;
            record.Gender = this.Gender;
            record.Notes = this.Notes;
            record.Signature = this.Signature;
            record.NiNumber = this.NiNumber;
            record.EthnicGroup = this.EthnicGroup;
            record.Diary = this.Diary;
            record.Language = this.Language;
            record.Warmth = this.Warmth;
            record.SoundexKey = this.SoundexKey;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.Userchar4 = this.Userchar4;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Node = this.Node;
            record.Aka = this.Aka;
            record.SecretaryPhone = this.SecretaryPhone;
            record.PrefComm = this.PrefComm;
            record.Donotmail2 = this.Donotmail2;
            record.Donotmail3 = this.Donotmail3;
            record.DesigLetters = this.DesigLetters;
            record.SignifPartner = this.SignifPartner;
            record.DietRequire = this.DietRequire;
            record.AlumniGrade = this.AlumniGrade;
            record.AlumniOffice = this.AlumniOffice;
            record.Target = this.Target;
            record.PromoId = this.PromoId;
            record.DateOfBirth = this.DateOfBirth;
            record.Religion = this.Religion;
            record.SpecialNeeds = this.SpecialNeeds;
            record.Userdate1 = this.Userdate1;
            record.Userdate2 = this.Userdate2;
            record.Attractive = this.Attractive;
            record.Potential = this.Potential;
            record.HomePhone = this.HomePhone;
            record.HomeFax = this.HomeFax;
            record.HomeOther = this.HomeOther;
            record.HomeAddId = this.HomeAddId;
            record.Shortname = this.Shortname;
            record.Flag1 = this.Flag1;
            record.Flag2 = this.Flag2;
            record.Flag3 = this.Flag3;
            record.Userchar5 = this.Userchar5;
            record.Userchar6 = this.Userchar6;
            record.Userchar7 = this.Userchar7;
            record.Userchar8 = this.Userchar8;
            record.Userchar9 = this.Userchar9;
            record.HomeEmail = this.HomeEmail;
            record.PicFile = this.PicFile;
            record.Userint1 = this.Userint1;
            record.Userint2 = this.Userint2;
            record.Userint3 = this.Userint3;
            record.Userint4 = this.Userint4;
            record.Userint5 = this.Userint5;
            record.Userint6 = this.Userint6;
            record.Usernum3 = this.Usernum3;
            record.Usernum4 = this.Usernum4;
            record.Usernum5 = this.Usernum5;
            record.Usernum6 = this.Usernum6;
            record.Userdate3 = this.Userdate3;
            record.Userdate4 = this.Userdate4;
            record.Userdate5 = this.Userdate5;
            record.Userdate6 = this.Userdate6;
            record.SpecialTerms = this.SpecialTerms;
            record.PartnerSysRef = this.PartnerSysRef;
            record.Ethnicity = this.Ethnicity;
            record.HomePhoneStd = this.HomePhoneStd;
            record.Mobile = this.Mobile;
            record.DataProt = this.DataProt;
            record.EmergencyContact = this.EmergencyContact;
            record.AccomPref = this.AccomPref;
            record.Disability = this.Disability;
            record.DisabilityNotes = this.DisabilityNotes;
            record.Nationality = this.Nationality;
            record.PorModDate = this.PorModDate;
            record.SyType = this.SyType;
            record.MedicalDet = this.MedicalDet;
            record.DoNotSpare1 = this.DoNotSpare1;
            record.DoNotSpare2 = this.DoNotSpare2;
            record.DoNotSpare3 = this.DoNotSpare3;
            record.DoNotSpare4 = this.DoNotSpare4;
            record.GdprConsentDate = this.GdprConsentDate;
            record.RetainUntilDate = this.RetainUntilDate;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PersonRecord" /> instance is equal to another <see cref="PersonRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PersonRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PersonRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.FirstName.TrimOrNullify() == that.FirstName.TrimOrNullify());
            result = result && (this.SecName.TrimOrNullify() == that.SecName.TrimOrNullify());
            result = result && (this.Initials.TrimOrNullify() == that.Initials.TrimOrNullify());
            result = result && (this.Surname.TrimOrNullify() == that.Surname.TrimOrNullify());
            result = result && (this.SnameSuffix.TrimOrNullify() == that.SnameSuffix.TrimOrNullify());
            result = result && (this.Honours.TrimOrNullify() == that.Honours.TrimOrNullify());
            result = result && (this.Salutation.TrimOrNullify() == that.Salutation.TrimOrNullify());
            result = result && (this.Donotmail == that.Donotmail);
            result = result && (this.OurPerson == that.OurPerson);
            result = result && (this.Gender.TrimOrNullify() == that.Gender.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Signature.TrimOrNullify() == that.Signature.TrimOrNullify());
            result = result && (this.NiNumber.TrimOrNullify() == that.NiNumber.TrimOrNullify());
            result = result && (this.EthnicGroup.TrimOrNullify() == that.EthnicGroup.TrimOrNullify());
            result = result && (this.Diary == that.Diary);
            result = result && (this.Language.TrimOrNullify() == that.Language.TrimOrNullify());
            result = result && (this.Warmth.TrimOrNullify() == that.Warmth.TrimOrNullify());
            result = result && (this.SoundexKey.TrimOrNullify() == that.SoundexKey.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.Userchar4.TrimOrNullify() == that.Userchar4.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Node.TrimOrNullify() == that.Node.TrimOrNullify());
            result = result && (this.Aka.TrimOrNullify() == that.Aka.TrimOrNullify());
            result = result && (this.SecretaryPhone.TrimOrNullify() == that.SecretaryPhone.TrimOrNullify());
            result = result && (this.PrefComm.TrimOrNullify() == that.PrefComm.TrimOrNullify());
            result = result && (this.Donotmail2 == that.Donotmail2);
            result = result && (this.Donotmail3 == that.Donotmail3);
            result = result && (this.DesigLetters.TrimOrNullify() == that.DesigLetters.TrimOrNullify());
            result = result && (this.SignifPartner.TrimOrNullify() == that.SignifPartner.TrimOrNullify());
            result = result && (this.DietRequire.TrimOrNullify() == that.DietRequire.TrimOrNullify());
            result = result && (this.AlumniGrade.TrimOrNullify() == that.AlumniGrade.TrimOrNullify());
            result = result && (this.AlumniOffice.TrimOrNullify() == that.AlumniOffice.TrimOrNullify());
            result = result && (this.Target.TrimOrNullify() == that.Target.TrimOrNullify());
            result = result && (this.PromoId.TrimOrNullify() == that.PromoId.TrimOrNullify());
            result = result && (this.DateOfBirth == that.DateOfBirth);
            result = result && (this.Religion.TrimOrNullify() == that.Religion.TrimOrNullify());
            result = result && (this.SpecialNeeds.TrimOrNullify() == that.SpecialNeeds.TrimOrNullify());
            result = result && (this.Userdate1 == that.Userdate1);
            result = result && (this.Userdate2 == that.Userdate2);
            result = result && (this.Attractive.TrimOrNullify() == that.Attractive.TrimOrNullify());
            result = result && (this.Potential.TrimOrNullify() == that.Potential.TrimOrNullify());
            result = result && (this.HomePhone.TrimOrNullify() == that.HomePhone.TrimOrNullify());
            result = result && (this.HomeFax.TrimOrNullify() == that.HomeFax.TrimOrNullify());
            result = result && (this.HomeOther.TrimOrNullify() == that.HomeOther.TrimOrNullify());
            result = result && (this.HomeAddId.TrimOrNullify() == that.HomeAddId.TrimOrNullify());
            result = result && (this.Shortname.TrimOrNullify() == that.Shortname.TrimOrNullify());
            result = result && (this.Flag1 == that.Flag1);
            result = result && (this.Flag2 == that.Flag2);
            result = result && (this.Flag3 == that.Flag3);
            result = result && (this.Userchar5.TrimOrNullify() == that.Userchar5.TrimOrNullify());
            result = result && (this.Userchar6.TrimOrNullify() == that.Userchar6.TrimOrNullify());
            result = result && (this.Userchar7.TrimOrNullify() == that.Userchar7.TrimOrNullify());
            result = result && (this.Userchar8.TrimOrNullify() == that.Userchar8.TrimOrNullify());
            result = result && (this.Userchar9.TrimOrNullify() == that.Userchar9.TrimOrNullify());
            result = result && (this.HomeEmail.TrimOrNullify() == that.HomeEmail.TrimOrNullify());
            result = result && (this.PicFile.TrimOrNullify() == that.PicFile.TrimOrNullify());
            result = result && (this.Userint1 == that.Userint1);
            result = result && (this.Userint2 == that.Userint2);
            result = result && (this.Userint3 == that.Userint3);
            result = result && (this.Userint4 == that.Userint4);
            result = result && (this.Userint5 == that.Userint5);
            result = result && (this.Userint6 == that.Userint6);
            result = result && (this.Usernum3 == that.Usernum3);
            result = result && (this.Usernum4 == that.Usernum4);
            result = result && (this.Usernum5 == that.Usernum5);
            result = result && (this.Usernum6 == that.Usernum6);
            result = result && (this.Userdate3 == that.Userdate3);
            result = result && (this.Userdate4 == that.Userdate4);
            result = result && (this.Userdate5 == that.Userdate5);
            result = result && (this.Userdate6 == that.Userdate6);
            result = result && (this.SpecialTerms.TrimOrNullify() == that.SpecialTerms.TrimOrNullify());
            result = result && (this.PartnerSysRef.TrimOrNullify() == that.PartnerSysRef.TrimOrNullify());
            result = result && (this.Ethnicity.TrimOrNullify() == that.Ethnicity.TrimOrNullify());
            result = result && (this.HomePhoneStd.TrimOrNullify() == that.HomePhoneStd.TrimOrNullify());
            result = result && (this.Mobile.TrimOrNullify() == that.Mobile.TrimOrNullify());
            result = result && (this.DataProt.TrimOrNullify() == that.DataProt.TrimOrNullify());
            result = result && (this.EmergencyContact.TrimOrNullify() == that.EmergencyContact.TrimOrNullify());
            result = result && (this.AccomPref.TrimOrNullify() == that.AccomPref.TrimOrNullify());
            result = result && (this.Disability == that.Disability);
            result = result && (this.DisabilityNotes.TrimOrNullify() == that.DisabilityNotes.TrimOrNullify());
            result = result && (this.Nationality.TrimOrNullify() == that.Nationality.TrimOrNullify());
            result = result && (this.PorModDate == that.PorModDate);
            result = result && (this.SyType == that.SyType);
            result = result && (this.MedicalDet.TrimOrNullify() == that.MedicalDet.TrimOrNullify());
            result = result && (this.DoNotSpare1 == that.DoNotSpare1);
            result = result && (this.DoNotSpare2 == that.DoNotSpare2);
            result = result && (this.DoNotSpare3 == that.DoNotSpare3);
            result = result && (this.DoNotSpare4 == that.DoNotSpare4);
            result = result && (this.GdprConsentDate == that.GdprConsentDate);
            result = result && (this.RetainUntilDate == that.RetainUntilDate);
            return result;
        }

        #endregion
    }
}
