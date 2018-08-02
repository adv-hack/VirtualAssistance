using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="GenericmodeltableRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerGenericModelRepository : SqlServerRepository<GenericmodeltableRecord, String>, IGenericModelRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Common"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Genericmodeltable"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="GenericmodeltableRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_GMT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "GenericModelTable"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="GenericmodeltableRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="GenericmodeltableRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, GenericmodeltableRecord record)
        {
            record.Id = dataRecord["GMT_ID"].ConvertTo<String>();
            record.Id1 = dataRecord["GMT_ID1"].ConvertTo<String>();
            record.Id2 = dataRecord["GMT_ID2"].ConvertTo<String>();
            record.Id3 = dataRecord["GMT_ID3"].ConvertTo<String>();
            record.Id4 = dataRecord["GMT_ID4"].ConvertTo<String>();
            record.Id5 = dataRecord["GMT_ID5"].ConvertTo<String>();
            record.Desc1 = dataRecord["GMT_DESC1"].ConvertTo<String>();
            record.Desc2 = dataRecord["GMT_DESC2"].ConvertTo<String>();
            record.Desc3 = dataRecord["GMT_DESC3"].ConvertTo<String>();
            record.Desc4 = dataRecord["GMT_DESC4"].ConvertTo<String>();
            record.Desc5 = dataRecord["GMT_DESC5"].ConvertTo<String>();
            record.Longdesc = dataRecord["GMT_LONGDESC"].ConvertTo<String>();
            record.Date1 = dataRecord["GMT_DATE1"].ConvertTo<DateTime?>();
            record.Date2 = dataRecord["GMT_DATE2"].ConvertTo<DateTime?>();
            record.Date3 = dataRecord["GMT_DATE3"].ConvertTo<DateTime?>();
            record.Int1 = dataRecord["GMT_INT1"].ConvertTo<Int32?>();
            record.Int2 = dataRecord["GMT_INT2"].ConvertTo<Int32?>();
            record.Int3 = dataRecord["GMT_INT3"].ConvertTo<Int32?>();
            record.Money1 = dataRecord["GMT_MONEY1"].ConvertTo<Decimal?>();
            record.Money2 = dataRecord["GMT_MONEY2"].ConvertTo<Decimal?>();
            record.Money3 = dataRecord["GMT_MONEY3"].ConvertTo<Decimal?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="GenericmodeltableRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, GenericmodeltableRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_GMT_ID", record.Id);
            this.MapParameterIn(command, "@PA_GMT_ID1", record.Id1);
            this.MapParameterIn(command, "@PA_GMT_ID2", record.Id2);
            this.MapParameterIn(command, "@PA_GMT_ID3", record.Id3);
            this.MapParameterIn(command, "@PA_GMT_ID4", record.Id4);
            this.MapParameterIn(command, "@PA_GMT_ID5", record.Id5);
            this.MapParameterIn(command, "@PA_GMT_DESC1", record.Desc1);
            this.MapParameterIn(command, "@PA_GMT_DESC2", record.Desc2);
            this.MapParameterIn(command, "@PA_GMT_DESC3", record.Desc3);
            this.MapParameterIn(command, "@PA_GMT_DESC4", record.Desc4);
            this.MapParameterIn(command, "@PA_GMT_DESC5", record.Desc5);
            this.MapParameterIn(command, "@PA_GMT_LONGDESC", record.Longdesc);
            this.MapParameterIn(command, "@PA_GMT_DATE1", record.Date1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date1);
            this.MapParameterIn(command, "@PA_GMT_DATE2", record.Date2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date2);
            this.MapParameterIn(command, "@PA_GMT_DATE3", record.Date3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date3);
            this.MapParameterIn(command, "@PA_GMT_INT1", record.Int1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Int1);
            this.MapParameterIn(command, "@PA_GMT_INT2", record.Int2 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Int2);
            this.MapParameterIn(command, "@PA_GMT_INT3", record.Int3 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Int3);
            this.MapParameterIn(command, "@PA_GMT_MONEY1", record.Money1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Money1);
            this.MapParameterIn(command, "@PA_GMT_MONEY2", record.Money2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Money2);
            this.MapParameterIn(command, "@PA_GMT_MONEY3", record.Money3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Money3);
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
        ///     The <see cref="GenericmodeltableRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, GenericmodeltableRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_GMT_ID", record.Id);
            record.Id1 = this.MapParameterOut(command, "@PA_GMT_ID1", record.Id1);
            record.Id2 = this.MapParameterOut(command, "@PA_GMT_ID2", record.Id2);
            record.Id3 = this.MapParameterOut(command, "@PA_GMT_ID3", record.Id3);
            record.Id4 = this.MapParameterOut(command, "@PA_GMT_ID4", record.Id4);
            record.Id5 = this.MapParameterOut(command, "@PA_GMT_ID5", record.Id5);
            record.Desc1 = this.MapParameterOut(command, "@PA_GMT_DESC1", record.Desc1);
            record.Desc2 = this.MapParameterOut(command, "@PA_GMT_DESC2", record.Desc2);
            record.Desc3 = this.MapParameterOut(command, "@PA_GMT_DESC3", record.Desc3);
            record.Desc4 = this.MapParameterOut(command, "@PA_GMT_DESC4", record.Desc4);
            record.Desc5 = this.MapParameterOut(command, "@PA_GMT_DESC5", record.Desc5);
            record.Longdesc = this.MapParameterOut(command, "@PA_GMT_LONGDESC", record.Longdesc);
            record.Date1 = this.MapParameterOut(command, "@PA_GMT_DATE1", record.Date1);
            record.Date2 = this.MapParameterOut(command, "@PA_GMT_DATE2", record.Date2);
            record.Date3 = this.MapParameterOut(command, "@PA_GMT_DATE3", record.Date3);
            record.Int1 = this.MapParameterOut(command, "@PA_GMT_INT1", record.Int1);
            record.Int2 = this.MapParameterOut(command, "@PA_GMT_INT2", record.Int2);
            record.Int3 = this.MapParameterOut(command, "@PA_GMT_INT3", record.Int3);
            record.Money1 = this.MapParameterOut(command, "@PA_GMT_MONEY1", record.Money1);
            record.Money2 = this.MapParameterOut(command, "@PA_GMT_MONEY2", record.Money2);
            record.Money3 = this.MapParameterOut(command, "@PA_GMT_MONEY3", record.Money3);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IGenericModelRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="accid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> IGenericModelRepository.FetchAllByAccIdAccountXref(System.String accid, System.String proleid)
        {
            return this.FetchAllByAccIdAccountXref(accid, proleid);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> IGenericModelRepository.FetchAllByCourseIdSessions(System.String courseid)
        {
            return this.FetchAllByCourseIdSessions(courseid);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> IGenericModelRepository.FetchAllByCourseIdPrices(System.String courseid, System.Int32 delcount)
        {
            return this.FetchAllByCourseIdPrices(courseid, delcount);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="prodid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> IGenericModelRepository.FetchAllByProdIdPrices(System.String prodid, System.Int32 quantity)
        {
            return this.FetchAllByProdIdPrices(prodid, quantity);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericmodeltableModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericmodeltableModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.GenericmodeltableRecord> IGenericModelRepository.ValidateDelegate(System.String courseid, System.String proleid, System.String qualid, System.Int16 ignorefreeplaces, System.Int16 delquantity)
        {
            return this.ValidateDelegate(courseid, proleid, qualid, ignorefreeplaces, delquantity);
        }

        #endregion
    }
}
