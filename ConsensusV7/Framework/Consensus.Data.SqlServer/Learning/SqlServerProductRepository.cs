using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProductRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    public partial class SqlServerProductRepository
    {
        public override void Modify(ProductRecord record)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spInsertUpdateProduct"); ;
            bool useV6Logic = true;
            if (record.SyProduct == 10)
            {
                command = this.Provider.GetStoredProcedure("spConsensusLearningProductModify");
                useV6Logic = false;
            }
            else
            {
                this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
                this.MapErrorParams(command);
            }

            this.MapParametersIn(command, record, useV6Logic);
            this.Execute(command);
            if (record.SyProduct != 10)
            {
                this.CheckErrorParams(command);
            }
            this.MapParametersOut(command, record);

        }

        public override void Create(ProductRecord record)
        {
            DbCommand command=this.Provider.GetStoredProcedure("spInsertUpdateProduct");
            //if (record.SyProduct == 17) //SysProd for MembershipGrade
            //    command = this.Provider.GetStoredProcedure("spInsertUpdateProductMemberGrade");
            //else if (record.SyProduct == 16) //SysProd for Specialist Group
            //    command = this.Provider.GetStoredProcedure("spInsertUpdateProductSpecialistGrp"); 


            this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
            this.MapErrorParams(command);
            this.MapParametersIn(command, record, true);
            this.Execute(command);
            this.CheckErrorParams(command);
            this.MapParametersOut(command, record);
        }

        /// <summary>
        ///     Retrieves a single <see cref="ProductRecord" /> instance from the data store.
        /// </summary>
        /// <param name="reference">
        ///     The value which identifies the <see cref='ProductRecord' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The first <see cref="ProductRecord" /> instance which matches the specified <paramref name="reference"/>.
        /// </returns>
        public ProductRecord FetchAllByReference(String reference)
        {
            DbCommand command = this.Provider.GetStoredProcedure("spConsensusLearningProductFetchAllByReference");
            this.MapParameterIn(command, "@PA_PROD_REF", reference);
            return this.Execute(command).FirstOrDefault();
        }
    }
}
