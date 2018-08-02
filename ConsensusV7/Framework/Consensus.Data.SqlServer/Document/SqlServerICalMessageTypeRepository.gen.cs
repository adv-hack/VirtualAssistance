using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="IcalmessagetypeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerICalMessageTypeRepository : SqlServerRepository<IcalmessagetypeRecord, Int32>, IICalMessageTypeRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Document"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Icalmessagetype"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="IcalmessagetypeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ICMT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "ICalMessageType"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="IcalmessagetypeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="IcalmessagetypeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, IcalmessagetypeRecord record)
        {
            record.Id = dataRecord["ICMT_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["ICMT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ICMT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ICMT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ICMT_MOD_BY"].ConvertTo<String>();
            record.Name = dataRecord["ICMT_NAME"].ConvertTo<String>();
            record.View = dataRecord["ICMT_VIEW"].ConvertTo<String>();
            record.Proc = dataRecord["ICMT_PROC"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="IcalmessagetypeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, IcalmessagetypeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ICMT_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_ICMT_NAME", record.Name);
            this.MapParameterIn(command, "@PA_ICMT_VIEW", record.View);
            this.MapParameterIn(command, "@PA_ICMT_PROC", record.Proc);
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
        ///     The <see cref="IcalmessagetypeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, IcalmessagetypeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ICMT_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_ICMT_NAME", record.Name);
            record.View = this.MapParameterOut(command, "@PA_ICMT_VIEW", record.View);
            record.Proc = this.MapParameterOut(command, "@PA_ICMT_PROC", record.Proc);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IICalMessageTypeRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
