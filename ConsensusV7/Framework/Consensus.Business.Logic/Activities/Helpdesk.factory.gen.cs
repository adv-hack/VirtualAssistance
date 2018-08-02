using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="HelpdeskModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalHelpdeskFactory : LocalFactory<LocalHelpdeskModel, HelpdeskRecord, String>, IHelpdeskFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='HelpdeskModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='HelpdeskModel' /> instance.
        /// </returns>
        public LocalHelpdeskModel Create()
        {
            return new LocalHelpdeskModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='HelpdeskModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='HelpdeskModel' /> instances.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAll()
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAll();
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='HelpdeskModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='HelpdeskModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalHelpdeskModel FetchById(String id)
        {
            HelpdeskRecord record = this.Provider.DataProvider.Activities.Helpdesk.FetchById(id);
            if (record == null)
                return null;
            return new LocalHelpdeskModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Helpdesk/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Activities.Helpdesk.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='orgIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllByOrgIdId(String orgIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllByOrgId(orgIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='proleIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllByProleIdId(String proleIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllByProleId(proleIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="givenToIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='givenToIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllByGivenToIdId(String givenToIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllByGivenToId(givenToIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='detailsIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllByDetailsIdId(String detailsIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllByDetailsId(detailsIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="fixIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='fixIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllByFixIdId(String fixIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllByFixId(fixIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="wipIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='wipIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllByWipIdId(String wipIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllByWipId(wipIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='selcoSpIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllBySelcoSpIdId(String selcoSpIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllBySelcoSpId(selcoSpIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='HelpdeskModel' /> instances.
        /// </summary>
        /// <param name="pmIdId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='HelpdeskModel' /> instances that match the specified <paramref name='pmIdId' />.
        /// </returns>
        public IEnumerable<LocalHelpdeskModel> FetchAllByPmIdId(String pmIdId)
        {
            IEnumerable<HelpdeskRecord> recordCollection = this.Provider.DataProvider.Activities.Helpdesk.FetchAllByPmId(pmIdId);
            foreach (HelpdeskRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalHelpdeskModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HelpdeskModel" /> instance.
        /// </returns>
        Consensus.Activities.IHelpdeskModel IHelpdeskFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HelpdeskModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HelpdeskModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HelpdeskModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IHelpdeskModel IHelpdeskFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IHelpdeskFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllByOrgIdId(System.String orgIdId)
        {
            return this.FetchAllByOrgIdId(orgIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllByProleIdId(System.String proleIdId)
        {
            return this.FetchAllByProleIdId(proleIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="givenToIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="givenToIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllByGivenToIdId(System.String givenToIdId)
        {
            return this.FetchAllByGivenToIdId(givenToIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllByDetailsIdId(System.String detailsIdId)
        {
            return this.FetchAllByDetailsIdId(detailsIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="fixIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="fixIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllByFixIdId(System.String fixIdId)
        {
            return this.FetchAllByFixIdId(fixIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="wipIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="wipIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllByWipIdId(System.String wipIdId)
        {
            return this.FetchAllByWipIdId(wipIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllBySelcoSpIdId(System.String selcoSpIdId)
        {
            return this.FetchAllBySelcoSpIdId(selcoSpIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="pmIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="pmIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> IHelpdeskFactory.FetchAllByPmIdId(System.String pmIdId)
        {
            return this.FetchAllByPmIdId(pmIdId);
        }

        #endregion
    }
}
