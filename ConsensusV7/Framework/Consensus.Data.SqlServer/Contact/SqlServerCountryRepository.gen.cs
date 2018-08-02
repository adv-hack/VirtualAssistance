using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CountryRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCountryRepository : SqlServerRepository<CountryRecord, String>, ICountryRepository
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
            get { return "Country"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CountryRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CO_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Country"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CountryRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CountryRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CountryRecord record)
        {
            record.Id = dataRecord["CO_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["CO_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["CO_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["CO_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CO_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["CO_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["CO_RCV_DATE"].ConvertTo<DateTime?>();
            record.Name = dataRecord["CO_NAME"].ConvertTo<String>();
            record.Format = dataRecord["CO_FORMAT"].ConvertTo<String>();
            record.Rep = dataRecord["CO_REP"].ConvertTo<String>();
            record.Area = dataRecord["CO_AREA"].ConvertTo<String>();
            record.RepId = dataRecord["CO_REP_ID"].ConvertTo<String>();
            record.Rep1Id = dataRecord["CO_REP1_ID"].ConvertTo<String>();
            record.Rep2Id = dataRecord["CO_REP2_ID"].ConvertTo<String>();
            record.PostcodeFlag = dataRecord["CO_POSTCODE_FLAG"].ConvertTo<String>();
            record.OrgType = dataRecord["CO_ORG_TYPE"].ConvertTo<String>();
            record.ProductGroup = dataRecord["CO_PRODUCT_GROUP"].ConvertTo<String>();
            record.Postcode = dataRecord["CO_POSTCODE"].ConvertTo<String>();
            record.Industry = dataRecord["CO_INDUSTRY"].ConvertTo<String>();
            record.TerrId = dataRecord["CO_TERR_ID"].ConvertTo<String>();
            record.Lock = dataRecord["CO_LOCK"].ConvertTo<String>();
            record.County = dataRecord["CO_COUNTY"].ConvertTo<String>();
            record.VatType = dataRecord["CO_VAT_TYPE"].ConvertTo<Byte?>();
            record.Language = dataRecord["CO_LANGUAGE"].ConvertTo<String>();
            record.Currency = dataRecord["CO_CURRENCY"].ConvertTo<String>();
            record.Userchar1 = dataRecord["CO_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["CO_USERCHAR_2"].ConvertTo<String>();
            record.Usernum1 = dataRecord["CO_USERNUM_1"].ConvertTo<Double?>();
            record.Usernum2 = dataRecord["CO_USERNUM_2"].ConvertTo<Double?>();
            record.Notes = dataRecord["CO_NOTES"].ConvertTo<String>();
            record.Euro = dataRecord["CO_EURO"].ConvertTo<Byte?>();
            record.CountryCode = dataRecord["CO_COUNTRY_CODE"].ConvertTo<String>();
            record.Town = dataRecord["CO_TOWN"].ConvertTo<String>();
            record.PcodeLu = dataRecord["CO_PCODE_LU"].ConvertTo<Byte?>();
            record.LinePos = dataRecord["CO_LINE_POS"].ConvertTo<String>();
            record.VatCode = dataRecord["CO_VAT_CODE"].ConvertTo<String>();
            record.VatCountryCode = dataRecord["CO_VAT_COUNTRY_CODE"].ConvertTo<String>();
            record.MailstringOrder = dataRecord["CO_MAILSTRING_ORDER"].ConvertTo<String>();
            record.MailstringDisplay = dataRecord["CO_MAILSTRING_DISPLAY"].ConvertTo<String>();
            record.MailstringNewline = dataRecord["CO_MAILSTRING_NEWLINE"].ConvertTo<String>();
            record.CountryCode2 = dataRecord["CO_COUNTRY_CODE_2"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CountryRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CountryRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CO_ID", record.Id);
            this.MapParameterIn(command, "@PA_CO_NAME", record.Name);
            this.MapParameterIn(command, "@PA_CO_FORMAT", record.Format);
            this.MapParameterIn(command, "@PA_CO_REP", record.Rep);
            this.MapParameterIn(command, "@PA_CO_AREA", record.Area);
            this.MapParameterIn(command, "@PA_CO_REP_ID", record.RepId);
            this.MapParameterIn(command, "@PA_CO_REP1_ID", record.Rep1Id);
            this.MapParameterIn(command, "@PA_CO_REP2_ID", record.Rep2Id);
            this.MapParameterIn(command, "@PA_CO_POSTCODE_FLAG", record.PostcodeFlag);
            this.MapParameterIn(command, "@PA_CO_ORG_TYPE", record.OrgType);
            this.MapParameterIn(command, "@PA_CO_PRODUCT_GROUP", record.ProductGroup);
            this.MapParameterIn(command, "@PA_CO_POSTCODE", record.Postcode);
            this.MapParameterIn(command, "@PA_CO_INDUSTRY", record.Industry);
            this.MapParameterIn(command, "@PA_CO_TERR_ID", record.TerrId);
            this.MapParameterIn(command, "@PA_CO_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_CO_COUNTY", record.County);
            this.MapParameterIn(command, "@PA_CO_VAT_TYPE", record.VatType);
            this.MapParameterIn(command, "@PA_CO_LANGUAGE", record.Language);
            this.MapParameterIn(command, "@PA_CO_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_CO_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_CO_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_CO_USERNUM_1", record.Usernum1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_CO_USERNUM_2", record.Usernum2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_CO_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_CO_EURO", record.Euro);
            this.MapParameterIn(command, "@PA_CO_COUNTRY_CODE", record.CountryCode);
            this.MapParameterIn(command, "@PA_CO_TOWN", record.Town);
            this.MapParameterIn(command, "@PA_CO_PCODE_LU", record.PcodeLu);
            this.MapParameterIn(command, "@PA_CO_LINE_POS", record.LinePos);
            this.MapParameterIn(command, "@PA_CO_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@PA_CO_VAT_COUNTRY_CODE", record.VatCountryCode);
            this.MapParameterIn(command, "@PA_CO_MAILSTRING_ORDER", record.MailstringOrder);
            this.MapParameterIn(command, "@PA_CO_MAILSTRING_DISPLAY", record.MailstringDisplay);
            this.MapParameterIn(command, "@PA_CO_MAILSTRING_NEWLINE", record.MailstringNewline);
            this.MapParameterIn(command, "@PA_CO_COUNTRY_CODE_2", record.CountryCode2);
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
        ///     The <see cref="CountryRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CountryRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CO_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_CO_NAME", record.Name);
            record.Format = this.MapParameterOut(command, "@PA_CO_FORMAT", record.Format);
            record.Rep = this.MapParameterOut(command, "@PA_CO_REP", record.Rep);
            record.Area = this.MapParameterOut(command, "@PA_CO_AREA", record.Area);
            record.RepId = this.MapParameterOut(command, "@PA_CO_REP_ID", record.RepId);
            record.Rep1Id = this.MapParameterOut(command, "@PA_CO_REP1_ID", record.Rep1Id);
            record.Rep2Id = this.MapParameterOut(command, "@PA_CO_REP2_ID", record.Rep2Id);
            record.PostcodeFlag = this.MapParameterOut(command, "@PA_CO_POSTCODE_FLAG", record.PostcodeFlag);
            record.OrgType = this.MapParameterOut(command, "@PA_CO_ORG_TYPE", record.OrgType);
            record.ProductGroup = this.MapParameterOut(command, "@PA_CO_PRODUCT_GROUP", record.ProductGroup);
            record.Postcode = this.MapParameterOut(command, "@PA_CO_POSTCODE", record.Postcode);
            record.Industry = this.MapParameterOut(command, "@PA_CO_INDUSTRY", record.Industry);
            record.TerrId = this.MapParameterOut(command, "@PA_CO_TERR_ID", record.TerrId);
            record.Lock = this.MapParameterOut(command, "@PA_CO_LOCK", record.Lock);
            record.County = this.MapParameterOut(command, "@PA_CO_COUNTY", record.County);
            record.VatType = this.MapParameterOut(command, "@PA_CO_VAT_TYPE", record.VatType);
            record.Language = this.MapParameterOut(command, "@PA_CO_LANGUAGE", record.Language);
            record.Currency = this.MapParameterOut(command, "@PA_CO_CURRENCY", record.Currency);
            record.Userchar1 = this.MapParameterOut(command, "@PA_CO_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_CO_USERCHAR_2", record.Userchar2);
            record.Usernum1 = this.MapParameterOut(command, "@PA_CO_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_CO_USERNUM_2", record.Usernum2);
            record.Notes = this.MapParameterOut(command, "@PA_CO_NOTES", record.Notes);
            record.Euro = this.MapParameterOut(command, "@PA_CO_EURO", record.Euro);
            record.CountryCode = this.MapParameterOut(command, "@PA_CO_COUNTRY_CODE", record.CountryCode);
            record.Town = this.MapParameterOut(command, "@PA_CO_TOWN", record.Town);
            record.PcodeLu = this.MapParameterOut(command, "@PA_CO_PCODE_LU", record.PcodeLu);
            record.LinePos = this.MapParameterOut(command, "@PA_CO_LINE_POS", record.LinePos);
            record.VatCode = this.MapParameterOut(command, "@PA_CO_VAT_CODE", record.VatCode);
            record.VatCountryCode = this.MapParameterOut(command, "@PA_CO_VAT_COUNTRY_CODE", record.VatCountryCode);
            record.MailstringOrder = this.MapParameterOut(command, "@PA_CO_MAILSTRING_ORDER", record.MailstringOrder);
            record.MailstringDisplay = this.MapParameterOut(command, "@PA_CO_MAILSTRING_DISPLAY", record.MailstringDisplay);
            record.MailstringNewline = this.MapParameterOut(command, "@PA_CO_MAILSTRING_NEWLINE", record.MailstringNewline);
            record.CountryCode2 = this.MapParameterOut(command, "@PA_CO_COUNTRY_CODE_2", record.CountryCode2);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICountryRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
