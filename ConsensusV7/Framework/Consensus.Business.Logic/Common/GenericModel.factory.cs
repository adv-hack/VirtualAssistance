using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="GenericModelModel" /> object.
    /// </summary>
    public partial class LocalGenericModelFactory
    {
      /// <summary>
      ///     Retrieves a specific <see cref='GenericModelModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericModelModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericModelModel' /> instance that matches the specified <paramref name='accId' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<LocalGenericModelModel> FetchAllByAccIdAccountXref(String accId, String proleId)
      {
        IEnumerable<GenericmodeltableRecord> recordCollection = this.Provider.DataProvider.Common.GenericModel.FetchAllByAccIdAccountXref(accId,proleId);
        IEnumerable<LocalGenericModelModel> modelCollection = recordCollection.Select(record => new LocalGenericModelModel(this.Provider, record));
        return modelCollection;
      }

      /// <summary>
      ///     Retrieves a specific <see cref='GenericModelModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericModelModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericModelModel' /> instance that matches the specified <paramref name='courseid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<LocalGenericModelModel> FetchAllByCourseIdSessions(String courseid)
      {
        IEnumerable<GenericmodeltableRecord> recordCollection = this.Provider.DataProvider.Common.GenericModel.FetchAllByCourseIdSessions(courseid);
        IEnumerable<LocalGenericModelModel> modelCollection = recordCollection.Select(record => new LocalGenericModelModel(this.Provider, record));
        return modelCollection;
      }

      /// <summary>
      ///     Retrieves a specific <see cref='GenericModelModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericModelModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericModelModel' /> instance that matches the specified <paramref name='courseid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<LocalGenericModelModel> FetchAllByCourseIdPrices(String courseid, int delcount)
      {
        IEnumerable<GenericmodeltableRecord> recordCollection = this.Provider.DataProvider.Common.GenericModel.FetchAllByCourseIdPrices(courseid, delcount);
        IEnumerable<LocalGenericModelModel> modelCollection = recordCollection.Select(record => new LocalGenericModelModel(this.Provider, record));
        return modelCollection;
      }

      /// <summary>
      ///     Retrieves a specific <see cref='GenericModelModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericModelModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericModelModel' /> instance that matches the specified <paramref name='courseid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<LocalGenericModelModel> FetchAllByProdIdPrices(String prodid, int qty)
      {
        IEnumerable<GenericmodeltableRecord> recordCollection = this.Provider.DataProvider.Common.GenericModel.FetchAllByProdIdPrices(prodid, qty);
        IEnumerable<LocalGenericModelModel> modelCollection = recordCollection.Select(record => new LocalGenericModelModel(this.Provider, record));
        return modelCollection;
      }

      /// <summary>
      ///     Retrieves a specific <see cref='GenericModelModel' /> instance.
      /// </summary>
      /// <param name="recType">
      ///     The recType value for the <see cref='GenericModelModel' /> instance to be returned.
      /// </param>
      /// <returns>
      ///     The <see cref='GenericModelModel' /> instance that matches the specified <paramref name='courseid' />; or null, if no matching instance can be found.
      /// </returns>
      public IEnumerable<LocalGenericModelModel> ValidateDelegate(String courseid, String proleid, String qualid, Int16 ignorefreeplaces, Int16 delquantity)
      {
        IEnumerable<GenericmodeltableRecord> recordCollection = this.Provider.DataProvider.Common.GenericModel.ValidateDelegate(courseid, proleid, qualid, ignorefreeplaces, delquantity);
        IEnumerable<LocalGenericModelModel> modelCollection = recordCollection.Select(record => new LocalGenericModelModel(this.Provider, record));
        return modelCollection;
      }
    }
}
