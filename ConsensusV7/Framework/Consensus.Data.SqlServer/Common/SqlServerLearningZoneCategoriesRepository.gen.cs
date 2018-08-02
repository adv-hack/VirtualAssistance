using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LearningzonecategoriesRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLearningZoneCategoriesRepository : SqlServerRepository<LearningzonecategoriesRecord, Int32>, ILearningZoneCategoriesRepository
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
            get { return "Learningzonecategories"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="LearningzonecategoriesRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LZC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "LearningZoneCategories"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="LearningzonecategoriesRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LearningzonecategoriesRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, LearningzonecategoriesRecord record)
        {
            record.Id = dataRecord["LZC_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["LZC_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["LZC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["LZC_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["LZC_MOD_BY"].ConvertTo<String>();
            record.CategoryTitle = dataRecord["LZC_CATEGORY_TITLE"].ConvertTo<String>();
            record.Description = dataRecord["LZC_DESCRIPTION"].ConvertTo<String>();
            record.DescriptionHtml = dataRecord["LZC_DESCRIPTION_HTML"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LearningzonecategoriesRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, LearningzonecategoriesRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LZC_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_LZC_CATEGORY_TITLE", record.CategoryTitle);
            this.MapParameterIn(command, "@PA_LZC_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_LZC_DESCRIPTION_HTML", record.DescriptionHtml);
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
        ///     The <see cref="LearningzonecategoriesRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, LearningzonecategoriesRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LZC_ID", record.Id);
            record.CategoryTitle = this.MapParameterOut(command, "@PA_LZC_CATEGORY_TITLE", record.CategoryTitle);
            record.Description = this.MapParameterOut(command, "@PA_LZC_DESCRIPTION", record.Description);
            record.DescriptionHtml = this.MapParameterOut(command, "@PA_LZC_DESCRIPTION_HTML", record.DescriptionHtml);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILearningZoneCategoriesRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
