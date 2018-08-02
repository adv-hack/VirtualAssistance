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
    public partial class SqlServerGenericModelRepository
    {
      /// <summary>
      ///     Retrieves a specific <see cref='GenericmodeltableModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericmodeltableModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericmodeltableModel' /> instance that matches the specified <paramref name='accid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<GenericmodeltableRecord> FetchAllByAccIdAccountXref(String accid, String proleid)
      {
        DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AccIdAccountXref");
        this.MapParameterIn(command, "@PA_ACC_ID", accid);
        this.MapParameterIn(command, "@PA_PROLE_ID", proleid);
        return this.Execute(command);
      }
      /// <summary>
      ///     Retrieves a specific <see cref='GenericmodeltableModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericmodeltableModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericmodeltableModel' /> instance that matches the specified <paramref name='courseid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<GenericmodeltableRecord> FetchAllByCourseIdSessions(String courseid)
      {
        DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseIdSessions");
        this.MapParameterIn(command, "@PA_COURSE_ID", courseid);
        return this.Execute(command);
      }
      /// <summary>
      ///     Retrieves a specific <see cref='GenericmodeltableModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericmodeltableModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericmodeltableModel' /> instance that matches the specified <paramref name='courseid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<GenericmodeltableRecord> FetchAllByCourseIdPrices(String courseid, int delcount)
      {
        DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseIdPrices");
        this.MapParameterIn(command, "@PA_COURSE_ID", courseid);
        this.MapParameterIn(command, "@PA_DEL_COUNT", delcount);
        return this.Execute(command);
      }
      /// <summary>
      ///     Retrieves a specific <see cref='GenericmodeltableModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericmodeltableModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericmodeltableModel' /> instance that matches the specified <paramref name='prodid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<GenericmodeltableRecord> FetchAllByProdIdPrices(String prodid, int quantity)
      {
        DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdIdPrices");
        this.MapParameterIn(command, "@PA_PROD_ID", prodid);
        this.MapParameterIn(command, "@PA_QTY", quantity);
        return this.Execute(command);
      }
      /// <summary>
      ///     Retrieves a specific <see cref='GenericmodeltableModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericmodeltableModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericmodeltableModel' /> instance that matches the specified <paramref name='courseid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<GenericmodeltableRecord> ValidateDelegate(String courseid, String proleid, String qualid,Int16 ignorefreeplaces, Int16 delquantity )
      {
        DbCommand command = this.Provider.GetStoredProcedure("spConsensusCommonGenericmodeltableValidateDelegate");
        this.MapParameterIn(command, "@PA_USER_LOGIN_ID", "dev");
        this.MapParameterIn(command, "@PA_COURSE_ID", courseid);
        this.MapParameterIn(command, "@PA_PROLE_ID", proleid);
        this.MapParameterIn(command, "@PA_QUAL_ID", qualid);
        this.MapParameterIn(command, "@PA_IGNORE_FREE_PLACES", ignorefreeplaces);
        this.MapParameterIn(command, "@PA_DEL_QUANTITY", delquantity);
        return this.Execute(command);
      }
    }
}
