using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AkaModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAkaFactory : LocalFactory<LocalAkaModel, AkaRecord, Int32>, IAkaFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AkaModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AkaModel' /> instance.
        /// </returns>
        public LocalAkaModel Create()
        {
            return new LocalAkaModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AkaModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AkaModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAkaModel> FetchAll()
        {
            IEnumerable<AkaRecord> recordCollection = this.Provider.DataProvider.Contact.Aka.FetchAll();
            foreach (AkaRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAkaModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AkaModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AkaModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AkaModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAkaModel FetchById(Int32 id)
        {
            AkaRecord record = this.Provider.DataProvider.Contact.Aka.FetchById(id);
            if (record == null)
                return null;
            return new LocalAkaModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Aka/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Aka.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AkaModel' /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref='AkaModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AkaModel' /> instances that match the specified <paramref name='orgIdId' />.
        /// </returns>
        public IEnumerable<LocalAkaModel> FetchAllByOrgIdId(String orgIdId)
        {
            IEnumerable<AkaRecord> recordCollection = this.Provider.DataProvider.Contact.Aka.FetchAllByOrgId(orgIdId);
            foreach (AkaRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAkaModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AkaModel' /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref='AkaModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AkaModel' /> instances that match the specified <paramref name='pnIdId' />.
        /// </returns>
        public IEnumerable<LocalAkaModel> FetchAllByPnIdId(String pnIdId)
        {
            IEnumerable<AkaRecord> recordCollection = this.Provider.DataProvider.Contact.Aka.FetchAllByPnId(pnIdId);
            foreach (AkaRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAkaModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AkaModel" /> instance.
        /// </returns>
        Consensus.Contact.IAkaModel IAkaFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AkaModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AkaModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAkaModel> IAkaFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AkaModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AkaModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IAkaModel IAkaFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IAkaFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAkaModel> IAkaFactory.FetchAllByOrgIdId(System.String orgIdId)
        {
            return this.FetchAllByOrgIdId(orgIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AkaModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:AkaModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AkaModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IAkaModel> IAkaFactory.FetchAllByPnIdId(System.String pnIdId)
        {
            return this.FetchAllByPnIdId(pnIdId);
        }

        #endregion
    }
}
