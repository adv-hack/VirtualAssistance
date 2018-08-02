using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PayAllocationRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPayAllocationRepository : SqlServerRepository<PayAllocationRecord, String>, IPayAllocationRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Finance"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "PayAllocation"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PayAllocationRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PA_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Pay_Allocation"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PayAllocationRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PayAllocationRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PayAllocationRecord record)
        {
            record.Id = dataRecord["PA_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PA_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PA_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PA_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PA_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PA_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PA_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PA_RCV_FROM"].ConvertTo<String>();
            record.Date = dataRecord["PA_DATE"].ConvertTo<DateTime?>();
            record.InvId = dataRecord["PA_INV_ID"].ConvertTo<String>();
            record.InvRef = dataRecord["PA_INV_REF"].ConvertTo<String>();
            record.PayId = dataRecord["PA_PAY_ID"].ConvertTo<String>();
            record.Hidden = dataRecord["PA_HIDDEN"].ConvertTo<Byte?>();
            record.CurrType = dataRecord["PA_CURR_TYPE"].ConvertTo<String>();
            record.Value = dataRecord["PA_VALUE"].ConvertTo<Decimal>();
            record.ValueBc = dataRecord["PA_VALUE_BC"].ConvertTo<Decimal>();
            record.CreditId = dataRecord["PA_CREDIT_ID"].ConvertTo<String>();
            record.CreditRef = dataRecord["PA_CREDIT_REF"].ConvertTo<String>();
            record.BookId = dataRecord["PA_BOOK_ID"].ConvertTo<String>();
            record.MepId = dataRecord["PA_MEP_ID"].ConvertTo<String>();
            record.BatId = dataRecord["PA_BAT_ID"].ConvertTo<String>();
            record.ValueBc2 = dataRecord["PA_VALUE_BC2"].ConvertTo<Decimal>();
            record.DelId = dataRecord["PA_DEL_ID"].ConvertTo<String>();
            record.Description = dataRecord["PA_DESCRIPTION"].ConvertTo<String>();
            record.External = dataRecord["PA_EXTERNAL"].ConvertTo<Byte?>();
            record.RefundId = dataRecord["PA_REFUND_ID"].ConvertTo<String>();
            record.Deallocation = dataRecord["PA_DEALLOCATION"].ConvertTo<Byte?>();
            record.ReversesPaId = dataRecord["PA_REVERSES_PA_ID"].ConvertTo<String>();
            record.ElemId = dataRecord["PA_ELEM_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PayAllocationRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PayAllocationRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PA_ID", record.Id);
            this.MapParameterIn(command, "@PA_PA_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PA_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
            this.MapParameterIn(command, "@PA_PA_INV_ID", record.InvId);
            this.MapParameterIn(command, "@PA_PA_INV_REF", record.InvRef);
            this.MapParameterIn(command, "@PA_PA_PAY_ID", record.PayId);
            this.MapParameterIn(command, "@PA_PA_HIDDEN", record.Hidden);
            this.MapParameterIn(command, "@PA_PA_CURR_TYPE", record.CurrType);
            this.MapParameterIn(command, "@PA_PA_VALUE", record.Value == Decimal.MinValue ? 0M : record.Value);
            this.MapParameterIn(command, "@PA_PA_VALUE_BC", record.ValueBc == Decimal.MinValue ? 0M : record.ValueBc);
            this.MapParameterIn(command, "@PA_PA_CREDIT_ID", record.CreditId);
            this.MapParameterIn(command, "@PA_PA_CREDIT_REF", record.CreditRef);
            this.MapParameterIn(command, "@PA_PA_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_PA_MEP_ID", record.MepId);
            this.MapParameterIn(command, "@PA_PA_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_PA_VALUE_BC2", record.ValueBc2 == Decimal.MinValue ? 0M : record.ValueBc2);
            this.MapParameterIn(command, "@PA_PA_DEL_ID", record.DelId);
            this.MapParameterIn(command, "@PA_PA_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_PA_EXTERNAL", record.External);
            this.MapParameterIn(command, "@PA_PA_REFUND_ID", record.RefundId);
            this.MapParameterIn(command, "@PA_PA_DEALLOCATION", record.Deallocation);
            this.MapParameterIn(command, "@PA_PA_REVERSES_PA_ID", record.ReversesPaId);
            this.MapParameterIn(command, "@PA_PA_ELEM_ID", record.ElemId);
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
        ///     The <see cref="PayAllocationRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PayAllocationRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PA_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PA_LOCK", record.Lock);
            record.Date = this.MapParameterOut(command, "@PA_PA_DATE", record.Date);
            record.InvId = this.MapParameterOut(command, "@PA_PA_INV_ID", record.InvId);
            record.InvRef = this.MapParameterOut(command, "@PA_PA_INV_REF", record.InvRef);
            record.PayId = this.MapParameterOut(command, "@PA_PA_PAY_ID", record.PayId);
            record.Hidden = this.MapParameterOut(command, "@PA_PA_HIDDEN", record.Hidden);
            record.CurrType = this.MapParameterOut(command, "@PA_PA_CURR_TYPE", record.CurrType);
            record.Value = this.MapParameterOut(command, "@PA_PA_VALUE", record.Value);
            record.ValueBc = this.MapParameterOut(command, "@PA_PA_VALUE_BC", record.ValueBc);
            record.CreditId = this.MapParameterOut(command, "@PA_PA_CREDIT_ID", record.CreditId);
            record.CreditRef = this.MapParameterOut(command, "@PA_PA_CREDIT_REF", record.CreditRef);
            record.BookId = this.MapParameterOut(command, "@PA_PA_BOOK_ID", record.BookId);
            record.MepId = this.MapParameterOut(command, "@PA_PA_MEP_ID", record.MepId);
            record.BatId = this.MapParameterOut(command, "@PA_PA_BAT_ID", record.BatId);
            record.ValueBc2 = this.MapParameterOut(command, "@PA_PA_VALUE_BC2", record.ValueBc2);
            record.DelId = this.MapParameterOut(command, "@PA_PA_DEL_ID", record.DelId);
            record.Description = this.MapParameterOut(command, "@PA_PA_DESCRIPTION", record.Description);
            record.External = this.MapParameterOut(command, "@PA_PA_EXTERNAL", record.External);
            record.RefundId = this.MapParameterOut(command, "@PA_PA_REFUND_ID", record.RefundId);
            record.Deallocation = this.MapParameterOut(command, "@PA_PA_DEALLOCATION", record.Deallocation);
            record.ReversesPaId = this.MapParameterOut(command, "@PA_PA_REVERSES_PA_ID", record.ReversesPaId);
            record.ElemId = this.MapParameterOut(command, "@PA_PA_ELEM_ID", record.ElemId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invId">
        ///     The value which identifies the <see cref='PayAllocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PayAllocationRecord" /> instances that match the specified <paramref name='invId' />.
        /// </returns>
        public IEnumerable<PayAllocationRecord> FetchAllByInvId(String invId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvId");
            this.MapParameterIn(command, "@PA_PA_INV_ID", invId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="payId">
        ///     The value which identifies the <see cref='PayAllocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PayAllocationRecord" /> instances that match the specified <paramref name='payId' />.
        /// </returns>
        public IEnumerable<PayAllocationRecord> FetchAllByPayId(String payId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PayId");
            this.MapParameterIn(command, "@PA_PA_PAY_ID", payId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="creditId">
        ///     The value which identifies the <see cref='PayAllocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PayAllocationRecord" /> instances that match the specified <paramref name='creditId' />.
        /// </returns>
        public IEnumerable<PayAllocationRecord> FetchAllByCreditId(String creditId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CreditId");
            this.MapParameterIn(command, "@PA_PA_CREDIT_ID", creditId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPayAllocationRepository.TableName
        {
            get { return this.TableName; }
        }

        void IPayAllocationRepository.Create(Consensus.Finance.PayAllocationRecord record)
        {
            this.Create(record);
        }

        void IPayAllocationRepository.CreateReverse(Consensus.Finance.PayAllocationRecord record, System.Boolean reverse, System.String paid)
        {
            this.CreateReverse(record, reverse, paid);
        }

        void IPayAllocationRepository.Modify(Consensus.Finance.PayAllocationRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances that match the specified <paramref name="invId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PayAllocationRecord> IPayAllocationRepository.FetchAllByInvId(System.String invId)
        {
            return this.FetchAllByInvId(invId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="payId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances that match the specified <paramref name="payId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PayAllocationRecord> IPayAllocationRepository.FetchAllByPayId(System.String payId)
        {
            return this.FetchAllByPayId(payId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="creditId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PayAllocationRecord" /> instances that match the specified <paramref name="creditId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PayAllocationRecord> IPayAllocationRepository.FetchAllByCreditId(System.String creditId)
        {
            return this.FetchAllByCreditId(creditId);
        }

        #endregion
    }
}
